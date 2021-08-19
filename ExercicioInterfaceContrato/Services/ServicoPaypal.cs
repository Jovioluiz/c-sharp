
namespace ExercicioInterfaceContrato.Services {
    class ServicoPaypal : IServicoPagamento {
        private const double TaxaPercentual = 0.02;
        private const double TaxaMensal = 0.01;

        public double TaxaPagamento(double valor)
        {
            return valor * TaxaPercentual;

        }

        public double AdicaoParcela(double montante, int meses)
        {
            return montante * TaxaMensal * meses; 
        }

    }
}
