using VideoGameTrackerDemoLibrary;
using VideoGameTrackerDemoLibrary.Repositories;
using VideoGameTrackerDemoLibrary.Repositories.Interfaces;

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

            // MediatR services
            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(VideoGameTrackerDemoLibraryEntryPoint).Assembly));
            builder.Services.AddSingleton<IVideoGameRepository, VideoGameRepository>();

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
