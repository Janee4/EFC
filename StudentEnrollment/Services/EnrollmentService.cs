using StudentCourse.Services;
using StudentEnrollment.Entities;
using StudentEnrollment.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment.Services
{
    internal class EnrollmentService
    {
        private readonly EnrollmentRepository _enrollmentRepository;
        private readonly StudentService _studentService;
        private readonly CourseService _courseService;

        public EnrollmentService(EnrollmentRepository enrollmentRepository, CourseService courseService, StudentService studentService)
        {
            _enrollmentRepository = enrollmentRepository;
            _courseService = courseService;
            _studentService = studentService;
        }


        public EnrollmentEntity CreateEnrollment(DateTime enrollmentDate, int studentId, int courseId )
        {
            var courseIdString = courseId.ToString();
            var studentIdString = studentId.ToString();

            // Hämta StudentEntity från StudentService
            var studentEntity = _studentService.GetStudentById(studentId);

            // Hämta CourseEntity från CourseService
            var courseEntity = _courseService.GetCourseById(courseId);


            //Get ersätter "read" i CRUD
            var enrollmentEntity = _enrollmentRepository.Get(x => x.EnrollmentDate == enrollmentDate);

            enrollmentEntity = new EnrollmentEntity
            {
                EnrollmentDate = enrollmentDate,
                StudentId = studentEntity.StudentId,
                CourseId = courseEntity.CourseId,
            };
            
            enrollmentEntity = _enrollmentRepository.Create(enrollmentEntity);

            return enrollmentEntity;
        }



        public EnrollmentEntity GetEnrollment(DateTime EnrollmentDate)
        {
            var enrollmentEntity = _enrollmentRepository.Get(x => x.EnrollmentDate == EnrollmentDate);
            return enrollmentEntity;

        }

        public EnrollmentEntity GetEnrollmentById(int EnrollmentId)
        {
            var enrollmentEntity = _enrollmentRepository.Get(x => x.EnrollmentId == EnrollmentId);
            return enrollmentEntity;
        }

        public IEnumerable<EnrollmentEntity> GetEnrollments()
        {
            var enrollments = _enrollmentRepository.GetAll();
            return enrollments;

        }

        public EnrollmentEntity UpdateEnrollment(EnrollmentEntity enrollmentEntity)
        {
            var updatedEnrollmentEntity = _enrollmentRepository.Update(x => x.EnrollmentId == enrollmentEntity.EnrollmentId, enrollmentEntity);
            return updatedEnrollmentEntity;

        }

        public void DeleteEnrollment(int EnrollmentId)
        {
            _enrollmentRepository.Delete(x => x.EnrollmentId == EnrollmentId);

        }






    }
}
