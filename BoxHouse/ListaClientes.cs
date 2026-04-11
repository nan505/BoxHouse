using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxHouse
{
    public static class ListaClientes
    {
        public static BindingList<Clientes> ClientesCadastrados { get; set; } = new BindingList<Clientes>();
    }
}
