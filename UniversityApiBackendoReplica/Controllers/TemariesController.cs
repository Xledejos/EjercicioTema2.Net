using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversityApiBackendoReplica.DataAccess;
using UniversityApiBackendoReplica.Models.DataModels;

namespace UniversityApiBackendoReplica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemariesController : ControllerBase
    {
        private readonly UniversityDbContext _context;

        public TemariesController(UniversityDbContext context)
        {
            _context = context;
        }

        // GET: api/Temaries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Temary>>> GetTemarys()
        {
            return await _context.Temarys.ToListAsync();
        }

        // GET: api/Temaries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Temary>> GetTemary(int id)
        {
            var temary = await _context.Temarys.FindAsync(id);

            if (temary == null)
            {
                return NotFound();
            }

            return temary;
        }

        // PUT: api/Temaries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTemary(int id, Temary temary)
        {
            if (id != temary.Id)
            {
                return BadRequest();
            }

            _context.Entry(temary).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TemaryExists(id))
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

        // POST: api/Temaries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Temary>> PostTemary(Temary temary)
        {
            _context.Temarys.Add(temary);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTemary", new { id = temary.Id }, temary);
        }

        // DELETE: api/Temaries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTemary(int id)
        {
            var temary = await _context.Temarys.FindAsync(id);
            if (temary == null)
            {
                return NotFound();
            }

            _context.Temarys.Remove(temary);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TemaryExists(int id)
        {
            return _context.Temarys.Any(e => e.Id == id);
        }
    }
}
