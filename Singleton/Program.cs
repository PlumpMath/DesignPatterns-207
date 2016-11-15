using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Difference between Singleton and Static classes.
            //  1. Singleton object stores in Heap but, static object stores in stack
            //  2. We can clone the object of Singleton but, we can not clone the static class object
            //  3. Singleton class follow the OOP(object oriented principles) but not static class
            //  4. We can implement interface with Singleton class but not with Static class.
            
            //  Both Singleton and Static classes can be thread-safe (or not) if they are properly implemented.

            //  Links:
            //  https://en.wikibooks.org/wiki/Computer_Science_Design_Patterns/Singleton
            //  https://sourcemaking.com/design_patterns/singleton
            //  http://stackoverflow.com/questions/519520/difference-between-static-class-and-singleton-pattern
            //  http://csharpindepth.com/Articles/General/Singleton.aspx
        }
    }
}
