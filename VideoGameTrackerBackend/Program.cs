using VideoGameTrackerDemoLibrary;
using VideoGameTrackerDemoLibrary.Repositories;
using VideoGameTrackerDemoLibrary.Repositories.Interfaces;
using VideoGameTrackerLibrary.Repositories;
using VideoGameTrackerLibrary.Repositories.Interfaces;
using VideoGameTrackerLibrary;

namespace VideoGameTrackerBackend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // MediatR services for VideoGameTrackerDemoLibrary
            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(VideoGameTrackerDemoLibraryEntryPoint).Assembly));
            builder.Services.AddSingleton<IVideoGameRepository, VideoGameRepository>();

            // MediatR and HttpClientFactory services for VideoGameTrackerLibrary
            builder.Services.AddHttpClient();
            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(VideoGameTrackerLibraryEntryPoint).Assembly));
            builder.Services.AddScoped<IMobyGamesRepository, MobyGamesRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
