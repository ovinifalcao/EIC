using eic_api_services.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eic_api_services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EscalasMidiasController : ControllerBase
    {
        private readonly EICContexto _context;

        public EscalasMidiasController(EICContexto context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<List<Models.API.Midias>> GetEscalas(DateTime DataCorte)
        {

            var Servicos = await _context.Servicos
                .Where(s => s.Data >= DataCorte.AddDays(-1))
                .ToListAsync();

            var escalas = await _context.Escalas
                .Include(e => e.Funcao)
                .Include(e => e.Ministro)
                .Include(e => e.Servico)
                .Where(e => e.Servico.Data  >= DataCorte.AddDays(-1) 
                    && e.Funcao.Ministerio.Id == 2)
                .ToListAsync();

            var EscalaMidias = new List<Models.API.Midias>();


            Servicos.ForEach(sc =>
                EscalaMidias.Add(new Models.API.Midias()
                {
                    Servico = sc,
                    Formacao = escalas.Where(e => e.Servico.Id == sc.Id).ToList()
                })
            );

            return EscalaMidias;
        }

    }
}
