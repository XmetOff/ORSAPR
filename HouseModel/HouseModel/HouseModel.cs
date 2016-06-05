using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using HouseModel;
using Application = Inventor.Application;

namespace House
{
    /// <summary>
    /// Класс инкапсулирует модель, вызывает построение модели
    /// </summary>
    public class HouseModel
    {
        #region Fields

        /// <summary>
        /// Ссылка на приложение Инвентора
        /// </summary>
        public Application InventorApplication { get; set; }

        /// <summary>
        /// Параметры модели
        /// </summary>
        private readonly HouseProperties _houseProperties;

        /// <summary>
        /// САПР API
        /// </summary>
        private readonly InventorApi _api;

        #endregion

        #region Methods

        /// <summary>
        /// Конструктор с входными параметрами модели
        /// </summary>
        /// <param name="houseProperties">Параметры модели</param>
        /// <param name="inventorApi"></param>
        public HouseModel(HouseProperties houseProperties, InventorApi inventorApi)
        {
            _houseProperties = houseProperties;
            _api = inventorApi;
            InventorApplication = inventorApi.InventorApplication;
        }

        /// <summary>
        /// Функция строит модель
        /// </summary>
        public void Build(HouseProperties houseProperties)
        {
            var houseWidth = _houseProperties.GetParameter(ParameterType.HouseWidth).Value;
            var houseLength = _houseProperties.GetParameter(ParameterType.HouseLength).Value;
            var floorsCount = _houseProperties.GetParameter(ParameterType.FloorsCount).Value;
            var windowHeight = _houseProperties.GetParameter(ParameterType.WindowHeight).Value;
            var windowWidth = _houseProperties.GetParameter(ParameterType.WindowWidth).Value;
            var windowDistanceHor = _houseProperties.GetParameter(ParameterType.WindowDistanceHor).Value;
            var windowDistanceVer = _houseProperties.GetParameter(ParameterType.WindowDistanceVer).Value;
            var balconHeight = _houseProperties.GetParameter(ParameterType.BalconHeight).Value;
            var balconWidth = _houseProperties.GetParameter(ParameterType.BalconWidth).Value;
            var balconLength = _houseProperties.GetParameter(ParameterType.BalconLength).Value;
            var doorHeight = _houseProperties.GetParameter(ParameterType.DoorHeight).Value;
            var doorWidth = _houseProperties.GetParameter(ParameterType.DoorWidth).Value;
            var peakLength = _houseProperties.GetParameter(ParameterType.PeakLength).Value;




            double houseHeight;
            double windowsRow;
            double balconRow;
            double doorDistance = 20.0;
            double peakHeight = 2.0;
            double lowDistance = 5.0;


            houseHeight = (windowHeight + windowDistanceVer) * floorsCount + doorHeight + doorDistance + peakHeight + lowDistance;
            windowsRow = Convert.ToInt32(houseWidth / (windowWidth + windowDistanceHor));
            balconRow = Convert.ToInt32(windowsRow / 3);


            ArrayList houseBuildingParameters = new ArrayList();

            houseBuildingParameters.Add(houseWidth);
            houseBuildingParameters.Add(houseLength);
            houseBuildingParameters.Add(floorsCount);
            houseBuildingParameters.Add(windowHeight);
            houseBuildingParameters.Add(windowWidth);
            houseBuildingParameters.Add(windowDistanceHor);
            houseBuildingParameters.Add(windowDistanceVer);
            houseBuildingParameters.Add(balconHeight);
            houseBuildingParameters.Add(balconWidth);
            houseBuildingParameters.Add(balconLength);
            houseBuildingParameters.Add(doorHeight);
            houseBuildingParameters.Add(doorWidth);
            houseBuildingParameters.Add(peakLength);
            houseBuildingParameters.Add(windowsRow);
            houseBuildingParameters.Add(houseHeight);
            houseBuildingParameters.Add(doorDistance);
            houseBuildingParameters.Add(peakHeight);
            houseBuildingParameters.Add(lowDistance);
            houseBuildingParameters.Add(balconRow);




            if (houseProperties == null) throw new AccessingNullException();
            BuildHouse(houseBuildingParameters);
            BuildWindows(houseBuildingParameters);
            BuildBalcons(houseBuildingParameters);
            BuildRoof(houseBuildingParameters);
            BuildPeak(houseBuildingParameters);
            BuildDoor(houseBuildingParameters);
        }

  

