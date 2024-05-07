using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameTrackerDemoLibrary.Commands.Update
{
    public class UpdateVideoGameCommand : IRequest<string>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ReleaseDate { get; set; }

        public UpdateVideoGameCommand(int id, string name, string description, string date)
        {
            Id = id;
            Name = name;
            Description = description;
            ReleaseDate = date;
        }
    }
}
