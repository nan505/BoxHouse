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
    public partial class FormPrincipal : Form
    {
        BindingList<Clientes> clientesCadastrados = ListaClientes.ClientesCadastrados;
        public FormPrincipal()
        {
            InitializeComponent();

            Clientes c1 = new Clientes("Paulo", "(19) 99999-9999", "Cavalo Caixa");
            Clientes c2 = new Clientes("Guto", "(19) 99999-9998", "Yorkshireson");

            clientesCadastrados.Add(c1);
            clientesCadastrados.Add(c2);

            Entregas e1 = new Entregas("Gregory House", "Princeton Plainsboro, 321", "25/03/2025", "Pendente");
            Entregas e2 = new Entregas("Alphonse Elric", "Rua dos Bobos, 123", "16/04/2026", "Saiu para entrega");

            ListaEntregas.EntregasCadastradas.Add(e1);
            ListaEntregas.EntregasCadastradas.Add(e2);

            Funcionarios f1 = new Funcionarios("Lucas", "Supervisor(a)");
            Funcionarios f2 = new Funcionarios("Laysla", "Tosador(a)");
            Funcionarios f3 = new Funcionarios("Einstein", "Adestrador(a)");

            ListaFuncionarios.FuncionariosCadastrados.Add(f1);
            ListaFuncionarios.FuncionariosCadastrados.Add(f2);
            ListaFuncionarios.FuncionariosCadastrados.Add(f3);
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            FormVendas formVendas = new FormVendas();

            formVendas.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();

            formClientes.ShowDialog();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            FormFuncionarios formFuncionarios = new FormFuncionarios();

            formFuncionarios.ShowDialog();
        }

        private void btnEntregas_Click(object sender, EventArgs e)
        {
            FormEntregas formEntregas = new FormEntregas();

            formEntregas.ShowDialog();
        }
    }
}
