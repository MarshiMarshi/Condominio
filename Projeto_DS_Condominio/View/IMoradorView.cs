using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DS_Condominio.View
{
    public interface IMoradorView
    {
        string Nome { get; set; }
        string Rg { get; set; }
        string Cpf { get; set; }
        string Bloco { get; set; }
        string Apartamento { get; set; }
        
        bool IsEditing { get; set; }
        bool IsSucessful { get; set; }
        bool IsSearching { get; set; }

        event EventHandler PesquisaEvent;
        event EventHandler AdicionaEvent;
        event EventHandler EditaEvent;
        event EventHandler DeleteEvent;
        event EventHandler SalvaEvent;
        event EventHandler CancelaEvent;

        void Show();
    }
}
