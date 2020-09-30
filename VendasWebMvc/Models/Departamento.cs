
using System;
using System.Collections.Generic;
using System.Linq;

namespace VendasWebMvc.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Vendedor> ListaVendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        {
        }

        public Departamento(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddVendedor(Vendedor vendedor)
        {
            ListaVendedores.Add(vendedor);
        }
        public double TotalVendedor(DateTime inicial, DateTime final)
        {
            return ListaVendedores.Sum(v => v.TotalVendas(inicial, final));
        }
    }
}
