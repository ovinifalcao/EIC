using System.Collections.Generic;

namespace eic_api_services.Models.API
{
    public class Louvor
    {
        public Servicos Servico { get; set; }
        //public List<Playlist> Playlist { get; set; }
        public List<Escalas> Formacao { get; set; }
    }
}
