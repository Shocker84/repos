using System;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;

public class AppDbContext : DbContext
{
    public DbSet<Doctor> Doctors { set; get; }
    public DbSet<Patient> Patients { set; get; }
    public DbSet<IntakeForm> IntakeForms { set; get; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(@"server=localhost;username=root;password=Dominic02;database=Clinic",
            ServerVersion.Parse("8.0.23-mysql")
        );
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Doctor>().HasData(
            new Doctor()
            {
                Id = 1,
                Name = "Dr Strange"
            },
            new Doctor()
            {
                Id = 2,
                Name = "Dr Octopus"
            },
            new Doctor()
            {
                Id = 3,
                Name = "Dr Doom"
            }
            );
        modelBuilder.Entity<Patient>().HasData(
                    new Patient()
                    {
                        Id = 1,
                        Name = "Spider Man",
                        DateOfBirth = DateTime.Now,
                        HealthNumber = 111222333,
                        Address = "123 Spider Dr, New York",
                        PhoneNumber = "+44 7911 123456"
                    },
                    new Patient()
                    {
                        Id = 2,
                        Name = "Iron Man",
                        DateOfBirth = DateTime.Now,
                        HealthNumber = 444555666,
                        Address = "321 Iron Man Way, New York",
                        PhoneNumber = "+44 7911 123457"
                    },
                    new Patient()
                    {
                        Id = 3,
                        Name = "Captain America",
                        DateOfBirth = DateTime.Now,
                        HealthNumber = 777888999,
                        Address = "222 Captain St, New York",
                        PhoneNumber = "+44 7911 123458"
                    }
                    );
        modelBuilder.Entity<IntakeForm>().HasData(
                   new IntakeForm()
                   {
                       Id = 1,
                       Ailment = "Insomnia",
                       DoctorId = 2,
                       PatientId = 1
                   },
                   new IntakeForm()
                   {
                       Id = 2,
                       Ailment = "Unable to fight villians",
                       DoctorId = 1,
                       PatientId = 2
                   },
                   new IntakeForm()
                   {
                       Id = 3,
                       Ailment = "Extreme fatique",
                       DoctorId = 3,
                       PatientId = 3
                   }
                   );

        base.OnModelCreating(modelBuilder);

    }
}
