
using RestAPI.Model;
using System.Net;
using System.Text.Json;

namespace RestAPI;

public class Program
{
    public static List<User> Users;
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        var wc = new WebClient();
        var usersJson = wc.DownloadString("https://jsonplaceholder.typicode.com/users");
        var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
        Users = JsonSerializer.Deserialize<List<User>>(usersJson, options);

        app.Run();

        

    }
}
