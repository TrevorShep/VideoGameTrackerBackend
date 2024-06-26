﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameTrackerDemoLibrary.Models;

namespace VideoGameTrackerDemoLibrary.Repositories.Interfaces
{
    public interface IVideoGameRepository
    {
        List<VideoGameModel> GetVideoGames();

        VideoGameModel InsertVideoGame(string name, string description, string date);

        string UpdateVideoGame(int id, string name, string description, string date);

        string DeleteVideoGame(int id);
    }
}
