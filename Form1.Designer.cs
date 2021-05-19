
namespace GameFramework
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.player1 = new GameFramework.Player();
            this.enemy1 = new GameFramework.Enemy();
            this.enemy2 = new GameFramework.Enemy();
            this.enemy3 = new GameFramework.Enemy();
            this.gameLoopTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.Gravity = 1F;
            this.player1.Image = global::GameFramework.Properties.Resources.Player;
            this.player1.Location = new System.Drawing.Point(68, 2);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(61, 76);
            this.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1.TabIndex = 0;
            this.player1.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.White;
            this.enemy1.Gravity = 0.5F;
            this.enemy1.Image = global::GameFramework.Properties.Resources.Enemy;
            this.enemy1.Location = new System.Drawing.Point(320, 91);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(55, 58);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 1;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.White;
            this.enemy2.Gravity = 0.5F;
            this.enemy2.Image = global::GameFramework.Properties.Resources.Enemy;
            this.enemy2.Location = new System.Drawing.Point(157, 132);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(55, 58);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 2;
            this.enemy2.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.BackColor = System.Drawing.Color.White;
            this.enemy3.Gravity = 0.5F;
            this.enemy3.Image = global::GameFramework.Properties.Resources.Enemy;
            this.enemy3.Location = new System.Drawing.Point(415, 91);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(55, 58);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 3;
            this.enemy3.TabStop = false;
            // 
            // gameLoopTimer
            // 
            this.gameLoopTimer.Enabled = true;
            this.gameLoopTimer.Interval = 20;
            this.gameLoopTimer.Tick += new System.EventHandler(this.gameLoopTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.player1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Player player1;
        private Enemy enemy1;
        private Enemy enemy2;
        private Enemy enemy3;
        private System.Windows.Forms.Timer gameLoopTimer;
    }
}

