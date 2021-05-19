using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace GameFramework
{
    abstract class GameObject : PictureBox
    {
        protected PhysicsComponent physics;
        protected Movement movement = new Movement();
        //For adjusting gravity from the properties panel
        public float Gravity { get => physics.Gravity; set => physics.Gravity = value; }
        public GameObject()
        {
            //for creating object from toolbox
            physics = new PhysicsComponent(this);
        }
        public GameObject(Image objectImage, float objectGravity)
        {
            //for creating object programatically
            this.Image = objectImage;
            physics = new PhysicsComponent(this, objectGravity);
        }
        public void setMovement(Movement movement)
        {
            this.movement = movement;
        }
        public virtual void update()
        {
            movement.update(physics);
            physics.update();
            //Refresh();
        }
    }
}
