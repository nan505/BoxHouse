using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxHouse
{
    public static class ListaEntregas
    {
        public static BindingList<Entregas> EntregasCadastradas { get; set; } = new BindingList<Entregas>();
    }
}
