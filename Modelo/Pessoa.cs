using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Pessoa
    {
        string nome;
        int rg, idade;

        public int Rg { get => rg; set => rg = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
