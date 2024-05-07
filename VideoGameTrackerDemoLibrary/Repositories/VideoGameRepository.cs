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
            _videoGames.Add(new VideoGameModel() { Id = 1, Name = "GameOne", Description = "DescriptionOne", ReleaseDate = "05/07/2024" });
            _videoGames.Add(new VideoGameModel() { Id = 2, Name = "GameTwo", Description = "DescriptionTwo", ReleaseDate = "05/07/2024" });
        }

        public List<VideoGameModel> GetVideoGames()
        {
            return _videoGames;
        }

        public VideoGameModel InsertVideoGame(string name, string description, string date)
        {
            VideoGameModel videoGameToInsert = new() { Name = name, Description = description, ReleaseDate = date };
            videoGameToInsert.Id = _videoGames.Count + 1;
            _videoGames.Add(videoGameToInsert);
            return videoGameToInsert;
        }

        public string DeleteVideoGame(int id)
        {
            VideoGameModel videoGameToDelete = _videoGames[id - 1];
            _videoGames.Remove(videoGameToDelete);
            return $"Video game was deleted\n\nName: {videoGameToDelete.Name}\nDescription: {videoGameToDelete.Description}\nRelease Date: {videoGameToDelete.ReleaseDate}";
        }
    }
}
