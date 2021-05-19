using System;
using System.Collections.Generic;

namespace GameFramework
{
    class MovementUpAndDown : Movement
    {
        public override void update(PhysicsComponent physics)
        {
            if (physics.VelocityY > 20) physics.Gravity = -1;
            else if (physics.VelocityY < -20) physics.Gravity = 1;
            
        }
    }
}
