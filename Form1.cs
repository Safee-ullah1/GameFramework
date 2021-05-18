﻿using System;
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
        public Form1()
        {
            InitializeComponent();
            game = new Game();
            game.addGameObject(player1);
            game.addGameObject(enemy1);
            game.addGameObject(enemy2);
            game.addGameObject(enemy3);
        }

        private void gameLoopTimer_Tick(object sender, EventArgs e)
        {
            game.update();
        }
    }
}