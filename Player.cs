using System;
using System.Collections.Generic;
using System.Drawing;

namespace GameFramework
{
    class Player: GameObject
    {
        public Player() : base() { }
        public Player(Image playerImage, float playerGravity) : base(playerImage, playerGravity) { }
        
    }
}
