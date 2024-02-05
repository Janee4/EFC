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

        public EnrollmentService(EnrollmentRepository EnrollmentRepository)
        {
            _enrollmentRepository = EnrollmentRepository;
        }


        public EnrollmentEntity CreateEnrollment(DateTime EnrollmentDate)
        {
            var enrollmentEntity = _enrollmentRepository.Get(x => x.EnrollmentDate == EnrollmentDate);

            enrollmentEntity ??= _enrollmentRepository.Create(new EnrollmentEntity { EnrollmentDate = EnrollmentDate });

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
