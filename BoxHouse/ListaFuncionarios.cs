using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxHouse
{
    public static class ListaFuncionarios
    {
        public static BindingList<Funcionarios> FuncionariosCadastrados { get; set; } = new BindingList<Funcionarios>();
    }
}
