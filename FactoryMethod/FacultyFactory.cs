// Factory Method to provide a way of 
// creating an instance of Faculty as 
// per requirements. 
// We need to define only the classes and their
// functionality and we can create instances of
// the required class during run-time.

namespace FactoryMethod
{
    // Abstract Class for the Faculty
    abstract class Faculty
    {
        public abstract string Title
        {
            get;
        }
    }

    class Professor : Faculty
    {
        public override string Title
        {
            get
            {
                return "Professor";
            }
        }
    }

    class Lecturer : Faculty
    {
        public override string Title
        {
            get
            {
                return "Lecturer";
            }
        }
    }

    class Scientist : Faculty
    {
        public override string Title
        {
            get
            {
                return "Scientist";
            }
        }
    }

    enum FacultyType
    {
        Professor,
        Lecturer,
        Scientist
    }

    class FacultyFactory
    {
        private FacultyFactory()
        {
        }

        public static Faculty GetFacultyInstance(FacultyType facultyType)
        {
            switch (facultyType)
            {
                case FacultyType.Professor:
                    {
                        return new Professor();
                    }
                case FacultyType.Lecturer:
                    {
                        return new Lecturer();
                    }
                case FacultyType.Scientist:
                    {
                        return new Scientist();
                    }
            }

            return null;
        }
    }
}
