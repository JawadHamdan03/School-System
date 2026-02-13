namespace AuthProject.Models;


class Teacher
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public List<Student> Students { get; set; }
}