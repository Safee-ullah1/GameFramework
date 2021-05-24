using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework
{
    class ObjectCounter
    {
        int objectCount;
        public int ObjectCount { get => objectCount; }
        private static ObjectCounter counterInstance;
        private ObjectCounter() { }
        public static ObjectCounter Instance()
        {
            if (counterInstance == null)
                counterInstance = new ObjectCounter();
            return counterInstance;
        }
        public void count() => objectCount++;
           
    }
}
