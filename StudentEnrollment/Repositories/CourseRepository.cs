using StudentEnrollment.Contexts;
using StudentEnrollment.Entities;

namespace StudentEnrollment.Repositories
{
    internal class CourseRepository : Repo<CourseEntity>
    {
        public CourseRepository(DataContext context) : base(context)
        {
        }
    }
}
