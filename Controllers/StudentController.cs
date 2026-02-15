using AuthProject.Data;
using AuthProject.DTO.Requests;
using AuthProject.DTO.Responses;
using AuthProject.Models;
using AuthProject.Repositories.Classes;
using Mapster;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace AuthProject.Controllers;


[Route("api/[Controller]")]
[ApiController]
public class StudentController(StudentRepositery studentRepositery) : ControllerBase
{

    [HttpGet]
    public async Task<IActionResult> GetStudents()
    {

        var sts = await studentRepositery.getAll();
        var res = sts.Adapt<List<StudentResponse>>();
        return Ok(res);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetStudentById(int id)
    {
        var st = await studentRepositery.GetStudentById(id);
        if (st is null) return NotFound("The Student does not exist");
        return Ok(st.Adapt<StudentResponse>());
    }


    [HttpPost]
    public async Task<IActionResult> Add(StudentRequest request)
    {
        var st = request.Adapt<Student>();
        var res = await studentRepositery.AddStudent(st);

        if (!res)
            BadRequest("data received are not valid");

        return Created();
    }



}