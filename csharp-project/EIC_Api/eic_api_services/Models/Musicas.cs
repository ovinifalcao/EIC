using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eic_api_services.Models
{
    public class Musicas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public string CoverLink { get; set; }
        public  string ColorBase { get; set; }
    }
}
