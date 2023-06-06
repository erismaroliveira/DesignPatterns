using DecoratorExample.Interfaces;

namespace DecoratorExample
{
    public class Pizza : IPizza
    {
        public string BuscarTipoPizza()
        {
            var pizza = "Esta é uma pizza normal";
            return pizza;
        }
    }
}
