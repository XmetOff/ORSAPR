using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using HouseModel;
using Inventor;
using Application = Inventor.Application;

namespace House
{
    /// <summary>
    /// Inventor API
    /// </summary>
    public class InventorApi
    {
        #region Fields

        /// <summary>
        /// Ссылка на приложение Инвентора
        /// </summary>
        public Application InventorApplication { get; set; }

        /// <summary>
        /// Документ в приложении
        /// </summary>
        private PartDocument _partDoc;

        /// <summary>
        /// Описание документа
        /// </summary>
        private PartComponentDefinition _partDef;

        /// <summary>
        /// Геометрия приложения
        /// </summary>
        private TransientGeometry _transGeometry;

        /// <summary>
        /// Текущий скетч
        /// </summary>
        private PlanarSketch _currentSketch;

        private double divider = 10.0;

        #endregion

        #region Methods

        /// <summary>
        /// Инициализировать Инвентор и подготовить переменные
        /// </summary>
        public InventorApi()
        {
            try
            {
                InventorApplication = (Application)Marshal.GetActiveObject("Inventor.Application");
            }
            catch (Exception)
            {
                try
                {
                    Type _InventorApplicationType = Type.GetTypeFromProgID("Inventor.Application");

                    InventorApplication = (Application)Activator.CreateInstance(_InventorApplicationType);
                    InventorApplication.Visible = true;

                    //Note: if the Inventor session is left running after this
                    //form is closed, there will still an be and Inventor.exe 
                    //running. We will use this Boolean to test in Form1.Designer.cs 
                    //in the dispose method whether or not the Inventor App should
                    //be shut down when the form is closed.

                }
                catch (Exception)
                {
                    //MessageBox.Show(ex2.ToString());
                    MessageBox.Show(@"Не получилось запустить инвентор.");
                }
            }

            Initialization(InventorApplication);
        }

        /// <summary>
        /// Инициализация приложения
        /// </summary>
        public void Initialization(Application InventorApplication)
        {
            if (InventorApplication == null) throw new AccessingNullException();

            // В открытом приложении создаем метрическуюсборку
            _partDoc = (PartDocument)InventorApplication.Documents.Add
                (DocumentTypeEnum.kPartDocumentObject, InventorApplication.FileManager.GetTemplateFile
                        (DocumentTypeEnum.kPartDocumentObject, SystemOfMeasureEnum.kMetricSystemOfMeasure));
            //Описание документа
            _partDef = _partDoc.ComponentDefinition;
            //инициализация метода геометрии
            _transGeometry = InventorApplication.TransientGeometry;
        }

        /// <summary>
        /// Создание плоскости переносом плоскостей ZY, ZX, XY
        /// </summary>
        /// <param name="n">Номер плоскости: 1 - ZY, 2 - ZX, 3 - XY</param>
        /// <param name="offset">Относительное смещение плоскости</param>
        public void MakeNewWorkingPlane(int n, double offset)
        {
            var mainPlane = _partDef.WorkPlanes[n];
            var offsetPlane = _partDef.WorkPlanes.AddByPlaneAndOffset(mainPlane, offset / divider);
            _currentSketch = _partDef.Sketches.Add(offsetPlane);
            offsetPlane.Visible = false;
        }

        /// <summary>
        /// Рисует прямоугольник по двум точкам
        /// </summary>
        /// <param name="pointOneX">Левая верхняя координата X</param>
        /// <param name="pointOneY">Левая верхняя координата Y</param>
        /// <param name="pointTwoX">Правая нижняя координата X</param>
        /// <param name="pointTwoY">Правая нижняя координата Y</param>
        public void DrawRectangle(double pointOneX, double pointOneY, double pointTwoX, double pointTwoY)
        {
            pointOneX /= divider;
            pointOneY /= divider;
            pointTwoX /= divider;
            pointTwoY /= divider;
            var cornerPointOne = _transGeometry.CreatePoint2d(pointOneX, pointOneY);
            var cornerPointTwo = _transGeometry.CreatePoint2d(pointTwoX, pointTwoY);
            _currentSketch.SketchLines.AddAsTwoPointRectangle(cornerPointOne, cornerPointTwo);
        }


        /// <summary>
        /// Рисует круг
        /// </summary>
        /// <param name="centerPointX">Координата X центра круга</param>
        /// <param name="centerPointY">Координата Y центра круга</param>
        /// <param name="diameter">Диаметр круга</param>
        public void DrawCircle(double centerPointX, double centerPointY, double diameter)
        {
            centerPointX /= divider;
            centerPointY /= divider;
            diameter /= divider;
            _currentSketch.SketchCircles.AddByCenterRadius(_transGeometry.CreatePoint2d(centerPointX, centerPointY), 
                0.5 * diameter);
        }

        /// <summary>
        /// Выдавливание
        /// </summary>
        /// <param name="distance">Длинна выдавливания</param>
        /// <param name="extrudeDirection">Направление выдавливания</param>
        public void Extrude(double distance, PartFeatureExtentDirectionEnum extrudeDirection = PartFeatureExtentDirectionEnum.kPositiveExtentDirection)
        {
            var extrudeDef = _partDef.Features.ExtrudeFeatures.CreateExtrudeDefinition(_currentSketch.Profiles.AddForSolid(), 
                PartFeatureOperationEnum.kJoinOperation);
            extrudeDef.SetDistanceExtent(distance / 10.0, extrudeDirection);
            _partDef.Features.ExtrudeFeatures.Add(extrudeDef);
        }

