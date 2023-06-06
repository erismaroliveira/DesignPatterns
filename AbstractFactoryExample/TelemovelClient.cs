using AbstractFactoryExample.Interfaces;

namespace AbstractFactoryExample
{
    /// <summary>
    /// Client
    /// </summary>
    public class TelemovelClient
    {
        private ISmartPhone _smartPhone;
        private INormalPhone _normalPhone;

        public TelemovelClient(ITelemovel telemovelFactory)
        {
            _smartPhone = telemovelFactory.BuscarSmartPhone();
            _normalPhone = telemovelFactory.BuscarNormalPhone();
        }

        public string BuscarSmartPhoneModeloDetalhes()
        {
            return _smartPhone.BuscarDetalhesModelo();
        }

        public string BuscarNormalPhoneModeloDetalhes()
        {
            return _normalPhone.BuscarDetalhesModelo();
        }
    }
}
