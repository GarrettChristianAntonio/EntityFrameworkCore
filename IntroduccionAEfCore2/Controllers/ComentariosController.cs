using AutoMapper;
using IntroduccionAEfCore2.DTOs;
using IntroduccionAEfCore2.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace IntroduccionAEfCore2.Controllers
{
    [ApiController]
    [Route("api/peliculas/{peliculaId:int}/comentarios")]
    public class ComentariosController: ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ComentariosController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult> Post(int peliculaId,ComentarioCreacionDTO comentarioCreacion)
        {
            var comentario = mapper.Map<Comentario>(comentarioCreacion);
            comentario.PeliculaId= peliculaId;
            context.Add(comentario);
            await context.SaveChangesAsync();
            return Ok(comentario);
        }
    }
}
