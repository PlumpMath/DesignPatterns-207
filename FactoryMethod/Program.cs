using System;

namespace FactoryMethod
{
    class Program
    {
        //  When to use Factory Method Pattern:
        //  1. When a class does not know which class of objects it must create.
        //  2. A class specifies its sub-classes to specify which objects to create.
        //  3. You have to create an object of any one of sub-classes depending on the data provided.

        //  The base type of the instance is known at the compile time but,
        //  the actual type of instance is known only at the run-time

        static void Main(string[] args)
        {
            Faculty facultyInstance = FacultyFactory.GetFacultyInstance(FacultyType.Professor);
            Console.WriteLine(facultyInstance.Title);
        }
    }
}
