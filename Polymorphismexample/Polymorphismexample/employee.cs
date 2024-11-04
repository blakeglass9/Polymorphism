using System;

namespace PolymorphismExample
{
    // Define the Employee class that inherits from Person and implements IQuittable
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        // Implement the SayName method from the Person class
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }

        // Implement the Quit method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} has quit their job.");
        }
    }
}
