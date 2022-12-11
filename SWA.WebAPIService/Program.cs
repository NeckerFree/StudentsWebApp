using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SWA.DataAccess.Data;
using SWA.DataAccess.Models;
using SWA.WebAPIServices.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddSingleton<IStudentService, StudentService>();
var connectionString = builder.Configuration.GetConnectionString("StudentsDBConnection");
builder.Services.AddDbContext<StudentsContext>(option => option.UseSqlite(connectionString));
//builder.Services.AddScoped<IStudentService, StudentService>();
//builder.Services.AddTransient<IStudentService, StudentService>();
builder.Services.AddScoped<StudentService>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("Cors", p =>
    {
        p.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("Cors");

app.UseHttpsRedirection();

app.MapGet("/api/students", async ([FromServices] StudentService studentService) =>
{

    var students = await studentService.GetAll();
    return Results.Ok(students);
});

app.MapGet("/api/students/{id:long}", (int id, [FromServices] StudentService studentService) =>
{
    var student = studentService.Get(id);
    return Results.Ok(student);
});

app.MapPost("/api/students", (Student student, [FromServices] StudentService studentService) =>
{

    var newStudent = studentService.Add(student);

    return Results.Created($"/api/students/{newStudent.Id}", newStudent);
});

app.MapPut("/api/students", (Student student, [FromServices] StudentService studentService) =>
{
    var updatedStudent = studentService.Update(student);
    return Results.Ok(updatedStudent);
});

app.MapDelete("/api/students/{id:int}", async (int id, [FromServices] StudentService studentService) =>
{
    await studentService.Remove(id);
    return Results.Ok();
});

app.Run();
public partial class Program { }