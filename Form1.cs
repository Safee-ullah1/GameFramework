using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    public partial class Form1 : Form
    {
        Game game;
        ObjectCounter counter = ObjectCounter.Instance();
        public Form1()
        {
            InitializeComponent();
            game = Game.Instance();
            GameObject player = new GameObject(playerPictureBox, new MovementWithKey(playerPictureBox, 15));
            GameObject circularPatrolEnemy = new GameObject(CircularPictureBox, new MovementCircular(CircularPictureBox, 100));
            GameObject upDownPatrolEnemy = new GameObject(UDPatrolPictureBox, new MovementPatrol(500, 5, PatrolMode.upDown));
            GameObject leftRightPatrolEnemy = new GameObject(LRPatrolPictureBox, new MovementPatrol(500, 5, PatrolMode.leftRight));
            GameObject rightwardEnemy = new GameObject(rightwardPictureBox, new MovementRight(5));
            GameObject leftwardEnemy = new GameObject(leftwardPictureBox, new MovementLeft(5));
            game.addGameObject(player);
            game.addGameObject(circularPatrolEnemy);
            game.addGameObject(upDownPatrolEnemy);
            game.addGameObject(upDownPatrolEnemy);
            game.addGameObject(leftRightPatrolEnemy);
            game.addGameObject(rightwardEnemy);
            game.addGameObject(leftwardEnemy);
        }

        private void gameLoopTimer_Tick(object sender, EventArgs e)
        {
            game.update();
            objectCountLabel.Text = $"Objects: {counter.ObjectCount}";
        }
    }
}
