using Domain.Entities;
using Domain.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ActorsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ActionResult GetAll() {

            var actorsFromRepo = _unitOfWork.Actor.GetAll();
            return Ok(actorsFromRepo);
        
        }

        [HttpGet("movies")]
        public ActionResult GetActorsWithMovies()
        {
            var actorsWithMovies =  _unitOfWork.Actor.GetActorWithMovies();
            return Ok(actorsWithMovies);
        }



    }
}
