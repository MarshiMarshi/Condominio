using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DS_Condominio.Repository
{
    public class MoradorRepository : RepositoryBase
    {
        public MoradorRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}
