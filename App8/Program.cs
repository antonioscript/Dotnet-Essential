using Microsoft.AspNetCore.Mvc;

namespace Get.Controllers
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
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _context.Users.ToListAsync();
            return Ok(teams);
        }

        //2º Forma | Simples
        [HttpGet]
        public async Task<ActionResult<List<User>>> Get()
        {
            return Ok(await _context.Users.ToListAsync());
        }

        //3º Forma | Simples
        public ICollection<Users> Get()
        {
            return _context.Users.OrderBy(u => u.Id).ToList();
        }

        //4º Forma | Complexa
        public async Task<ServiceResponse<List<GetUserDto>>> Get()
        {
            var response = new ServiceResponse<List<GetUserDto>>();
            var dbUsers = await _context.Users
                .Include(c => c.Weapon)
                .Include(c => c.Skills)
                .Where(c => c.User.Id == GetUserId())
                .ToListAsync();
            response.Data = dbUsers.Select(c => _mapper.Map<GetUserDto>(c)).ToList();
            return response;
        }
    }    