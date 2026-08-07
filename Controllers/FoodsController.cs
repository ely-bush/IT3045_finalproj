using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IT3045_finalproj.Models;
using IT3045_finalproj.Data;

namespace IT3045_finalproj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FoodController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id?}")]
        public async Task<ActionResult<IEnumerable<Food>>> GetFoods(int? id)
        {
            if (id == null || id == 0)
                return await _context.Foods.Take(5).ToListAsync();

            var food = await _context.Foods.FindAsync(id);
            if (food == null)
                return NotFound();

            return new List<Food> { food };
        }

        [HttpPost]
        public async Task<ActionResult<Food>> PostFood(Food food)
        {
            _context.Foods.Add(food);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetFoods), new { id = food.FoodId }, food);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutFood(int id, Food food)
        {
            if (id != food.FoodId)
                return BadRequest();

            _context.Entry(food).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Foods.Any(e => e.FoodId == id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFood(int id)
        {
            var food = await _context.Foods.FindAsync(id);
            if (food == null)
                return NotFound();

            _context.Foods.Remove(food);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}