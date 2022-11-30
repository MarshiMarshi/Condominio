using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_DS_Condominio.View;
using Projeto_DS_Condominio.Model;
using System.Windows.Forms;
using Projeto_DS_Condominio.Enums;

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
            this.view.CarregaEvent += CarregaMoradorSelecionado;
            this.view.EditaEvent += EditaMorador;
            this.view.DeleteEvent += ExcluiMoradorSelecionado;
            this.view.SalvaEvent += AdicionaMorador;
            this.view.CancelaEvent += CancelaAcao;
            this.view.SetEncomendaListBindingSource(moradoresBindingSource);

            this.CarregarTodosMoradores();
            this.view.Show();
        }

        private void CarregarTodosMoradores()
        {
            moradorList = repository.GetAll();
            moradoresBindingSource.DataSource = moradorList;
        }

        private void PesquisaMorador(object sender, EventArgs e)
        {
            moradorList = repository.GetByValor(this.view.NomePesquisa, this.view.RgPesquisa, this.view.CpfPesquisa, this.view.ApartamentoPesquisa, this.view.BlocoPesquisa);
            moradoresBindingSource.DataSource = moradorList;
        }
        
        private void EditarMorador(object sender, EventArgs e)
        {
            view.IsEditing = false;
        }

        private void CarregaMoradorSelecionado(object sender, EventArgs e)
        {
            if (moradoresBindingSource.Current == null)
                return;
            view.IsEditing = true;
            view.GuiaSelecionada = 1;
            Morador morador = (Morador)moradoresBindingSource.Current;
            view.NomeEdicao = morador.Nome;
            view.CpfEdicao = morador.Cpf.ToFormattedString();
            view.RgEdicao = morador.Rg.ToFormattedString();
            view.BlocoEdicao = morador.Bloco.ToString();
            view.ApartamentoEdicao = morador.Apartamento.ToString();
        }

        private void ExcluiMoradorSelecionado(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AdicionaMorador(object sender, EventArgs e)
        {
            Morador morador = new Morador();
            try
            {
                //new System.Data.Common.ModelDataValidation().Validate(morador);
                morador.Nome = view.Nome;
                morador.Rg = new Rg(view.Rg);
                morador.Cpf = new Cpf(view.Cpf);
                BlocoEnum blocoLido;
                Enum.TryParse<BlocoEnum>(view.Bloco.ToString(), out blocoLido);
                morador.Bloco = blocoLido;
                morador.Apartamento = Convert.ToInt32(view.Apartamento);
                repository.Adicionar(morador);
                view.Mensagem = "Morador adicionado com sucesso";
                view.IsSuccessful = true;
                CarregarTodosMoradores();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Mensagem = "Erro ao adicionar morador, verifique os dados";
            }
        }

        private void EditaMorador(object sender, EventArgs e)
        {
            Morador morador = new Morador();
            try
            {
                //new System.Data.Common.ModelDataValidation().Validate(morador);
                morador.Id = view.Id;
                morador.Nome = view.NomeEdicao;
                morador.Rg = new Rg(view.RgEdicao);
                morador.Cpf = new Cpf(view.CpfEdicao);
                BlocoEnum blocoLido;
                Enum.TryParse<BlocoEnum>(view.BlocoEdicao.ToString(), out blocoLido);
                morador.Bloco = blocoLido;
                morador.Apartamento = Convert.ToInt32(view.ApartamentoEdicao);
                repository.Editar(morador);
                view.Mensagem = "Morador editado com sucesso";
                view.IsSuccessful = true;
                CarregarTodosMoradores();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Mensagem = "Erro ao editar morador, verifique os dados";
            }
        }

        private void CancelaAcao(object sender, EventArgs e)
        {
            this.view.GuiaSelecionada = 0;
            CleanViewFields();
        }

        public void CleanViewFields()
        {
            this.view.Nome = "";
            this.view.Rg = "";
            this.view.Cpf = "";
            this.view.Bloco = "";
            this.view.Apartamento = "";
            this.view.NomePesquisa = "";
            this.view.RgPesquisa = "";
            this.view.CpfPesquisa = "";
            this.view.ApartamentoPesquisa = "";
            this.view.NomeEdicao = "";
            this.view.RgEdicao = "";
            this.view.CpfEdicao = "";
            this.view.ApartamentoEdicao = "";
        }
    }
}
