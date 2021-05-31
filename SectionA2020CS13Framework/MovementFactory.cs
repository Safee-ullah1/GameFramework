﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SectionA2020CS13Framework
{
    public class MovementFactory
    {
        static MovementFactory factoryInstance;
        List<IMovement> available = new List<IMovement>();
        List<IMovement> occupied = new List<IMovement>();
        int[] movementCount = new int[3];
        private MovementFactory() { }
        public static MovementFactory Instance()
        {
            if (factoryInstance == null) factoryInstance = new MovementFactory();
            return factoryInstance;
        }
        public IMovement createMovement(MovementType movementType)
        {
            IMovement movement = findMovement(movementType, available);
            if (movement != null)
            {
                if (movement.IsExclusive)
                {
                    available.Remove(movement);
                    occupied.Add(movement);
                }
                return movement;
            }

            else
            {
                IMovement newMovement;
                if (movementType == MovementType.right) newMovement = new MovementRight();
                else if (movementType == MovementType.left) newMovement = new MovementLeft();
                else newMovement = new MovementWithKey();

                if (newMovement.IsExclusive) occupied.Add(newMovement);
                else available.Add(newMovement);

                movementCount[(int)newMovement.MovementType]++;
                return newMovement;
            }
        }
        public int getCount(MovementType movementType) => movementCount[(int)movementType];
        public int getTotalMovementCount()
        {
            int count = 0;
            foreach (int movCount in movementCount) count += movCount;
            return count;
        }
        IMovement findMovement(MovementType typeToLookFor, List<IMovement> listToSearch)
        {
            foreach(IMovement movement in listToSearch)
                if (movement.MovementType == typeToLookFor) return movement;
            return null;
        }
        public void free(IMovement movement)
        {
            if (movement.IsExclusive)
            {
                occupied.Remove(movement);
                available.Add(movement);
            }
        }
    }
    public enum MovementType
    {
        keyBoard,
        right,
        left
    }
}
