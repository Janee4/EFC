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

        public AssignmentService(AssignmentRepository assignmentRepository)
        {
            _assignmentRepository = assignmentRepository;
        }


        public AssignmentEntity CreateAssignment(string assignmentName)
        {
            var assignmentEntity = _assignmentRepository.Get(x => x.AssignmentName == assignmentName);

            assignmentEntity ??=  _assignmentRepository.Create(new AssignmentEntity { AssignmentName = assignmentName });
     
            return assignmentEntity;    
        }

        public AssignmentEntity GetAssignmentByAssignmentName(string assignmentName) 
        { 
            var assignmentEntity = _assignmentRepository.Get(x =>x.AssignmentName == assignmentName);
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

        public AssignmentEntity UpdateAssignment (AssignmentEntity assignmentEntity) 
        {
            var updatedAssignmentEntity = _assignmentRepository.Update(x => x.AssignmentId == assignmentEntity.AssignmentId, assignmentEntity);
            return updatedAssignmentEntity;
        
        }

        public void DeleteAssignment (int AssignmentId) 
        { 
            _assignmentRepository.Delete(x => x.AssignmentId == AssignmentId);
        
        }
    }
}
