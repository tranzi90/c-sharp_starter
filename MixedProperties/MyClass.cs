using System;

namespace MixedProperties
{
    class MyClass
    {
        int field = -1;

        public int Property_1
        {
            get => (field < 0) ? default : field; // getter (accessor)
            set { field = value; }                // setter (mutator)
        }

        public int Property_2
        {
            get { return (field < 0) ? default : field; } // getter (accessor)
            set => field = value;                         // setter (mutator)
        }
    }
}
