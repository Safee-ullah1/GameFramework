using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace GameFramework
{
    // Interface for using in game objects
    interface IMovement
    {
        void update(PhysicsComponent physics);
    }
}
