using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_DS_Condominio.View;
using Projeto_DS_Condominio.Presenter;
using Projeto_DS_Condominio.Repository;

namespace Projeto_DS_Condominio
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string sqlConnectionString = "";
            IMainView mainView = new frmMainView();
            new MainPresenter(mainView, sqlConnectionString);
            Application.Run(new frmMainView());
        }
    }
}
