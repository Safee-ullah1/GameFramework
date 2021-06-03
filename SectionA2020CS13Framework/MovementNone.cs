using System;
using System.Collections.Generic;
using System.Text;

namespace SectionA2020CS13Framework
{
    public class MovementNone : Movement, IMovement
    {
        int movementSpeed = 5;
        public MovementNone() : base(MovementType.nonMoving, false) { }
        public void update(PhysicsComponent physics)
        {
            physics.Gravity = 0;
        }
    }
}
