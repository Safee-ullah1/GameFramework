using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GameFramework
{
    class Player: GameObject
    {
        public Player(Control objectPicture, IMovement objectMovement, float objectGravity = 1):base(objectPicture, objectMovement, objectGravity) { }
        public Player(Image objectImage, Point objectPosition, IMovement objectMovement, float objectGravity = 1) : base(objectImage, objectPosition, objectMovement, objectGravity) { }
        public Player(Image objectImage, Point objectPosition, Size objectSize, float objectGravity, IMovement objectMovement) : base(objectImage, objectPosition, objectSize, objectMovement, objectGravity) { }
        public override void update()
        {
            //Custom player code here
            base.update();
        }
    }
}
