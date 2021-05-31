using System;
using System.Collections.Generic;
using System.Drawing;
namespace SectionA2020CS13Framework
{
    public class MovementPatrol
    {
        int strideLength, movementSpeed;
        PatrolMode patrolMode;
        bool startFlag;
        Point startPoint;
        public MovementPatrol(int strideLength, int movementSpeed, PatrolMode patrolMode)
        {
            this.strideLength = strideLength;
            this.movementSpeed = movementSpeed;
            this.patrolMode = patrolMode;
        }
        public void update(PhysicsComponent physics)
        {
            physics.Gravity = 0;
            if(patrolMode == PatrolMode.upDown)
            {
                if (!startFlag)
                {
                    physics.setSpeed(0, movementSpeed);
                    startPoint = new Point(physics.Location.X, physics.Location.Y);
                    startFlag = true;
                }
                if (physics.Location.Y < startPoint.Y + 20) physics.setSpeed(0, movementSpeed);
                if (physics.Location.Y > strideLength) physics.setSpeed(0, -movementSpeed);
            }
            else if (patrolMode == PatrolMode.leftRight)
            {
                if (!startFlag)
                {
                    physics.setSpeed(movementSpeed, 0);
                    startPoint = new Point(physics.Location.X, physics.Location.Y);
                    startFlag = true;
                }
                if (physics.Location.X < startPoint.X + 20) physics.setSpeed(movementSpeed, 0);
                if (physics.Location.X > strideLength) physics.setSpeed(-movementSpeed, 0);
            }

        }
    }
    public enum PatrolMode
    {
        upDown,
        leftRight
    }
}
