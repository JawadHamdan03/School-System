namespace AuthProject.DTO.Requests;


public class StudentRequest
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateOnly DateOfBirth { get; set; }

}