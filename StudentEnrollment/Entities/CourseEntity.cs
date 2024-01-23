using System.ComponentModel.DataAnnotations;

namespace StudentEnrollment.Entities
{
    internal class CourseEntity
    {

        //Primärnyckel
        [Key]
        public int CourseID { get; set; }

        //övriga egenskaper
        public string CourseName { get; set; }

        //antal högskolepoäng för kursen
        public int Credits { get; set; }



    }
}
