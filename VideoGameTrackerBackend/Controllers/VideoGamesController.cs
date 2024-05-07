using MediatR;
using Microsoft.AspNetCore.Mvc;
using VideoGameTrackerDemoLibrary.Commands.Create;
using VideoGameTrackerDemoLibrary.Commands.Delete;
using VideoGameTrackerDemoLibrary.Models;
using VideoGameTrackerDemoLibrary.Queries;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VideoGameTrackerBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGamesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VideoGamesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<VideoGamesController>
        [HttpGet]
        public async Task<List<VideoGameModel>> GetVideoGame()
        {
            return await _mediator.Send(new GetAllVideoGamesQuery());
        }

        // GET api/<VideoGamesController>/5
        [HttpGet("{id}")]
        public async Task<VideoGameModel> GetVideoGameById(int id)
        {
            return await _mediator.Send(new GetVideoGameByIdQuery(id));
        }

        // POST api/<VideoGamesController>
        [HttpPost]
        public async Task<VideoGameModel> Post([FromBody] VideoGameModel value)
        {
            return await _mediator.Send(new InsertVideoGameCommand(value.Name, value.Description, value.ReleaseDate));
        }

        // PUT api/<VideoGamesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VideoGamesController>/5
        [HttpDelete("{id}")]
        public async Task<string> Delete(int id)
        {
            return await _mediator.Send(new DeleteVideoGameCommand(id));
        }
    }
}
