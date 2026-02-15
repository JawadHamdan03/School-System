using AuthProject.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthProject.Data;


public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Teacher> Teachers { get; set; } = null!;
}