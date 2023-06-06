using ObserverExample.Interfaces;

namespace ObserverExample
{
    public class EstacaoMeteorologica : ISubject
    {
        private readonly List<IObserver> _observers;

        public EstacaoMeteorologica()
        {
            _observers = new List<IObserver>();
        }

        private float _temperatura;
        public float Temperatura
        {
            get { return _temperatura; }
            set { _temperatura = value; Notificar(); }
        }

        public void Anexar(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Notificar()
        {
            _observers.ForEach(o =>
            {
                o.Atualizar(this);
            });
        }
    }
}
