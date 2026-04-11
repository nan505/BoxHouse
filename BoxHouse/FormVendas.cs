using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxHouse
{
    public partial class FormVendas : Form
    {
        BindingList<Produtos> listaProdutos = new BindingList<Produtos>();
        BindingList<Produtos> inventarioProdutos = new BindingList<Produtos>();
        double valorTotal;
        double qtdProduto;
        public FormVendas()
        {
            InitializeComponent();

            Produtos p1 = new Produtos("Ração de cachorro", 12.99);
            Produtos p2 = new Produtos("Coleira pequena", 24.49);
            Produtos p3 = new Produtos("Petisco genérico", 14.99);

            inventarioProdutos.Add(p1);
            inventarioProdutos.Add(p2);
            inventarioProdutos.Add(p3);
        }

        private void btnAddProdutos_Click(object sender, EventArgs e)
        {
            string nomeProduto = cbSelecionarProdutos.Text;

            if (nomeProduto != string.Empty)
            {
                qtdProduto = (int)numQuantidade.Value;
                var locProduto = inventarioProdutos.FirstOrDefault(p => p.NomeProduto == nomeProduto);
                double valorProduto = locProduto.ValorProduto;

                Produtos produtoAdicionado = new Produtos(nomeProduto, valorProduto);

                listaProdutos.Add(produtoAdicionado);
                valorTotal = listaProdutos.Sum(p => p.ValorProduto);

                var dgvProdutos = listaProdutos.Select(p => new
                {
                    nomeProduto = p.NomeProduto,
                    valorProduto = p.ValorProduto,
                    qtdProduto = qtdProduto
                }).ToList();

                dgvProdutosAdicionados.DataSource = dgvProdutos;
                dgvProdutosAdicionados.Refresh();
            }
        }
    }
}
