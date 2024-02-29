using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternApi.Models;
using RepositoryPatternApi.Repository.IUnitOfWork;

namespace RepositoryPatternApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWorkRP _unitOfWork;
        public UserController(IUnitOfWorkRP unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetPopularDevelopers([FromQuery] int count)
        {
            var popularDevelopers = _unitOfWork.Developers.GetPopularDevelopers(count);
            return Ok(popularDevelopers);
        }

        [HttpPost]
        public IActionResult AddNewUserAndProject()
        {
            var user = new User
            {
                Followers = 35,
                Name = "Mukesh Murugan"
            };
            var project = new Project
            {
                Name = "codewithmukesh"
            };
            _unitOfWork.Developers.Add(user);
            _unitOfWork.Projects.Add(project);
            _unitOfWork.Complete();
            return Ok();
        }
    }
}
