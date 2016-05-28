using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Inventor;

namespace House
{
    /// <summary>
    /// Класс инкапсулирует модель, вызывает построение модели
    /// </summary>
    public class ValModel
    {
        #region Fields

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
        public ValModel(HouseProperties houseProperties, InventorApi inventorApi)
        {
            _houseProperties = houseProperties;
            _api = inventorApi;
        }

        /// <summary>
        /// Функция строит модель
        /// </summary>
        public void Build()
        {

            BuildHouse();
            //BuildGroove();
            //   BuildKeyway();
        }

        /// <summary>
        /// Функция строит основу пятиступенчатого вала
        /// </summary>
        private void BuildHouse()
        {
            //TODO:
            var HouseLength = _houseProperties.GetParameter(ParameterType.HouseLength).Value;
            var HouseWidth = _houseProperties.GetParameter(ParameterType.HouseWidth).Value;
            var FloorsCount = _houseProperties.GetParameter(ParameterType.FloorsCount).Value;
            var WindowHeight = _houseProperties.GetParameter(ParameterType.WindowHeight).Value;
            var WindowWidth = _houseProperties.GetParameter(ParameterType.WindowWidth).Value;
            var WindowDistanceHor = _houseProperties.GetParameter(ParameterType.WindowDistanceHor).Value;
            var WindowDistanceVer = _houseProperties.GetParameter(ParameterType.WindowDistanceVer).Value;
            var BalconHeight = _houseProperties.GetParameter(ParameterType.BalconHeight).Value;
            var BalconWidth = _houseProperties.GetParameter(ParameterType.BalconWidth).Value;
            var BalconLength = _houseProperties.GetParameter(ParameterType.BalconLength).Value;
            var DoorHeight = _houseProperties.GetParameter(ParameterType.DoorHeight).Value;
            var DoorWidth = _houseProperties.GetParameter(ParameterType.DoorWidth).Value;
            var PeakLength = _houseProperties.GetParameter(ParameterType.PeakLength).Value;



            double smeshY;
            double smeshX;
            HouseWidth = 400;
            HouseLength = 100;
            int DoorDistance = 20;
            int PeakHeight = 2;
            int PeakWidth = 10;
            int LowDistance = 5;
            double HouseHeight;
            int WindowsRow; 

            HouseHeight = (WindowHeight + WindowDistanceVer)*FloorsCount + DoorHeight + DoorDistance + PeakHeight + LowDistance;
            WindowsRow = Convert.ToInt32(HouseWidth/(WindowWidth + WindowDistanceHor));

            smeshY = HouseHeight - WindowDistanceVer;
            smeshX = WindowDistanceHor/2;

            _api.MakeNewWorkingPlane(3, 0);
            _api.DrawRectangle(0, 0, HouseWidth, HouseHeight);

            for (int i = 0; i < FloorsCount; i++)
            {
                for (int j = 0; j < WindowsRow; j++)
                {
                    _api.DrawRectangle(smeshX, smeshY, smeshX + WindowWidth, smeshY - WindowHeight);
                    smeshX += WindowWidth + WindowDistanceHor;
                }
                smeshX = WindowDistanceHor / 2;
                smeshY -= WindowHeight + WindowDistanceVer;
            }
            _api.Extrude(HouseLength);


            smeshY = HouseHeight - WindowDistanceVer;
            smeshX = WindowDistanceHor / 2;

            _api.MakeNewWorkingPlane(3, 5);

            for (int i = 0; i < FloorsCount; i++)
            {
                for (int j = 0; j < WindowsRow; j++)
                {
                    _api.DrawRectangle(smeshX, smeshY, smeshX + WindowWidth, smeshY - WindowHeight);
                    smeshX += WindowWidth + WindowDistanceHor;
                }
                smeshX = WindowDistanceHor / 2;
                smeshY -= WindowHeight + WindowDistanceVer;
            }
            _api.Extrude(HouseLength-10);

            

            // Крыша
            _api.MakeNewWorkingPlane(1, -5);
            _api.DrawLine(HouseHeight, -5, HouseHeight, HouseLength+5);
            _api.DrawLine(HouseHeight+30,HouseLength/2);
            _api.CloseShape();
            _api.Extrude(HouseWidth+5);
            
            // Дверь
            _api.MakeNewWorkingPlane(3,0);
            _api.CutExtrudeRectangle(HouseWidth/2 - DoorWidth/2, DoorHeight + LowDistance, HouseWidth/2 + DoorWidth/2,LowDistance,5);

            // Козырек
            _api.MakeNewWorkingPlane(3, -10);
            _api.DrawRectangle(85, 30, 115, 32);
            _api.Extrude(10);

            // Балконы

            int xPoint = 80;
            int xStep = 0;
            int yPoint = 220;
            int yStep = 0;

            _api.MakeNewWorkingPlane(3, -10);
            for (int j = 0; j<3; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    _api.DrawRectangle(xPoint + xStep, yPoint - yStep, xPoint + 40 + xStep, yPoint - 20 - yStep);
                    yStep += 40;
                }
                xStep += 120;
                yStep = 0;
            }
            _api.Extrude(2);


            xPoint = 80;
            xStep = 0;
            yPoint = 220;
            yStep = 0;

            _api.MakeNewWorkingPlane(3, -8);
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    _api.DrawRectangle(xPoint + xStep, yPoint - yStep, xPoint + xStep + 2, yPoint - 20 - yStep);
                    _api.DrawRectangle(xPoint +xStep + 38, yPoint - yStep, xPoint + xStep + 38 + 2, yPoint - 20 - yStep);
                    yStep += 40;
                }
                xStep += 120;
                yStep = 0;
            }
            _api.Extrude(8);


            xPoint = 80;
            yPoint = 200;
            yStep = 0;
            xStep = 0;

            _api.MakeNewWorkingPlane(3, -10);

            for (int j = 0; j<3; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    _api.DrawRectangle(xPoint + xStep, yPoint - yStep, xPoint + xStep + 40, yPoint + 2 - yStep);
                    yStep += 40;
                }
                xStep += 120;
                yStep = 0;
            }

            _api.Extrude(10);
            _api.ChangeMaterial(@"Серебро");


            #endregion
        }
    }
}
