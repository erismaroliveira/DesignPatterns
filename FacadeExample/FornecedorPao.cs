using FacadeExample.Interfaces;

namespace FacadeExample
{
    public class FornecedorPao : IPao
    {
        public void BuscarPaoDeAlho()
        {
            Console.WriteLine("Obtendo Pão De Alho.");
        }

        public void BuscarPaoDeAlhoComQueijo()
        {
            ObterQueijo();
            Console.WriteLine("Obtendo Pão De Alho Com Queijo.");
        }

        private void ObterQueijo()
        {
            Console.WriteLine("Obtendo queijo.");
        }
    }
}
