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
        private readonly Dictionary<ParameterType, Parameter> _parameters;

        #region Methods

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public HouseProperties()
        {
            _parameters = new Dictionary<ParameterType, Parameter>
            {
                {ParameterType.HouseWidth, new Parameter(400, 50, 500)},
                {ParameterType.HouseLength, new Parameter(100, 50, 200)},
                {ParameterType.FloorsCount, new Parameter(5, 2, 10)},
                {ParameterType.WindowHeight, new Parameter(20, 15, 30)},
                {ParameterType.WindowWidth, new Parameter(20, 15, 30)},
                {ParameterType.WindowDistanceHor, new Parameter(20, 15, 30)},
                {ParameterType.WindowDistanceVer, new Parameter(20, 15, 30)},
                {ParameterType.BalconHeight, new Parameter(55.25, 85.0, 114.75)},
                {ParameterType.BalconLength, new Parameter(55.25, 85.0, 114.75)},
                {ParameterType.BalconWidth, new Parameter(55.25, 85.0, 114.75)},
                {ParameterType.DoorHeight, new Parameter(25, 20, 30)},
                {ParameterType.DoorWidth, new Parameter(20, 20, 25)},
                {ParameterType.PeakLength, new Parameter(55.25, 85.0, 114.75)}
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
        public Parameter GetParameter(ParameterType parameterType)
        {
            return _parameters[parameterType];
        }

        /// <summary>
        /// Проверка значение и установка ограничений
        /// </summary>
       
        #endregion
    }
}
