using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace SectionA2020CS13Framework
{
    // Interface for using in game objects
    public interface IMovement
    {
        public MovementType MovementType { get; }
        public bool IsExclusive { get; }
        void update(PhysicsComponent physics);
    }
}
