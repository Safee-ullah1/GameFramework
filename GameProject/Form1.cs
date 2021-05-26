using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SectionA2020CS13Framework;


namespace GameProject
{
    public partial class Form1 : Form
    {
        Game game;
        ObjectFactory factory;
        public Form1()
        {
            InitializeComponent();
            game = Game.Instance();
            factory = ObjectFactory.Instance();
            GameObject player = factory.createObject(playerPictureBox, new MovementWithKey(playerPictureBox, 15), ObjectType.player);
            GameObject circularPatrolEnemy = factory.createObject(CircularPictureBox, new MovementCircular(CircularPictureBox, 100), ObjectType.circlingEnemy);
            GameObject upDownPatrolEnemy = factory.createObject(UDPatrolPictureBox, new MovementPatrol(500, 5, PatrolMode.upDown), ObjectType.patrollingEnemy);
            GameObject leftRightPatrolEnemy = factory.createObject(LRPatrolPictureBox, new MovementPatrol(500, 5, PatrolMode.leftRight), ObjectType.patrollingEnemy);
            GameObject rightwardEnemy = factory.createObject(rightwardPictureBox, new MovementRight(5), ObjectType.rightMovingEnemy);
            GameObject leftwardEnemy = factory.createObject(leftwardPictureBox, new MovementLeft(5), ObjectType.leftMovingEnemy);
            game.addGameObject(player);
            game.addGameObject(circularPatrolEnemy);
            game.addGameObject(upDownPatrolEnemy);
            game.addGameObject(leftRightPatrolEnemy);
            game.addGameObject(rightwardEnemy);
            game.addGameObject(leftwardEnemy);
        }
        
        private void gameLoopTimer_Tick(object sender, EventArgs e)
        {
            game.update();
            objectCountLabel.Text = $"Objects: {factory.getTotalObjectsCount()}";
        }
    }
}
