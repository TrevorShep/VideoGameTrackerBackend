using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameTrackerDemoLibrary.Repositories.Interfaces;
using VideoGameTrackerDemoLibrary.Models;

namespace VideoGameTrackerDemoLibrary.Repositories
{
    public class VideoGameRepository : IVideoGameRepository
    {
        private List<VideoGameModel> _videoGames = new();

        public VideoGameRepository()
        {
            _videoGames.Add(new VideoGameModel() { Id = 1, Name = "GameOne", Description = "DescriptionOne", ReleaseDate = DateTime.Now });
            _videoGames.Add(new VideoGameModel() { Id = 2, Name = "GameTwo", Description = "DescriptionTwo", ReleaseDate = DateTime.Now });
        }

        public List<VideoGameModel> GetVideoGames()
        {
            return _videoGames;
        }

        public VideoGameModel InsertVideoGame(string name, string description, DateTime date)
        {
            VideoGameModel videoGameToInsert = new() { Name = name, Description = description, ReleaseDate = Convert.ToDateTime(date) };
            videoGameToInsert.Id = _videoGames.Count + 1;
            _videoGames.Add(videoGameToInsert);
            return videoGameToInsert;
        }
    }
}
