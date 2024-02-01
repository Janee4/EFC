using StudentEnrollment.Entities;
using StudentEnrollment.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment.Services
{
    internal class TeacherService
    {
        private readonly TeacherRepository _teacherRepository;

        public TeacherService(TeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }


        public TeacherEntity CreateTeacher(string firstName, string lastName, string subject)
        {
            var teacherEntity = _teacherRepository.Get(x => x.FirstName == firstName && x.LastName == lastName && x.Subject == subject);

            teacherEntity ??= _teacherRepository.Create(new TeacherEntity { FirstName = firstName, LastName = lastName, Subject = subject  });

            return teacherEntity;
        }

        public TeacherEntity GetAssignmentByAssignmentName(string teacherName)
        {
            var assignmentEntity = _teacherRepository.Get(x => x.TeacherName == teacherName);
            return assignmentEntity;

        }

        public TeacherEntity GetAssignmentById(int id)
        {
            var teacherEntity = _teacherRepository.Get(x => x.TeacherId == id);
            return teacherEntity;
        }

        public IEnumerable<TeacherEntity> GetAssignments()
        {
            var assignments = _teacherRepository.GetAll();
            return assignments;

        }

        public TeacherEntity UpdateAssignment(TeacherEntity assignmentEntity)
        {
            var updatedAssignmentEntity = _teacherRepository.Update(x => x.TeacherId == TeacherEntity.TeacherId, TeacherEntity);
            return updatedAssignmentEntity;

        }

        public void DeleteAssignment(int AssignmentId)
        {
            _teacherRepository.Delete(x => x.AssignmentId == AssignmentId);

        }

    }
}
