using AutoMapper;
using IntroduccionAEfCore2.DTOs;
using IntroduccionAEfCore2.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IntroduccionAEfCore2.Controllers
{
    [ApiController]
    [Route("api/peliculas")]
    public class PeliculasController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public PeliculasController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Pelicula>> Get(int id)
        {
            var pelicula = await context.Peliculas
                .Include(p => p.Comentarios)
                .Include(p => p.Generos)
                .Include(p => p.PeliculasActores.OrderBy(pa => pa.Orden))
                    .ThenInclude(pa => pa.Actor)
                .FirstOrDefaultAsync(p => p.Id == id);
            if(pelicula == null)
            {
                return NotFound();
            }
            return pelicula;
        }
        [HttpGet("select/{id:int}")]
        public async Task<ActionResult> GetSelect(int id)
        {
            var pelicula = await context.Peliculas
             .Select(pel => new
             {
                 pel.Id,
                 pel.Titulo,
                 Generos = pel.Generos.Select(g => g.Nombre).ToList(),
                 Actores = pel.PeliculasActores.OrderBy(pa => pa.Orden).Select(pa =>
                 new {
                     Id = pa.ActorId,
                     pa.Actor.Nombre,
                     pa.Personaje
                 }),
                 CantidadComentarios = pel.Comentarios.Count(),
                 Comentarios = pel.Comentarios.Select(c => c.Contenido).ToList()
             })
                .FirstOrDefaultAsync(p => p.Id == id);
            if (pelicula == null)
            {
                return NotFound();
            }
            return Ok(pelicula);
        }




        [HttpPost]
        public async Task<ActionResult> Post(PeliculaCreacionDTO peliculaCreacion)
        {
            var pelicula = mapper.Map<Pelicula>(peliculaCreacion);
            if(pelicula.Generos is not null)
            {
                foreach(var genero in pelicula.Generos)
                {
                    context.Entry(genero).State = EntityState.Unchanged;
                }
            }
            if(pelicula.PeliculasActores is not null)
            {
                for(int i= 0; i < pelicula.PeliculasActores.Count; i++)
                {
                    pelicula.PeliculasActores[i].Orden = i + 1;
                }
            }
            context.Add(pelicula);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}/net6")]
        public async Task<IActionResult> Delete(int id)
        {
            var genero = await context.Peliculas.FirstOrDefaultAsync(g => g.Id == id);
            if (genero == null)
            {
                return NotFound();
            }
            context.Remove(genero);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
