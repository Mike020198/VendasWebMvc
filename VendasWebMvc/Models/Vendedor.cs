using System;
using System.Collections.Generic;
using System.Linq;

namespace VendasWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<RegistroVendas> ListaRegistroVendas { get; set; } = new List<RegistroVendas>();

        public Vendedor()
        {
        }

        public Vendedor(int id, string name, string email, DateTime dataNascimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Name = name;
            Email = email;
            DataNascimento = dataNascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddRegistroVendas(RegistroVendas rv)
        {
            ListaRegistroVendas.Add(rv);
        }

        public void DeleteRegistroVendas(RegistroVendas rv)
        {
            ListaRegistroVendas.Remove(rv);
        }

        public double TotalVendas(DateTime inicial, DateTime final)
        {
            return ListaRegistroVendas
                .Where(v => v.DataVenda >= inicial && v.DataVenda <= final)
                .DefaultIfEmpty()
                .Sum(v => v.ValorVenda);
        }
    }
}
