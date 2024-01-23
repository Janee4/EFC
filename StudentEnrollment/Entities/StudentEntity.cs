using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEnrollment.Entities
{
    public class StudentEntity
    {

        //Primärnyckel (Primary Key) som kommer behövas då varje student kommer att ha en unik identifikation
        [Key]
        public int StudentId { get; set; }

        [Required]
        //övriga egenskaper
        [Column(TypeName = "nvarchar(50")]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(50")]
        public string LastName { get; set; }

        [Column(TypeName = "varchar(8")]
        public DateTime BirthDate { get; set; }

        [Column (TypeName = "varchar(2")]
        public int Grade { get; set; }

      public virtual ICollection<EnrollmentEntity> Enrollments { get; set; } = new HashSet<EnrollmentEntity>();

    }
}
