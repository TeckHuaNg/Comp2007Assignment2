using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Assignment2.Models;

namespace Assignment2.Controllers
{
    [Produces("application/json")]
    [Route("api/Shoes")]
    public class ShoesController : Controller
    {
        private readonly ShoeStoreModel _context;

        public ShoesController(ShoeStoreModel context)
        {
            _context = context;
        }

        // GET: api/Shoes
        [HttpGet]
        public IEnumerable<Shoe> GetShoes()
        {
            return _context.Shoes;
        }

        // GET: api/Shoes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetShoe([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var shoe = await _context.Shoes.SingleOrDefaultAsync(m => m.ProductId == id);

            if (shoe == null)
            {
                return NotFound();
            }

            return Ok(shoe);
        }

        // PUT: api/Shoes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShoe([FromRoute] int id, [FromBody] Shoe shoe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != shoe.ProductId)
            {
                return BadRequest();
            }

            _context.Entry(shoe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShoeExists(id))
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

        // POST: api/Shoes
        [HttpPost]
        public async Task<IActionResult> PostShoe([FromBody] Shoe shoe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Shoes.Add(shoe);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShoe", new { id = shoe.ProductId }, shoe);
        }

        // DELETE: api/Shoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShoe([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var shoe = await _context.Shoes.SingleOrDefaultAsync(m => m.ProductId == id);
            if (shoe == null)
            {
                return NotFound();
            }

            _context.Shoes.Remove(shoe);
            await _context.SaveChangesAsync();

            return Ok(shoe);
        }

        private bool ShoeExists(int id)
        {
            return _context.Shoes.Any(e => e.ProductId == id);
        }
    }
}