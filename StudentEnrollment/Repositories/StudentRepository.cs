using Microsoft.EntityFrameworkCore;
using StudentEnrollment.Contexts;
using StudentEnrollment.Entities;
using System.Linq;
using System.Linq.Expressions;

namespace StudentEnrollment.Repositories
{
    internal class StudentRepository : Repo<StudentEntity>
    {

        private readonly DataContext _context;
        public StudentRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public override StudentEntity Get(Expression<Func<StudentEntity, bool>> expression)
        {
            var entity = _context.Students
                .FirstOrDefault(expression);
            return entity!;
        }

        public override IEnumerable<StudentEntity> GetAll()
        {
            return _context.Students       
                .ToList();
        }
    }
}
