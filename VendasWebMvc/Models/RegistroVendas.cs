using System;
using VendasWebMvc.Models.Enums;

namespace VendasWebMvc.Models
{
    public class RegistroVendas
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public double ValorVenda { get; set; }
        public StatusVenda Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroVendas()
        {
        }

        public RegistroVendas(int id, DateTime dataVenda, double valorVenda, StatusVenda status, Vendedor vendedor)
        {
            Id = id;
            DataVenda = dataVenda;
            ValorVenda = valorVenda;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
