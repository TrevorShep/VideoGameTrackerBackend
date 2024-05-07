using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameTrackerDemoLibrary.Models;

namespace VideoGameTrackerDemoLibrary.Commands.Create
{
    public class InsertVideoGameCommand : IRequest<VideoGameModel>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ReleaseDate { get; set; }

        public InsertVideoGameCommand(string name, string description, string releaseDate)
        {
            Name = name;
            Description = description;
            ReleaseDate = releaseDate;
        }
    }
}
