using StudentEnrollment.Contexts;
using StudentEnrollment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment.Repositories
{
    internal class AssignmentRepository : Repo<AssignmentEntity>
    {
        public AssignmentRepository(DataContext context) : base(context)
        {
        }
    }
}
