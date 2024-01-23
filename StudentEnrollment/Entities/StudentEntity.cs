using System.ComponentModel.DataAnnotations;

namespace StudentEnrollment.Entities
{
    public class StudentEntity
    {

        //Primärnyckel (Primary Key) som kommer behövas då varje student kommer att ha en unik identifikation
        [Key]
        public int StudentId { get; set; }

        //övriga egenskaper
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Grade { get; set; }



    }
}
