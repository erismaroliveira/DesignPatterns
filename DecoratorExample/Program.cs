using DecoratorExample;
using DecoratorExample.Interfaces;

IPizza pizza = new Pizza();
IPizza queijoDecorator = new QueijoDecorator(pizza);
IPizza baconDecorator = new BaconDecorator(queijoDecorator);
IPizza cebolaDecorator = new CebolaDecorator(baconDecorator);

// Console.WriteLine(pizza.BuscarTipoPizza());
// Console.WriteLine(queijoDecorator.BuscarTipoPizza());
// Console.WriteLine(baconDecorator.BuscarTipoPizza());
Console.WriteLine(cebolaDecorator.BuscarTipoPizza());
Console.WriteLine();
