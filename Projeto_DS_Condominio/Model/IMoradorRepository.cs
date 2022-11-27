using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DS_Condominio.Model
{
    public interface IMoradorRepository
    {
        void Adicionar(Morador morador);
        void Editar(Morador morador);
        void Delete(int id);
        IEnumerable<Morador> GetAll();
        IEnumerable<Morador> GetByValor(String valNome, String valRg, String valCpf, String valApartamento, String valBloco);
    }
}
