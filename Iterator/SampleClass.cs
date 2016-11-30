using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class SampleClass
    {
        private ArrayList items = new ArrayList();

        public Iterator GetIterator()
        {
            return new SampleClassIterator(this);
        }

        public int Size()
        {
            return items.Count;
        }

        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }

    class SampleClassIterator : Iterator
    {
        private SampleClass classObject;
        private int currentLocation = 0;
        private int objectSize = 0;

        public SampleClassIterator(SampleClass classObject)
        {
            this.classObject = classObject;
            objectSize = this.classObject.Size();
        }

        public override object Current()
        {
            return classObject[currentLocation];
        }

        public override object First()
        {
            return classObject[0];
        }

        public override object Last()
        {
            return classObject[objectSize - 1];
        }

        public override object Next()
        {
            if (currentLocation >= objectSize - 1)
            {
                return null;
            }

            return classObject[++currentLocation];
        }

        public override void Reset()
        {
            currentLocation = 0;
        }
    }
}
