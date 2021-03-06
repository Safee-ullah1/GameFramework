using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace SectionA2020CS13Framework
{
    public class PhysicsComponent
    {
        float velocityX, velocityY;
        float accelerationX, accelerationY;
        float gravity;
        Control objectToAttach;
        
        public Point Location { get => objectToAttach.Location; }
        public float VelocityX { get => velocityX;}
        public float VelocityY { get => velocityY;}
        public float AccelerationX { get => accelerationX;}
        public float AccelerationY { get => accelerationY;}
        public float Gravity { get => gravity; set => gravity = value; }
        internal Form ObjectForm { get => objectToAttach?.FindForm(); }
        public PhysicsComponent(Control objectToAttach, float gravity = 0)
        {
            this.objectToAttach = objectToAttach;
            this.gravity = gravity;
        }

        public void setSpeed(float velocityX, float velocityY)
        {
            this.velocityX = velocityX;
            this.velocityY = velocityY;
        }
        public void setAcceleration(float accelerationX, float accelerationY)
        {
            this.accelerationX = accelerationX;
            this.accelerationY = accelerationY;
        }
        public void update()
        {
            objectToAttach.Top += (int)velocityY;
            objectToAttach.Left += (int)velocityX;
            velocityX += accelerationX;
            velocityY += accelerationY + gravity;
        }
        public void addSpeed(float velocityX, float velocityY)
        {
            this.velocityX += velocityX;
            this.velocityY += velocityY;
        }
    }
}
