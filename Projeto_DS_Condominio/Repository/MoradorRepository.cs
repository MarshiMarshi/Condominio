using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_DS_Condominio.Enums;
using Projeto_DS_Condominio.Model;

namespace Projeto_DS_Condominio.Repository
{
    public class MoradorRepository : RepositoryBase, IMoradorRepository
    {
        public MoradorRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Adicionar(Morador morador)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Editar(Morador morador)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Morador> GetAll()
        {
            List<Morador> moradorList = new List<Morador>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from Morador order by bloco_morador, apartamento desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Morador morador = new Morador();
                        morador.Id = (int)reader[0];
                        morador.Nome = reader[1].ToString();
                        morador.Rg = reader[2].ToString();
                        morador.Cpf = reader[3].ToString();

                        BlocoEnum bloco;
                        Enum.TryParse<BlocoEnum>(reader[4].ToString(), out bloco);
                        morador.Bloco = bloco;

                        morador.Apartamento = Int32.Parse(reader[5].ToString());
                        moradorList.Add(morador);
                    }
                }
            }
            return moradorList;
        }
    }
}
