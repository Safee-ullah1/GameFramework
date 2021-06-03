using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
namespace SectionA2020CS13Framework
{
    public class ObjectFactory
    {
        int[] objectCount = new int[10];
        MovementFactory movementFactory = MovementFactory.Instance();
        private static ObjectFactory factoryInstance;
        private static readonly object locker = new object();
        private ObjectFactory() { }
        public static ObjectFactory Instance()
        {
            lock (locker)
            {
                if (factoryInstance == null)
                    factoryInstance = new ObjectFactory();

                return factoryInstance;

            }
        }
        public GameObject createObject(Control objectPicture, MovementType movementType, ObjectType objectType, float objectGravity = 1)
        {
            objectCount[(int)objectType]++;
            return new GameObject(objectPicture, movementFactory.createMovement(movementType), objectType, objectGravity);
        }
        public int getCount(ObjectType objectType) => objectCount[(int)objectType];
        public int getTotalObjectsCount()
        {
            int count = 0;
            foreach (int objCount in objectCount) count += objCount;
            return count;
        }
    }
    public enum ObjectType
    {
        player,
        circlingEnemy,
        patrollingEnemy,
        rightMovingEnemy,
        leftMovingEnemy,
        nonMovingObject,
        customMovementObject
    }
}
