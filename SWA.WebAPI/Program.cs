using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SWA.DataAccess.Data;
using SWA.DataAccess.Models;
using SWA.WebAPI.Services;
using Microsoft.OpenApi.Models;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connectionString = builder.Configuration.GetConnectionString("");
builder.Services.AddDbContext<StudentsContext>(option => option.UseSqlite(connectionString));
//StudentService studentService = new StudentService(new StudentsContext());
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//using var scope = app.Services.CreateScope();
//var db = scope.ServiceProvider.GetService<StudentsContext>();
//db?.Database.MigrateAsync();

app.MapGet("/api/students", () =>
{
   
    var students= studentService.GetAll();
    return Results.Ok(students);
});

app.MapGet("/api/students/{id:int}", (int id) =>
{ 
     var student = studentService.Get(id);
    return Results.Ok(student);
});

app.MapPost("/api/students", (Student student) =>
{
   
    var newStudent = studentService.Add(student);

    return Results.Created($"/api/students/{newStudent.Id}", newStudent);
});

app.MapPut("/api/students", (Student student) =>
{
       var updatedStudent = studentService.Update(student);
    return Results.Ok(updatedStudent);
});

app.MapDelete("/api/students/{id:int}", (int id) =>
{
    studentService.Remove(id);
    return Results.Ok();
});

app.Run();

public partial class Program
{ }
