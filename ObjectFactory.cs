using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
namespace GameFramework
{
    class ObjectFactory
    {
        int[] objectCount = new int[20];
        private static ObjectFactory counterInstance;
        private ObjectFactory() { }
        public static ObjectFactory Instance()
        {
            if (counterInstance == null)
                counterInstance = new ObjectFactory();
            return counterInstance;
        }
        public GameObject createObject(Control objectPicture, IMovement objectMovement, ObjectType objectType, float objectGravity = 1)
        {
            ++objectCount[(int)objectType];
            return new GameObject(objectPicture, objectMovement, objectGravity);
        }
        public GameObject createObject(Image objectImage, Point objectPosition, IMovement objectMovement, ObjectType objectType, float objectGravity = 1)
        {
            ++objectCount[(int)objectType];
            return new GameObject(objectImage, objectPosition, objectMovement, objectGravity);
        }
        public GameObject createObject(Image objectImage, Point objectPosition, Size objectSize, IMovement objectMovement, ObjectType objectType, float objectGravity = 1)
        {
            ++objectCount[(int)objectType];
            return new GameObject(objectImage, objectPosition, objectSize, objectMovement, objectGravity);
        }
        public int getCount(ObjectType objectType) => objectCount[(int)objectType];
        public int getTotalObjectsCount()
        {
            int count = 0;
            foreach (int objCount in objectCount) count += objCount;
            return count;
        }
    }
    enum ObjectType
    {
        player,
        circlingEnemy,
        patrollingEnemy,
        rightMovingEnemy,
        leftMovingEnemy,
        nonMovingObject
    }
}
