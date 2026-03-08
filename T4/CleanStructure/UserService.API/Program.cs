using Scalar.AspNetCore;
using UserService.Core.Entities.Models;
using UserService.Core.Entities.Interfaces;
using UserService.Infrastructure.Services;
using UserService.Infrastructure.Repositories;
var builder = WebApplication.CreateBuilder(args);

// 
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddSingleton<IUserService, UserService.Infrastructure.Services.UserService>();
builder.Services.AddSingleton<UserRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();
app.MapControllers();


// APIs
app.MapGet("/", () => "User Service Running 🚀");

app.MapGet("/users", (UserRepository repo) =>
{
    return repo.GetAllUsers();
});

app.MapPost("/users", (User user, UserRepository repo) =>
{
    repo.AddUser(user);
    return Results.Ok(user);
});

app.Run();