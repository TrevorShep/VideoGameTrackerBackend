using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameTrackerLibrary.Models;

namespace VideoGameTrackerLibrary.Repositories.Interfaces
{
    public interface IMobyGamesRepository
    {
        Task<GenresModelContainer> GetGenres();

        Task<string> GetOneGameTest();
    }
}
