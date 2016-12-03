using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleClass sampleObject = new SampleClass();
            sampleObject[0] = "Sample";
            sampleObject[1] = "Iterator";
            sampleObject[2] = "Class";

            Iterator classIterator = sampleObject.GetIterator();
            while (classIterator.HasNext())
            {
                Console.WriteLine(classIterator.Next());
            }
        }
    }
}
