using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameTrackerDemoLibrary.Models;

namespace VideoGameTrackerDemoLibrary.Commands.Delete
{
    public class DeleteVideoGameCommand : IRequest<string>
    {
        public int Id { get; set; }

        public DeleteVideoGameCommand(int id)
        {
            Id = id;
        }
    }
}
