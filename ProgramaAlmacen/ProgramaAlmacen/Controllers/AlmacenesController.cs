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
 
    public class AlmacenesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AlmacenesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Almacenes
        [HttpGet]
        public IEnumerable<Almacenes> GetAlmacenes()
        {
            return new List<Almacenes>()
            {
                new Almacenes() { ID=1 ,Nombre="Almacenes FF", Descripcion="somos un almacen", Correo_electronico="sdhcjkdshnc", Telefono="46464", Ubicacion="Maria de arana", Capacidad_articulos=45, Proveedores="Bon" },
                new Almacenes() {ID=2,Nombre="Almacenes guanao", Descripcion="somos dos almacen", Correo_electronico="sdhcjkdshnc", Telefono="6546", Ubicacion="Ensanche la fe", Capacidad_articulos=45, Proveedores="Bon" }
            };
            //return _context.Almacenes();
        }

        // GET: api/Almacenes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Almacenes>> GetAlmacenes(int id)
        {
            var almacenes = await _context.Almacenes.FindAsync(id);

            if (almacenes == null)
            {
                return NotFound();
            }

            return almacenes;
        }

        // PUT: api/Almacenes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlmacenes(int id, Almacenes almacenes)
        {
            if (id != almacenes.ID)
            {
                return BadRequest();
            }

            _context.Entry(almacenes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlmacenesExists(id))
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

        // POST: api/Almacenes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Almacenes>> PostAlmacenes(Almacenes almacenes)
        {
            _context.Almacenes.Add(almacenes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlmacenes", new { id = almacenes.ID }, almacenes);
        }

        // DELETE: api/Almacenes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Almacenes>> DeleteAlmacenes(int id)
        {
            var almacenes = await _context.Almacenes.FindAsync(id);
            if (almacenes == null)
            {
                return NotFound();
            }

            _context.Almacenes.Remove(almacenes);
            await _context.SaveChangesAsync();

            return almacenes;
        }

        private bool AlmacenesExists(int id)
        {
            return _context.Almacenes.Any(e => e.ID == id);
        }
    }
}
