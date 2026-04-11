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
        public FormEntregas()
        {
            InitializeComponent();

            cbClientesCadastrados.DataSource = ListaClientes.ClientesCadastrados.Select(p => p.NomeCliente).ToList();
        }
    }
}
