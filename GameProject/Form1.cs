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
            GameObject player = factory.createObject(shipPictureBox, MovementType.keyBoard, ObjectType.player);
            GameObject alien1 = factory.createObject(alienPictureBox1, MovementType.patrol, ObjectType.customMovementObject);
            GameObject alien2 = factory.createObject(alienPictureBox2, MovementType.patrol, ObjectType.customMovementObject);
            GameObject alien3 = factory.createObject(alienPictureBox3, MovementType.patrol, ObjectType.customMovementObject);
            GameObject alien4 = factory.createObject(alienPictureBox4, MovementType.patrol, ObjectType.customMovementObject);
            game.addGameObject(player);
            game.addGameObject(alien1);
            game.addGameObject(alien2);
            game.addGameObject(alien3);
            game.addGameObject(alien4);
            game.addCollision(new CollisionDetector(ObjectType.player, ObjectType.nonMovingObject, new DeleteObject(game, ObjectType.nonMovingObject)));
        }

        private void gameLoopTimer_Tick(object sender, EventArgs e)
        {
            game.update();
            
            objectCountLabel.Text = $"Objects: {factory.getTotalObjectsCount()}, Movements: NonMoving:{movementFactory.getCount(MovementType.nonMoving)}Left:{movementFactory.getCount(MovementType.left)} Right:{movementFactory.getCount(MovementType.right)} KeyBoard:{movementFactory.getCount(MovementType.keyBoard)}";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        void generateAsteroid()
        {
            PictureBox asteroidPictureBox = new PictureBox();
            asteroidPictureBox.Image = Properties.Resources.asteroid;
            asteroidPictureBox.Size = new System.Drawing.Size(100, 100);
            asteroidPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Random rando = new Random();
            asteroidPictureBox.Location = new System.Drawing.Point(rando.Next(1, this.Width));
            this.Controls.Add(asteroidPictureBox);
            game.addGameObject(factory.createObject(asteroidPictureBox, MovementType.down, ObjectType.customMovementObject));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            generateAsteroid();
        }
    }
}
