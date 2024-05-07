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
    public class GetVideoGameByIdHandler : IRequestHandler<GetVideoGameByIdQuery, VideoGameModel>
    {
        private readonly IVideoGameRepository _videoGameRepository;

        public GetVideoGameByIdHandler(IVideoGameRepository videoGameRepository)
        {
            _videoGameRepository = videoGameRepository;
        }

        public Task<VideoGameModel> Handle(GetVideoGameByIdQuery request, CancellationToken cancellationToken)
        {
            List<VideoGameModel> videoGameList = _videoGameRepository.GetVideoGames();
            VideoGameModel? videoGameById = videoGameList.FirstOrDefault(x => x.Id == request.Id);
            return Task.FromResult(videoGameById);
        }
    }
}
