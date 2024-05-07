using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameTrackerDemoLibrary.Models;

namespace VideoGameTrackerDemoLibrary.Queries
{
    public class GetAllVideoGamesQuery : IRequest<List<VideoGameModel>> { }
}