        /// <summary>
        /// Функция строит окна дома
        /// </summary>
        private void BuildWindows(ArrayList houseBuildingParameters)
        {
            var houseLength = (double)houseBuildingParameters[1];
            var floorsCount = (double)houseBuildingParameters[2];
            var windowHeight = (double)houseBuildingParameters[3];
            var windowWidth = (double)houseBuildingParameters[4];
            var windowDistanceHor = (double)houseBuildingParameters[5];
            var windowDistanceVer = (double)houseBuildingParameters[6];
            double HouseHeight = (double)houseBuildingParameters[14];
            double WindowsRow = (double)houseBuildingParameters[13];
            double smeshX;
            double smeshY;


            smeshY = HouseHeight - windowDistanceVer;
            smeshX = windowDistanceHor / 2;

            _api.MakeNewWorkingPlane(3, 5);

            for (int i = 0; i < floorsCount; i++)
            {
                for (int j = 0; j < WindowsRow; j++)
                {
                    _api.DrawRectangle(smeshX, smeshY, smeshX + windowWidth, smeshY - windowHeight);
                    smeshX += windowWidth + windowDistanceHor;
                }
                smeshX = windowDistanceHor / 2;
                smeshY -= windowHeight + windowDistanceVer;
            }
            _api.Extrude(houseLength - 10);
        }

        /// <summary>
        /// Функция строит крышу дома
        /// </summary>
        private void BuildRoof(ArrayList houseBuildingParameters)
        {
            var houseLength = (double)houseBuildingParameters[1];
            var houseWidth = (double)houseBuildingParameters[0];
            double HouseHeight = (double)houseBuildingParameters[14];

            _api.MakeNewWorkingPlane(1, -5);
            _api.DrawLine(HouseHeight, -5, HouseHeight, houseLength + 5);
            _api.DrawLine(HouseHeight + 30, houseLength / 2);
            _api.CloseShape();
            _api.Extrude(houseWidth + 10);
        }

        /// <summary>
        /// Функция строит дверь дома
        /// </summary>
        private void BuildDoor(ArrayList houseBuildingParameters)
        {
            var doorHeight = (double)houseBuildingParameters[10];
            var doorWidth = (double)houseBuildingParameters[11];
            var houseWidth = (double)houseBuildingParameters[0];
            double LowDistance = (double)houseBuildingParameters[17];

            _api.MakeNewWorkingPlane(3, 0);
            _api.CutExtrudeRectangle(houseWidth / 2 - doorWidth / 2, doorHeight + LowDistance, houseWidth / 2 + doorWidth / 2, LowDistance, 5);
        }

        /// <summary>
        /// Функция строит козырек над дверью
        /// </summary>
        private void BuildPeak(ArrayList houseBuildingParameters)
        {
            var peakLength = (double)houseBuildingParameters[12];
            var doorHeight = (double)houseBuildingParameters[10];
            var houseWidth = (double)houseBuildingParameters[0];
            var doorWidth = (double)houseBuildingParameters[11];
            double PeakHeight = (double)houseBuildingParameters[16];
            double LowDistance = (double)houseBuildingParameters[17];

            _api.MakeNewWorkingPlane(3, -peakLength);
            _api.DrawRectangle(houseWidth / 2 - doorWidth / 2 - PeakHeight, doorHeight + LowDistance + 2, houseWidth / 2 + doorWidth / 2 + PeakHeight, doorHeight + LowDistance);
            _api.Extrude(peakLength);
        }

