using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_DS_Condominio.Enums;

namespace Projeto_DS_Condominio.Model
{
    public class Morador
    {
        private int _id;
        private string _nome;
        private string _rg;
        private string _cpf;
        private BlocoEnum _bloco;
        private int _apartamento;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Rg { get => _rg; set => _rg = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public BlocoEnum Bloco { get => _bloco; set => _bloco = value; }
        public int Apartamento { get => _apartamento; set => _apartamento = value; }
    }
}
