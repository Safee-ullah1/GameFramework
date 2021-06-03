using SectionA2020CS13Framework;
using System;
using System.Windows.Forms;


namespace GameProject
{
    public partial class Form1 : Form
    {
        Game game;
        ObjectFactory factory;
        MovementFactory movementFactory;
        public Form1()
        {
            InitializeComponent();
            game = Game.Instance("bg.txt", this);
            factory = ObjectFactory.Instance();
            movementFactory = MovementFactory.Instance();
            GameObject player = factory.createObject(playerPictureBox, MovementType.keyBoard, ObjectType.player);
            GameObject stillEnemy = factory.createObject(CircularPictureBox, MovementType.nonMoving, ObjectType.nonMovingObject);
            game.addGameObject(player);

            game.addGameObject(stillEnemy);
            game.addGameObject(factory.createObject(UDPatrolPictureBox, MovementType.left, ObjectType.leftMovingEnemy));
            game.addGameObject(factory.createObject(LRPatrolPictureBox, MovementType.right, ObjectType.rightMovingEnemy));
            game.addGameObject(factory.createObject(rightwardPictureBox, MovementType.right, ObjectType.rightMovingEnemy));
            game.addGameObject(factory.createObject(leftwardPictureBox, MovementType.left, ObjectType.leftMovingEnemy));
            game.addCollision(new CollisionDetector(ObjectType.player, ObjectType.nonMovingObject, new DeleteObject(game, ObjectType.nonMovingObject)));
        }

        private void gameLoopTimer_Tick(object sender, EventArgs e)
        {
            game.update();
            objectCountLabel.Text = $"Objects: {factory.getTotalObjectsCount()}, Movements: NonMoving:{movementFactory.getCount(MovementType.nonMoving)}Left:{movementFactory.getCount(MovementType.left)} Right:{movementFactory.getCount(MovementType.right)} KeyBoard:{movementFactory.getCount(MovementType.keyBoard)}";
        }
    }
}
