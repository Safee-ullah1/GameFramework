
namespace GameProject
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
            this.gameLoopTimer = new System.Windows.Forms.Timer(this.components);
            this.objectCountLabel = new System.Windows.Forms.Label();
            this.alienPictureBox2 = new System.Windows.Forms.PictureBox();
            this.alienPictureBox1 = new System.Windows.Forms.PictureBox();
            this.alienPictureBox3 = new System.Windows.Forms.PictureBox();
            this.alienPictureBox4 = new System.Windows.Forms.PictureBox();
            this.shipPictureBox = new System.Windows.Forms.PictureBox();
            this.asteroidSpawnTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.alienPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameLoopTimer
            // 
            this.gameLoopTimer.Enabled = true;
            this.gameLoopTimer.Interval = 20;
            this.gameLoopTimer.Tick += new System.EventHandler(this.gameLoopTimer_Tick);
            // 
            // objectCountLabel
            // 
            this.objectCountLabel.AutoSize = true;
            this.objectCountLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.objectCountLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.objectCountLabel.Location = new System.Drawing.Point(12, 9);
            this.objectCountLabel.Name = "objectCountLabel";
            this.objectCountLabel.Size = new System.Drawing.Size(97, 22);
            this.objectCountLabel.TabIndex = 6;
            this.objectCountLabel.Text = "Objects: 0";
            // 
            // alienPictureBox2
            // 
            this.alienPictureBox2.Image = global::GameProject.Properties.Resources.alien;
            this.alienPictureBox2.Location = new System.Drawing.Point(12, 61);
            this.alienPictureBox2.Name = "alienPictureBox2";
            this.alienPictureBox2.Size = new System.Drawing.Size(92, 75);
            this.alienPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alienPictureBox2.TabIndex = 7;
            this.alienPictureBox2.TabStop = false;
            // 
            // alienPictureBox1
            // 
            this.alienPictureBox1.Image = global::GameProject.Properties.Resources.alien;
            this.alienPictureBox1.Location = new System.Drawing.Point(110, 61);
            this.alienPictureBox1.Name = "alienPictureBox1";
            this.alienPictureBox1.Size = new System.Drawing.Size(92, 75);
            this.alienPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alienPictureBox1.TabIndex = 8;
            this.alienPictureBox1.TabStop = false;
            // 
            // alienPictureBox3
            // 
            this.alienPictureBox3.Image = global::GameProject.Properties.Resources.alien;
            this.alienPictureBox3.Location = new System.Drawing.Point(593, 160);
            this.alienPictureBox3.Name = "alienPictureBox3";
            this.alienPictureBox3.Size = new System.Drawing.Size(92, 75);
            this.alienPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alienPictureBox3.TabIndex = 9;
            this.alienPictureBox3.TabStop = false;
            this.alienPictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // alienPictureBox4
            // 
            this.alienPictureBox4.Image = global::GameProject.Properties.Resources.alien;
            this.alienPictureBox4.Location = new System.Drawing.Point(691, 160);
            this.alienPictureBox4.Name = "alienPictureBox4";
            this.alienPictureBox4.Size = new System.Drawing.Size(92, 75);
            this.alienPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alienPictureBox4.TabIndex = 10;
            this.alienPictureBox4.TabStop = false;
            // 
            // shipPictureBox
            // 
            this.shipPictureBox.Image = global::GameProject.Properties.Resources.ship;
            this.shipPictureBox.Location = new System.Drawing.Point(319, 466);
            this.shipPictureBox.Name = "shipPictureBox";
            this.shipPictureBox.Size = new System.Drawing.Size(154, 113);
            this.shipPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shipPictureBox.TabIndex = 11;
            this.shipPictureBox.TabStop = false;
            // 
            // asteroidSpawnTimer
            // 
            this.asteroidSpawnTimer.Enabled = true;
            this.asteroidSpawnTimer.Interval = 10000;
            this.asteroidSpawnTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(6)))), ((int)(((byte)(34)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(this.shipPictureBox);
            this.Controls.Add(this.alienPictureBox4);
            this.Controls.Add(this.alienPictureBox3);
            this.Controls.Add(this.alienPictureBox1);
            this.Controls.Add(this.alienPictureBox2);
            this.Controls.Add(this.objectCountLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.alienPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        private System.Windows.Forms.Timer gameLoopTimer;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox leftwardEnemy;
        private System.Windows.Forms.Label objectCountLabel;
        private System.Windows.Forms.PictureBox alienPictureBox2;
        private System.Windows.Forms.PictureBox alienPictureBox1;
        private System.Windows.Forms.PictureBox alienPictureBox3;
        private System.Windows.Forms.PictureBox alienPictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox ship;
        private System.Windows.Forms.PictureBox shipPictureBox;
        private System.Windows.Forms.Timer asteroidSpawnTimer;
    }
}

