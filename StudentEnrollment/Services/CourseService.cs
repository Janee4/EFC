
using StudentEnrollment.Entities;
using StudentEnrollment.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourse.Services
{
    internal class CourseService
    {
        private readonly CourseRepository _courseRepository;

        public CourseService(CourseRepository CourseRepository)
        {
            _courseRepository = CourseRepository;
        }


        public CourseEntity CreateCourse(string courseName)
        {
            var CourseEntity = _courseRepository.Get(x => x.CourseName == courseName);

            CourseEntity ??= _courseRepository.Create(new CourseEntity { CourseName = courseName });

            return CourseEntity;
        }

        public CourseEntity GetCourse(string courseName)
        {
            var CourseEntity = _courseRepository.Get(x => x.CourseName == courseName);
            return CourseEntity;

        }

        public CourseEntity GetCourseById(int CourseId)
        {
            var CourseEntity = _courseRepository.Get(x => x.CourseId == CourseId);
            return CourseEntity;
        }

        public IEnumerable<CourseEntity> GetCourses()
        {
            var courses = _courseRepository.GetAll();
            return courses;

        }

        public CourseEntity UpdateCourse(CourseEntity CourseEntity)
        {
            var updatedCourseEntity = _courseRepository.Update(x => x.CourseId == CourseEntity.CourseId, CourseEntity);
            return updatedCourseEntity;

        }

        public void DeleteCourse(int CourseId)
        {
            _courseRepository.Delete(x => x.CourseId == CourseId);

        }


    }
}
