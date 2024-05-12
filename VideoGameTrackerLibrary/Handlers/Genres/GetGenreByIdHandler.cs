using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameTrackerLibrary.Models;
using VideoGameTrackerLibrary.Queries.Genres;
using VideoGameTrackerLibrary.Repositories.Interfaces;

namespace VideoGameTrackerLibrary.Handlers.Genres
{
    public class GetGenreByIdHandler : IRequestHandler<GetGenreByIdQuery, GenresModel>
    {
        private readonly IMobyGamesRepository _mobyGamesRepository;

        public GetGenreByIdHandler(IMobyGamesRepository mobyGamesRepository)
        {
            _mobyGamesRepository = mobyGamesRepository;
        }

        public Task<GenresModel> Handle(GetGenreByIdQuery request, CancellationToken cancellationToken)
        {
            return _mobyGamesRepository.GetGenreById(request.GenreId);
        }
    }
}
