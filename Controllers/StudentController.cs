using AuthProject.Data;
using AuthProject.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace AuthProject.Controllers;


[Route("api/students")]
[ApiController]
public class StudentController(AppDbContext dbContext) : ControllerBase
{

    [HttpGet]
    public IActionResult GetStudents() => Ok(dbContext.Students.ToList());

    [HttpGet("{id:int}")]
    public IActionResult GetStudentById(int id)
    {
        var student = dbContext.Students.FirstOrDefault(s => s.Id == id);

        if (student is null)
            return NotFound();

        return Ok(student);
    }


    [HttpPost]
    public IActionResult Add(Student student)
    {
        dbContext.Students.Add(student);
        dbContext.SaveChanges();
        return CreatedAtAction(nameof(GetStudentById), new { id = student.Id }, student);
    }



}