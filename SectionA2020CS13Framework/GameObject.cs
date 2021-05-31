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
        public float Gravity { get => physics.Gravity; set => physics.Gravity = value; }
        internal GameObject(Control objectPicture, IMovement objectMovement, float objectGravity = 1)
        {
            //for creating object from a component
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
        ~GameObject() => movementFactory.free(objectMovement);
    }
}
