using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using eic_api_services.Models;
using System;
using eic_api_services.Models.API;

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
        public async Task<List<Louvor>> GetEscalas()
        {
            var DataCorte = DateTime.Now.AddDays(-1);
            var idDoMinsLouvor = 1;

            return await MontarListaEscalaAsync(await ConsultarEscalas(new DateTime(2022,07,25), idDoMinsLouvor));

        }

        private async Task<List<Escalas>> ConsultarEscalas(DateTime dataCorte, int idMinisterio) => 
            await _context.Escalas
            .Include(svc => svc.Ministro)
            .Include(svc => svc.Funcao)
            .Include(svc => svc.Servico)
            .Where(
                svc => svc.Servico.Data >= dataCorte
                && svc.Funcao.Ministerio.Id == idMinisterio
             )
            .OrderBy(svc => svc.Servico.Data)
            .ToListAsync();

        private List<Playlists_Plataforma> ConsultarPlaylistPlataforma(int idCulto) =>
            _context.Playlists_Plataforma
                .Where(pp => pp.Servico.Id == idCulto)
                .ToList();

        private async Task<List<Playlists_Info>> ConsultarPlaylistInfo(int idCulto) =>
            await _context.Playlists_Info
                .Include(pl => pl.Musica)
                .Where(pl => pl.Servico.Id == idCulto)
                .ToListAsync();

        private async Task<List<Louvor>> MontarListaEscalaAsync(List<Escalas> escalas)
        {
            var cultosDistintos = escalas.Select(e => e.Servico).Distinct().ToList();
            var escalaMontadas = new List<Louvor>();

            foreach (Servicos culto in cultosDistintos)
            {
                escalaMontadas.Add(
                    new Louvor()
                    {
                        Servico = culto,
                        Formacao = escalas.Where(e => e.Servico == culto).ToList(),
                        Playlists_Info = await ConsultarPlaylistInfo(culto.Id),
                        Playlists_Plataformas = ConsultarPlaylistPlataforma(culto.Id)
                    });
            }

            return escalaMontadas;
        }
    }
}
