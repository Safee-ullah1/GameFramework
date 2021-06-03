using System;
using System.Collections.Generic;
using System.Text;

namespace SectionA2020CS13Framework
{
    public class Movement
    {
        protected MovementType movementType;
        protected bool isExclusive;
        public MovementType MovementType { get => movementType; }
        public bool IsExclusive { get => isExclusive; }
        public Movement(MovementType movementType, bool isExclusive)
        {
            this.movementType =movementType;
            this.isExclusive = isExclusive;
        }
    }
}
