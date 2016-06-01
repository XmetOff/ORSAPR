using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
#if !DEBUG
            SterssTestButton.Visible = false;
#endif
        }

        //TODO:
        /// <summary>
        /// 
        /// </summary>
        private void InitParameters()
        {
            HouseWidth.Parameter = _houseProperties.GetParameter(ParameterType.HouseWidth);
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

        private void StressTesting()
        {
            Stopwatch stopwatch = new Stopwatch();
            var listTimes = new List<string>();
            for (int i = 0; i < 200; i++)
            {
                stopwatch.Start();
                RunInventorButton_Click(null, new EventArgs());

                //_inventorApi = new InventorApi();

                stopwatch.Stop();
                listTimes.Add(stopwatch.Elapsed.ToString());
                stopwatch.Reset();
            }

            StreamWriter file = new StreamWriter(@"C:\Users\Арсен\Documents\StressTestLog.txt");
            {
                foreach (string line in listTimes)
                {
                    file.WriteLine(line);
                }
            }
            file.Close();
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

        private void RunInventorButton_Click(object sender, EventArgs e)
        {
            _inventorApi = new InventorApi();
        }

        private void SterssTestButton_Click(object sender, EventArgs e)
        {
            StressTesting();
        }



    }
}
