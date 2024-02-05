using StudentEnrollment.Entities;
using StudentEnrollment.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment.Services
{
    internal class StudentService
    {

        private readonly StudentRepository _studentRepository;

        public StudentService(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }


        public StudentEntity CreateStudent(string firstName, string lastName, DateTime birthDate, int grade)
        {
            var studentEntity = _studentRepository.Get(x => x.FirstName == firstName && x.LastName == lastName && x.BirthDate == birthDate);

            studentEntity ??= _studentRepository.Create(new StudentEntity { FirstName = firstName, LastName = lastName, BirthDate = birthDate });

            return studentEntity;
        }

        public StudentEntity GetStudent(string firstName, string lastName, DateTime birthDate, int grade)
        {
            var studentEntity = _studentRepository.Get(x => x.FirstName == firstName && x.LastName == lastName && x.BirthDate == birthDate);
            return studentEntity;

        }

        public StudentEntity GetStudentById(int StudentId)
        {
            var StudentEntity = _studentRepository.Get(x => x.StudentId == StudentId);
            return StudentEntity;
        }

        public IEnumerable<StudentEntity> GetStudents()
        {
            var students = _studentRepository.GetAll();
            return students;

        }

        public StudentEntity UpdateStudent(StudentEntity studentEntity)
        {
            var updatedStudentEntity = _studentRepository.Update(x => x.StudentId == studentEntity.StudentId, studentEntity);
            return updatedStudentEntity;

        }

        public void DeleteStudent(int StudentId)
        {
            _studentRepository.Delete(x => x.StudentId == StudentId);

        }



    }
}
