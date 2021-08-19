
namespace ExercicioInterfaceContrato.Services {
    interface IServicoPagamento {
        double TaxaPagamento(double valor);
        double AdicaoParcela(double montante, int meses);
    }
}
