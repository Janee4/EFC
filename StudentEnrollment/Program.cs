using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StudentCourse.Services;
using StudentEnrollment;
using StudentEnrollment.Contexts;
using StudentEnrollment.Repositories;
using StudentEnrollment.Services;

var builder = Host.CreateDefaultBuilder().ConfigureServices(services =>

{
    //Registera datacontext inuti dependency injection så att vi kan använda denna i hela vår applikation utan att behöva specifiera upp context delen i olika filer repeterande gånger
    services.AddDbContext<DataContext>(x => x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\CSharp-Projects\EFC\StudentEnrollment\Data\local_database.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True"));


    services.AddScoped<StudentRepository>();
    services.AddScoped<TeacherRepository>();
    services.AddScoped<AssignmentRepository>();
    services.AddScoped<CourseRepository>();
    services.AddScoped<EnrollmentRepository>();

    services.AddScoped<StudentService>();
    services.AddScoped<TeacherService>();
    services.AddScoped<AssignmentService>();
    services.AddScoped<CourseService>();
    services.AddScoped<EnrollmentService>();

    services.AddSingleton<ConsoleUI>();
}).Build();


var consoleUI = builder.Services.GetRequiredService<ConsoleUI>();
consoleUI.CreateStudent_UI();