using System;

namespace Observer
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private ISubject _weatherData;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public ForecastDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            if (_temperature > 78.0 && _temperature < 85)
            {
                Console.WriteLine("Improving weather is on the way!");
            }
            else if (_temperature <= 78 && _humidity > 10.0)
            {
                Console.WriteLine("There will be cool & rainy weather.");
            }
            else if (_temperature > 85)
            {
                Console.WriteLine("Watch out today is going to be a scorcher! ");
            }
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            _pressure = pressure;
            Display();
        }
    }
}
