using System.Text.Json.Serialization;
using APITutorial.Data;
using APITutorial.Map;
using APITutorial.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// siapapun yg butuh ICategoryRepository kasih CategoryRepository
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

// siapun yg butuh CategoryRepository kasih CategoryRepository
// builder.Services.AddScoped<CategoryRepository>();

// AddScoped: using { }, udah ada dispose, dan klo masih satu scope masih dikasih instance yg sama
// AddSingleton
// AddTransient

builder.Services.AddAutoMapper(typeof(MyMapper));

// builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(
    // why using this? literally because you use this in the CategoryController -> var categories = _db.Categories.Include(c => c.Products).ToList();
    x =>
    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles
); //so that it was not throw error cycle because inside Category there was Product and vice versa

builder.Services.AddDbContext<DataContext>(options => {
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();