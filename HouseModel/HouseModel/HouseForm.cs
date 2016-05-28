using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Inventor;

namespace House
{
    public partial class HouseForm : Form
    {
        /// <summary>
        /// Параметры модели
        /// </summary>
        private readonly HouseProperties _houseProperties = new HouseProperties();

        /// <summary>
        /// Модель вала
        /// </summary>
        private HouseModel _houseModel;

        /// <summary>
        /// Интерфейс САПР API
        /// </summary>
        private InventorApi _inventorApi;

        public HouseForm()
        {
            InitializeComponent();
            InitParameters();
        }

        //TODO:
        /// <summary>
        /// 
        /// </summary>
        private void InitParameters()
        {
            HouseWidth.Parameter = _houseProperties.GetParameter(ParameterType.HouseLength);
            HouseLength.Parameter = _houseProperties.GetParameter(ParameterType.HouseLength);
            FloorsCount.Parameter = _houseProperties.GetParameter(ParameterType.FloorsCount);
            WindowHeight.Parameter = _houseProperties.GetParameter(ParameterType.WindowHeight);
            WindowWidth.Parameter = _houseProperties.GetParameter(ParameterType.WindowWidth);
            WindowDistanceHor.Parameter = _houseProperties.GetParameter(ParameterType.WindowDistanceHor);
            WindowDistanceVer.Parameter = _houseProperties.GetParameter(ParameterType.WindowDistanceVer);
            BalconHeight.Parameter = _houseProperties.GetParameter(ParameterType.BalconHeight);
            BalconWidth.Parameter = _houseProperties.GetParameter(ParameterType.BalconWidth);
            BalconLength.Parameter = _houseProperties.GetParameter(ParameterType.BalconLength);
            DoorWidth.Parameter = _houseProperties.GetParameter(ParameterType.DoorWidth);
            DoorHeight.Parameter = _houseProperties.GetParameter(ParameterType.DoorHeight);
            PeakLength.Parameter = _houseProperties.GetParameter(ParameterType.PeakLength);
        }

        /// <summary>
        /// Построение модели
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Параметры</param>
        

        private void buildHouseButton_Click(object sender, EventArgs e)
        {
            _inventorApi = new InventorApi();
            _houseModel = new HouseModel(_houseProperties, _inventorApi);
            _houseModel.Build(_houseProperties);
        }

        
    }
}
