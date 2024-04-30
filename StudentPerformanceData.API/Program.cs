using Microsoft.EntityFrameworkCore;
using StudentPerformance.Business.Business;
using StudentPerformance.Business.Contract;
using StudentPerformance.Entity.Models;
using StudentPerformance.Repository.Contract;
using StudentPerformance.Repository.Common;
using AutoMapper.Extensions.ExpressionMapping;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SperformanceContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("StudentPerformanceConnectionString"));
});
builder.Services.AddScoped<DbContext, SperformanceContext>();
builder.Services.AddScoped<IStudentPerformanceBusiness, StudentPerformanceBusiness>();
builder.Services.AddScoped<IStudentPerformance, StudentPerformance>();

builder.Services.AddAutoMapper(c =>
{
    c.AddExpressionMapping();
}, typeof(StudentPerformance).Assembly);

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
