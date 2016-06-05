using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HouseModel;
using Inventor;

namespace House
{
    /// <summary>
    /// Параметры модели
    /// </summary>
    public class HouseProperties
    {
        /// <summary>
        /// Словарь параметров 
        /// </summary>
        private readonly Dictionary<ParameterType, HouseParameter> _parameters;

        private HouseParameter _parameter;
        public event EventHandler ParameterChanged;


        #region Methods

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public HouseProperties()
        {
            _parameters = new Dictionary<ParameterType, HouseParameter>
            {
                {ParameterType.WindowsRow, new HouseParameter(10, 3, 12)},
                {ParameterType.HouseLength, new HouseParameter(100, 50, 200)},
                {ParameterType.FloorsCount, new HouseParameter(5, 2, 10)},
                {ParameterType.WindowHeight, new HouseParameter(20, 15, 30)},
                {ParameterType.WindowWidth, new HouseParameter(20, 15, 30)},
                {ParameterType.WindowDistanceHor, new HouseParameter(20, 15, 30)},
                {ParameterType.WindowDistanceVer, new HouseParameter(20, 15, 30)},
                {ParameterType.BalconHeight, new HouseParameter(15, 15, 20)},
                {ParameterType.BalconLength, new HouseParameter(10, 10, 15)},
                {ParameterType.BalconWidth, new HouseParameter(40, 30, 40)},
                {ParameterType.DoorHeight, new HouseParameter(25, 20, 30)},
                {ParameterType.DoorWidth, new HouseParameter(15, 10, 20)},
                {ParameterType.PeakLength, new HouseParameter(10, 5, 15)},
                {ParameterType.ArcHeight, new HouseParameter(40, 30, 45)},
                {ParameterType.ArcWidth, new HouseParameter(50, 30, 50)},
                {ParameterType.StartPoint, new HouseParameter(5, 5, 440)}
            };
            foreach (var parameter in _parameters.Values)
            {
                parameter.ParameterChanged += ParameterOnParameterChanged;
            }
        }

        /// <summary>
        /// Слот, вызываемый при изменении какого-либо параметра модели
        /// </summary>
        /// <param name="sender">Отправитель</param>
        /// <param name="e">Аргументы</param>
        private void ParameterOnParameterChanged(object sender, EventArgs e)
        {
            try
            {
                Validate();
            }
            catch
            {
                MessageBox.Show(@"ай ай ай");
            }
            
        }

        private void Validate()
        {
            
            if (
                _parameters[ParameterType.BalconWidth].Value >
                _parameters[ParameterType.WindowWidth].Value)
            {
                _parameters[ParameterType.BalconWidth].Validate();
            }
            else
            {
                _parameters[ParameterType.BalconWidth].Value = 40;
                throw new ValueException();
            }

            double doorStartPoint;
            double doorEndPoint;
            double houseWidth;

            doorStartPoint = ((_parameters[ParameterType.WindowWidth].Value +
                               _parameters[ParameterType.WindowDistanceHor].Value)*
                              _parameters[ParameterType.WindowsRow].Value +
                              _parameters[ParameterType.WindowDistanceHor].Value/2)/2 -
                             _parameters[ParameterType.DoorWidth].Value/2 - 2;

            doorEndPoint = ((_parameters[ParameterType.WindowWidth].Value +
                             _parameters[ParameterType.WindowDistanceHor].Value)*
                            _parameters[ParameterType.WindowsRow].Value +
                            _parameters[ParameterType.WindowDistanceHor].Value/2)/2 +
                           _parameters[ParameterType.DoorWidth].Value/2 + 2;

            houseWidth = (_parameters[ParameterType.WindowWidth].Value +
                             _parameters[ParameterType.WindowDistanceHor].Value)*
                            _parameters[ParameterType.WindowsRow].Value +
                            _parameters[ParameterType.WindowDistanceHor].Value / 2;

            if (
                (_parameters[ParameterType.StartPoint].Value < doorStartPoint)  &&   
                (_parameters[ParameterType.StartPoint].Value + _parameters[ParameterType.ArcWidth].Value < doorStartPoint)) 
            {
                _parameters[ParameterType.StartPoint].Validate();
            }
            else if (
                (_parameters[ParameterType.StartPoint].Value > doorEndPoint) &&
                (_parameters[ParameterType.StartPoint].Value + _parameters[ParameterType.ArcWidth].Value < houseWidth))
            {
                _parameters[ParameterType.StartPoint].Validate();
            }
            else
            {
                _parameters[ParameterType.StartPoint].Value = 5;
                throw new ValueException();
            }





        }

        /// <summary>
        /// Получить параметр
        /// </summary>
        /// <param name="parameterType">Тип параметра</param>
        /// <returns>Полученный параметр</returns>
        public HouseParameter GetParameter(ParameterType parameterType)
        {
            return _parameters[parameterType];
        }

        /// <summary>
        /// Проверка значение и установка ограничений
        /// </summary>
       
        #endregion
    }
}
