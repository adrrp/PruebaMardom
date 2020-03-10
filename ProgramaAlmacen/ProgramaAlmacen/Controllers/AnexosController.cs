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
    public class AnexosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AnexosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Anexos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Anexos>>> GetAnexos()
        {
            return await _context.Anexos.ToListAsync();
        }

        // GET: api/Anexos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Anexos>> GetAnexos(int id)
        {
            var anexos = await _context.Anexos.FindAsync(id);

            if (anexos == null)
            {
                return NotFound();
            }

            return anexos;
        }

        // PUT: api/Anexos/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnexos(int id, Anexos anexos)
        {
            if (id != anexos.ID)
            {
                return BadRequest();
            }

            _context.Entry(anexos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnexosExists(id))
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

        // POST: api/Anexos
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Anexos>> PostAnexos(Anexos anexos)
        {
            _context.Anexos.Add(anexos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAnexos", new { id = anexos.ID }, anexos);
        }

        // DELETE: api/Anexos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Anexos>> DeleteAnexos(int id)
        {
            var anexos = await _context.Anexos.FindAsync(id);
            if (anexos == null)
            {
                return NotFound();
            }

            _context.Anexos.Remove(anexos);
            await _context.SaveChangesAsync();

            return anexos;
        }

        private bool AnexosExists(int id)
        {
            return _context.Anexos.Any(e => e.ID == id);
        }
    }
}
