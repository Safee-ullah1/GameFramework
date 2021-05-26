using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace SectionA2020CS13Framework
{
    // Interface for using in game objects
    public interface IMovement
    {
        void update(PhysicsComponent physics);
    }
}
