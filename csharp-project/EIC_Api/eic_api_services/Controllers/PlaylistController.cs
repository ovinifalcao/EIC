using eic_api_services.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eic_api_services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaylistController : ControllerBase
    {
        private readonly EICContexto _context;

        public PlaylistController(EICContexto context)
        {
            _context = context;
        }

        [HttpGet("ServiceId")]
        public async Task<List<Playlists_Info>> GetPlaylists(int idCulto) => 
            await ConsultarPlaylist(idCulto);

        private async Task<List<Playlists_Info>> ConsultarPlaylist(int idCulto)
        {
            return await _context.Playlists_Info
                .Include(pl => pl.Musica)
                .Where(pl => pl.Servico.Id == idCulto)
                .ToListAsync();
        }
    }
}
