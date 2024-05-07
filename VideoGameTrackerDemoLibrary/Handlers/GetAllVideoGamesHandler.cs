using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameTrackerDemoLibrary.Models;
using VideoGameTrackerDemoLibrary.Queries;
using VideoGameTrackerDemoLibrary.Repositories.Interfaces;

namespace VideoGameTrackerDemoLibrary.Handlers
{
    public class GetAllVideoGamesHandler : IRequestHandler<GetAllVideoGamesQuery, List<VideoGameModel>>
    {
        private readonly IVideoGameRepository _videoGameRepository;

        public GetAllVideoGamesHandler(IVideoGameRepository videoGameRepository)
        {
            _videoGameRepository = videoGameRepository;
        }

        public Task<List<VideoGameModel>> Handle(GetAllVideoGamesQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_videoGameRepository.GetVideoGames());
        }
    }
}
