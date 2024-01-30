using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEnrollment.Entities
{
    public class TeacherEntity
    {

        //Primär nyckel
        [Key]
        public int TeacherId { get; set; }

        //Övriga egenskaper
        [Required]

        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; }
        
        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }

        //Ämnet som läraren undervisar i
        [Column(TypeName = "nvarchar(50)")]
        public string Subject { get; set; }



    }
}
