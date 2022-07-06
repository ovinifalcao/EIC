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
        public async Task<List<Models.API.Louvor>> GetEscalas()
        {
            var DataCorte = DateTime.Now;
            var todasPlaylists = await _context.Playlists
                .Include(pl => pl.Plataforma)
                .Include(pl => pl.Streaming)
                .Include(pl => pl.Streaming.Servico)
                .Where(pl => pl.Streaming.Servico.Data >= DataCorte.AddDays(-1))
                .ToListAsync();

            var playlistsPorCultos = todasPlaylists.GroupBy(pl => pl.Streaming.Servico);

            var escalas = await _context.Escalas
                .Include(e => e.Funcao)
                .Include(e => e.Ministro)
                .Include(e => e.Servico)
                .Where(e => e.Servico.Data >= DataCorte.AddDays(-1)
                    && e.Funcao.Ministerio.Id == 1)
                .ToListAsync();

            var EscalaLouvor = new List<Models.API.Louvor>();

            foreach(IGrouping<Servicos, Playlist> pl in playlistsPorCultos)
            {
                EscalaLouvor.Add(new Models.API.Louvor()
                {
                    Servico = pl.Key,
                    Playlist = todasPlaylists.Where(tpl => tpl.Streaming.Servico.Id == pl.Key.Id).ToList(),
                    Formacao = escalas.Where(e => e.Servico.Id == pl.Key.Id).ToList()
                });
            }

            return EscalaLouvor.OrderBy(escala => escala.Servico.Data).ToList();
        }


    }
}
