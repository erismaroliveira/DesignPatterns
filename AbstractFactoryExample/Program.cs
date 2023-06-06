using AbstractFactoryExample;
using AbstractFactoryExample.ConcretesFactory;
using AbstractFactoryExample.Interfaces;

ITelemovel nokiaTelemovel = new Nokia();
TelemovelClient nokiaClient = new TelemovelClient(nokiaTelemovel);

Console.WriteLine("************** NOKIA **************");
Console.WriteLine(nokiaClient.BuscarSmartPhoneModeloDetalhes());
Console.WriteLine(nokiaClient.BuscarNormalPhoneModeloDetalhes());

ITelemovel samsungTelemovel = new Samsung();
TelemovelClient samsungClient = new TelemovelClient(samsungTelemovel);

Console.WriteLine("************** SAMSUNG **************");
Console.WriteLine(samsungClient.BuscarSmartPhoneModeloDetalhes());
Console.WriteLine(samsungClient.BuscarNormalPhoneModeloDetalhes());

Console.ReadKey();
