namespace StudentEnrollment.Entities
{
    internal class AssignmentEntity
    {
        //Primär nyckel, en unik identifierare för varje uppgift
        public int AssignmentId { get; set; }

        //Främmande nyckel (Foreign Key), denna nyckeln pekar på den kurs som uppgiften är kopplad till
        public int CourseId { get; set; }

        //Övriga egenskaper
        //Titeln på uppgiften
        public string  Title { get; set; }
        //beskrivningen av uppgiften
        public string Description { get; set; }

        //Datum då uppgiften ska vara klar
        public DateTime DueDate { get; set; }




    }
}
