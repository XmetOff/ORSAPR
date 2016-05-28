using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
        private ValModel _houseModel;

        /// <summary>
        /// Интерфейс САПР API
        /// </summary>
        private InventorApi _inventorApi;

        public HouseForm()
        {
            InitializeComponent();
            initParameters();
        }

        //TODO:
        /// <summary>
        /// 
        /// </summary>
        private void initParameters()
        {
           
        }

        /// <summary>
        /// Построение модели
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Параметры</param>
        private void BuildVal_Click(object sender, EventArgs e)
        {
            _inventorApi = new InventorApi();
            _houseModel = new ValModel(_houseProperties, _inventorApi);
            _houseModel.Build();
        }

        private void buildHouseButton_Click(object sender, EventArgs e)
        {
            _inventorApi = new InventorApi();
            _houseModel = new ValModel(_houseProperties, _inventorApi);
            _houseModel.Build();
        }

        private void HouseForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}
