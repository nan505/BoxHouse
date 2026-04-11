using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxHouse
{
    internal class Clientes
    {
        public string NomeCliente { get; set; }
        public string TelefoneCliente { get; set; }
        public string NomePetCliente { get; set; }

        public Clientes(string nomeCliente, string telefoneCliente, string nomePetCliente)
        {
            NomeCliente = nomeCliente;
            TelefoneCliente = telefoneCliente;
            NomePetCliente = nomePetCliente;
        }

        BindingList<Clientes> clientesCadastrados = new BindingList<Clientes>();
    }
}
