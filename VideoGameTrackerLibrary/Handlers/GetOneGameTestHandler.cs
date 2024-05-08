using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameTrackerLibrary.Queries;
using VideoGameTrackerLibrary.Repositories.Interfaces;

namespace VideoGameTrackerLibrary.Handlers
{
    public class GetOneGameTestHandler : IRequestHandler<GetOneGameTestQuery, string>
    {
        private readonly IMobyGamesRepository _mobyGamesRepository;

        public GetOneGameTestHandler(IMobyGamesRepository mobyGamesRepository)
        {
            _mobyGamesRepository = mobyGamesRepository;
        }

        public Task<string> Handle(GetOneGameTestQuery request, CancellationToken cancellationToken)
        {
            Task<string> oneGameTest= _mobyGamesRepository.GetOneGameTest();
            return oneGameTest;
        }
    }
}
