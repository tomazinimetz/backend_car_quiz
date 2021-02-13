using Application.Service;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CarQuiz.Controllers
{
    [Route("api/quiz")]
    [ApiController]
    public sealed class GetQuizController : ControllerBase
    {
        private readonly IGetService<Quiz> _service;

        public GetQuizController(IGetService<Quiz> service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<Quiz> Get()
        {
            var quiz = _service.Get();

            if (quiz == null)
            {
                return NotFound();
            }

            return quiz;
        }
    }
}
