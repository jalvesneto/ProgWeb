using Microsoft.EntityFrameworkCore;
using ProgWeb.Domain.Entities;

namespace ProgWeb.Domain
{
    public partial class ProgWebContext : DbContext
    {
        public DbSet<AcompanhamentoOrcamentario> AcompanhamentoOrcamentario { get; set; }
        public DbSet<Esfera> Esferas { get; set; }
        public DbSet<Funcao> Funcoes { get; set; }
        public DbSet<Localizacao> Localizacao { get; set; }
        public DbSet<Localizador> Localizadores { get; set; }
        public DbSet<Orgao> Orgaos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoPO> ProdutosPO { get; set; }
        public DbSet<Programa> Programas { get; set; }
        public DbSet<SubFuncao> SubFuncoes { get; set; }
        public DbSet<TipoPrograma> TipoProgramas { get; set; }
        public DbSet<UnidadeMedida> UnidadesMedida { get; set; }
        public DbSet<UnidadeMedidaPO> UnidadesMedidaPO { get; set; }
        public DbSet<UnidadeOrcamentaria> UnidadesOrcamentaria { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                String ConnectionString = Environment.GetEnvironmentVariable("ProgWeb_CONNECTION_STRING");
                optionsBuilder.UseMySql(ConnectionString, ServerVersion.Parse("10.4.22"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
