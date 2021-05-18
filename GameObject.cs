using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace GameFramework
{
    abstract class GameObject : PictureBox
    {
        protected PhysicsComponent physics;
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
        public virtual void update()
        {
            physics.update();
            //Refresh();
        }
    }
}
