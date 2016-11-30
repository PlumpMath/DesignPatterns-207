using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    abstract class Iterator
    {
        public abstract object First();

        public abstract object Last();

        public abstract object Current();

        public abstract object Next();

        public abstract void Reset();
    }
}
