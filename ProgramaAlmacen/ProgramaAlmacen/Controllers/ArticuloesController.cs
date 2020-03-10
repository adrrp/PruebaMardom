using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProgramaAlmacen.Models;

namespace ProgramaAlmacen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticuloesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ArticuloesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Articuloes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Articulo>>> GetArticulo()
        {
            return await _context.Articulo.ToListAsync();
        }

        // GET: api/Articuloes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Articulo>> GetArticulo(int id)
        {
            var articulo = await _context.Articulo.FindAsync(id);

            if (articulo == null)
            {
                return NotFound();
            }

            return articulo;
        }

        // PUT: api/Articuloes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArticulo(int id, Articulo articulo)
        {
            if (id != articulo.ID)
            {
                return BadRequest();
            }

            _context.Entry(articulo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArticuloExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Articuloes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Articulo>> PostArticulo(Articulo articulo)
        {
            _context.Articulo.Add(articulo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArticulo", new { id = articulo.ID }, articulo);
        }

        // DELETE: api/Articuloes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Articulo>> DeleteArticulo(int id)
        {
            var articulo = await _context.Articulo.FindAsync(id);
            if (articulo == null)
            {
                return NotFound();
            }

            _context.Articulo.Remove(articulo);
            await _context.SaveChangesAsync();

            return articulo;
        }

        private bool ArticuloExists(int id)
        {
            return _context.Articulo.Any(e => e.ID == id);
        }
    }
}
