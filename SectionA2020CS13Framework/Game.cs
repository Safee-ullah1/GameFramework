using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SectionA2020CS13Framework
{
    public class Game
    {
        List<GameObject> gameObjects = new List<GameObject>();
        List<CollisionDetector> collisions = new List<CollisionDetector>();
        private static Game gameInstance;
        static Form gameForm;
        static TileGrid tileGrid;
        static bool runSetup;
        public Form GameForm { set => gameForm = value; }
        private static readonly object locker = new object();
        private Game() { }
        public static Game Instance(string mapFilePath, Form gForm)
        {
            lock (locker)
            {
                if (gameInstance == null) gameInstance = new Game();
            }
            gameForm = gForm;
            tileGrid = new TileGrid(gForm.Height, gForm.Width, mapFilePath);
            runSetup = true;
            return gameInstance;
        }
        public static Game Instance()
        {
            lock (locker)
            {
                if (gameInstance == null) gameInstance = new Game();
            }
            return gameInstance;
        }
        public void addGameObject(GameObject gameObject)
        {
            gameObjects.Add(gameObject);
        }
        public void removeGameObject(GameObject gameObject)
        {
            gameObjects.Remove(gameObject);
        }
        public void addCollision(CollisionDetector collision)
        {
            collisions.Add(collision);
        }
        void setup()
        {
            tileGrid.fillScreem(gameForm);
        }
        public void update()
        {
            if (runSetup)
            {
                setup();
                runSetup = false;
            }
            foreach (CollisionDetector collision in collisions)
            {
                collision.check(gameObjects);
            }
            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.update();
            }
        }
    }
}
