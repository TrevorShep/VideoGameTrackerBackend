using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameTrackerDemoLibrary.Commands.Delete;
using VideoGameTrackerDemoLibrary.Repositories.Interfaces;

namespace VideoGameTrackerDemoLibrary.Handlers.Commands.Delete
{
    public class DeleteVideoGameHandler : IRequestHandler<DeleteVideoGameCommand, string>
    {
        private readonly IVideoGameRepository _videoGameRepository;

        public DeleteVideoGameHandler(IVideoGameRepository videoGameRepository)
        {
            _videoGameRepository = videoGameRepository;
        }

        public Task<string> Handle(DeleteVideoGameCommand request, CancellationToken cancellationToken)
        {
            string deleteVideoGame = _videoGameRepository.DeleteVideoGame(request.Id);
            return Task.FromResult(deleteVideoGame);
        }
    }
}
