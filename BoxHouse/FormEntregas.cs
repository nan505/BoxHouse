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
    public partial class FormEntregas : Form
    {
        BindingList<Entregas> entregasAdicionadas = new BindingList<Entregas>();

        public FormEntregas()
        {
            InitializeComponent();

            cbClientesCadastrados.DataSource = ListaClientes.ClientesCadastrados.Select(p => p.NomeCliente).ToList();

            cbClientesCadastrados.SelectedIndex = -1;

            Entregas e1 = new Entregas("Gregory House", "Princeton Plainsboro, 321", "Pendente");
            Entregas e2 = new Entregas("Alphonse Elric", "Rua dos Bobos, 123", "Saiu para entrega");

            entregasAdicionadas.Add(e1);
            entregasAdicionadas.Add(e2);

            dgvEntregasCadastradas.DataSource = entregasAdicionadas;
        }

        private void btnAddEntrega_Click(object sender, EventArgs e)
        {
            string nomeClienteEntrega = cbClientesCadastrados.Text;
            string enderecoEntrega = tBoxEndereco.Text;
            string statusEntrega = cbStatusEntrega.Text;

            if(nomeClienteEntrega != string.Empty && enderecoEntrega != string.Empty
                && statusEntrega != string.Empty)
            {
                if(statusEntrega != "Entregue")
                {
                    Entregas novaEntrega = new Entregas(nomeClienteEntrega, enderecoEntrega, statusEntrega);

                    MessageBox.Show($"A nova entrega para {nomeClienteEntrega} em {enderecoEntrega} com o status " +
                        $"'{statusEntrega.ToLower()}' foi adicionada com sucesso.", "Mensagem de Aviso");

                    entregasAdicionadas.Add(novaEntrega);

                    fnLimparForms();

                    dgvEntregasCadastradas.Refresh();
                }
                else
                {
                    MessageBox.Show("Uma nova entrega a ser adicionada não pode ter seu status definido como 'Entregue'",
                        "Mensagem de Aviso");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente.", "Mensagem de Aviso");
            }
        }

        private void btnAtualizarStatus_Click(object sender, EventArgs e)
        {
            string statusEntrega = cbStatusEntrega.Text;
            string statusEntregaSelecionado = dgvEntregasCadastradas.CurrentRow.Cells["StatusEntrega"].Value.ToString();

            if(statusEntregaSelecionado != "Entregue")
            {
                if(statusEntregaSelecionado != statusEntrega)
                {
                    string nomeClienteStatus = dgvEntregasCadastradas.CurrentRow.Cells["NomeClienteEntrega"].Value.ToString();
                    MessageBox.Show($"O status da entrega de {nomeClienteStatus} foi alterado para '{statusEntrega}' com sucesso.\n\n" +
                        $"Status anterior: {statusEntregaSelecionado}.", "Mensagem de Aviso");

                    dgvEntregasCadastradas.CurrentRow.Cells["StatusEntrega"].Value = statusEntrega;

                    fnLimparForms();

                    dgvEntregasCadastradas.Refresh();
                }
                else
                {
                    MessageBox.Show("O status informado é o mesmo da entrega selecionada.", "Mensagem de Aviso");
                }
            }
            else
            {
                MessageBox.Show("O pedido selecionado já foi entregue e seu status não pode ser alterado.", "Mensagem de Aviso");
            }
        }

        private void btnFiltroStatus_Click(object sender, EventArgs e)
        {
            string statusFiltro = cbStatusEntrega.Text;

            if(statusFiltro != string.Empty)
            {
                var filtroStatus = entregasAdicionadas.Where(p => p.StatusEntrega.Contains(statusFiltro)).ToList();
                dgvEntregasCadastradas.DataSource = filtroStatus;
            }
            else
            {
                dgvEntregasCadastradas.DataSource = entregasAdicionadas;
            }
        }

        private void fnLimparForms()
        {
            cbClientesCadastrados.SelectedIndex = -1;
            tBoxEndereco.Text = "";
            cbStatusEntrega.SelectedIndex = -1;
        }

        private void btnResetarFiltro_Click(object sender, EventArgs e)
        {
            dgvEntregasCadastradas.DataSource = entregasAdicionadas;
        }
    }
}
