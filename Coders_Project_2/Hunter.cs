using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coders_Project_2
{
    public partial class Hunter : Form
    {
        //declaring variablesw
        int score, x=300, y=150, remTime, rA,rAnIm, totalScore =0,aX = 472,aY = 192,anMaxWidth = 545,anMaxHeight = 290,lvl1W,lvl1H,gbDifLvl1,labelTimeLvl1,labelScoreLvl1,buttonExitLvl1;
        double hovPicW, hovPicH, hovPicPerW, hovPicPerH;

 
        private void pbAnimal_MouseEnter(object sender, EventArgs e)
        {
            //enlarge the image when mouse enters
            hovPicW = pbAnimal.Size.Width;
            hovPicH = pbAnimal.Size.Height;
            hovPicPerW = hovPicW;
            hovPicW *= 0.05;
            hovPicPerW += hovPicW;
            hovPicPerH = hovPicH;
            hovPicH *= 0.05;
            hovPicPerH += hovPicH;
            pbAnimal.Width = Convert.ToInt32(hovPicPerW);
            pbAnimal.Height = Convert.ToInt32(hovPicPerH);
        }

        private void pbAnimal_MouseLeave(object sender, EventArgs e)
        {
            //image back to it's position when mouse left
            hovPicW = pbAnimal.Size.Width;
            hovPicH = pbAnimal.Size.Height;
            hovPicPerW = hovPicW;
            hovPicW *= 0.05;
            hovPicPerW -= hovPicW;
            hovPicPerH = hovPicH;
            hovPicH *= 0.05;
            hovPicPerH -= hovPicH;
            pbAnimal.Width = Convert.ToInt32(hovPicPerW);
            pbAnimal.Height = Convert.ToInt32(hovPicPerH);
        }

        public Hunter(string userName)
        {
            InitializeComponent();
            changeCursor();
            labelWelcome.Text = "Welcome \n" +  userName + " !";
        }

        private void Hunter_Load(object sender, EventArgs e)
        {
            //get original size of items
            lvl1W = this.Size.Width;
            lvl1H = this.Size.Height;
            gbDifLvl1 = gbDifficulty.Location.Y;
            labelTimeLvl1 = labelTime.Location.Y;
            labelScoreLvl1 = labelScore.Location.Y;
            buttonExitLvl1 = buttonExit.Location.Y;
            this.CenterToScreen();
            
        }
        
        
        
        void changeCursor()//to sniper png 
        {
            Bitmap bmp = new Bitmap(Properties.Resources.sniperEdited);
            Cursor c = new Cursor(bmp.GetHicon());
            this.Cursor = c;
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (rbEasy.Checked != true && rbMedium.Checked != true && rbHard.Checked != true)
            {
                MessageBox.Show("Please choose the difficulty mode!");
            }
            else
            {
                this.CenterToScreen();
                pbAnimal.Visible = false;
                //if user restarted, back to original position and size
                this.Height = lvl1H;
                this.Width = lvl1W;
                gbDifficulty.Location = new Point(gbDifficulty.Location.X,gbDifLvl1);
                labelTime.Location = new Point(labelTime.Location.X, labelTimeLvl1);
                labelScore.Location = new Point(labelScore.Location.X, labelScoreLvl1);
                buttonExit.Location = new Point(buttonExit.Location.X, buttonExitLvl1);
                anMaxWidth = 545;
                anMaxHeight = 290;
                labelGameOver.Visible = false;
                Random rnd = new Random();
                x = rnd.Next(110, anMaxWidth);
                y = rnd.Next(1, anMaxHeight);
                pbAnimal.Visible = true;

                int labelGy = (this.Height / 2) - (labelGameOver.Height / 2);
                int labelGx = ((this.Width / 2)+50) - (labelGameOver.Width / 2);
                labelGameOver.Location = new Point(labelGx, labelGy);
                timerEnd.Start();
                if (rbEasy.Checked)
                {
                     remTime = 12;

                }
                else if (rbMedium.Checked)
                { 
                     remTime = 8;

                }
                else if (rbHard.Checked)
                {
                     remTime = 4;

                }
               
            }
            if (remTime != 0)
            {
                buttonStart.Enabled = false;
                rbEasy.Enabled = false;
                rbMedium.Enabled = false;
                rbHard.Enabled = false;

            }
         


        }
   
        public void pictureBox1_Click_1(object sender, EventArgs e)
        {
           
            pbAnimal.Visible = false;
            Random rnd = new Random();
            x = rnd.Next(110, anMaxWidth);
            y = rnd.Next(1, anMaxHeight);
            pbAnimal.Location = new Point(x, y);
            pbAnimal.Visible = true;
            score++;
            totalScore ++;
            labelScore.Text = "Score \n" + score;


            rA = rnd.Next(1, 8);
            rAnIm = rnd.Next(1, 6);
            switch (rAnIm)
            {
                case 1:
                 pbAnimal.Image = Properties.Resources.baboon;
                    break;
                case 2:
                    pbAnimal.Image = Properties.Resources.badger;
                    break;
                case 3:
                    pbAnimal.Image = Properties.Resources.bison;
                    break;
                case 4:
                    pbAnimal.Image = Properties.Resources.boar;
                    break;
                case 5:
                    pbAnimal.Image = Properties.Resources.caiman;
                    break;
                case 6:
                    pbAnimal.Image = Properties.Resources.deer;
                    break;
               
            }
            
            void LevelUp()
            {
                //increase size of a form on each level up
                this.Width += Convert.ToInt32(this.Width * 0.15);
                this.Height += Convert.ToInt32(this.Height * 0.14);
                gbGameMenu.Height += Convert.ToInt32(gbGameMenu.Height * 0.5);
                this.CenterToScreen();

                // move item location as level increases
                gbDifficulty.Top += Convert.ToInt32(gbDifficulty.Location.Y * 0.15);
                labelTime.Top += Convert.ToInt32(labelTime.Location.Y * 0.15);
                labelScore.Top += Convert.ToInt32(labelScore.Location.Y * 0.15);
                buttonExit.Top += Convert.ToInt32(buttonExit.Location.Y * 0.15);
               
                //for label
                labelGameOver.Width = this.Size.Width;
                labelGameOver.Height = this.Size.Height;

                //animal moving space
                anMaxWidth = this.Width -100;
                anMaxHeight = this.Height -100;

                //to center gameover label
                this.CenterToScreen();
                int labelGy = (this.Height / 2) - (labelGameOver.Height / 2);
                int labelGx = (this.Width / 2) - (labelGameOver.Width / 2);
                labelGameOver.Location = new Point(labelGx, labelGy);

            }

            if (totalScore == 8 || totalScore == 16 || totalScore == 24 || totalScore == 32 || totalScore == 40)
            {
                 LevelUp();
                
            }
        }
       
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            remTime--;
            labelTime.Text = "Time \n" + remTime;
            labelGameOver.Text = "total score" + totalScore;
            if (remTime == 1)
            {
                timerEnd.Stop();
                remTime += score;
                score = 0;
                labelScore.Text = "Score \n" + score;
                timerEnd.Start();
            }else if (remTime == 0)
            {
                score = 0;
                labelScore.Text = "Score \n" + score;
                timerEnd.Stop();
                pbAnimal.Visible = false;
                labelGameOver.Visible = true;
                labelGameOver.Text = "GAME IS OVER \n your score is \n" + totalScore;

                //for restarting the game
                totalScore = 0;
                buttonStart.Enabled = true;
                rbEasy.Enabled = true;
                rbMedium.Enabled = true;
                rbHard.Enabled = true;
            }
            
             
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void timerAnimalMove_Tick(object sender, EventArgs e)
        {
            anMaxWidth = this.Width - 100;
            anMaxHeight = this.Height - 100;
            //if animal moves where it is not seen
            if (x < 110)
            {
                rA = 4;
            }
             if (x > anMaxWidth)
            {
                rA = 7;
            }
             if (y < 1)
            {
                rA = 2;
            }
             if (y > anMaxHeight)
            {
                rA = 8;
            }

             //random moving sides
            switch (rA)
            {
                case 1:
                    aX = (x -= 1);
                    aY = (y += 1);
                    break;
                case 2:
                    aX = x;
                    aY = (y += 1);
                    break;
                case 3:
                    aX = (x += 1);
                    aY = (y += 1);
                    break;
                case 4:
                    aX = (x += 1);
                    aY = (y);
                    break;
                case 5:
                    aX = (x += 1);
                    aY = (y -= 1);
                    break;
                case 6:
                    aX = (x -= 1);
                    aY = (y -= 1);
                    break;
                case 7:
                    aX = (x -= 1);
                    aY = (y);
                    break;
                case 8:
                    aX = (x);
                    aY = (y -= 1);
                    break;
            }
            pbAnimal.Location = new Point(aX, aY);


           

        }
    }
}
