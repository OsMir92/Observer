using System;

namespace Observer
{   /*Implementa el Observer para recibir cambios de WeatherData.
     *Tambien implementa DisplayElement ya que es necesaria para representar los cambios.*/
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private ISubject _weatherData;
    //Al construcor se le pasa el objeto weatherData para registrar el display como observador.
        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
    //Graba la temperatura y humedad y llama a Display.
        public void Update(float temp, float humidity, float pressure)
        {
            this._temperature = temp;
            this._humidity = humidity;
            Display();
        }
    //Imprime en pantalla los valores mas recientes.
        public void Display()
        {
            Console.WriteLine("Current conditions : " + _temperature + "F degrees and  " + _humidity + "% humidity.");
        }
    }
}