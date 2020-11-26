using System.Collections.Generic;
using System.Linq;

namespace Observer
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers; //Proporciona Add/Remove
        private float _temperature;         //Lista contiene a los
        private float _humidity;            //observadores
        private float _pressure;
        //Se crea lista en constructor
        public WeatherData()                
        {
            _observers = new List<IObserver>();
        }
        //Se agrega observador al final de la lista
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        //Se elimina observador de la lista
        public void RemoveObserver(IObserver observer)
        {
            if (_observers != null && _observers.Count() > 0)
            {
                _observers.Remove(observer);
            }
        }
        /*Aqui se informa a los observadores de nuevos estados por medio
        del metodo Update()*/
        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }
        //Se notifica a los observadores cuando hay un cambio en valores
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
            MeasurementsChanged();
        }
    }
}
