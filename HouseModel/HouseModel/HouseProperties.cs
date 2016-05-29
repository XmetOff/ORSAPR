using System;
using System.Collections.Generic;

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

        #region Methods

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public HouseProperties()
        {
            _parameters = new Dictionary<ParameterType, HouseParameter>
            {
                {ParameterType.HouseWidth, new HouseParameter(400, 100, 500)},
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
                {ParameterType.PeakLength, new HouseParameter(10, 5, 15)}
            };
        }

        /// <summary>
        /// Слот, вызываемый при изменении какого-либо параметра модели
        /// </summary>
        /// <param name="sender">Отправитель</param>
        /// <param name="e">Аргументы</param>

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
