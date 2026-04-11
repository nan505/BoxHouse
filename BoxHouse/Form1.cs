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
