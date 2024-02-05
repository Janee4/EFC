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
    internal class AssignmentService
    {
        private readonly AssignmentRepository _assignmentRepository;
        private readonly CourseService _courseService;

        public AssignmentService(AssignmentRepository assignmentRepository, CourseService courseService)
        {
            _assignmentRepository = assignmentRepository;
            _courseService = courseService;
        }


        public AssignmentEntity CreateAssignment(string assignmentName, DateTime dueDate, string description, string title, int courseId)
        {
            var courseIdString = courseId.ToString();
            var courseEntity = _courseService.CreateCourse(courseIdString);

            var assignmentEntity = _assignmentRepository.Get(x => x.AssignmentName == assignmentName);

            assignmentEntity = new AssignmentEntity
            {
                AssignmentName = assignmentName,
                DueDate = dueDate,
                Description = description,
                Title = title,
                CourseId = courseEntity.CourseId,
            };

            assignmentEntity = _assignmentRepository.Create(assignmentEntity);

            return assignmentEntity;
        }

        public AssignmentEntity GetAssignmentByAssignmentName(string assignmentName)
        {
            var assignmentEntity = _assignmentRepository.Get(x => x.AssignmentName == assignmentName);
            return assignmentEntity;

        }

        public AssignmentEntity GetAssignmentById(int id)
        {
            var assignmentEntity = _assignmentRepository.Get(x => x.AssignmentId == id);
            return assignmentEntity;
        }

        public IEnumerable<AssignmentEntity> GetAssignments()
        {
            var assignments = _assignmentRepository.GetAll();
            return assignments;

        }

        public AssignmentEntity UpdateAssignment(AssignmentEntity assignmentEntity)
        {
            var updatedAssignmentEntity = _assignmentRepository.Update(x => x.AssignmentId == assignmentEntity.AssignmentId, assignmentEntity);
            return updatedAssignmentEntity;

        }

        public void DeleteAssignment(int AssignmentId)
        {
            _assignmentRepository.Delete(x => x.AssignmentId == AssignmentId);

        }
    }
}
