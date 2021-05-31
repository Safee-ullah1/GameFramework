using System;
using System.Collections.Generic;
using System.Text;

namespace SectionA2020CS13Framework
{
    public class MovementLeft : Movement, IMovement
    {
        int movementSpeed = 5;
        public MovementLeft():base(MovementType.left, false) { }
        public void update(PhysicsComponent physics)
        {
            physics.Gravity = 0;
            physics.setSpeed(-movementSpeed, 0);
        }
    }
}
