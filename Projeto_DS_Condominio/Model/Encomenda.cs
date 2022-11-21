using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public int Id { get => _id; set => _id = value; }
        public StatusEncomendaEnum Status { get => _status; set => _status = value; }
        public LocalArmazenamentoEnum Armazenamento { get => _armazenamento; set => _armazenamento = value; }
        public DateTime DataChegada { get => _dataChegada; set => _dataChegada = value; }
        public DateTime DataEntrega { get => _dataEntrega; set => _dataEntrega = value; }
        public Morador Destinatario { get => _destinatario; set => _destinatario = value; }
        public DescricaoAusente DescricaoAusente { get => _descricaoAusente; set => _descricaoAusente = value; }
        public DescricaoDevolutiva DescricaoDevolutiva { get => _descricaoDevolutiva; set => _descricaoDevolutiva = value; }
    }
}
