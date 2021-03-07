using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace RUSSIAN_ROULETTE_GAME
{
    public partial class frmRussianRoulette : Form
    {
        Game Obj_game = new Game();
        Random Rnd_Spin = new Random(); // Random No for the spin

       
        public frmRussianRoulette()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            proBarRounds.Maximum = 6;
         }

        private void frmRussianRoulette_Load(object sender, EventArgs e)
        {
            btnSpin.Focus();
            Default_Events();
            btnPlayAgain.Visible = false;
            //btnPlaySameUser.Enabled = false;
           
         }

        
        private void btnShootU_Click(object sender, EventArgs e)
        {
            /* Shoot YourSelf */
             PBChamberSpin.Image = Properties.Resources.Gun_Right1;
           
            //lblChamber.Text = ChamberPull.ToString(); //To Know How many shots fired
            if (Obj_game.PlayerGun[Obj_game.ChamberPull] == 1)

            {
                Play_GunFire();
                PBBulletR.Image = Properties.Resources.Bullet_Right;
                PBBulletR.Left = PBBulletR.Left + 85; Obj_game.Bullet_Right = 80; Obj_game.Bullet_Left = 0;
                pbGameFrame.Image = Properties.Resources.Person_Dead;
                lblGameMessage.Text = "     Oops..Bad Luck..  ";
                lblGameMessage1.Text = "Load Bullet and Spin";
                Obj_game.Round_Status = true; // Round Over
                RoundOver(Obj_game.Round_Status);
                Obj_game.Game_Round++; lblRounds.Text = Obj_game.Game_Round.ToString();
            }
            else
            {
                /* Gun not fired */
                Play_DryFire();
                lblGameMessage.Text = "     Lucky You.. Try Next Shot   ";
                lblGameMessage1.Text = "          SHOOT        ";
                Obj_game.ChamberPull++;
                Obj_game.Shoot_Away = 0;
                Obj_game.Player_Scores += 10; lblScore.Text = Obj_game.Player_Scores.ToString();
            }
            if (Obj_game.Game_Round > 6) 
                {
                Obj_game.Player_Scores += Obj_game.Bonus_Points;
                f_GameOver();
                }
        }

        private void btnShootC_Click(object sender, EventArgs e)
        {
            /* Shoot Away */
            PBChamberSpin.Image = Properties.Resources.Gun_Left1;
           // lblChamber.Text = ChamberPull.ToString();
            if (Obj_game.PlayerGun[Obj_game.ChamberPull] == 1)
            { /* Gun fired in shoot away */
                Play_GlassBoken();
                PBBulletL.Image = Properties.Resources.Bullet_Left;                
                PBBulletL.Left = PBBulletL.Left -120; Obj_game.Bullet_Left = 120; Obj_game.Bullet_Right = 0;
                Obj_game.Player_Scores += Obj_game.Bonus_Points; lblScore.Text = Obj_game.Player_Scores.ToString();
                Obj_game.Game_Round++; lblRounds.Text = Obj_game.Game_Round.ToString();
                lblGameMessage.Text = "Lucky..You Won..100 Bonus Points.";
                lblGameMessage1.Text = " Load Bullet and Spin ";
                btnSpin.Focus();
                Obj_game.Round_Status = false;
                PBShootAwayFrame.Image = Properties.Resources.ShootAwayBroken;                
                //MessageBox.Show("Survived and next round");
                RoundOver(Obj_game.Game_Status);//Round over     
            }
            else
             {
                /* Gun not fired in shoot away */
                Play_DryFire();
                Obj_game.ChamberPull++;
                Obj_game.Shoot_Away++;//MessageBox.Show("Shoot Away Chance" + Shoot_Away.ToString());
                lblGameMessage.Text = "   You Lost 1 Shoot Away Chance  ";
            }
            if (Obj_game.Shoot_Away >= 2) /*shoot away counting only 2 chances allowed*/
            {   btnShootC.Enabled = false; btnShootU.Focus();
                lblGameMessage.Text = "   Bad Luck..Nomore Shoot Away  ";
                lblGameMessage1.Text = "    Shoot Yourself    ";
                Obj_game.ChamberPull = Obj_game.PlayerChamber; //Shoot U on the next click
            }

            if (Obj_game.Game_Round > 6)/* Total 6 rounds on the basis of 6 Bullets per Game */
            {

                Obj_game.Player_Scores += Obj_game.Bonus_Points;
                 f_GameOver();
            }
        }


        private void btnSpin_Click(object sender, EventArgs e)

        {/* Loading and Spinning Gun Chamber */
            Obj_game.File_Flag = true;
            btnSpin.Enabled = false;
            btnExit.Enabled = false;
            PBBulletR.Image = null; //Bulet image space adjuster
            PBBulletL.Image = null;

            lblGameMessage.Text = "  Shoot Yourself or Shoot Away..";
            lblGameMessage1.Text = "Click the Buttons Below";
            if (Obj_game.Game_Round <= 6)
            {
                Obj_game.Seconds = 0;
                Obj_game.PlayerChamber = Rnd_Spin.Next(0, 6);
                lblC.Text = Convert.ToString(Obj_game.PlayerChamber);
                TimerChamberLoad.Start();
                PBChamberSpin.Image = Properties.Resources.chamber_Spin;
                Obj_game.PlayerGun[Obj_game.PlayerChamber] = 1;
                proBarRounds.PerformStep();
                Obj_game.ChamberPull = 0; Obj_game.Shoot_Away = 0;
                
            }
            else
            {
                f_GameOver();                 
            }

            if (PBShootAwayFrame.Image != Properties.Resources.ShootAway1|| pbGameFrame.Image != Properties.Resources.Person1)
            {
                PBShootAwayFrame.Image = Properties.Resources.ShootAway1;
                pbGameFrame.Image = Properties.Resources.Person1;
            }
               PBBulletR.Left -= Obj_game.Bullet_Right; PBBulletL.Left += Obj_game.Bullet_Left; //Adjusting the Bullet image
          
            
        }
        public void RoundOver(bool Round_Status)/* Going to Next Round of Game*/
        {
            if (Round_Status == true)
            {   
                /* Going to next round after firing bullet at Shoot Yourself */
                btnSpin.Enabled = true;btnSpin.Focus();
                lblScore.Text = Obj_game.Player_Scores.ToString();
                Obj_game.Loss++; lblWinLoss.Text = Obj_game.Win + " / " + Obj_game.Loss;
                Obj_game.ChamberPull = 0;
                Clear_Gun();            
                Round_Status = false;
            }
            else
            {
                /* Going to next round after firing bullet at Shoot Away */
                btnSpin.Enabled = true;
                Obj_game.Win++; lblWinLoss.Text = Obj_game.Win + " / " + Obj_game.Loss;
                lblRounds.Text = Obj_game.Game_Round.ToString();
                Obj_game.ChamberPull = 0;       
                Clear_Gun();
            }


        }
        public void f_GameOver() /*Game Over after 6 Rounds */
        {
            btnSpin.Enabled = true;
          
            //dgvScores.Rows.Clear();
             Default_Events();
            Obj_game.Player_Scores = 0;
            Obj_game.ChamberPull = 0;           
            proBarRounds.Value = 0;
            Obj_game.Game_Round = 0;
            Obj_game.Game_Status = false;
            Clear_Gun();
            lblRounds.Text = "6";   
            lblGameMessage.Text =  "!!!  NO MORE BULLETS  GAME OVER  !!!    ";
            lblGameMessage1.Text = "   !!!  PLAY AGAIN   !!!         ";
            btnSpin.Visible = false;
            btnShootU.Enabled = false;
            btnShootC.Enabled = false;
            //btnPlaySameUser.Enabled = true;
            btnPlayAgain.Visible = true;btnPlayAgain.Focus();
            
          
            
        }
        public void Default_Events() //Load Event Initializing
        {
            btnShootC.Enabled = false;
            btnShootU.Enabled = false;
            proBarRounds.Step = Obj_game.Game_Round;
            lblRounds.Text = Obj_game.Game_Round.ToString();
            lblScore.Text = Obj_game.Player_Scores.ToString();
            //lblChamber.Text = ChamberPull.ToString();
             lblWinLoss.Text = "0 / 0";
            pbGameFrame.SizeMode = PictureBoxSizeMode.StretchImage;
            PBChamberSpin.SizeMode = PictureBoxSizeMode.StretchImage;
            PBShootAwayFrame.SizeMode = PictureBoxSizeMode.StretchImage;
            PBBulletR.SizeMode = PictureBoxSizeMode.StretchImage;
            PBBulletL.SizeMode = PictureBoxSizeMode.StretchImage;
            
            lblC.Visible = false;       
            lblChamber.Visible = false;

        }
        
        // To Change Gun Positions on Mouse Over
       
        private void btnShootU_MouseMove(object sender, MouseEventArgs e)
        {
            if (PBChamberSpin.Image != Properties.Resources.Gun_Right1)
            {
                PBChamberSpin.Image = Properties.Resources.Gun_Right1;
            }
        }

        private void btnShootC_MouseMove(object sender, MouseEventArgs e)
        {
            if (PBChamberSpin.Image != Properties.Resources.Gun_Left1)
            {
                PBChamberSpin.Image = Properties.Resources.Gun_Left1;
            }
        }

        // Function to Write Scores in to a File Scores.txt
      
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            if (!Obj_game.File_Flag)
            {
                Obj_game.File_Flag = false;
                this.Close();              
            }
            else
            {                
                this.Close();
            }
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Timer for Chamber load image,sound and buttons
        private void TimerChamberLoad_Tick(object sender, EventArgs e)
        {
            Obj_game.Seconds++;
            if (Obj_game.Seconds == 1) { Play_ChamberLoad(); }
            if (Obj_game.Seconds == 2)
            {
                //MessageBox.Show(Seconds.ToString());
                pbGameFrame.Image = Properties.Resources.Person1;
                PBChamberSpin.Image = Properties.Resources.Gun_Right1;
                PBShootAwayFrame.Image = Properties.Resources.ShootAway1;
                    TimerChamberLoad.Stop();
                Obj_game.Seconds = 0;
                btnShootU.Enabled = true;
                btnShootC.Enabled = true;
                btnSpin.Enabled = false;
                btnShootU.Focus();
                btnExit.Enabled = true;
            }
        }

        // Reading from score file..
        //Sounds
        public void Play_GunFire()
        {
            SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.GunFire);
            player.Play();
        }
        public void Play_DryFire()
        {
            SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.DryFire);
            player.Play();
        }
        public void Play_ChamberLoad()
        {
            SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Reload);
            player.Play();
        }
        public void Play_GlassBoken()
        {
            SoundPlayer player1 = new System.Media.SoundPlayer(Properties.Resources.GlassBroken);
            player1.Play();
        }

        private void btnPlaySameUser_Click(object sender, EventArgs e)
        {
            frmRussianRoulette Same_User = new frmRussianRoulette();
            this.Close();
            Same_User.Show();
        }

        //Function to clear PlayerGun Array
        public void Clear_Gun()
        {
            for (int i = 0; i < 6; i++) { Obj_game.PlayerGun[i] = 0; }
            btnShootC.Enabled = false;
            btnShootU.Enabled = false;
        }
    }
}
  
        