        /// <summary>
        /// Выдавить круг с вычитанием
        /// </summary>
        /// <param name="diameter">Диаметр круга</param>
        /// <param name="distance">Дистанция выдавливания</param>
        /// <param name="centerPointX">X координата центра</param>
        /// <param name="centerPointY">Y координата центра</param>
        public void CutExtrudeCircle(double centerPointX, double centerPointY, double diameter, double distance)
        {
            DrawCircle(centerPointX, centerPointY, diameter);
            var extrudeDef = _partDef.Features.ExtrudeFeatures.CreateExtrudeDefinition(_currentSketch.Profiles.AddForSolid(), 
                PartFeatureOperationEnum.kCutOperation);
            extrudeDef.SetDistanceExtent(distance / divider, PartFeatureExtentDirectionEnum.kPositiveExtentDirection);
            //TODO:
            var extrude = _partDef.Features.ExtrudeFeatures.Add(extrudeDef);
        }

        /// <summary>
        /// Выдавить прямоугольник с вычитанием
        /// </summary>
        /// <param name="distance">Дистанция выдавливания</param>
        /// <param name="PointX">X координата центра</param>
        /// <param name="pointOneX">Левая верхняя координата X</param>
        /// <param name="pointOneY">Левая верхняя координата Y</param>
        /// <param name="pointTwoX">Правая нижняя координата X</param>
        /// <param name="pointTwoY">Правая нижняя координата Y</param>
        public void CutExtrudeRectangle(double pointOneX, double pointOneY, double pointTwoX, double pointTwoY, double distance)
        {
            pointOneX /= divider;
            pointOneY /= divider;
            pointTwoX /= divider;
            pointTwoY /= divider;
            var cornerPointOne = _transGeometry.CreatePoint2d(pointOneX, pointOneY);
            var cornerPointTwo = _transGeometry.CreatePoint2d(pointTwoX, pointTwoY);
            _currentSketch.SketchLines.AddAsTwoPointRectangle(cornerPointOne, cornerPointTwo);
            var extrudeDef = _partDef.Features.ExtrudeFeatures.CreateExtrudeDefinition(_currentSketch.Profiles.AddForSolid(), 
                PartFeatureOperationEnum.kCutOperation);
            extrudeDef.SetDistanceExtent(distance / divider, PartFeatureExtentDirectionEnum.kPositiveExtentDirection);
            //TODO:
            var extrude = _partDef.Features.ExtrudeFeatures.Add(extrudeDef);
        }

        /// <summary>
        /// Выполняет полное вращение замкнутого скетча вокруг оси
        /// </summary>
        /// <param name="startPointX">Координата X начала оси вращения</param>
        /// <param name="startPointY">Координата Y начала оси вращения</param>
        /// <param name="endPointX">Координата X конца оси вращения</param>
        /// <param name="endPointY">Координата Y конца оси вращения</param>
        public void RevolveFull(double startPointX, double startPointY, double endPointX, double endPointY)
        {
            var startPoint = _transGeometry.CreatePoint2d(startPointX, startPointY);
            var endPoint = _transGeometry.CreatePoint2d(endPointX, endPointY);
            var line = _currentSketch.SketchLines.AddByTwoPoints(startPoint, endPoint);
            var profile = _currentSketch.Profiles.AddForSolid();
            //TODO:
            var revolveFeat = _partDef.Features.RevolveFeatures.AddFull(profile, line, PartFeatureOperationEnum.kJoinOperation);
        }

        /// <summary>
        /// Построить линию
        /// </summary>
        /// <param name="startPointX">Начальная координата X</param>
        /// <param name="startPointY">Начальная координата Y</param>
        /// <param name="endPointX">Конечная координата X</param>
        /// <param name="endPointY">Конечная координата Y</param>
        public void DrawLine(double startPointX, double startPointY, double endPointX, double endPointY)
        {
            startPointX /= divider;
            startPointY /= divider;
            endPointX /= divider;
            endPointY /= divider;
            var startPoint = _transGeometry.CreatePoint2d(startPointX, startPointY);
            var endPoint = _transGeometry.CreatePoint2d(endPointX, endPointY);
            _currentSketch.SketchLines.AddByTwoPoints(startPoint, endPoint);
        }

        /// <summary>
        /// Продолжает линию с последней точки
        /// </summary>
        /// <param name="endPointX">Координата X конца линии</param>
        /// <param name="endPointY">Координата Y конца линии</param>
        public void DrawLine(double endPointX, double endPointY)
        {
            endPointX /= divider;
            endPointY /= divider;
            var endPoint = _transGeometry.CreatePoint2d(endPointX, endPointY);
            _currentSketch.SketchLines.AddByTwoPoints(_currentSketch.SketchLines[_currentSketch.SketchLines.Count].EndSketchPoint, endPoint);
        }

        /// <summary>
        /// Метод соединяет первую и последнюю точки
        /// </summary>
        public void CloseShape()
        {
            _currentSketch.SketchLines.AddByTwoPoints(
                _currentSketch.SketchLines[_currentSketch.SketchLines.Count].EndSketchPoint,
                _currentSketch.SketchLines[1].StartSketchPoint);
        }

        #endregion
    }
}
