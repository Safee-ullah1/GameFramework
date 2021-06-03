using System;
using System.Collections.Generic;
using System.Text;

namespace SectionA2020CS13Framework
{
    public class CollisionDetector
    {
        ObjectType first, second;
        ICollisionBehavior behavior;
        public CollisionDetector(ObjectType first, ObjectType second, ICollisionBehavior behavior)
        {
            this.first = first;
            this.second = second;
            this.behavior = behavior;
        }
        public void check(List<GameObject> objects)
        {
            for (int i = 0; i < objects.Count - 1; i++)
                for (int j = i + 1; j < objects.Count; j++)
                {
                    GameObject firstObject = objects[i];
                    GameObject secondObject = objects[j];

                    if (firstObject.Type == first && secondObject.Type == second
                        && firstObject.collidesWith(secondObject))
                    {
                        behavior.apply(firstObject, secondObject);
                    }
                }
        }
    }
}
