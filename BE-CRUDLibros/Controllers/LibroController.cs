using BE_CRUDLibros.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BE_CRUDLibros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public LibroController(AplicationDbContext context) { 
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            try {
                Thread.Sleep(1000);
                var lisLibros = await _context.Libro.ToListAsync();
                return Ok(lisLibros);
            }catch(Exception ex)
            { 
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{isbn}")]
        public async Task<IActionResult> Get(int isbn) 
        {
            try 
            {
                var libro = await _context.Libro.FindAsync(isbn);
                if (libro == null) 
                {
                    return NotFound();
                }
                return Ok(libro);
            }catch(Exception ex) 
            { 
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{isbn}")]
        public async Task<IActionResult> Delete(int isbn)
        {
            try
            {
                var libro = await _context.Libro.FindAsync(isbn);
                if(libro == null)
                {
                    return NotFound();
                }

                _context.Libro.Remove(libro);
                await _context.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
