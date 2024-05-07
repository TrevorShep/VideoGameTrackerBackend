using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameTrackerDemoLibrary.Commands.Update;
using VideoGameTrackerDemoLibrary.Repositories.Interfaces;

namespace VideoGameTrackerDemoLibrary.Handlers.Commands.Update
{
    public class UpdateVideoGameHandler : IRequestHandler<UpdateVideoGameCommand, string>
    {
        private readonly IVideoGameRepository _videoGameRepository;

        public UpdateVideoGameHandler(IVideoGameRepository videoGameRepository)
        {
            _videoGameRepository = videoGameRepository;
        }

        public Task<string> Handle(UpdateVideoGameCommand request, CancellationToken cancellationToken)
        {
            string updateVideoGame = _videoGameRepository.UpdateVideoGame(request.Id, request.Name, request.Description, request.ReleaseDate);
            return Task.FromResult(updateVideoGame);
        }
    }
}
