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

            ChangeArcComboBox.Items.Add("Нет");
            ChangeArcComboBox.Items.Add("Есть");
            ChangeArcComboBox.SelectedIndex = 0;
#if !DEBUG
            SterssTestButton.Visible = false;
#endif
        }

        //TODO:
        /// <summary>
        /// Инициализация параетров в полях формы
        /// </summary>
        public void InitParameters()
        {
            WindowsRow.Parameter = _houseProperties.GetParameter(ParameterType.WindowsRow);
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
            ArcHeight.Parameter = _houseProperties.GetParameter(ParameterType.ArcHeight);
            ArcWidth.Parameter = _houseProperties.GetParameter(ParameterType.ArcWidth);
            StartPoint.Parameter = _houseProperties.GetParameter(ParameterType.StartPoint);
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


        private void ChangeArcComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ChangeArcComboBox.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Выберите фигуру!");
                    ArcHeight.ReadOnly = true;
                    ArcWidth.ReadOnly = true;
                    StartPoint.ReadOnly = true;
                    break;
                case 0:
                    ArcHeight.ReadOnly = true;
                    ArcWidth.ReadOnly = true;
                    StartPoint.ReadOnly = true;
                    break;
                case 1:
                    ArcHeight.ReadOnly = false;
                    ArcWidth.ReadOnly = false;
                    StartPoint.ReadOnly = false;
                    break;
            }
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
            if (ChangeArcComboBox.SelectedIndex == 0)
            { _houseModel.Build(_houseProperties); }
            if (ChangeArcComboBox.SelectedIndex == 1)
            {
                _houseModel.Build(_houseProperties);
                _houseModel.BuildArc(_houseProperties);

            }
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
