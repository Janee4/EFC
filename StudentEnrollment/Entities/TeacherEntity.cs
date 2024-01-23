using System.ComponentModel.DataAnnotations;

namespace StudentEnrollment.Entities
{
    internal class TeacherEntity
    {

        //Primär nyckel
        [Key]
        public int TeacherId { get; set; }

        //Övriga egenskaper

        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Ämnet som läraren undervisar i
        public string Subject { get; set; }



    }
}
