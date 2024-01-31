using StudentEnrollment.Contexts;
using StudentEnrollment.Entities;

namespace StudentEnrollment.Repositories
{
    internal class StudentRepository : Repo<StudentEntity>
    {
        public StudentRepository(DataContext context) : base(context)
        {
        }
    }
}
