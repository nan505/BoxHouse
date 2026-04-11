using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxHouse
{
    public class Produtos
    {
        public string NomeProduto { get; set; }
        public double ValorProduto { get; set; }

        public Produtos(string nomeProduto, double valorProduto){
            NomeProduto = nomeProduto;
            ValorProduto = valorProduto;
        }
    }
}
