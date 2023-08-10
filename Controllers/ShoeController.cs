using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project2104.Context;
using Project2104.DataModels;

namespace Project2104.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShoeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ShoeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddShoe([FromBody] Shoe shoe)
        {
            _context.Shoes.Add(shoe);
            await _context.SaveChangesAsync();

            return Ok(shoe);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetShoeById(int id)
        {
            Shoe shoe = await _context.Shoes.FindAsync(id);

            if(shoe == null)
            {
                return NotFound();
            }

            return Ok(shoe);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShoe(int id)
        {
            Shoe shoe = await _context.Shoes.FindAsync(id);

            if (shoe == null)
            {
                return NotFound();
            }

            _context.Shoes.Remove(shoe);
            await _context.SaveChangesAsync();

            return Ok(shoe);
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllShoes()
        {
            List<Shoe> shoes = await _context.Shoes.ToListAsync();

            return Ok(shoes);
        }

        [HttpGet("category/{category}")]
        public async Task<IActionResult> GetShoesByCategory(string category)
        {
            List<Shoe> shoes = await _context.Shoes.Where(s => s.Category.ToLower() == category.ToLower()).ToListAsync();

            return Ok(shoes);
        }

        [HttpGet("search/{searchText}")]
        public async Task<IActionResult> SearchShoes(string searchText)
        {
            List<Shoe> shoes = await _context.Shoes.Where(s => s.Name.ToLower().Contains(searchText.ToLower())).ToListAsync();

            return Ok(shoes);
        }


        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
