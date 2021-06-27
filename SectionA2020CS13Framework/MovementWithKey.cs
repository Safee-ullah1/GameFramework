using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SectionA2020CS13Framework
{
    public class MovementWithKey : Movement, IMovement
    {
        PhysicsComponent physics;
        int movementSpeed = 10;
        bool firstTimeCheck;
        public MovementWithKey():base(MovementType.keyBoard, true) { }
        public void update(PhysicsComponent physics)
        {
            physics.Gravity = 0;
            if (!firstTimeCheck)
            {
                this.physics = physics;
                physics.ObjectForm.KeyDown += new KeyEventHandler(keyDownHandler);
                physics.ObjectForm.KeyUp += new KeyEventHandler(keyUpHandler);
                firstTimeCheck = true;
            }

        }
        private void keyDownHandler(object sender, KeyEventArgs e)
        {
            if(physics.VelocityX + physics.VelocityY < movementSpeed)
            {
                if (e.KeyCode == Keys.Up) physics.setSpeed(0, -movementSpeed);
                if (e.KeyCode == Keys.Down) physics.setSpeed(0, movementSpeed);
                if (e.KeyCode == Keys.Left) physics.setSpeed(-movementSpeed, 0);
                if (e.KeyCode == Keys.Right) physics.setSpeed(movementSpeed, 0);
            }
        }
        private void keyUpHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) physics.setSpeed(physics.VelocityX, 0);
            if (e.KeyCode == Keys.Down) physics.setSpeed(physics.VelocityX, 0);
            if (e.KeyCode == Keys.Left) physics.setSpeed(0, physics.VelocityY);
            if (e.KeyCode == Keys.Right) physics.setSpeed(0, physics.VelocityY);
        }
    }
}
