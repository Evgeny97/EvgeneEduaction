namespace Library_avto_park
{
    public class Car
    {
        /// <summary>
        /// Марка автомобиля
        /// </summary>
        public string Marka { get; private set; }
        /// <summary>
        /// Объем двигателя
        /// </summary>
        public float EngineCapacity { get; private set; }
        /// <summary>
        /// Цвет автомобиля
        /// </summary>
        public string Colour { get; private set; }
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { get; protected set; }
        /// <summary>
        /// Объем багажного отделения
        /// </summary>
        public int LuggageSpace { get; private set; }
        /// <summary>
        /// Вес автомобиля
        /// </summary>
        public int Сar_weight { get; protected set; }
        /// <summary>
        /// Наличие зажигание 
        /// </summary>
        public bool PresenceOfIgnition { get; protected set; }
        /// <summary>
        /// Счетчик автомобиля
        /// </summary>
        public int CarCount { get; private set; }

        public Car(string Marka, float EngineCapacity, string Colour, int MaxSpeed, int LuggageSpace, int Сar_weight, bool PresenceOfIgnition)
        {
       //     CarCount++;
            this.Marka = Marka;
            this.EngineCapacity = EngineCapacity;
            this.Colour = Colour;
            this.MaxSpeed = MaxSpeed;
            this.LuggageSpace = LuggageSpace;
            this.Сar_weight = Сar_weight;
            this.PresenceOfIgnition = PresenceOfIgnition;
        }
    }
}
