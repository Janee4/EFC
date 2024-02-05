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

        private readonly StudentRepository _StudentRepository;

        public StudentService(StudentRepository StudentRepository)
        {
            _StudentRepository = StudentRepository;
        }


        public StudentEntity CreateStudent(string firstName, string lastName, DateTime birthDate, int grade)
        {
            var StudentEntity = _StudentRepository.Get(x => x.StudentName == StudentName);

            StudentEntity ??= _StudentRepository.Create(new StudentEntity { StudentName = StudentName });

            return StudentEntity;
        }

        public StudentEntity GetStudent(string StudentName)
        {
            var StudentEntity = _StudentRepository.Get(x => x.StudentName == StudentName);
            return StudentEntity;

        }

        public StudentEntity GetStudentById(int StudentId)
        {
            var StudentEntity = _StudentRepository.Get(x => x.StudentId == StudentId);
            return StudentEntity;
        }

        public IEnumerable<StudentEntity> GetStudents()
        {
            var Students = _StudentRepository.GetAll();
            return Students;

        }

        public StudentEntity UpdateStudent(StudentEntity StudentEntity)
        {
            var updatedStudentEntity = _StudentRepository.Update(x => x.StudentId == StudentEntity.StudentId, StudentEntity);
            return updatedStudentEntity;

        }

        public void DeleteStudent(int StudentId)
        {
            _StudentRepository.Delete(x => x.StudentId == StudentId);

        }



    }
}
