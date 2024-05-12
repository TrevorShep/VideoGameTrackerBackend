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
    public class GetGenresHandler : IRequestHandler<GetGenresQuery, GenresModelContainer>
    {
        private readonly IMobyGamesRepository _mobyGamesRepository;

        public GetGenresHandler(IMobyGamesRepository mobyGamesRepository)
        {
            _mobyGamesRepository = mobyGamesRepository;
        }

        public Task<GenresModelContainer> Handle(GetGenresQuery request, CancellationToken cancellationToken)
        {
            return _mobyGamesRepository.GetGenres();
        }
    }
}
