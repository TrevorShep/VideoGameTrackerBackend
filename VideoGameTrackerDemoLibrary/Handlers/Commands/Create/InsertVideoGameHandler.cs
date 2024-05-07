using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameTrackerDemoLibrary.Commands.Create;
using VideoGameTrackerDemoLibrary.Models;
using VideoGameTrackerDemoLibrary.Repositories.Interfaces;

namespace VideoGameTrackerDemoLibrary.Handlers.Commands.Create
{
    public class InsertVideoGameHandler : IRequestHandler<InsertVideoGameCommand, VideoGameModel>
    {
        private readonly IVideoGameRepository _videoGameRepository;

        public InsertVideoGameHandler (IVideoGameRepository videoGameRepository)
        {
            _videoGameRepository = videoGameRepository;
        }

        public Task<VideoGameModel> Handle(InsertVideoGameCommand request, CancellationToken cancellationToken)
        {
            VideoGameModel videoGameModelToInsert = _videoGameRepository.InsertVideoGame(request.Name, request.Description, request.ReleaseDate);
            return Task.FromResult(videoGameModelToInsert);
        }
    }
}
