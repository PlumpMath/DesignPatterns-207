
namespace Iterator
{
    // Abstract Class tto define the operations
    // that an iterator will provide over a 
    // base class whose objects we want to iterate 
    // upon. These operations are generic and are
    // independent of the underlying class
    abstract class Iterator
    {
        // The return type of each abstract function
        // is "object" to ensure that this class is 
        // generic and can be used to create iterator
        // operations for any class.

        public abstract object First();

        public abstract object Last();

        public abstract object Current();

        public abstract object Next();

        public abstract bool HasNext();

        public abstract void Reset();
    }
}
