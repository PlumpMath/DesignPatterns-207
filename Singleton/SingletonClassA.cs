// Singleton Class
// Three main points:
//      1. Global Access Point to the Resource
//      2. Single instance of the class 

namespace Singleton
{
    // This class instance is not lazy initialized 
    // and is highly useful in creating Logging libraries.  
    public sealed class SingletonClassA
    {
        // Static Readonly Instance of the class provides 
        // thread-safe creation of the instance
        // Public modifier creates a Global access point 
        // for the class instance
        // No need for a seperate accessor Function. 
        public static readonly SingletonClassA Instance = new SingletonClassA();

        // Private (or Protected) Constructor ensures the 
        // ownership of the instance of the Class. 
        private SingletonClassA()
        {
        }
    }
}
