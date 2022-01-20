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
    public class StudentLesseesController : ControllerBase
    {
        private readonly PropertyManagementSystemContext _context;

        public StudentLesseesController(PropertyManagementSystemContext context)
        {
            _context = context;
        }

        // GET: api/StudentLessees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentLessee>>> GetStudent()
        {
            return await _context.Student.ToListAsync();
        }

        // GET: api/StudentLessees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentLessee>> GetStudentLessee(int id)
        {
            var studentLessee = await _context.Student.FindAsync(id);

            if (studentLessee == null)
            {
                return NotFound();
            }

            return studentLessee;
        }

        // PUT: api/StudentLessees/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudentLessee(int id, StudentLessee studentLessee)
        {
            if (id != studentLessee.Id)
            {
                return BadRequest();
            }

            _context.Entry(studentLessee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentLesseeExists(id))
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

        // POST: api/StudentLessees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StudentLessee>> PostStudentLessee(StudentLessee studentLessee)
        {
            _context.Student.Add(studentLessee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudentLessee", new { id = studentLessee.Id }, studentLessee);
        }

        // DELETE: api/StudentLessees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudentLessee(int id)
        {
            var studentLessee = await _context.Student.FindAsync(id);
            if (studentLessee == null)
            {
                return NotFound();
            }

            _context.Student.Remove(studentLessee);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudentLesseeExists(int id)
        {
            return _context.Student.Any(e => e.Id == id);
        }
    }
}
