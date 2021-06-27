using System;
using System.Collections.Generic;
using System.Text;

namespace SectionA2020CS13Framework
{
    public class MovementDownward : Movement, IMovement
    {
        int movementSpeed = 3;
        public MovementDownward() : base(MovementType.right, false) { }
        public void update(PhysicsComponent physics)
        {
            physics.Gravity = 0;
            physics.setSpeed(0, movementSpeed);
        }
    }
}
