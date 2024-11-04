using System;

namespace PolymorphismExample
{
    // Define the abstract Person class with properties for first and last name
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Define an abstract SayName method
        public abstract void SayName();
    }
}
