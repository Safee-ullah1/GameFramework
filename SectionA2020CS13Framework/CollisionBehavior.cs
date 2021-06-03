using System;
using System.Collections.Generic;
using System.Text;

namespace SectionA2020CS13Framework
{
    public interface ICollisionBehavior
    {
        public void apply(GameObject first, GameObject second);
    }
}
