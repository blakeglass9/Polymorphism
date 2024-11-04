using System;

namespace PolymorphismExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate and initialize an Employee object
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            // Use polymorphism to create an IQuittable type object
            IQuittable quittableEmployee = employee;

            // Call the Quit method on the IQuittable object
            quittableEmployee.Quit();

            // Pause to view output
            Console.ReadKey();
        }
    }
}
