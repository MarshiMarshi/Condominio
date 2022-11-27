using System;
using System.Collections.Generic;
using System.Data;
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

        public IEnumerable<Morador> GetByValor(String valNome, String valRg, String valCpf, String valApartamento, String valBloco)
        {
            List<Morador> moradorList = new List<Morador>();
            int apartamento = int.TryParse(valApartamento, out _) ? Convert.ToInt32(valApartamento) : -1;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"select * from Morador ";

                command.CommandText += "where 1 = 1 ";

                if (valNome != "")
                {
                    command.CommandText += "and nome_morador like @nome + '%' ";
                    command.Parameters.Add("@nome", SqlDbType.VarChar).Value = valNome;
                }

                if (valRg != "")
                {
                    command.CommandText += "and rg_morador = @rg ";
                    command.Parameters.Add("@rg", SqlDbType.Char).Value = valRg;
                }

                if (valCpf != "")
                {
                    command.CommandText += "and cpf_morador = @cpf ";
                    command.Parameters.Add("@cpf", SqlDbType.Char).Value = valCpf;
                }

                if (apartamento != -1)
                {
                    command.CommandText += "and apartamento = @apartamento ";
                    command.Parameters.Add("@apartamento", SqlDbType.VarChar).Value = apartamento;
                }

                if (valBloco != "")
                {
                    command.CommandText += "and bloco_morador = @bloco ";
                    command.Parameters.Add("@bloco", SqlDbType.VarChar).Value = valBloco;
                }

                command.CommandText += "order by bloco_morador, apartamento desc";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Morador morador = new Morador();
                        morador.Id = (int)reader[0];
                        morador.Nome = reader[1].ToString();
                        morador.Rg = reader[2].ToString();
                        morador.Cpf = reader[3].ToString();

                        BlocoEnum blocoLido;
                        Enum.TryParse<BlocoEnum>(reader[4].ToString(), out blocoLido);
                        morador.Bloco = blocoLido;

                        morador.Apartamento = Int32.Parse(reader[5].ToString());
                        moradorList.Add(morador);
                    }
                }
            }
            return moradorList;
        }
    }
}
