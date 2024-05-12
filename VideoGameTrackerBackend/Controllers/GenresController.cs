using MediatR;
using Microsoft.AspNetCore.Mvc;
using VideoGameTrackerLibrary.Models;
using VideoGameTrackerLibrary.Queries.Genres;

namespace VideoGameTrackerBackend.Controllers
{
    [Route("api/genres")]
    [ApiController]
    public class GenresController : Controller
    {
        private readonly IMediator _mediator;

        public GenresController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<GenresModelContainer> GetAllGenres()
        {
            return await _mediator.Send(new GetGenresQuery());
        }

        [HttpGet("{genreId}")]
        public async Task<GenresModel> GetGenreById(int genreId)
        {
            return await _mediator.Send(new GetGenreByIdQuery(genreId));
        }
    }
}
