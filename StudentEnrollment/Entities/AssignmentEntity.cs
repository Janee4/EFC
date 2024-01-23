using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEnrollment.Entities
{
    internal class AssignmentEntity
    {
        //Primär nyckel, en unik identifierare för varje uppgift
        [Key]
        public int AssignmentId { get; set; }

        //Främmande nyckel (Foreign Key), denna nyckeln pekar på den kurs som uppgiften är kopplad till
        public int CourseId { get; set; }

        //Övriga egenskaper

        [Required] //talar om att det måste fyllas i
        [Column(TypeName = "nvarchar(50")]
        //Titeln på uppgiften
        public string Title { get; set; } = null!;

        //beskrivningen av uppgiften
        [Column(TypeName = "nvarchar 50")]
        public string Description { get; set; }

        //Datum då uppgiften ska vara klar
        [Column(TypeName = "varchar 8")]
        public DateTime DueDate { get; set; }


    }
}
