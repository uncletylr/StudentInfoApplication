using System;

namespace StudentInfoApplication
{
    public class StudentInfo
    {
        // ENCAPSULATION: Using Auto-implemented properties 
        // These replace the need for explicit private backing fields.
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        /// <summary>
        /// Overloaded Constructor 1: Default
        /// Initializes properties with "N/A"
        /// </summary>
        public StudentInfo()
        {
            StudentID = "N/A";
            FirstName = "N/A";
            LastName = "N/A";
        }

        /// <summary>
        /// Overloaded Constructor 2: Parameterized
        /// </summary>
        public StudentInfo(string studentID, string firstName, string lastName)
        {
            this.StudentID = studentID;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        // Bonus: Override ToString for easier debugging/display
        public override string ToString() =>
            $"[ID: {StudentID}] Name: {FirstName} {LastName}";
    }
}