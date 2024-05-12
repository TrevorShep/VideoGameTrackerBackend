using MediatR;
using Microsoft.AspNetCore.Mvc;
using VideoGameTrackerDemoLibrary.Commands.Create;
using VideoGameTrackerDemoLibrary.Commands.Delete;
using VideoGameTrackerDemoLibrary.Commands.Update;
using VideoGameTrackerDemoLibrary.Models;
using VideoGameTrackerDemoLibrary.Queries;
using VideoGameTrackerLibrary.Models;
using VideoGameTrackerLibrary.Queries;

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
        public async Task<List<VideoGameModel>> GetAllVideoGames()
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
        public async Task<VideoGameModel> PostVideoGame([FromBody] VideoGameModel value)
        {
            return await _mediator.Send(new InsertVideoGameCommand(value.Name, value.Description, value.ReleaseDate));
        }

        // PUT api/<VideoGamesController>/5
        [HttpPut("{id}")]
        public async Task<string> UpdateVideoGame(int id, [FromBody] VideoGameModel value)
        {
            return await _mediator.Send(new UpdateVideoGameCommand(id, value.Name, value.Description, value.ReleaseDate));
        }

        // DELETE api/<VideoGamesController>/5
        [HttpDelete("{id}")]
        public async Task<string> DeleteVideoGame(int id)
        {
            return await _mediator.Send(new DeleteVideoGameCommand(id));
        }
    }
}
