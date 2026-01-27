using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Cosmos DB Configuration
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseCosmos(
        builder.Configuration.GetConnectionString("StudentDBConnection"),
        builder.Configuration["CosmosDbSettings:DatabaseName"] ?? "StudentPortalDb"
    ));

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