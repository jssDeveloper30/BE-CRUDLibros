using BE_CRUDLibros.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE_CRUDLibros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        [HttpGet]
        public String Get() 
        {
           return "hola mundo";
        }
    }
}
