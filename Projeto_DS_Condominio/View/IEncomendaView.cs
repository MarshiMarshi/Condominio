using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DS_Condominio.View
{
    public interface IEncomendaView
    {
        //properties
        String Id { get; set; }
        String Status { get; set; }
        String Armazenamento { get; set; }
        String DataChegada { get; set; }
        String DataEntrega { get; set; }
        String NomeDestinatario { get; set; }
        String DescricaoAusente { get; set; }
        String DescricaoDevolutiva { get; set; }

        String ProcurarId { get; set; }
        bool Editar { get; set; }
        bool Concluido { get; set; }
        String Mensagem { get; set; }
        int GuiaSelecionada { get; set; }

        //Events
        event EventHandler SalvarEvent;
        event EventHandler limparEvent;
        event EventHandler EditarEvent;
        event EventHandler PesquisarEvent;

        //Methods
        void SetEncomendaListBindingSource(BindingSource encomendaList);
        void Show();
    }
}
