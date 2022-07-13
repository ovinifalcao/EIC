using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eic_api_services.Models
{
    public class Playlists_Info
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Servicos Servico { get; set; }
        public Musicas Musica { get; set; }
        public string Tom { get; set; }
        public string VSLink { get; set; }
        public string CrifraLink { get; set; }
        public string VozesLink { get; set; }
        public string LetraLink { get; set; }
        public string Observacoes { get; set; }
    }
}
