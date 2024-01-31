using StudentEnrollment.Contexts;
using StudentEnrollment.Entities;

namespace StudentEnrollment.Repositories
{
    internal class EnrollmentRepository : Repo<EnrollmentEntity>
    {
        public EnrollmentRepository(DataContext context) : base(context)
        {
        }
    }
}
