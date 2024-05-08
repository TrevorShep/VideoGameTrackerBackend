using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameTrackerLibrary.Repositories.Interfaces
{
    public interface IMobyGamesRepository
    {
        Task<string> GetOneGameTest();
    }
}
