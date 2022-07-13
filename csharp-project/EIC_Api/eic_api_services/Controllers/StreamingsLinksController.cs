using eic_api_services.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace eic_api_services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StreamingsLinksController : ControllerBase
    {
        private readonly EICContexto _context;

        public StreamingsLinksController(EICContexto context)
        {
            _context = context;
        }

        [HttpGet("ServiceId")]
        public List<Playlists_Plataforma> GetStreamingInfo(int idCulto) =>
            ConsultarStreamingInfo(idCulto);

        private List<Playlists_Plataforma> ConsultarStreamingInfo(int idCulto)
        {
            return  _context.Playlists_Plataforma
                .Where(pp => pp.Servico.Id == idCulto)
                .ToList();
        }

    }
}
