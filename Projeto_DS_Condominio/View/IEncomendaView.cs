using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_DS_Condominio.Enums;

namespace Projeto_DS_Condominio.View
{
    public interface IEncomendaView
    {
        // Campos/Propriedades
        string NomeDestinatario { get; set; }
        BlocoEnum Bloco { get; set; }
        string Apartamento { get; set; }

        LocalArmazenamentoEnum LocalArmazem { get; set; }
        DateTime DataChegada { get; set; }
        StatusEncomendaEnum Status { get; set; }
        DateTime DataEntrega { get; set; }

        MotivoEnum Motivo { get; set; }
        DateTime DataDevolucao { get; set; }

        string NomeDestinatarioPesquisa { get; set; }
        DateTime DataInicio { get; set; }
        IntervaloEnum Intervalo { get; set; }
        string DataEntre { get; set; }
        StatusEncomendaEnum StatusPesquisa { get; set; }

        
        // Eventos
        event EventHandler EditEvent; /////////////////
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler CleanTextsEvent;
        event EventHandler SearchEvent;


        // Métodos
        void SetEncomendaBindingSource(BindingSource encomendaList);
        void Show();
    }
}
