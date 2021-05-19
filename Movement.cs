using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace GameFramework
{
    // A base class for movements
    class Movement
    {
        protected float movementSpeed = 10;
        public void setMovementSpeed(float movementSpeed)
        {
            this.movementSpeed = movementSpeed;
        }
        public virtual void update(PhysicsComponent physics)
        {
            //base behaviour to move rightwards
            physics.setSpeed(movementSpeed, 0);
        }
    }
}
