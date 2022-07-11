using Microsoft.EntityFrameworkCore;

namespace eic_api_services.Models
{
    public class EICContexto : DbContext
    {
        public EICContexto(DbContextOptions<EICContexto> options) : base(options)
        {
        }

        public DbSet<Escalas> Escalas { get; set; }
        public DbSet<Funcoes> Funcoes { get; set; }
        public DbSet<Ministerios> Ministerios { get; set; }
        public DbSet<Ministros> Ministros { get; set; }
        public DbSet<Platformas> Platformas { get; set; }
        public DbSet<Servicos> Servicos { get; set; }
        public DbSet<Musicas> Musicas { get; set; }
        public DbSet<Playlists_Info> Playlists_Info { get; set; }
        public DbSet<Playlists_Plataforma> Playlists_Plataforma { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ministerios>().HasData(
                new Ministerios() { Descricao = "Louvor", Id=1 },
                new Ministerios() { Descricao = "Mídias", Id = 2 },
                new Ministerios() { Descricao = "Sonoplastia", Id = 3 }
                );

            modelBuilder.Entity<Platformas>().HasData(
                new Platformas() { Descricao = "Spotify", Id = 1 },
                new Platformas() { Descricao = "Youtube", Id = 2 },
                new Platformas() { Descricao = "Deezer", Id = 3 }
                );

            modelBuilder.Entity<Funcoes>().HasData(
                new { Descricao = "Voz", Id = 1, MinisterioId = 1},
                new { Descricao = "Violão", Id = 2, MinisterioId = 1 },
                new { Descricao = "Guitarra", Id = 3, MinisterioId = 1 },
                new { Descricao = "Bateria", Id = 4, MinisterioId = 1 },
                new { Descricao = "Baixo", Id = 5, MinisterioId = 1 },
                new { Descricao = "Teclado", Id = 6, MinisterioId = 1 },
                new { Descricao = "Cajon", Id = 7, MinisterioId = 1 },
                new { Descricao = "Fotografia", Id = 8, MinisterioId = 2 },
                new { Descricao = "Projeção", Id = 9, MinisterioId = 2 },
                new { Descricao = "Transmicao", Id = 10, MinisterioId = 2 }
                );
        }
    }
}
