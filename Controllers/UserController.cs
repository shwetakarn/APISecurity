using Microsoft.AspNetCore.Mvc;
using APISecurity.UserRepository;
using AutoMapper;
using APISecurity.Models;

namespace APISecurity.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        IUserRepository userRepository;
        IMapper mapper;
        public UserController(IUserRepository us, IMapper map)
        {
            this.mapper = map;
            this.userRepository = us;
        }

        [HttpPost("Create")]
        public ActionResult CreateUser(UserDTO us)
        {
            var usr = mapper.Map<User>(us);
            userRepository.Add(usr);
            return Ok();

        }

        [HttpGet("Fetch")]
        public ActionResult GetUser()
        {
            return Ok(userRepository.GetAll());
        }
    }
}