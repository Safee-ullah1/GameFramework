using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SectionA2020CS13Framework
{
    class MovementCircular 
    {
        Control objectToMove;
        int startX, startY;
        double angleCounter;
        double radius;
        public MovementCircular(Control objectToMove, double radius)
        {
            this.objectToMove = objectToMove;
            startY = objectToMove.Top;
            startX = objectToMove.Left;
            this.radius = radius;
        } 
        public void update(PhysicsComponent physics)
        {
            physics.Gravity = 0;
            angleCounter += 0.05;

            objectToMove.Top = (int)(startY + radius * Math.Sin(angleCounter));
                objectToMove.Left = (int)(startX + radius * Math.Cos(angleCounter));
            

        }
    }
}
