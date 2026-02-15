using AuthProject.Data;
using AuthProject.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthProject.Repositories.Classes;


public class StudentRepositery(AppDbContext dbContext)
{

    public async Task<List<Student>> getAll() => await dbContext.Students.ToListAsync();

    public async Task<Student> GetStudentById(int id) => await dbContext.Students.FindAsync(id);

    public async Task<bool> AddStudent(Student student)
    {
        if (student is null) return false;
        await dbContext.Students.AddAsync(student);
        dbContext.SaveChangesAsync();
        return true;
    }

    public async Task<bool> Delete(int id)
    {
        var st = await dbContext.Students.FindAsync(id);
        if (st is null) return false;
        dbContext.Students.Remove(st);
        await dbContext.SaveChangesAsync();
        return true;
    }

    public async Task<bool> Edit(int id, Student student)
    {
        var st = await dbContext.Students.FindAsync(id);
        if (st is null) return false;
        st.Name = student.Name;
        st.DateOfBirth = student.DateOfBirth;
        dbContext.Students.Update(st);
        return true;
    }

}