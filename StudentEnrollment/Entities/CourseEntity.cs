using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEnrollment.Entities
{
    public class CourseEntity
    {

        //Primärnyckel
        [Key]
        public int CourseID { get; set; }

        //övriga egenskaper
        [Column(TypeName = "nvarchar(50")]
        public string CourseName { get; set; }

        //antal högskolepoäng för kursen
        [Column(TypeName = "varchar(5")]
        public int Credits { get; set; }



    }
}
