using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameTrackerDemoLibrary.Models;

namespace VideoGameTrackerDemoLibrary.Queries
{
    public class GetVideoGameByIdQuery : IRequest<VideoGameModel>
    {
        public int Id { get; set; }

        public GetVideoGameByIdQuery(int id)
        {
            Id = id;
        }
    }
}
