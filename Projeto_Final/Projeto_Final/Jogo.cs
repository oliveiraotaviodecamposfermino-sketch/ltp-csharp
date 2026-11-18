using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastro
{

    internal class Jogo
    {
        string nome;
        string plataforma;
        string desenvolvedora;
        int ano_lançamento;
        float nota;
        string observação;

        public string Nome { get => nome; set => nome = value; }
        public string Plataforma { get => plataforma; set => plataforma = value; }
        public string Desenvolvedora { get => desenvolvedora; set => desenvolvedora = value; }
        public int Ano_lancamento { get => ano_lançamento; set => ano_lançamento = value; }
        public float Nota { get => nota; set => nota = value; }
        public string Observação { get => observação; set => observação = value; }
    }

}