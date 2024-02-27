using AutoMapper;
using AutoMapper.QueryableExtensions;
using IntroduccionAEfCore2.DTOs;
using IntroduccionAEfCore2.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IntroduccionAEfCore2.Controllers
{
    [ApiController]
    [Route("api/actores")]
    public class ActoresController :ControllerBase
    {
        ApplicationDbContext _context;
        IMapper _mapper;
        public ActoresController(ApplicationDbContext context, IMapper mapper) 
        { 
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Actor>>> Get()
        {
            return await _context.Actores.OrderByDescending(a=> a.FechaNacimiento).ToListAsync();
        }

        [HttpGet("nombre")]
        public async Task<ActionResult<IEnumerable<Actor>>> Get(string nombre)
        {
            //Versión 1
            return await _context.Actores
                .Where(a => a.Nombre == nombre)
                .OrderBy(a => a.Nombre)
                    .ThenBy(a=> a.FechaNacimiento)
                .ToListAsync();
        }

        [HttpGet("nombre/v2")]
        public async Task<ActionResult<IEnumerable<Actor>>> GetV2(string nombre)
        {
            return await _context.Actores.Where(a=>a.Nombre.Contains(nombre)).ToListAsync();
        }

        [HttpGet("fechaNacimiento/rango")]
        public async Task<ActionResult<IEnumerable<Actor>>> GetFecha(DateTime inicio, DateTime fin)
        {
            //Versión 1
            return await _context.Actores
                .Where(a => a.FechaNacimiento >= inicio && a.FechaNacimiento <= fin)
                .ToListAsync();
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Actor>> GetFirst(int id)
        {
            var actor = await _context.Actores.FirstOrDefaultAsync(a => a.Id == id);

            if(actor == null)
            {
                return NotFound();
            }
            return actor;
        }

        [HttpGet("idynombre")]
        public async Task<ActionResult<IEnumerable<ActorDTO>>> Getidynombre()
        {
            return await _context.Actores
                .ProjectTo<ActorDTO>(_mapper.ConfigurationProvider)
                .ToListAsync();           
        }

        [HttpPost]
        public async Task<ActionResult> Post(ActorCreacionDTO actorCreacion)
        {
            var actor = _mapper.Map<Actor>(actorCreacion);
            _context.Add(actor);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
