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
            game = Game.Instance();
            factory = ObjectFactory.Instance();
            movementFactory = MovementFactory.Instance();
            game.addGameObject(factory.createObject(playerPictureBox, MovementType.keyBoard, ObjectType.player, 0));
            game.addGameObject(factory.createObject(CircularPictureBox, MovementType.left, ObjectType.circlingEnemy));
            game.addGameObject(factory.createObject(UDPatrolPictureBox, MovementType.left, ObjectType.patrollingEnemy));
            game.addGameObject(factory.createObject(LRPatrolPictureBox, MovementType.right, ObjectType.patrollingEnemy));
            game.addGameObject(factory.createObject(rightwardPictureBox, MovementType.right, ObjectType.rightMovingEnemy));
            game.addGameObject(factory.createObject(leftwardPictureBox, MovementType.left, ObjectType.leftMovingEnemy));
        }

        private void gameLoopTimer_Tick(object sender, EventArgs e)
        {
            game.update();
            objectCountLabel.Text = $"Objects: {factory.getTotalObjectsCount()}, Movements: Left:{movementFactory.getCount(MovementType.left)} Right:{movementFactory.getCount(MovementType.right)} KeyBoard:{movementFactory.getCount(MovementType.keyBoard)}";
        }
    }
}
