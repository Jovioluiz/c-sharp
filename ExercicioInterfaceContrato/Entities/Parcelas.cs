using System;
using System.Globalization;

namespace ExercicioInterfaceContrato.Entities {
    class Parcelas {
        public DateTime DataVencimento { get; set; }
        public double ValorParcela { get; set; }

        public Parcelas(DateTime dataVencimento, double valorParcela)
        {
            DataVencimento = dataVencimento;
            ValorParcela = valorParcela;
        }

        public override string ToString()
        {
            return DataVencimento.ToString("dd/MM/yyyy")
                + " - "
                + ValorParcela.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
