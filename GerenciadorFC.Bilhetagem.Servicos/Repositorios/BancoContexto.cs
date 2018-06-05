using Microsoft.EntityFrameworkCore;
using GerenciadorFC.Bilhetagem.Domino.Implementacao;


namespace GerenciadorFC.Bilhetagem.Servicos.Repositorios
{
    public class BancoContexto : DbContext
	{
		public DbSet<HistoricoDeProcesso> HistoricoDeProcessos { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=tcp:gerenciadorbilhetagem.database.windows.net,1433;Initial Catalog=dbBilhetagem; Uid=fabioesimoes; Pwd=q1w2e3r4@;");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<HistoricoDeProcesso>().HasKey(h => h.Codigo);
			modelBuilder.Entity<HistoricoDeProcesso>().Property(h => h.TipoProcesso).IsRequired();
			modelBuilder.Entity<HistoricoDeProcesso>().Property(h => h.DataProcesso).IsRequired();
			modelBuilder.Entity<HistoricoDeProcesso>().Property(h => h.Descricao).HasMaxLength(500).IsRequired();
			modelBuilder.Entity<HistoricoDeProcesso>().Property(h => h.Documento).HasMaxLength(20).IsRequired();
			modelBuilder.Entity<HistoricoDeProcesso>().Property(h => h.NumeroProcesso).HasMaxLength(30).IsRequired();
			modelBuilder.Entity<HistoricoDeProcesso>().Property(h => h.Sistema).IsRequired();
			modelBuilder.Entity<HistoricoDeProcesso>().Property(h => h.Status).IsRequired();
			modelBuilder.Entity<HistoricoDeProcesso>().Property(h => h.ValorHistorico).HasMaxLength(30).IsRequired();
			modelBuilder.Entity<HistoricoDeProcesso>().Property(h => h.VerificacaoProcesso).HasMaxLength(30).IsRequired();
			modelBuilder.Entity<HistoricoDeProcesso>().Property(h => h.Arquivo).HasMaxLength(200);
		}
	}
}
