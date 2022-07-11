using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eic_api_services.Models
{
    public class Playlists
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Platformas Plataforma { get; set; }
        public Streamings Streaming { get; set; }
        public string Link { get; set; }
    }
}
