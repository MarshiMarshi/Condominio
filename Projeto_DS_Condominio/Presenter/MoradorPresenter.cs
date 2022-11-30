using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_DS_Condominio.View;
using Projeto_DS_Condominio.Model;
using System.Windows.Forms;

namespace Projeto_DS_Condominio.Presenter
{
    public class MoradorPresenter
    {
        public IMoradorView view;
        public IMoradorRepository repository;
        private BindingSource moradoresBindingSource;
        private IEnumerable<Morador> moradorList;

        public MoradorPresenter(IMoradorView view, IMoradorRepository repository)
        {
            this.moradoresBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.PesquisaEvent += PesquisaMorador;
            this.view.AdicionaEvent += AdicionaMorador;
            this.view.EditaEvent += CarregaMoradorSelecionado;
            this.view.DeleteEvent += ExcluiMoradorSelecionado;
            this.view.SalvaEvent += SalvaMorador;
            this.view.CancelaEvent += CancelaAcao;
            this.SetBindingSource(moradoresBindingSource);

            this.CarregarTodosMoradores();
            this.view.Show();
        }

        private void SetBindingSource(BindingSource moradoresBindingSource)
        {
            moradorList = repository.GetAll();
            moradoresBindingSource.DataSource = moradorList;
        }

        private void CarregarTodosMoradores()
        {
            moradorList = repository.GetByValor(this.view.Nome, this.view.Rg, this.view.Cpf, this.view.Apartamento, this.view.Bloco);
            moradoresBindingSource.DataSource = moradorList;
        }

        private void PesquisaMorador(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AdicionaMorador(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CarregaMoradorSelecionado(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ExcluiMoradorSelecionado(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SalvaMorador(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CancelaAcao(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
