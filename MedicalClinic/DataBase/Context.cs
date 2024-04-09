using Microsoft.EntityFrameworkCore;
using MedicalClinic.DataBase.Models;

namespace MedicalClinic.DataBase;

public class Context : DbContext
{
    private string _connectionString;

    public Context()
    {
        _connectionString = "Host=localhost;Port=5432;Database=mydb;Username=myuser;Password=mypassword;";
    }

    public DbSet<Patient> Patients { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_connectionString);
    }

}