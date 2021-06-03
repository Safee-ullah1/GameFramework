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
        MovementFactory movementFactory;
        Control objectPicture;
        ObjectType type;
        bool onScreen = true;
        public ObjectType Type { get => type; }
        public float Gravity { get => physics.Gravity; set => physics.Gravity = value; }
        internal GameObject(Control objectPicture, IMovement objectMovement, ObjectType type, float objectGravity = 1)
        {
            //for creating object from a component
            this.type = type;
            this.objectPicture = objectPicture;
            physics = new PhysicsComponent(objectPicture, objectGravity);
            this.objectMovement = objectMovement;
            movementFactory = MovementFactory.Instance();
        }
        public virtual void update()
        {
            objectMovement.update(physics);
            physics.update();
            //Refresh();
        }
        public bool collidesWith(GameObject gameObject)
        {
            return (this.objectPicture.Bounds.IntersectsWith(gameObject.objectPicture.Bounds));
        }
        public void removeSelf()
        {
            if (onScreen)
            {
                objectPicture.FindForm().Controls.Remove(objectPicture);
                objectPicture.Dispose();
                onScreen = false;
            }
        }
        ~GameObject() => movementFactory.release(objectMovement);
    }
}
