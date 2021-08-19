using System;
using System.Collections.Generic;

namespace ExercicioInterfaceContrato.Entities {
    class Contrato {
        public int Numero { get; set; }
        public DateTime Date { get; set; }
        public double ValorTotal { get; set; }
        public List<Parcelas> Parcelas { get; set; }

        public Contrato(int numero, DateTime date, double valorTotal)
        {
            Numero = numero;
            Date = date;
            ValorTotal = valorTotal;
            Parcelas = new List<Parcelas>();
        }

        public void AddParcelas(Parcelas par)
        {
            Parcelas.Add(par);
        }
    }
}
