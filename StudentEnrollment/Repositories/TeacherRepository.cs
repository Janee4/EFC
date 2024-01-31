using StudentEnrollment.Contexts;
using StudentEnrollment.Entities;

namespace StudentEnrollment.Repositories
{
    internal class TeacherRepository : Repo<TeacherEntity>
    {
        public TeacherRepository(DataContext context) : base(context)
        {
        }
    }
}
