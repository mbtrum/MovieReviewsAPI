var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();



//
// API Endpoints
//

// GET: /api/welcome
app.MapGet("/api/welcome", () =>
{
    return new { Message = "Welcome to the Movie Reviews API!" };
})
.WithName("GetWelcomeMessage");



app.Run();
