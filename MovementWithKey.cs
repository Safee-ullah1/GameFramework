using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GameFramework
{
    class MovementWithKey : IMovement
    {
        Control gameObject;
        int movementSpeed;
        Form form;
        PhysicsComponent physics;
        public MovementWithKey(Control gameObject, int movementSpeed)
        {
            this.gameObject = gameObject;
            this.movementSpeed = movementSpeed;
            form = gameObject.FindForm();
        }
        public void update(PhysicsComponent physics)
        {
            physics.Gravity = 0;
            this.physics = physics;
            form.KeyDown += new KeyEventHandler(keyDownHandler);
            form.KeyUp += new KeyEventHandler(keyUpHandler);

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
