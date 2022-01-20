using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PropertyManagementSystem.Common.Models;
using PropertyManagementSystem.Data;

namespace PropertyManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NonStudentLesseesController : ControllerBase
    {
        private readonly PropertyManagementSystemContext _context;

        public NonStudentLesseesController(PropertyManagementSystemContext context)
        {
            _context = context;
        }

        // GET: api/NonStudentLessees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NonStudentLessee>>> GetNonStudentLessee()
        {
            return await _context.NonStudentLessee.ToListAsync();
        }

        // GET: api/NonStudentLessees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NonStudentLessee>> GetNonStudentLessee(int id)
        {
            var nonStudentLessee = await _context.NonStudentLessee.FindAsync(id);

            if (nonStudentLessee == null)
            {
                return NotFound();
            }

            return nonStudentLessee;
        }

        // PUT: api/NonStudentLessees/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNonStudentLessee(int id, NonStudentLessee nonStudentLessee)
        {
            if (id != nonStudentLessee.Id)
            {
                return BadRequest();
            }

            _context.Entry(nonStudentLessee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NonStudentLesseeExists(id))
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

        // POST: api/NonStudentLessees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<NonStudentLessee>> PostNonStudentLessee(NonStudentLessee nonStudentLessee)
        {
            _context.NonStudentLessee.Add(nonStudentLessee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNonStudentLessee", new { id = nonStudentLessee.Id }, nonStudentLessee);
        }

        // DELETE: api/NonStudentLessees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNonStudentLessee(int id)
        {
            var nonStudentLessee = await _context.NonStudentLessee.FindAsync(id);
            if (nonStudentLessee == null)
            {
                return NotFound();
            }

            _context.NonStudentLessee.Remove(nonStudentLessee);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NonStudentLesseeExists(int id)
        {
            return _context.NonStudentLessee.Any(e => e.Id == id);
        }
    }
}
