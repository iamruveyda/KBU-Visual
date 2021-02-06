
namespace CarBump
{
    partial class carGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(carGame));
            this.pnlGame = new System.Windows.Forms.Panel();
            this.player = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.roadLine1 = new System.Windows.Forms.PictureBox();
            this.roadLine2 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gameOver = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadLine2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.Silver;
            this.pnlGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGame.Controls.Add(this.player);
            this.pnlGame.Controls.Add(this.car2);
            this.pnlGame.Controls.Add(this.car1);
            this.pnlGame.Controls.Add(this.roadLine1);
            this.pnlGame.Controls.Add(this.roadLine2);
            this.pnlGame.Location = new System.Drawing.Point(-3, -3);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(453, 610);
            this.pnlGame.TabIndex = 0;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(197, 453);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(45, 90);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 8;
            this.player.TabStop = false;
            // 
            // car2
            // 
            this.car2.BackColor = System.Drawing.Color.Transparent;
            this.car2.Image = ((System.Drawing.Image)(resources.GetObject("car2.Image")));
            this.car2.Location = new System.Drawing.Point(289, 22);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(45, 90);
            this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car2.TabIndex = 7;
            this.car2.TabStop = false;
            // 
            // car1
            // 
            this.car1.BackColor = System.Drawing.Color.Transparent;
            this.car1.Image = ((System.Drawing.Image)(resources.GetObject("car1.Image")));
            this.car1.Location = new System.Drawing.Point(118, 22);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(45, 90);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car1.TabIndex = 6;
            this.car1.TabStop = false;
            // 
            // roadLine1
            // 
            this.roadLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roadLine1.Location = new System.Drawing.Point(212, 453);
            this.roadLine1.Name = "roadLine1";
            this.roadLine1.Size = new System.Drawing.Size(16, 100);
            this.roadLine1.TabIndex = 5;
            this.roadLine1.TabStop = false;
            // 
            // roadLine2
            // 
            this.roadLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roadLine2.Location = new System.Drawing.Point(212, 64);
            this.roadLine2.Name = "roadLine2";
            this.roadLine2.Size = new System.Drawing.Size(16, 100);
            this.roadLine2.TabIndex = 4;
            this.roadLine2.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(456, 4);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(130, 34);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "Score : 0";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.ForeColor = System.Drawing.Color.White;
            this.lblSpeed.Location = new System.Drawing.Point(456, 43);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(137, 34);
            this.lblSpeed.TabIndex = 10;
            this.lblSpeed.Text = "Speed : 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(456, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "High Score : ";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.BackColor = System.Drawing.Color.Transparent;
            this.lblHighScore.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.ForeColor = System.Drawing.Color.White;
            this.lblHighScore.Location = new System.Drawing.Point(628, 80);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(32, 34);
            this.lblHighScore.TabIndex = 12;
            this.lblHighScore.Text = "0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Cooper Std Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 40);
            this.label2.TabIndex = 14;
            this.label2.Text = "Use left , right arrow keys to \r\nmove the car";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Hobo Std", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(39, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 72);
            this.label3.TabIndex = 15;
            this.label3.Text = "800    -  1500    -> Bronze\r\n1500  -  3000    -> Silver\r\n3000  -   ∞        -> Go" +
    "ld";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(502, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 186);
            this.panel1.TabIndex = 16;
            // 
            // gameOver
            // 
            this.gameOver.Location = new System.Drawing.Point(522, 122);
            this.gameOver.Name = "gameOver";
            this.gameOver.Size = new System.Drawing.Size(236, 101);
            this.gameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameOver.TabIndex = 13;
            this.gameOver.TabStop = false;
            this.gameOver.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarBump.Properties.Resources.CarBump;
            this.pictureBox1.Location = new System.Drawing.Point(748, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // carGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(837, 601);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gameOver);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pnlGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "carGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarBump!";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.carGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.carGame_KeyUp);
            this.pnlGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadLine2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.PictureBox roadLine1;
        private System.Windows.Forms.PictureBox roadLine2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox gameOver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

