using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProject_IT212.Data;
using FinalProject_IT212.Models;

namespace FinalProject_IT212.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuantitiesController : ControllerBase
    {
        private readonly FinalProject_IT212Context _context;

        public QuantitiesController(FinalProject_IT212Context context)
        {
            _context = context;
        }

        // GET: api/Quantities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Quantity>>> GetQuantity()
        {
            return await _context.Quantity.ToListAsync();
        }

        // GET: api/Quantities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Quantity>> GetQuantity(int id)
        {
            var quantity = await _context.Quantity.FindAsync(id);

            if (quantity == null)
            {
                return NotFound();
            }

            return quantity;
        }

        // PUT: api/Quantities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuantity(int id, Quantity quantity)
        {
            if (id != quantity.QuantityId)
            {
                return BadRequest();
            }

            _context.Entry(quantity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuantityExists(id))
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

        // POST: api/Quantities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Quantity>> PostQuantity(Quantity quantity)
        {
            _context.Quantity.Add(quantity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuantity", new { id = quantity.QuantityId }, quantity);
        }

        // DELETE: api/Quantities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuantity(int id)
        {
            var quantity = await _context.Quantity.FindAsync(id);
            if (quantity == null)
            {
                return NotFound();
            }

            _context.Quantity.Remove(quantity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool QuantityExists(int id)
        {
            return _context.Quantity.Any(e => e.QuantityId == id);
        }
    }
}
