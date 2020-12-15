using Loja_Cet_49.Dados.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Loja_Cet_49.Dados
{
    public class DataContext : DbContext
    {

        public DbSet<Produto> Produtos { get; set; } /* cria a tabela dos produtos - Nota: é generico para todas as tabelas*/


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
