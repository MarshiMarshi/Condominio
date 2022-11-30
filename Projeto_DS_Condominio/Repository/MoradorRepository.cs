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
            List<Morador> moradorList = new List<Morador>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into Morador(nome_morador, rg_morador, cpf_morador, bloco_morador, apartamento) values (@nome, @rg, @cpf, @bloco, @apartamento)";
                command.Parameters.Add("@nome", SqlDbType.VarChar).Value = morador.Nome;
                command.Parameters.Add("@rg", SqlDbType.Char).Value = morador.Rg.ToDigitsString();
                command.Parameters.Add("@cpf", SqlDbType.Char).Value = morador.Cpf.ToDigitsString();
                command.Parameters.Add("@apartamento", SqlDbType.Int).Value = morador.Apartamento;
                command.Parameters.Add("@bloco", SqlDbType.VarChar).Value = morador.Bloco;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            List<Morador> moradorList = new List<Morador>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from Morador where id_morador = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Editar(Morador morador)
        {
            List<Morador> moradorList = new List<Morador>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "update Morador set nome_morador = @nome, rg_morador = @rg, cpf_morador = @cpf, bloco_morador = @bloco, apartamento = @apartamento where id_morador = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = morador.Id;
                command.Parameters.Add("@nome", SqlDbType.VarChar).Value = morador.Nome;
                command.Parameters.Add("@rg", SqlDbType.Char).Value = morador.Rg.ToDigitsString();
                command.Parameters.Add("@cpf", SqlDbType.Char).Value = morador.Cpf.ToDigitsString();
                command.Parameters.Add("@apartamento", SqlDbType.Int).Value = morador.Apartamento;
                command.Parameters.Add("@bloco", SqlDbType.VarChar).Value = morador.Bloco;
                command.ExecuteNonQuery();
            }
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
                        morador.Rg = new Rg(reader[2].ToString());
                        morador.Cpf = new Cpf(reader[3].ToString());

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
            String cpf = Cpf.TryParse(valCpf, out _) ? new Cpf(valCpf).ToDigitsString() : "";
            String rg = Cpf.TryParse(valRg, out _) ? new Rg(valRg).ToDigitsString() : "";

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from Morador ";

                command.CommandText += "where 1 = 1 ";

                if (valNome != "")
                {
                    command.CommandText += "and nome_morador like @nome + '%' ";
                    command.Parameters.Add("@nome", SqlDbType.VarChar).Value = valNome;
                }

                if (rg != "")
                {
                    command.CommandText += "and rg_morador = @rg ";
                    command.Parameters.Add("@rg", SqlDbType.Char).Value = rg;
                }

                if (cpf != "")
                {
                    command.CommandText += "and cpf_morador = @cpf ";
                    command.Parameters.Add("@cpf", SqlDbType.Char).Value = cpf;
                }

                if (apartamento != -1)
                {
                    command.CommandText += "and apartamento = @apartamento ";
                    command.Parameters.Add("@apartamento", SqlDbType.Int).Value = apartamento;
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
                        morador.Rg = new Rg(reader[2].ToString());
                        morador.Cpf = new Cpf(reader[3].ToString());

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
