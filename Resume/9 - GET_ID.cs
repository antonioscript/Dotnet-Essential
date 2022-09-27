using Microsoft.AspNetCore.Mvc;

namespace GETID.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly DataContext _context;

        public CharacterController(DataContext context)
        {
            _context = context;
        }

        //1º Forma | Simples
        [HttpGet("{id}")]
        public async Task<IActionResult> GetId(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);

            if (team == null)
                return BadRequest("Invalid Id");

            return Ok(team);
        }

        //2º Forma | Simples
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetId(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
                return BadRequest("User not found.");
            return Ok(user);
        }

        //3º Forma | Simples
        public User GetId(int id)
        {
            return _context.Users.Where(u => u.Id == id).FirstOrDefault();
        }

        //4º Forma | Complexa
        [HttpGet]
        public async Task<ActionResult<List<User>>> Get(int id)
        {
            var characters = await _context.Users
                .Where(c => c.id == id)
                .Include(c => c.Weapon)
                .Include(c => c.Skills)
                .ToListAsync();

            return characters;
        }

    }
}