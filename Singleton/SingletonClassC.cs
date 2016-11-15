// Singleton Class
// Three main points:
//      1. Global Access Point to the Resource
//      2. Single instance of the class 

using System;

namespace Singleton
{
    // Explicitly using Lazy Template to ensure
    // lazy initialization of class instance
    public sealed class SingletonClassC
    {
        // Lazy Template for creating class instance 
        // in a thread-safe lazy initialization fashion.
        private static readonly Lazy<SingletonClassC> classInstance = new Lazy<SingletonClassC>(() => new SingletonClassC(), true);

        // Global Access Point to class Instance
        // We can also create a Class Propertiey 
        // instead without a set accessor of a 
        // class method
        public static SingletonClassC Instance()
        {
            return classInstance.Value;
        }

        // Private (or Protected) Constructor ensures the 
        // ownership of the instance of the Class. 
        private SingletonClassC()
        {
        }
    }
}
