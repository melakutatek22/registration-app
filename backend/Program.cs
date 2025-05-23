var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapPost("/register", (User user) =>
{
    // Simulate user registration logic
    return Results.Ok(new { Message = "User registered successfully", User = user });
});

app.Run();

record User(string Username, string Email, string Password);
