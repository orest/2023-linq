namespace LinqExamples.Models {
    public class Person {
        public int Id { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int Age {
            get { return DateTime.Now.Year - DateOfBirth.Year; }
        }
    }
}