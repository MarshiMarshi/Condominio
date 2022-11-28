using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Projeto_DS_Condominio.Enums;

namespace Projeto_DS_Condominio.Model
{
    public class Encomenda
    {
        private int _id;
        private StatusEncomendaEnum _status;
        private LocalArmazenamentoEnum _armazenamento;
        private DateTime _dataChegada;
        private DateTime _dataEntrega;
        private Morador _destinatario;
        private DescricaoAusente _descricaoAusente;
        private DescricaoDevolutiva _descricaoDevolutiva;

        [DisplayName("Encomenda Id")]
        public int Id { get => _id; set => _id = value; }

        [DisplayName("Status Encomenda")]
        [Required(ErrorMessage = "Necessario Status")]
        public StatusEncomendaEnum Status { get => _status; set => _status = value; }

        [DisplayName("Local de Aramazenamento")]
        public LocalArmazenamentoEnum Armazenamento { get => _armazenamento; set => _armazenamento = value; }

        [DisplayName("Data de recebimento da Encomenda")]
        [Required(ErrorMessage = "Necessario data de recebimento")]
        public DateTime DataChegada { get => _dataChegada; set => _dataChegada = value; }

        [DisplayName("Data de entrega")]
        public DateTime DataEntrega { get => _dataEntrega; set => _dataEntrega = value; }

        [DisplayName("Dono da Encomenda")]
        [Required(ErrorMessage = "Necessario nome do destinatario")]
        public Morador Destinatario { get => _destinatario; set => _destinatario = value; }
        public DescricaoAusente DescricaoAusente { get => _descricaoAusente; set => _descricaoAusente = value; }
        public DescricaoDevolutiva DescricaoDevolutiva { get => _descricaoDevolutiva; set => _descricaoDevolutiva = value; }
    }
}
