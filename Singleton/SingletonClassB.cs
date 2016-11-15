// Singleton Class
// Three main points:
//      1. Global Access Point to the Resource
//      2. Single instance of the class 

using System;

namespace Singleton
{
    // This class is lazy initialized and thread safe during
    // the creation of an instance
    public sealed class SingletonClassB
    {
        // Static Object ensures the global life-time of the 
        // instance of the class.
        private static SingletonClassB classInstance = null;

        // For Synchronization
        private readonly static Object lockObject = new Object();

        // Private (or Protected) Constructor ensures the 
        // ownership of the instance of the Class. 
        private SingletonClassB()
        {
        }

        // Public Static function to provide Global Access to
        // the instance of the class. 
        // This function also ensures the Lazy Initialization 
        // of the class Instance
        public static SingletonClassB Instance()
        {
            if (classInstance != null)
            {
                return classInstance;
            }
            else
            {
                lock (lockObject)
                {
                    if (classInstance == null)
                    {
                        classInstance = new SingletonClassB();
                    }
                }

                return classInstance;
            }
        }
    }
}
