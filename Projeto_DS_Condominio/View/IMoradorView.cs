using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DS_Condominio.View
{
    public interface IMoradorView
    {
        string Nome { get; set; }
        string Rg { get; set; }
        string Cpf { get; set; }
        string Bloco { get; set; }
        string Apartamento { get; set; }

        string NomeEdicao { get; set; }
        string RgEdicao { get; set; }
        string CpfEdicao { get; set; }
        string BlocoEdicao { get; set; }
        string ApartamentoEdicao { get; set; }

        string NomePesquisa { get; set; }
        string RgPesquisa { get; set; }
        string CpfPesquisa { get; set; }
        string BlocoPesquisa { get; set; }
        string ApartamentoPesquisa { get; set; }

        bool IsEditing { get; set; }
        bool IsSuccessful { get; set; }
        bool IsSearching { get; set; }
        string Mensagem { get; set; }

        event EventHandler PesquisaEvent;
        event EventHandler AdicionaEvent;
        event EventHandler EditaEvent;
        event EventHandler DeleteEvent;
        event EventHandler SalvaEvent;
        event EventHandler CancelaEvent;

        void SetEncomendaListBindingSource(BindingSource moradorList);
        void Show();
    }
}
