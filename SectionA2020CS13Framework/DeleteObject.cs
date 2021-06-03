using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SectionA2020CS13Framework
{
    public class DeleteObject : ICollisionBehavior
    {
        Game game;
        ObjectType typeToDelete;
        public DeleteObject(Game game, ObjectType typeToDelete)
        {
            this.game = game;
            this.typeToDelete = typeToDelete;
        }
        public void apply(GameObject first, GameObject second)
        {
            if(first.Type == typeToDelete)
            {
                first.removeSelf();
                game.removeGameObject(first);
                GC.Collect();
            }
            else if (second.Type == typeToDelete)
            {
                second.removeSelf();
                game.removeGameObject(second);
                GC.Collect();
            }
        }
    }
}
