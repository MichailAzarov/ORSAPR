using System;

namespace FlangeSizes
{
    /// <summary>
    /// Параметры фланца.
    /// </summary>
    public class FlangeParameters
    {
        /// <summary>
        /// Внешний диаметр фланца должен быть не меньше 90 мм и не больше 1450 мм.
        /// </summary>
        public double FlangeExternalDiameter 
        {
            get => _flangeExternalDiameter;

            set
            {
                CheckValue(value, "Внешний диаметр", 90, 1450);
                _flangeExternalDiameter = value;
            }
        }

        /// <summary>
        /// Внутренний диаметр фланца должен быть не меньше 20 мм и не больше 1220 мм.
        /// </summary>
        public double FlangeInnerDiameter
        {
            get => _flangeInnerDiameter;
            set
            {
                CheckValue(value, "Внутренний диаметр", 20, 1220);
                _flangeInnerDiameter = value;
            }
        }

        /// <summary>
        /// Межосевое расстояние фланца должно быть не меньше 50 мм и не больше 1120 мм.
        /// </summary>
        public double FlangeCenterDistance
        {
            get => _flangeCenterDistance;
            set
            {
                CheckValue(value, "Межосевое расстояние", 50, 1350);
                _flangeCenterDistance = value;
            }
        }

        /// <summary>
        /// Толщина фланца должна быть не меньше 10 мм и не больше 60 мм.
        /// </summary>
        public double FlangeLength
        {
            get => _flangeLength;
            set
            {
                CheckValue(value, "Толщина фланца", 10, 60);
                _flangeLength = value;
            }
        }

        /// <summary>
        /// Количество крепёжных отверстий фланца должно быть от 4 до 32 штук.
        /// </summary>
        public int HoleNumber
        {
            get => _holeNumber;
            set
            {
                CheckValue(value, "Количество отверстий", 4, 32);
                _holeNumber = value;
            }
        }


        /// <summary>
        /// Диаметр отверстий фланца должен быть не меньше 12 и не больше 36.
        /// </summary>
        public double HoleDiameter
        {
            get => _holeDiameter;
            set
            {
                CheckValue(value, "Диаметр отверстий", 12, 36);
                _holeDiameter = value;
            }
        }

        /// <summary>
        /// Проверка исключений.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="name">Название параметра.</param>
        /// <param name="min">Минимальный размер.</param>
        /// <param name="max">Максимальный размер.</param>
        private static void CheckValue(double value, string name,
            double min, double max)
        {
            if (min <= value && value <= max) return;

            var message = $"{name} не может быть меньше {min} или больше {max}.\n";
            throw new ArgumentException(string.Join("\n", message));
        }

        /// <summary>
        /// Внешний диаметр фланца.
        /// </summary>
        private double _flangeExternalDiameter;

        /// <summary>
        /// Внутренний диаметр фланца.
        /// </summary>
        private double _flangeInnerDiameter;

        /// <summary>
        /// Межосевое расстояние.
        /// </summary>
        private double _flangeCenterDistance;

        /// <summary>
        /// Толщина фланца.
        /// </summary>
        private double _flangeLength;

        /// <summary>
        /// Количество крепёжных отверстий.
        /// </summary>
        private int _holeNumber;

        /// <summary>
        /// Диаметр крепёжных отверстий.
        /// </summary>
        private double _holeDiameter;
    }
}
