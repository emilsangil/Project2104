using Microsoft.AspNetCore.Mvc;
using Project2104.DataModels;
using Project2104.Context;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;

namespace Project2104.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<UserController> _logger;

        public UserController(AppDbContext context, ILogger<UserController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateUser([FromBody] User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Ok(user);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUerById(int id)
        {
            User user = await _context.Users.FindAsync(id);

            if(user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpGet("{id}/favorites")]
        public async Task <IActionResult> GetUserFavorites(int id)
        {
            User user = await _context.Users.Include(u => u.Favorites).FirstOrDefaultAsync(u => u.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            List<Shoe> favorites = user.Favorites;

            return Ok(favorites);
        }

        [HttpPost("{id}/favorites")]
        public async Task<IActionResult> AddShoeToFavorites(int id, [FromBody] Shoe shoe)
        {
            User user = await _context.Users.Include(u => u.Favorites).FirstOrDefaultAsync(u => u.Id == id);

            if(user == null)
            {
                return NotFound();
            }

            if(shoe == null)
            {
                return BadRequest("Shoe data does not exist");
            }

            if(user.Favorites.Contains(shoe))
            {
                return BadRequest("Shoe is already in favorites");
            }

            user.Favorites.Add(shoe);
            await _context.SaveChangesAsync();

            return Ok("Shoe added to favorites");
        }

        [HttpDelete("{id}/favorites/{shoeId}")]
        public async Task<IActionResult> RemoveShoesFromFavorites(int id, int shoeId)
        {
            User user = await _context.Users.Include(u => u.Favorites).FirstOrDefaultAsync(u => u.Id == id);

            if(user == null) {
                return NotFound("User not found");
            }

            Shoe shoeRemove = user.Favorites.FirstOrDefault(shoe => shoe.Id == shoeId);

            if(shoeRemove == null)
            {
                return NotFound("Shoe is not in your favorites");
            }

            user.Favorites.Remove(shoeRemove);
            await _context.SaveChangesAsync();

            return Ok("Shoe removed from favorites");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] login login)
        {
            _logger.LogInformation("Logging in", login.Email, login.Password);
            User user = await _context.Users.FirstOrDefaultAsync(u => u.Email == login.Email);

            if (user == null || !VerifyPasswordHash(login.Password, user.Password))
            {
                return Unauthorized();
            }

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.Id.ToString())
            };

            var keyBytes = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(keyBytes);
            }
            var key = new SymmetricSecurityKey(keyBytes);

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "localhost",
                audience: "localhost",
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds
            );

            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token),
                userId = user.Id
            }) ;

        }

        private bool VerifyPasswordHash(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }


        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
