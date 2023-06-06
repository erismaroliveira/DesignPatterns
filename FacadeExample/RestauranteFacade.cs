using FacadeExample.Interfaces;

namespace FacadeExample
{
    public class RestauranteFacade
    {
        private IPizza _fornecedorPizza;
        private IPao _fornecedorPao;

        public RestauranteFacade()
        {
            _fornecedorPizza = new FornecedorPizza();
            _fornecedorPao = new FornecedorPao();
        }

        public void BuscarPizzaNormal()
        {
            _fornecedorPizza.BuscarPizzaNormal();
        }

        public void BuscarPizzaVegana()
        {
            _fornecedorPizza.BuscarPizzaVegana();
        }

        public void BuscarPaoDeAlho()
        {
            _fornecedorPao.BuscarPaoDeAlho();
        }

        public void BuscarPaoDeAlhoComQueijo()
        {
            _fornecedorPao.BuscarPaoDeAlhoComQueijo();
        }
    }
}
