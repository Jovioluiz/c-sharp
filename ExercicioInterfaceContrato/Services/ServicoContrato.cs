using System;
using ExercicioInterfaceContrato.Entities;

namespace ExercicioInterfaceContrato.Services {
    class ServicoContrato {
        private IServicoPagamento _servicePaypal;

        public ServicoContrato(IServicoPagamento servicePaypal)
        {
            _servicePaypal = servicePaypal;
        }

        public void ProcessaContrato(Contrato contrato, int meses)
        {
            double valorBase = contrato.ValorTotal / meses;

            for (int i = 1; i <= meses; i++)
            {
                DateTime dataVencimento = contrato.Date.AddMonths(i);
                double updateParcela = valorBase + _servicePaypal.AdicaoParcela(valorBase, i);
                double valorFinal = updateParcela + _servicePaypal.TaxaPagamento(updateParcela);
                contrato.AddParcelas(new Parcelas(dataVencimento, valorFinal));
            }
        }
    }
}
