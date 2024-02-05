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

        public TeacherEntity GetTeacher(string firstName, string lastName, string subject)
        {
            var teacherEntity = _teacherRepository.Get(x => x.FirstName == firstName && x.LastName == lastName && x.Subject == subject);
            return teacherEntity;

        }

        public TeacherEntity GetTeacherById(int TeacherId)
        {
            var teacherEntity = _teacherRepository.Get(x => x.TeacherId == TeacherId);
            return teacherEntity;
        }

        public IEnumerable<TeacherEntity> GetTeachers()
        {
            var teachers = _teacherRepository.GetAll();
            return teachers;

        }

        public TeacherEntity UpdateTeacher(TeacherEntity teacherEntity)
        {
            var updatedTeacherEntity = _teacherRepository.Update(x => x.TeacherId == teacherEntity.TeacherId, teacherEntity);
            return updatedTeacherEntity;

        }

        public void DeleteTeacher(int TeacherId)
        {
            _teacherRepository.Delete(x => x.TeacherId == TeacherId);

        }

    }
}
