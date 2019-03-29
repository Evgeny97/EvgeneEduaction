namespace Library
{
    internal class Car
    {
        private string marka;
        private string engineCapacity;
        private string speed;
        private int luggageSpace;
        private string currentLoad;

        public Car(string marka, string engineCapacity, string speed, int luggageSpace, string currentLoad)
        {
            this.marka = marka;
            this.engineCapacity = engineCapacity;
            this.speed = speed;
            this.luggageSpace = luggageSpace;
            this.currentLoad = currentLoad;
        }
    }
}