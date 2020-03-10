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
    public class Articulo_ProveedoresController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Articulo_ProveedoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Articulo_Proveedores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Articulo_Proveedores>>> GetArticulo_Proveedores()
        {
            return await _context.Articulo_Proveedores.ToListAsync();
        }

        // GET: api/Articulo_Proveedores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Articulo_Proveedores>> GetArticulo_Proveedores(int id)
        {
            var articulo_Proveedores = await _context.Articulo_Proveedores.FindAsync(id);

            if (articulo_Proveedores == null)
            {
                return NotFound();
            }

            return articulo_Proveedores;
        }

        // PUT: api/Articulo_Proveedores/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArticulo_Proveedores(int id, Articulo_Proveedores articulo_Proveedores)
        {
            if (id != articulo_Proveedores.ID)
            {
                return BadRequest();
            }

            _context.Entry(articulo_Proveedores).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Articulo_ProveedoresExists(id))
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

        // POST: api/Articulo_Proveedores
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Articulo_Proveedores>> PostArticulo_Proveedores(Articulo_Proveedores articulo_Proveedores)
        {
            _context.Articulo_Proveedores.Add(articulo_Proveedores);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArticulo_Proveedores", new { id = articulo_Proveedores.ID }, articulo_Proveedores);
        }

        // DELETE: api/Articulo_Proveedores/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Articulo_Proveedores>> DeleteArticulo_Proveedores(int id)
        {
            var articulo_Proveedores = await _context.Articulo_Proveedores.FindAsync(id);
            if (articulo_Proveedores == null)
            {
                return NotFound();
            }

            _context.Articulo_Proveedores.Remove(articulo_Proveedores);
            await _context.SaveChangesAsync();

            return articulo_Proveedores;
        }

        private bool Articulo_ProveedoresExists(int id)
        {
            return _context.Articulo_Proveedores.Any(e => e.ID == id);
        }
    }
}
