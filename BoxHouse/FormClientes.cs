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
    public partial class FormClientes : Form
    {
        BindingList<Clientes> clientesCadastrados = ListaClientes.ClientesCadastrados;

        public FormClientes()
        {
            InitializeComponent();

            dgvClientesCadastrados.DataSource = clientesCadastrados;

            tBoxNomeCliente.Focus();
        }

        private void fnLimparForms()
        {
            tBoxNomeCliente.Text = "";
            mTBoxTelefone.Text = "";
            tBoxNomePetCliente.Text = "";

            tBoxNomeCliente.Focus();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            string nomeCliente = tBoxNomeCliente.Text;
            string telefoneCliente = mTBoxTelefone.Text;
            string nomePetCliente = tBoxNomePetCliente.Text;

            bool nomeClienteJaFoiCadastrado = clientesCadastrados.Any(p => p.NomeCliente.ToLower() == nomeCliente.ToLower());
            bool telefoneClienteJaFoiCadastrado = clientesCadastrados.Any(p => p.TelefoneCliente == telefoneCliente);

            if (nomeCliente != string.Empty && telefoneCliente.Length == 15 && nomePetCliente != string.Empty)
            {
                if(nomeClienteJaFoiCadastrado == false && telefoneClienteJaFoiCadastrado == false)
                {
                    Clientes novoClienteCadastrado = new Clientes(nomeCliente, telefoneCliente, nomePetCliente);

                    clientesCadastrados.Add(novoClienteCadastrado);

                    MessageBox.Show($"Cliente {nomeCliente} cadastrado com sucesso!", "Mensagem de Aviso");

                    fnLimparForms();

                    dgvClientesCadastrados.Refresh();
                }
                else
                {
                    MessageBox.Show("O nome e/ou telefone informado já está cadastrado em nosso sistema.", "Mensagem de Aviso");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente.", "Mensagem de Aviso");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisaInicial = tBoxPesquisar.Text;
            
            if(pesquisaInicial != string.Empty)
            {
                var filtroPesquisa = clientesCadastrados.Where(p => p.NomeCliente.ToLower().Contains(pesquisaInicial.ToLower())).ToList();
                dgvClientesCadastrados.DataSource = filtroPesquisa;
            }
            else
            {
                dgvClientesCadastrados.DataSource = clientesCadastrados;
            }

        }

        private void btnLimparForms_Click(object sender, EventArgs e)
        {
            fnLimparForms();
        }

        private void dgvClientesCadastrados_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvClientesCadastrados.Columns["NomeCliente"].HeaderText = "Nome do cliente";
            dgvClientesCadastrados.Columns["TelefoneCliente"].HeaderText = "Número de telefone";
            dgvClientesCadastrados.Columns["NomePetCliente"].HeaderText = "Nome do pet";
        }
    }
}
