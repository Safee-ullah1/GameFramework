
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
            this.gameLoopTimer = new System.Windows.Forms.Timer(this.components);
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.CircularPictureBox = new System.Windows.Forms.PictureBox();
            this.UDPatrolPictureBox = new System.Windows.Forms.PictureBox();
            this.LRPatrolPictureBox = new System.Windows.Forms.PictureBox();
            this.rightwardPictureBox = new System.Windows.Forms.PictureBox();
            this.leftwardPictureBox = new System.Windows.Forms.PictureBox();
            this.objectCountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircularPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDPatrolPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LRPatrolPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightwardPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftwardPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameLoopTimer
            // 
            this.gameLoopTimer.Enabled = true;
            this.gameLoopTimer.Interval = 20;
            this.gameLoopTimer.Tick += new System.EventHandler(this.gameLoopTimer_Tick);
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.Image = global::GameFramework.Properties.Resources.Player;
            this.playerPictureBox.Location = new System.Drawing.Point(56, 61);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(93, 97);
            this.playerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPictureBox.TabIndex = 0;
            this.playerPictureBox.TabStop = false;
            // 
            // CircularPictureBox
            // 
            this.CircularPictureBox.Image = global::GameFramework.Properties.Resources.Enemy;
            this.CircularPictureBox.Location = new System.Drawing.Point(354, 326);
            this.CircularPictureBox.Name = "CircularPictureBox";
            this.CircularPictureBox.Size = new System.Drawing.Size(93, 97);
            this.CircularPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CircularPictureBox.TabIndex = 1;
            this.CircularPictureBox.TabStop = false;
            // 
            // UDPatrolPictureBox
            // 
            this.UDPatrolPictureBox.Image = global::GameFramework.Properties.Resources.Enemy;
            this.UDPatrolPictureBox.Location = new System.Drawing.Point(627, 42);
            this.UDPatrolPictureBox.Name = "UDPatrolPictureBox";
            this.UDPatrolPictureBox.Size = new System.Drawing.Size(93, 97);
            this.UDPatrolPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UDPatrolPictureBox.TabIndex = 2;
            this.UDPatrolPictureBox.TabStop = false;
            // 
            // LRPatrolPictureBox
            // 
            this.LRPatrolPictureBox.Image = global::GameFramework.Properties.Resources.Enemy;
            this.LRPatrolPictureBox.Location = new System.Drawing.Point(12, 326);
            this.LRPatrolPictureBox.Name = "LRPatrolPictureBox";
            this.LRPatrolPictureBox.Size = new System.Drawing.Size(93, 97);
            this.LRPatrolPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LRPatrolPictureBox.TabIndex = 3;
            this.LRPatrolPictureBox.TabStop = false;
            // 
            // rightwardPictureBox
            // 
            this.rightwardPictureBox.Image = global::GameFramework.Properties.Resources.Enemy;
            this.rightwardPictureBox.Location = new System.Drawing.Point(354, 200);
            this.rightwardPictureBox.Name = "rightwardPictureBox";
            this.rightwardPictureBox.Size = new System.Drawing.Size(93, 97);
            this.rightwardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightwardPictureBox.TabIndex = 4;
            this.rightwardPictureBox.TabStop = false;
            // 
            // leftwardPictureBox
            // 
            this.leftwardPictureBox.Image = global::GameFramework.Properties.Resources.Enemy;
            this.leftwardPictureBox.Location = new System.Drawing.Point(354, 429);
            this.leftwardPictureBox.Name = "leftwardPictureBox";
            this.leftwardPictureBox.Size = new System.Drawing.Size(93, 97);
            this.leftwardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftwardPictureBox.TabIndex = 5;
            this.leftwardPictureBox.TabStop = false;
            // 
            // objectCountLabel
            // 
            this.objectCountLabel.AutoSize = true;
            this.objectCountLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.objectCountLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.objectCountLabel.Location = new System.Drawing.Point(336, 9);
            this.objectCountLabel.Name = "objectCountLabel";
            this.objectCountLabel.Size = new System.Drawing.Size(122, 27);
            this.objectCountLabel.TabIndex = 6;
            this.objectCountLabel.Text = "Objects: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(6)))), ((int)(((byte)(34)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(this.objectCountLabel);
            this.Controls.Add(this.leftwardPictureBox);
            this.Controls.Add(this.rightwardPictureBox);
            this.Controls.Add(this.LRPatrolPictureBox);
            this.Controls.Add(this.UDPatrolPictureBox);
            this.Controls.Add(this.CircularPictureBox);
            this.Controls.Add(this.playerPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircularPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDPatrolPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LRPatrolPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightwardPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftwardPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        private System.Windows.Forms.Timer gameLoopTimer;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox CircularPictureBox;
        private System.Windows.Forms.PictureBox UDPatrolPictureBox;
        private System.Windows.Forms.PictureBox LRPatrolPictureBox;
        private System.Windows.Forms.PictureBox rightwardPictureBox;
        private System.Windows.Forms.PictureBox leftwardEnemy;
        private System.Windows.Forms.PictureBox leftwardPictureBox;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.Label objectCountLabel;
    }
}

