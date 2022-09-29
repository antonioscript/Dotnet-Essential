using Microsoft.AspNetCore.Mvc;

namespace POST.Controllers
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

        //1º Forma 
        [HttpPost]
        public async Task<ActionResult<List<User>>> Post(UserDTO newUser)
        {
            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();

            return Ok(await _context.Users.ToListAsync());
        }

    }
}