        private void BuildBalcons(ArrayList houseBuildingParameters)
        {
            // Балконы
            var floorsCount = (double)houseBuildingParameters[2];
            var windowHeight = (double)houseBuildingParameters[3];
            var windowWidth = (double)houseBuildingParameters[4];
            var windowDistanceHor = (double)houseBuildingParameters[5];
            var windowDistanceVer = (double)houseBuildingParameters[6];
            var balconHeight = (double)houseBuildingParameters[7];
            var balconWidth = (double)houseBuildingParameters[8];
            var balconLength = (double)houseBuildingParameters[9];
            double HouseHeight = (double)houseBuildingParameters[14]; 
            double BalconRow = (double)houseBuildingParameters[18];

            double xPoint;
            double yPoint;
            double xStep = 0;
            double yStep = 0;

            xPoint = (windowDistanceHor + windowWidth) * 2;
            yPoint = (HouseHeight - windowDistanceVer - windowHeight / 2);


            _api.MakeNewWorkingPlane(3, -balconLength);
            for (int j = 0; j < BalconRow; j++)
            {
                for (int i = 0; i < floorsCount; i++)
                {
                    _api.DrawRectangle(xPoint + xStep, yPoint - yStep, xPoint + balconWidth + xStep, yPoint - balconHeight - yStep);
                    yStep += windowDistanceVer + windowHeight;
                }
                xStep += (windowDistanceHor + windowWidth) * 3;
                yStep = 0;
            }
            _api.Extrude(2);



            xPoint = (windowDistanceHor + windowWidth) * 2;
            yPoint = (HouseHeight - windowDistanceVer - windowHeight / 2);
            xStep = 0;
            yStep = 0;


            _api.MakeNewWorkingPlane(3, -balconLength + 2);
            for (int j = 0; j < BalconRow; j++)
            {
                for (int i = 0; i < floorsCount; i++)
                {
                    _api.DrawRectangle(xPoint + xStep, yPoint - yStep, xPoint + xStep + 2, yPoint - balconHeight - yStep);
                    _api.DrawRectangle(xPoint + xStep + balconWidth - 2, yPoint - yStep, xPoint + xStep + balconWidth, yPoint - balconHeight - yStep);
                    yStep += windowDistanceVer + windowHeight;
                }
                xStep += (windowDistanceHor + windowWidth) * 3; ;
                yStep = 0;
            }
            _api.Extrude(balconLength - 2);


            xPoint = (windowDistanceHor + windowWidth) * 2;
            yPoint = (HouseHeight - windowDistanceVer - windowHeight / 2 - balconHeight);
            yStep = 0;
            xStep = 0;

            _api.MakeNewWorkingPlane(3, -balconLength);

            for (int j = 0; j < BalconRow; j++)
            {
                for (int i = 0; i < floorsCount; i++)
                {
                    _api.DrawRectangle(xPoint + xStep, yPoint - yStep, xPoint + xStep + balconWidth, yPoint + 2 - yStep);
                    yStep += windowDistanceVer + windowHeight;
                }
                xStep += (windowDistanceHor + windowWidth) * 3;
                yStep = 0;
            }

            _api.Extrude(balconLength);
        }

        public void BuildArc(HouseProperties houseProperties)
        {
            var startPoint = _houseProperties.GetParameter(ParameterType.StartPoint).Value;
            var arcHeight = _houseProperties.GetParameter(ParameterType.ArcHeight).Value;
            var arcWidth = _houseProperties.GetParameter(ParameterType.ArcWidth).Value;
            var houseLength = _houseProperties.GetParameter(ParameterType.HouseLength).Value;

            _api.MakeNewWorkingPlane(3, 0);
            _api.CutExtrudeRectangle(startPoint, 0, arcWidth + startPoint, arcHeight, houseLength);
        }

        /// <summary>
        /// Функция строит корпус дома
        /// </summary>
        private void BuildHouse(ArrayList houseBuildingParameters)
        {
            //TODO:
            var houseWidth = (double)houseBuildingParameters[0];
            var houseLength = (double)houseBuildingParameters[1];
            var floorsCount = (double)houseBuildingParameters[2];
            var windowHeight = (double)houseBuildingParameters[3];
            var windowWidth = (double)houseBuildingParameters[4];
            var windowDistanceHor = (double)houseBuildingParameters[5];
            var windowDistanceVer = (double)houseBuildingParameters[6];
            double WindowsRow = (double)houseBuildingParameters[13];
            double HouseHeight = (double)houseBuildingParameters[14];
            double smeshX;
            double smeshY;
            
            smeshY = HouseHeight - windowDistanceVer;
            smeshX = windowDistanceHor / 2;

            _api.MakeNewWorkingPlane(3, 0);
            _api.DrawRectangle(0, 0, houseWidth, HouseHeight);

            for (int i = 0; i < floorsCount; i++)
            {
                for (int j = 0; j < WindowsRow; j++)
                {
                    _api.DrawRectangle(smeshX, smeshY, smeshX + windowWidth, smeshY - windowHeight);
                    smeshX += windowWidth + windowDistanceHor;
                }
                smeshX = windowDistanceHor / 2;
                smeshY -= windowHeight + windowDistanceVer;
            }

            _api.Extrude(houseLength);
            #endregion
        }
    }
}
