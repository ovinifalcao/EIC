using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using eic_api_services.Models;
using System;

namespace eic_api_services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EscalasLouvorController : ControllerBase
    {
        private readonly EICContexto _context;

        public EscalasLouvorController(EICContexto context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<List<Escalas>> GetEscalas()
        {
            var DataCorte = DateTime.Now.AddDays(-1);
            var idDoMinsLouvor = 1;

            var todasPlaylists = await _context.Escalas
                .Include(svc => svc.Ministro)
                .Include(svc => svc.Funcao)
                .Include(svc => svc.Servico)
                .Where(
                    svc => svc.Servico.Data >= DataCorte
                    && svc.Funcao.Ministerio.Id == idDoMinsLouvor
                 )
                .OrderBy(svc => svc.Servico.Data)
                .ToListAsync();

            return todasPlaylists;
        }


    }
}
