using System;
using System.Collections.Generic;
using System.Drawing;

namespace GameFramework
{
    class Enemy :GameObject
    {
        public Enemy() : base() { }
        public Enemy(Image enemyImage, float enemyGravity) : base(enemyImage, enemyGravity) { }
    }
}
