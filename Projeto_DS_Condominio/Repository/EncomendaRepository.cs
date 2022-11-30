using Projeto_DS_Condominio.Enums;
using Projeto_DS_Condominio.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DS_Condominio.Repository
{
    public class EncomendaRepository : RepositoryBase, IEncomendaRepository
    {
        public EncomendaRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Adicionar(Encomenda encomenda)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Editar(Encomenda encomenda)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Encomenda> GetAll()
        {
            List<Encomenda> encomendaList = new List<Encomenda>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select id_encomenda, status_encomenda, local_Armazem, dt_entrega, dt_chegada, id_morador, nome_morador, rg_morador, cpf_morador, bloco_morador, apartamento from Encomenda as e inner join Morador as m on e.id_destinatario = m.id_morador order by bloco_morador, apartamento desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Encomenda encomenda = new Encomenda();
                        encomenda.Id = (int)reader[0];

                        StatusEncomendaEnum statusEncomenda;
                        Enum.TryParse<StatusEncomendaEnum>(reader[1].ToString(), out statusEncomenda);
                        encomenda.Status = statusEncomenda;

                        LocalArmazenamentoEnum localArmazenamento;
                        Enum.TryParse<LocalArmazenamentoEnum>(reader[2].ToString(), out localArmazenamento);
                        encomenda.Armazenamento = localArmazenamento;

                        encomenda.DataEntrega = (DateTime)reader[3];
                        encomenda.DataChegada = (DateTime)reader[4];

                        Morador morador = new Morador();
                        morador.Id = (int)reader[5];
                        morador.Nome = reader[6].ToString();
                        morador.Rg = new Rg(reader[7].ToString());
                        morador.Cpf = new Cpf(reader[8].ToString());

                        BlocoEnum bloco;
                        Enum.TryParse<BlocoEnum>(reader[9].ToString(), out bloco);
                        morador.Bloco = bloco;

                        morador.Apartamento = Int32.Parse(reader[10].ToString());

                        encomenda.Destinatario = morador;
                        encomendaList.Add(encomenda);
                    }
                }
            }
            return encomendaList;
        }
    }
}
