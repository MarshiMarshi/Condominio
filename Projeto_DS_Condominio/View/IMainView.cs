using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DS_Condominio.View
{
    public interface IMainView
    {
        event EventHandler ShowEncomendaView;
        event EventHandler ShowMoradorView;
    }
}
