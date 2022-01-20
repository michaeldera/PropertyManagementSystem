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
    public class PropertyTypesController : ControllerBase
    {
        private readonly PropertyManagementSystemContext _context;

        public PropertyTypesController(PropertyManagementSystemContext context)
        {
            _context = context;
        }

        // GET: api/PropertyTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PropertyType>>> GetPropertyType()
        {
            return await _context.PropertyType.ToListAsync();
        }

        // GET: api/PropertyTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PropertyType>> GetPropertyType(int id)
        {
            var propertyType = await _context.PropertyType.FindAsync(id);

            if (propertyType == null)
            {
                return NotFound();
            }

            return propertyType;
        }

        // PUT: api/PropertyTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPropertyType(int id, PropertyType propertyType)
        {
            if (id != propertyType.Id)
            {
                return BadRequest();
            }

            _context.Entry(propertyType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PropertyTypeExists(id))
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

        // POST: api/PropertyTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PropertyType>> PostPropertyType(PropertyType propertyType)
        {
            _context.PropertyType.Add(propertyType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPropertyType", new { id = propertyType.Id }, propertyType);
        }

        // DELETE: api/PropertyTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePropertyType(int id)
        {
            var propertyType = await _context.PropertyType.FindAsync(id);
            if (propertyType == null)
            {
                return NotFound();
            }

            _context.PropertyType.Remove(propertyType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PropertyTypeExists(int id)
        {
            return _context.PropertyType.Any(e => e.Id == id);
        }
    }
}
