using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework
{
    class MovementAtAngle :Movement
    {
        bool startFlag = true;
        public override void update(PhysicsComponent physics)
        {
            physics.Gravity = 0;
            if (startFlag)
            {
                physics.setAcceleration(1, 1);
                startFlag = false;
            }
            if (physics.VelocityY > 20) physics.setAcceleration(-1, -1);
            else if (physics.VelocityY < -20) physics.setAcceleration(1, 1);

        }
    }
}
