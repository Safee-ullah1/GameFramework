using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace SectionA2020CS13Framework
{
    public class GameObject
    {
        protected PhysicsComponent physics;
        protected IMovement objectMovement;
        public float Gravity { get => physics.Gravity; set => physics.Gravity = value; }
        internal GameObject(Control objectPicture, IMovement objectMovement, float objectGravity = 1)
        {
            //for creating object from a component
            physics = new PhysicsComponent(objectPicture, objectGravity);
            this.objectMovement = objectMovement;
        }
        internal GameObject(Image objectImage, Point objectPosition, IMovement objectMovement, float objectGravity = 1)
        {
            //for creating object from a an Image
            PictureBox objectPB = createPictureBox(objectImage, objectPosition);
            objectPB.SizeMode = PictureBoxSizeMode.AutoSize;
            physics = new PhysicsComponent(objectPB, objectGravity);
        }
        internal GameObject(Image objectImage, Point objectPosition, Size objectSize, IMovement objectMovement, float objectGravity = 1)
        {
            //for creating object of custom size from a an Image
            PictureBox objectPB = createPictureBox(objectImage, objectPosition);
            objectPB.Size = objectSize;
            physics = new PhysicsComponent(objectPB, objectGravity);
        }
        PictureBox createPictureBox(Image objectImage, Point objectPosition)
        {
            //Utility function
            PictureBox objectPB = new PictureBox();
            objectPB.Image = objectImage;
            objectPB.Location = objectPosition;
            objectPB.BackColor = Color.Transparent;
            return objectPB;
        }
        public virtual void update()
        {
            objectMovement.update(physics);
            physics.update();
            //Refresh();
        }
    }
}
