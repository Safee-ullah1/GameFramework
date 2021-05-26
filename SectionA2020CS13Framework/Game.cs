using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SectionA2020CS13Framework
{
    public class Game
    {
        List<GameObject> gameObjects = new List<GameObject>();
        private static Game gameInstance;
        private Game() { }
        public static Game Instance()
        {
            if (gameInstance == null)
                gameInstance = new Game();
            return gameInstance;
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
