using FactoryMethodExample.Product;

namespace FactoryMethodExample.ConcreteProduct
{
    public class CartaoPlatinum : CartaoCredito
    {
        private readonly string _tipoCartao;
        private int _limiteCartao;
        private int _cobrancaAnual;

        public CartaoPlatinum(int limiteCredito, int cobrancaAnual)
        {
            this._tipoCartao = "Platinum";
            this._limiteCartao = limiteCredito;
            this._cobrancaAnual = cobrancaAnual;
        }

        public override string TipoCartao
        {
            get { return _tipoCartao; }
        }
        public override int LimiteCredito
        {
            get { return this._limiteCartao; }
            set { _limiteCartao = value; }
        }
        public override int CobrancaAnual
        {
            get { return this._cobrancaAnual; }
            set { _cobrancaAnual = value; }
        }
    }
}
