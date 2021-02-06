using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CarBump
{
    public partial class carGame : Form
    {
        public carGame()
        {
            InitializeComponent();
            HighScore();
        }

        //variables
        int speed = 6;
        int score = 0;
        bool left = false, right = false;


        Random r = new Random();


        //high score
        private void HighScore()
        {

            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string user = Environment.UserName;
            string FilePath = @"C:\Users\" + user + @"\Documents\Car Game High Score.txt";

        Start:
            if (File.Exists(FilePath))
            {

                StreamReader Sr = new StreamReader(FilePath);
                lblHighScore.Text = Sr.ReadToEnd();
                Sr.Close();
                int HighScore = int.Parse(lblHighScore.Text);

                if (score > HighScore)
                {
                    lblHighScore.Text = score.ToString();
                    StreamWriter Sw = new StreamWriter(FilePath);
                    Sw.Write(lblHighScore.Text);
                    Sw.Close();
                }
            }
            else
            {
                using (StreamWriter Sw = File.AppendText(FilePath))
                {
                    Sw.Write("0");
                    Sw.Close();
                }
                goto Start;
            }

        }

        //key down
        private void carGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                right = true;
            }

        }

        //key up
        private void carGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
        }


        //game timer
        private void gameTimerEvent(object sender, EventArgs e)
        {
            score++;
            lblScore.Text = "Score : " + score;
            lblSpeed.Text = "Speed : " + (speed * 10);


            //player
            if (right == true && player.Left < (pnlGame.Width - player.Width - 5))
            {
                player.Left += speed;
            }
            else if (left == true && player.Left > 5)
            {
                player.Left -= speed;
            }

            //roadline
            roadLine1.Top += speed;
            roadLine2.Top += speed;
            roadLine1.Left = pnlGame.Width / 2 - 8;
            roadLine2.Left = pnlGame.Width / 2 - 8;

            if (roadLine1.Top > pnlGame.Height)
            {
                roadLine1.Top = -roadLine1.Height;
            }
            if (roadLine2.Top > pnlGame.Height)
            {
                roadLine2.Top = -roadLine2.Height;
            }


            //car1 car2
            car1.Top += speed;
            car2.Top += speed;
            if (car1.Top > pnlGame.Height)
            {

                car1.Top = -car1.Height;
                car1.Left = r.Next(5, (pnlGame.Width / 2) - car1.Width - 15);
                int carImage = r.Next(1, 8);
                if (carImage == 1) car1.Image = Properties.Resources.car1;
                else if (carImage == 2) car1.Image = Properties.Resources.car2;
                else if (carImage == 3) car1.Image = Properties.Resources.car3;
                else if (carImage == 4) car1.Image = Properties.Resources.car4;
                else if (carImage == 5) car1.Image = Properties.Resources.car5;
                else if (carImage == 6) car1.Image = Properties.Resources.car6;
                else car1.Image = Properties.Resources.car7;

            }
            if (car2.Top > pnlGame.Height)
            {
                car2.Visible = false;
                car2.Top = -car2.Height;
                car2.Left = r.Next((pnlGame.Width / 2) + 5, (pnlGame.Width - car2.Width - 5));
                int carImage = r.Next(1, 8);
                if (carImage == 1) car2.Image = Properties.Resources.car1;
                else if (carImage == 2) car2.Image = Properties.Resources.car2;
                else if (carImage == 3) car2.Image = Properties.Resources.car3;
                else if (carImage == 4) car2.Image = Properties.Resources.car4;
                else if (carImage == 5) car2.Image = Properties.Resources.car5;
                else if (carImage == 6) car2.Image = Properties.Resources.car6;
                else car2.Image = Properties.Resources.car7;
                car2.Visible = true;
            }


            //speed control
            if (score > 500) speed = 8;
            if (score > 1000) speed = 10;
            if (score > 1500) speed = 12;
            if (score > 2000) speed = 14;
            if (score > 2500) speed = 16;


            //game over
            if (player.Bounds.IntersectsWith(car1.Bounds) || player.Bounds.IntersectsWith(car2.Bounds))
            {
                HighScore();
                System.Media.SoundPlayer crash = new System.Media.SoundPlayer(Properties.Resources.hit);
                crash.Play();


                gameTimer.Stop();

                gameOver.Visible = true;

                if (score > 0 && score <= 800)
                {
                    gameOver.Image = Properties.Resources.lose;
                }

                if (score > 800 && score <= 1500)
                {
                    gameOver.Image = Properties.Resources.bronze;
                }

                if (score > 1500 && score <= 3000)
                {
                    gameOver.Image = Properties.Resources.silver;
                }
                if (score > 3000)
                {
                    gameOver.Image = Properties.Resources.gold;
                }


                if (MessageBox.Show("Would you like to play again?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    GameReset();

                }
                else
                    this.Close();

            }
        }


        // game reset
        private void GameReset()
        {

            gameOver.Visible = false;
      

            speed = 6;
            score = 0;
            left = false;
            right = false;


            car1.Left = r.Next(5, (pnlGame.Width / 2) - car1.Width - 15);
            car1.Top = -car1.Height;

            car2.Left = r.Next((pnlGame.Width / 2) + 5, (pnlGame.Width - car2.Width - 5));
            car2.Top = -car2.Height;

            player.Left = pnlGame.Width / 2 - 22;

            gameTimer.Start();

        }


    }
}
