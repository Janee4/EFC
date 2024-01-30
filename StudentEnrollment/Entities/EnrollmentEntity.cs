
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEnrollment.Entities
{
    public class EnrollmentEntity
    {
        //Primär nyckel för registreringen, en unik identifierare för varje registrering
        [Key]
        public int EnrollmentId { get; set; }

        //Främmande nycklar (Foreign Keys) Dessa pekar på student- och course entiteterna och representerar vilken student som är registrerad för vilken kurd
        [Required]
        [ForeignKey(nameof(StudentEntity))]
        public int StudentId { get; set; }
        [Required]
        [ForeignKey(nameof(CourseEntity))]
        public int CourseId { get; set; }

        public virtual StudentEntity Student { get; set; }
        public virtual CourseEntity Course { get; set; }
        //övriga egenskaper
        //Datum då studenten registrerades för kursen
        [Column(TypeName = "varchar(8)")]
        public DateTime EnrollmentDate { get; set; }


    }
}
