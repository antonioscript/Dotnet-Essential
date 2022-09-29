using Microsoft.AspNetCore.Mvc;

namespace UPDATE.Controllers
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
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<User>>> Delete(int id)
        {
            var dbUser = await _context.Users.FindAsync(id);
            if (dbUser == null)
                return BadRequest("User not found.");

            _context.Users.Remove(dbUser);
            await _context.SaveChangesAsync();

            return Ok(await _context.Users.ToListAsync());
        }
        //2º Forma
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var dbUser = Users.FirstOrDefault(u => u.Id == id);
            
            if (dbUser == null)
                return BadRequest("User not found.");

            _context.Users.Remove(dbUser);

            return NoContent();
        }

    }
}