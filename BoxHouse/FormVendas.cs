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
        public FormVendas()
        {
            InitializeComponent();

            Produtos p1 = new Produtos("Ração de cachorro", 12.99, 1);
            Produtos p2 = new Produtos("Coleira pequena", 24.49, 1);
            Produtos p3 = new Produtos("Petisco genérico", 14.99, 1);

            inventarioProdutos.Add(p1);
            inventarioProdutos.Add(p2);
            inventarioProdutos.Add(p3);

            dgvProdutosAdicionados.DataSource = listaProdutos;
        }

        private void fnLimparForms()
        {
            cbSelecionarProdutos.SelectedIndex = -1;
            numQuantidade.Value = 1;
        }

        private void btnAddProdutos_Click(object sender, EventArgs e)
        {
            string nomeProduto = cbSelecionarProdutos.Text;
            int qtdProduto = (int)numQuantidade.Value;

            if (nomeProduto != string.Empty && qtdProduto > 0)
            {
                var locProduto = inventarioProdutos.FirstOrDefault(p => p.NomeProduto == nomeProduto);
                double valorProduto = locProduto.ValorProduto;
                double valorTotal = 0;

                Produtos produtoAdicionado = new Produtos(nomeProduto, valorProduto, qtdProduto);

                listaProdutos.Add(produtoAdicionado);
                valorTotal = valorTotal + (valorProduto * qtdProduto);

                lbValorTotal.Text = $"R${valorTotal.ToString("F2")}";

                fnLimparForms();

                dgvProdutosAdicionados.Refresh();

                produtoAdicionado.fnMsgAddProduto();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente.", "Mensagem de Aviso");
            }
        }
    }
}
