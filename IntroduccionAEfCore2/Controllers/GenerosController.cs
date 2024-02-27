using AutoMapper;
using IntroduccionAEfCore2.DTOs;
using IntroduccionAEfCore2.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IntroduccionAEfCore2.Controllers
{
    [ApiController]
    [Route("api/generos")]
    public class GenerosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GenerosController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Genero>>> Get()
        {
            return await _context.Generos.ToListAsync();
        }


        [HttpPost]
        public async Task<ActionResult> Post(GeneroCreacionDTO generoCreacion)
        {

            var yaExisteGeneroConNombre = await _context.Generos.AnyAsync(g => g.Nombre == generoCreacion.Nombre);
            if(yaExisteGeneroConNombre)
            {
                return BadRequest("Ya existe un género con el nombre"+ generoCreacion.Nombre);
            }
            var genero = _mapper.Map<Genero>(generoCreacion);
            _context.Add(genero);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpPost("varios")]
        public async Task<ActionResult> Post(GeneroCreacionDTO[] generosCreacionDTO)
        {
            var generos = _mapper.Map<Genero[]>(generosCreacionDTO);
            _context.AddRange(generos);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpPut("{id:int}/nombre2")]
        public async Task<ActionResult> Put(int id)
        {
            var genero = await _context.Generos.FirstOrDefaultAsync(g => g.Id == id);
            if(genero == null)
            {
                return NotFound();
            }
            genero.Nombre = genero.Nombre + 2;
            await _context.SaveChangesAsync();
            return Ok();
            
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, GeneroCreacionDTO generoCreacionDTO)
        {
            var genero = _mapper.Map<Genero>(generoCreacionDTO);
            genero.Id = id;
            _context.Update(genero);
            await _context.SaveChangesAsync();
            return Ok();
        }
        //[HttpDelete("{id:int}/moderna")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var filasAlteradas = await _context.Generos.Where(g => g.Id == id).ExecuteDeleteAsync();
        //    if(filasAlteradas == 0)
        //    {
        //        return NotFound();
        //    }
        //    return NoContent();
        //}
        [HttpDelete("{id:int}/net6")]
        public async Task<IActionResult> Delete(int id)
        {
            var genero = await _context.Generos.FirstOrDefaultAsync(g => g.Id == id);
            if (genero == null)
            {
                return NotFound();
            }
            _context.Remove(genero);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
