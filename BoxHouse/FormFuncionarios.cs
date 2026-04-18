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
    public partial class FormFuncionarios : Form
    {
        BindingList<Funcionarios> funcionariosCadastrados = new BindingList<Funcionarios>();

        public FormFuncionarios()
        {
            InitializeComponent();

            Funcionarios f1 = new Funcionarios("Lucas", "Supervisor(a)");
            Funcionarios f2 = new Funcionarios("Laysla", "Tosador(a)");
            Funcionarios f3 = new Funcionarios("Einstein", "Adestrador(a)");

            funcionariosCadastrados.Add(f1);
            funcionariosCadastrados.Add(f2);
            funcionariosCadastrados.Add(f3);

            tBoxNomeFuncionario.Focus();
            dgvFuncionarios.DataSource = funcionariosCadastrados;
        }

        private void fnLimparForms()
        {
            tBoxNomeFuncionario.Text = "";
            cbCargoFuncionario.SelectedIndex = -1;

            tBoxNomeFuncionario.Focus();
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            string nomeFuncionario = tBoxNomeFuncionario.Text;
            string cargoFuncionario = cbCargoFuncionario.Text;

            if(nomeFuncionario != string.Empty && cargoFuncionario != string.Empty)
            {
                Funcionarios novoFuncionario = new Funcionarios(nomeFuncionario, cargoFuncionario);

                MessageBox.Show($"Funcionário(a) {nomeFuncionario} cadastrado(a) com sucesso!", "Mensagem de Aviso");

                funcionariosCadastrados.Add(novoFuncionario);

                fnLimparForms();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente.", "Mensagem de Aviso");
                tBoxNomeFuncionario.Focus();
            }
        }

        private void btnCalcularComissao_Click(object sender, EventArgs e)
        {
            decimal valorVendas = numValorVendas.Value;

            if(dgvFuncionarios.CurrentRow != null && valorVendas > 0)
            {
                string nomeFuncionarioComissao = dgvFuncionarios.CurrentRow.Cells["NomeFuncionario"].Value.ToString();
                string cargoFuncionarioComissao = dgvFuncionarios.CurrentRow.Cells["CargoFuncionario"].Value.ToString();

                if(valorVendas > 500)
                {
                    decimal valorComissao = (valorVendas * 0.05m);

                    MessageBox.Show($"Funcionário(a) {nomeFuncionarioComissao} ( Cargo: {cargoFuncionarioComissao} )" +
                        $" recebeu 5% de comissão pelas vendas.\n\n" +

                        $"O valor da comissão foi de R$ {valorComissao}", "Mensagem de Aviso");

                    valorVendas = 0;
                }
                else
                {
                    MessageBox.Show($"Funcionário(a) {nomeFuncionarioComissao} ( Cargo: {cargoFuncionarioComissao} )" +
                        $" não se qualifica para receber a comissão de 5% (Mínimo de valor de vendas necessário: R$ 500,00).");
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha e/ou informe um valor de vendas válido.", "Mensagem de Aviso");
            }
        }

        private void btnLimparForms_Click(object sender, EventArgs e)
        {
            fnLimparForms();
        }

        private void dgvFuncionarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvFuncionarios.Columns["NomeFuncionario"].HeaderText = "Nome do funcionário";
            dgvFuncionarios.Columns["CargoFuncionario"].HeaderText = "Cargo atribuído";
        }
    }
}
