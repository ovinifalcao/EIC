using System.Collections.Generic;

namespace eic_api_services.Models.API
{
    public class Louvor
    {
        public Servicos Servico { get; set; }
        public List<Playlists_Info> Playlists_Info { get; set; }
        public List<Playlists_Plataforma> Playlists_Plataformas { get; set; }
        public List<Escalas> Formacao { get; set; }
    }
}
