using ObserverExample.Interfaces;

namespace ObserverExample
{
    public class NovasAgenciasNoticias : IObserver
    {
        public NovasAgenciasNoticias(string nomeAgencia)
        {
            NomeAgencia = nomeAgencia;
        }

        public string NomeAgencia { get; set; }

        public void Atualizar(ISubject subject)
        {
            if (subject is EstacaoMeteorologica estacaoMeteorologica)
            {
                Console.WriteLine(string.Format("{0} reportando a temperatura {1} graus celsius.", NomeAgencia, estacaoMeteorologica.Temperatura));
                Console.WriteLine();
            }
        }
    }
}
