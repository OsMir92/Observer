namespace Observer
{
    public interface ISubject
    {
        // Registra un observador
        void RegisterObserver(IObserver observer);

        // Elimina un observador para no seguir notificandolo de cambios
        void RemoveObserver(IObserver observer);

        // Notifica a todos los observadores cuando cambia el estado del Sujeto(Subject)
        void NotifyObservers();
    }
}
