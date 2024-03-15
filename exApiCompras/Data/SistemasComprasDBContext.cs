using exApiCompras.Data.Map;
using exApiCompras.Models;
using Microsoft.EntityFrameworkCore;

namespace exApiCompras.Data
{
    public class SistemasComprasDBContext : DbContext
    {
        public SistemasComprasDBContext(DbContextOptions<SistemasComprasDBContext> options) : base(options) { }
        public DbSet<UsuarioModels> Usuarios { get; set; }
        public DbSet<PedidoModels> Pedidos { get; set; }
        public DbSet<CategoriaModels> Categorias { get; set; }
        public DbSet<ProdutoModels> Produtos { get; set; }
        public DbSet<PedidosProdutosModels> PedidosProdutos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new PedidosProdutosMap());
            modelBuilder.ApplyConfiguration(new PedidoMap());
            modelBuilder.ApplyConfiguration(new CategoriaMap());


            base.OnModelCreating(modelBuilder);
        }
    }
}
