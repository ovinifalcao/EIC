using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eic_api_services.Models
{
    public class Escalas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Servicos Servico { get; set; }
        public Funcoes Funcao { get; set; }
        public Ministros Ministro { get; set; }
    }
}
