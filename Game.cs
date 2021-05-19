using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GameFramework
{
    class Game
    {
        List<GameObject> gameObjects = new List<GameObject>();
        public void addGameObject(GameObject gameObject, Movement movement)
        {
            gameObject.setMovement(movement);
            addGameObject(gameObject);
        }
        public void addGameObject(GameObject gameObject)
        {
            gameObjects.Add(gameObject);
        }
        public void update()
        {
            foreach (GameObject gameObject in gameObjects)
                gameObject.update();
        }
    }
}
