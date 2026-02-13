using AuthProject.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthProject.Data;


class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<StudentTeacher> StudentTeachers { get; set; } = null!;
    public DbSet<Teacher> Teachers { get; set; } = null!;
}