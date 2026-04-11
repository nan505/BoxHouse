using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxHouse
{
    public class Produtos
    {
        public string NomeProduto { get; set; }
        public double ValorProduto { get; set; }
        public int QtdProduto { get; set; }

        public Produtos(string nomeProduto, double valorProduto, int qtdProduto)
        {
            NomeProduto = nomeProduto;
            ValorProduto = valorProduto;
            QtdProduto = qtdProduto;
        }

        public void fnMsgAddProduto()
        {
            if (QtdProduto == 1)
            {
                MessageBox.Show($"O produto '{NomeProduto}' foi adicionado com sucesso.", "Mensagem de Aviso");
            }
            else
            {
                MessageBox.Show($"O produto '{NomeProduto}' foi adicionado {QtdProduto} vezes com sucesso.", "Mensagem de Aviso");
            }
        }
    }
}
