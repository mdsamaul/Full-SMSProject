using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Persistence.Context;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("AppCon");
builder.Services.AddDbContext<SchoolDbContext>(options => // DbContext এর সঠিক নাম ব্যবহার করুন
    options.UseSqlServer(connectionString,
        b => b.MigrationsAssembly(typeof(SchoolDbContext).Assembly.FullName)));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
