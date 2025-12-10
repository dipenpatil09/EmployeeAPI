var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Enable Swagger for UI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();        // Works only if package installed
    app.UseSwaggerUI();      // Works only if package installed
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();