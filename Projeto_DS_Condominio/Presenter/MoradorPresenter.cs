using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_DS_Condominio.View;
using Projeto_DS_Condominio.Model;

namespace Projeto_DS_Condominio.Presenter
{
    public class MoradorPresenter
    {
        public IMoradorView view;
        public IMoradorRepository repository;
        private IEnumerable<Morador> moradorList;

        public MoradorPresenter(IMoradorView view, IMoradorRepository repository)
        {
            this.view = view;
            this.repository = repository;

            //this.view.SearchEvent += SearchPet;
            //this.view.AddNewEvent += AddNewPet;
            //this.view.EditEvent += LoadSelectedPetToEdit;
            //this.view.DeleteEvent += DeleteSelectedPet;
            //this.view.SaveEvent += SavePet;
            this.view.CancelEvent += CancelAction;

            this.view.Show();
        }

        public void CleanViewFields()
        {
            this.view.Nome = "";
            this.view.Rg = "";
            this.view.Cpf = "";
            this.view.Bloco = "";
            this.view.Apartamento = "";
        }

        public void CancelAction(Object sender, EventArgs e)
        {
            CleanViewFields();
        }
    }
}
