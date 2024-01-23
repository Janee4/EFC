using Microsoft.EntityFrameworkCore;
using StudentEnrollment.Entities;

namespace StudentEnrollment.Contexts;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)

{
    public virtual DbSet<AssignmentEntity> Assignments { get; set; }
    public virtual DbSet<TeacherEntity> Teachers { get; set; }
    public virtual DbSet<EnrollmentEntity> Enrollments { get; set; }
    public virtual DbSet<CourseEntity> Courses { get; set; }
    public virtual DbSet<StudentEntity> Students { get; set; }

}
    

