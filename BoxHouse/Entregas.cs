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
        public string DataPedidoRealizado { get; set; }
        public string StatusEntrega { get; set; }

        public Entregas(string nomeClienteEntrega, string enderecoEntrega, string dataAtualDiaMesAno, string statusEntrega)
        {
            NomeClienteEntrega = nomeClienteEntrega;
            EnderecoEntrega = enderecoEntrega;
            DataPedidoRealizado = dataAtualDiaMesAno;
            StatusEntrega = statusEntrega;
        }
    }
}
