using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        private Rg _rg;
        private Cpf _cpf;
        private BlocoEnum _bloco;
        private int _apartamento;

        public int Id { get => _id; set => _id = value; }
        [DisplayName("Nome")]
        [Required(ErrorMessage = "O nome do morador é obrigatório")]
        [StringLength(30, ErrorMessage = "O nome deve ter no máximo 30 caracteres")]
        public string Nome { get => _nome; set => _nome = value; }
        [DisplayName("RG")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "O RG está incompleto")]
        public Rg Rg { get => _rg; set => _rg = value; }
        [DisplayName("CPF")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF está incompleto")]
        public Cpf Cpf { get => _cpf; set => _cpf = value; }
        [DisplayName("Bloco")]
        [Required(ErrorMessage = "O bloco do morador é obrigatório")]
        public BlocoEnum Bloco { get => _bloco; set => _bloco = value; }
        [DisplayName("Apartamento")]
        [Required(ErrorMessage = "O apartamento do morador é obrigatório")]
        public int Apartamento { get => _apartamento; set => _apartamento = value; }
    }
}
