using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxHouse
{
    public class Funcionarios
    {
        public string NomeFuncionario { get; set; }
        public string CargoFuncionario { get; set; }

        public Funcionarios(string nomeFuncionario, string cargoFuncionario)
        {
            NomeFuncionario = nomeFuncionario;
            CargoFuncionario = cargoFuncionario;
        }
    }
}
