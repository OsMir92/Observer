using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Weather Station");
            Console.WriteLine();

            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            Console.WriteLine();
            weatherData.SetMeasurements(87, 70, 29.2f);
            Console.WriteLine();
            weatherData.SetMeasurements(78, 90, 29.2f);
            Console.WriteLine();
            weatherData.SetMeasurements(65, 75, 29.2f);
            Console.WriteLine();

            int temp, hum;
            float press;
            Console.Write("What is the current Temperature? T: ");
            temp = Int32.Parse(Console.ReadLine());
            Console.Write("What is the current Humidity? H: ");
            hum = Int32.Parse(Console.ReadLine());
            Console.Write("What is the current Pressure? P: ");
            press = float.Parse(Console.ReadLine());
            Console.WriteLine();

            weatherData.SetMeasurements(temp, hum, press);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}