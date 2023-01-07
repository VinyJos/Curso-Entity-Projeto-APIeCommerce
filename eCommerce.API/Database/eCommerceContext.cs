using Microsoft.EntityFrameworkCore;

namespace eCommerce.API.Database
{
    public class eCommerceContext : DbContext
    {
        #region Conexão com o banco, sem distinção de ambientes de execução
        // Conexão com o banco, sem distinção de ambientes de execução
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //qual banco de dados vai ser utilizado
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=eCommerce;Integrated Security=True");

        }
        #endregion

        //Conexão com o banco, usando ambientes de desenvolvimento

    }
}
