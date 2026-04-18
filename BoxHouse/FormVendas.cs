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

        double valorTotal = 0;
        string dataAtualDiaMesAno = DateTime.Now.ToString("dd/MM/yyyy");
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
            cbSelecionarCliente.DataSource = ListaClientes.ClientesCadastrados.Select(p => p.NomeCliente).ToList();
            cbSelecionarCliente.SelectedIndex = -1;
            lbDataAtual.Text = dataAtualDiaMesAno;
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

        private void fnLimparVendas()
        {
            cbSelecionarProdutos.SelectedIndex = -1;
            numQuantidade.Value = 1;
            listaProdutos.Clear();
            cbSelecionarCliente.SelectedIndex = -1;
            tBoxEnderecoCliente.Text = string.Empty;
            dgvProdutosAdicionados.Refresh();
        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            if (dgvProdutosAdicionados.Rows.Count > 0)
            {
                if(cbSelecionarCliente.Text != string.Empty)
                {
                    string nomeClienteEntrega = cbSelecionarCliente.Text;
                    string enderecoEntrega = tBoxEnderecoCliente.Text;
                    string statusEntrega = "Pendente";

                    if (enderecoEntrega == string.Empty)
                    {
                        MessageBox.Show($"O pedido de {nomeClienteEntrega} foi finalizado com sucesso!", 
                            "Mensagem de Aviso");

                        fnLimparVendas();
                    }
                    else
                    {
                        Entregas cadastroNovaEntrega = new Entregas(nomeClienteEntrega, enderecoEntrega, 
                            dataAtualDiaMesAno, statusEntrega);
                        ListaEntregas.EntregasCadastradas.Add(cadastroNovaEntrega);

                        MessageBox.Show($"O pedido de {nomeClienteEntrega} foi adicionado para entrega com sucesso!",
                            "Mensagem de Aviso");

                        fnLimparVendas();
                    }
                }
                else
                {
                    MessageBox.Show("Uma compra finalizada precisa ser atribuída a um cliente.", "Mensagem de Aviso");
                }
            }
            else
            {
                MessageBox.Show("Ao menos um produto precisa ser adicionado para a compra ser finalizada.",
                    "Mensagem de Aviso");
            }
        }
    }
}
