using System;
using System.Collections.Generic;
using System.Text;

namespace SectionA2020CS13Framework
{
    public class MovementRight : IMovement
    {
        int movementSpeed;
        public MovementRight(int movementSpeed)
        {
            this.movementSpeed = movementSpeed;
        }
        public void update(PhysicsComponent physics)
        {
            physics.Gravity = 0;
            physics.setSpeed(movementSpeed, 0);
        }
    }
}
