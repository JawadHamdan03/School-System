using Microsoft.EntityFrameworkCore;

namespace AuthProject.Models;


[PrimaryKey(nameof(StudentId), nameof(TeacherId))]
class StudentTeacher
{
    public int StudentId { get; set; }
    public int TeacherId { get; set; }

    public Student? Student { get; set; }
    public Teacher? Teacher { get; set; }
}