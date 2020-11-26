namespace Observer
{
    public interface IObserver
    {
        /*Se utiliza para actualizar a los observadores registrados.
         * Los parametros son los valores que son retornados a los observadores del Sujeto(Subject)
         * cuando cambian los valores del clima.*/        
        void Update(float temp, float humidity, float pressure);
    }
}
