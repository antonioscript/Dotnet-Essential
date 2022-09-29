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
        [HttpPut]
        public async Task<ActionResult<List<uSER>>> Update(User request)
        {
            var dbUser = await _context.Users.FindAsync(request.Id);
            if (dbUser == null)
                return BadRequest("User not found.");

            dbUser.Name = request.Name;
            dbUser.FirstName = request.FirstName;
            dbUser.LastName = request.LastName;
            dbUser.Place = request.Place;

            await _context.SaveChangesAsync();

            return Ok(await _context.Users.ToListAsync());
        }

        //2º Forma
        

    }
}