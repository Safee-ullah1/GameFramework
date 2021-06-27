using System;
using System.Collections.Generic;
using System.Text;

namespace SectionA2020CS13Framework
{
    public class MovementLinear : Movement, IMovement, ILinearDirection
    {
        int movementSpeed = 5;
        int xDir = 1;
        int yDir = 0;
        public MovementLinear():base(MovementType.left, false) { }
        public void update(PhysicsComponent physics)
        {
            physics.Gravity = 0;
            physics.setSpeed(xDir * movementSpeed, yDir * movementSpeed);
        }
        public void changeDirection(MovementType direction)
        {
            if(movementType == MovementType.up)
            {
                yDir = -1;
                xDir = 0;
            }
            else if (movementType == MovementType.down)
            {
                yDir = 1;
                xDir = 0;
            }
            else if (movementType == MovementType.left)
            {
                yDir = 0;
                xDir = -1;
            }
            else if (movementType == MovementType.right)
            {
                yDir = 0;
                xDir = 1;
            }
            else if (movementType == MovementType.flip)
            {
                yDir *= -1;
                xDir *= -1;
            }
        }
    }
}
