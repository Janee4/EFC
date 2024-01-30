using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StudentEnrollment.Contexts;

var builder = Host.CreateDefaultBuilder();
builder.ConfigureServices(services =>
{
    //Registera datacontext inuti dependency injection så att vi kan använda denna i hela vår applikation utan att behöva specifiera upp context delen i olika filer repeterande gånger
    services.AddDbContext<DataContext>(x => x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\CSharp-Projects\EFC\StudentEnrollment\Data\local_database.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True"));


});

builder.Build();
