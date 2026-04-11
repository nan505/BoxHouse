using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxHouse
{
    public class Entregas
    {
        public string NomeClienteEntrega { get; set; }
        public string EnderecoEntrega { get; set; }
        public string StatusEntrega { get; set; }

        public Entregas(string nomeClienteEntrega, string enderecoEntrega, string statusEntrega)
        {
            NomeClienteEntrega = nomeClienteEntrega;
            EnderecoEntrega = enderecoEntrega;
            StatusEntrega = statusEntrega;
        }
    }
}
