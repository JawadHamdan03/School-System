using AuthProject.Models;

namespace AuthProject.Repositories.Intefaces;


public interface IStudentRepositery
{
    public Task<List<Student>> getAll();

    public Task<bool> AddStudent(Student student);


    public Task<bool> Delete(int id);


    public Task<bool> Edit(int id, Student student);


}