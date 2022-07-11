using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eic_api_services.Models
{
    public class Playlists_Plataforma
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Servicos Servico { get; set; }
        public Platformas Platforma { get; set; }
        public string Link { get; set; }
    }
}
