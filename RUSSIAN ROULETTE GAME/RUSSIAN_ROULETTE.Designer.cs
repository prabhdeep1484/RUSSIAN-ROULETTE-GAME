namespace RUSSIAN_ROULETTE_GAME
{
    partial class frmRussianRoulette
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
            this.btnShootU = new System.Windows.Forms.Button();
            this.btnShootC = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.lblChamber = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblRounds = new System.Windows.Forms.Label();
            this.lblGameRound = new System.Windows.Forms.Label();
            this.proBarRounds = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TimerChamberLoad = new System.Windows.Forms.Timer(this.components);
            this.gbTitle = new System.Windows.Forms.GroupBox();
            this.lblWinLoss = new System.Windows.Forms.Label();
            this.lblWL = new System.Windows.Forms.Label();
            this.lblScoreL = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProBarBullets6 = new System.Windows.Forms.Label();
            this.lblProBarBullets5 = new System.Windows.Forms.Label();
            this.lblProBarBullets4 = new System.Windows.Forms.Label();
            this.lblProBarBullets3 = new System.Windows.Forms.Label();
            this.lblProBarBullets2 = new System.Windows.Forms.Label();
            this.lblProBarBullets1 = new System.Windows.Forms.Label();
            this.lblProBars = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.PanelMessage = new System.Windows.Forms.Panel();
            this.lblGameMessage = new System.Windows.Forms.Label();
            this.lblGameMessage1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.PBBulletL = new System.Windows.Forms.PictureBox();
            this.PBBulletR = new System.Windows.Forms.PictureBox();
            this.PBShootAwayFrame = new System.Windows.Forms.PictureBox();
            this.pbGameFrame = new System.Windows.Forms.PictureBox();
            this.PBChamberSpin = new System.Windows.Forms.PictureBox();
            this.lblC = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSubTiltle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.gbTitle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PanelMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBBulletL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBBulletR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBShootAwayFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBChamberSpin)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShootU
            // 
            this.btnShootU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnShootU.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShootU.Location = new System.Drawing.Point(709, 384);
            this.btnShootU.Margin = new System.Windows.Forms.Padding(4);
            this.btnShootU.Name = "btnShootU";
            this.btnShootU.Size = new System.Drawing.Size(309, 78);
            this.btnShootU.TabIndex = 2;
            this.btnShootU.Text = "Shoot Yourself";
            this.btnShootU.UseVisualStyleBackColor = false;
            this.btnShootU.Click += new System.EventHandler(this.btnShootU_Click);
            this.btnShootU.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnShootU_MouseMove);
            // 
            // btnShootC
            // 
            this.btnShootC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnShootC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShootC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShootC.Location = new System.Drawing.Point(357, 384);
            this.btnShootC.Margin = new System.Windows.Forms.Padding(4);
            this.btnShootC.Name = "btnShootC";
            this.btnShootC.Size = new System.Drawing.Size(316, 78);
            this.btnShootC.TabIndex = 3;
            this.btnShootC.Text = "Shoot Away";
            this.btnShootC.UseVisualStyleBackColor = false;
            this.btnShootC.Click += new System.EventHandler(this.btnShootC_Click);
            this.btnShootC.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnShootC_MouseMove);
            // 
            // btnSpin
            // 
            this.btnSpin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSpin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSpin.Location = new System.Drawing.Point(507, 23);
            this.btnSpin.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(323, 80);
            this.btnSpin.TabIndex = 0;
            this.btnSpin.Text = "Load Bullet Spin Chamber";
            this.btnSpin.UseVisualStyleBackColor = false;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // lblChamber
            // 
            this.lblChamber.AutoSize = true;
            this.lblChamber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChamber.Location = new System.Drawing.Point(1429, 11);
            this.lblChamber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChamber.Name = "lblChamber";
            this.lblChamber.Size = new System.Drawing.Size(60, 24);
            this.lblChamber.TabIndex = 7;
            this.lblChamber.Text = "label2";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblScore.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Gold;
            this.lblScore.Location = new System.Drawing.Point(764, 34);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(88, 29);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "label2";
            // 
            // lblRounds
            // 
            this.lblRounds.AutoSize = true;
            this.lblRounds.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRounds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblRounds.Location = new System.Drawing.Point(340, 34);
            this.lblRounds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRounds.Name = "lblRounds";
            this.lblRounds.Size = new System.Drawing.Size(97, 29);
            this.lblRounds.TabIndex = 12;
            this.lblRounds.Text = "Round";
            // 
            // lblGameRound
            // 
            this.lblGameRound.AutoSize = true;
            this.lblGameRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblGameRound.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameRound.ForeColor = System.Drawing.Color.Gold;
            this.lblGameRound.Location = new System.Drawing.Point(230, 34);
            this.lblGameRound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameRound.Name = "lblGameRound";
            this.lblGameRound.Size = new System.Drawing.Size(118, 29);
            this.lblGameRound.TabIndex = 13;
            this.lblGameRound.Text = "Round : ";
            // 
            // proBarRounds
            // 
            this.proBarRounds.BackColor = System.Drawing.Color.IndianRed;
            this.proBarRounds.ForeColor = System.Drawing.Color.Transparent;
            this.proBarRounds.Location = new System.Drawing.Point(335, 511);
            this.proBarRounds.Margin = new System.Windows.Forms.Padding(4);
            this.proBarRounds.Name = "proBarRounds";
            this.proBarRounds.Size = new System.Drawing.Size(715, 54);
            this.proBarRounds.TabIndex = 14;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1029);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(19, 0, 1, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1487, 24);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(142, 18);
            this.toolStripStatusLabel1.Text = "Russian Roulette Progress";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 1124);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 24);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // TimerChamberLoad
            // 
            this.TimerChamberLoad.Interval = 925;
            this.TimerChamberLoad.Tick += new System.EventHandler(this.TimerChamberLoad_Tick);
            // 
            // gbTitle
            // 
            this.gbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbTitle.Controls.Add(this.lblWinLoss);
            this.gbTitle.Controls.Add(this.lblWL);
            this.gbTitle.Controls.Add(this.lblScoreL);
            this.gbTitle.Controls.Add(this.lblRounds);
            this.gbTitle.Controls.Add(this.lblGameRound);
            this.gbTitle.Controls.Add(this.lblScore);
            this.gbTitle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gbTitle.Location = new System.Drawing.Point(51, 160);
            this.gbTitle.Margin = new System.Windows.Forms.Padding(4);
            this.gbTitle.Name = "gbTitle";
            this.gbTitle.Padding = new System.Windows.Forms.Padding(4);
            this.gbTitle.Size = new System.Drawing.Size(1383, 86);
            this.gbTitle.TabIndex = 19;
            this.gbTitle.TabStop = false;
            this.gbTitle.Text = "Score Details";
            // 
            // lblWinLoss
            // 
            this.lblWinLoss.AutoSize = true;
            this.lblWinLoss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblWinLoss.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinLoss.ForeColor = System.Drawing.Color.Gold;
            this.lblWinLoss.Location = new System.Drawing.Point(1235, 34);
            this.lblWinLoss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWinLoss.Name = "lblWinLoss";
            this.lblWinLoss.Size = new System.Drawing.Size(24, 29);
            this.lblWinLoss.TabIndex = 16;
            this.lblWinLoss.Text = "/";
            // 
            // lblWL
            // 
            this.lblWL.AutoSize = true;
            this.lblWL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblWL.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWL.ForeColor = System.Drawing.Color.Gold;
            this.lblWL.Location = new System.Drawing.Point(1079, 34);
            this.lblWL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWL.Name = "lblWL";
            this.lblWL.Size = new System.Drawing.Size(152, 29);
            this.lblWL.TabIndex = 15;
            this.lblWL.Text = "Win/Loss : ";
            // 
            // lblScoreL
            // 
            this.lblScoreL.AutoSize = true;
            this.lblScoreL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblScoreL.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreL.ForeColor = System.Drawing.Color.Gold;
            this.lblScoreL.Location = new System.Drawing.Point(660, 34);
            this.lblScoreL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScoreL.Name = "lblScoreL";
            this.lblScoreL.Size = new System.Drawing.Size(98, 29);
            this.lblScoreL.TabIndex = 14;
            this.lblScoreL.Text = "Score :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBox1.Controls.Add(this.lblProBarBullets6);
            this.groupBox1.Controls.Add(this.lblProBarBullets5);
            this.groupBox1.Controls.Add(this.lblProBarBullets4);
            this.groupBox1.Controls.Add(this.lblProBarBullets3);
            this.groupBox1.Controls.Add(this.lblProBarBullets2);
            this.groupBox1.Controls.Add(this.lblProBarBullets1);
            this.groupBox1.Controls.Add(this.lblProBars);
            this.groupBox1.Controls.Add(this.btnPlayAgain);
            this.groupBox1.Controls.Add(this.PanelMessage);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.PBBulletL);
            this.groupBox1.Controls.Add(this.PBBulletR);
            this.groupBox1.Controls.Add(this.PBShootAwayFrame);
            this.groupBox1.Controls.Add(this.pbGameFrame);
            this.groupBox1.Controls.Add(this.PBChamberSpin);
            this.groupBox1.Controls.Add(this.btnSpin);
            this.groupBox1.Controls.Add(this.btnShootU);
            this.groupBox1.Controls.Add(this.btnShootC);
            this.groupBox1.Controls.Add(this.proBarRounds);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(51, 254);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1383, 588);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game";
            // 
            // lblProBarBullets6
            // 
            this.lblProBarBullets6.AutoSize = true;
            this.lblProBarBullets6.Location = new System.Drawing.Point(1023, 482);
            this.lblProBarBullets6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProBarBullets6.Name = "lblProBarBullets6";
            this.lblProBarBullets6.Size = new System.Drawing.Size(29, 29);
            this.lblProBarBullets6.TabIndex = 34;
            this.lblProBarBullets6.Text = "6";
            // 
            // lblProBarBullets5
            // 
            this.lblProBarBullets5.AutoSize = true;
            this.lblProBarBullets5.Location = new System.Drawing.Point(909, 481);
            this.lblProBarBullets5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProBarBullets5.Name = "lblProBarBullets5";
            this.lblProBarBullets5.Size = new System.Drawing.Size(27, 29);
            this.lblProBarBullets5.TabIndex = 33;
            this.lblProBarBullets5.Text = "5";
            // 
            // lblProBarBullets4
            // 
            this.lblProBarBullets4.AutoSize = true;
            this.lblProBarBullets4.Location = new System.Drawing.Point(780, 481);
            this.lblProBarBullets4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProBarBullets4.Name = "lblProBarBullets4";
            this.lblProBarBullets4.Size = new System.Drawing.Size(29, 29);
            this.lblProBarBullets4.TabIndex = 32;
            this.lblProBarBullets4.Text = "4";
            // 
            // lblProBarBullets3
            // 
            this.lblProBarBullets3.AutoSize = true;
            this.lblProBarBullets3.Location = new System.Drawing.Point(663, 481);
            this.lblProBarBullets3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProBarBullets3.Name = "lblProBarBullets3";
            this.lblProBarBullets3.Size = new System.Drawing.Size(28, 29);
            this.lblProBarBullets3.TabIndex = 31;
            this.lblProBarBullets3.Text = "3";
            // 
            // lblProBarBullets2
            // 
            this.lblProBarBullets2.AutoSize = true;
            this.lblProBarBullets2.Location = new System.Drawing.Point(540, 481);
            this.lblProBarBullets2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProBarBullets2.Name = "lblProBarBullets2";
            this.lblProBarBullets2.Size = new System.Drawing.Size(28, 29);
            this.lblProBarBullets2.TabIndex = 30;
            this.lblProBarBullets2.Text = "2";
            // 
            // lblProBarBullets1
            // 
            this.lblProBarBullets1.AutoSize = true;
            this.lblProBarBullets1.Location = new System.Drawing.Point(428, 481);
            this.lblProBarBullets1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProBarBullets1.Name = "lblProBarBullets1";
            this.lblProBarBullets1.Size = new System.Drawing.Size(25, 29);
            this.lblProBarBullets1.TabIndex = 29;
            this.lblProBarBullets1.Text = "1";
            // 
            // lblProBars
            // 
            this.lblProBars.AutoSize = true;
            this.lblProBars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblProBars.ForeColor = System.Drawing.Color.Gold;
            this.lblProBars.Location = new System.Drawing.Point(327, 482);
            this.lblProBars.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProBars.Name = "lblProBars";
            this.lblProBars.Size = new System.Drawing.Size(94, 29);
            this.lblProBars.TabIndex = 28;
            this.lblProBars.Text = "Bullet ";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPlayAgain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlayAgain.Location = new System.Drawing.Point(1081, 384);
            this.btnPlayAgain.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(268, 78);
            this.btnPlayAgain.TabIndex = 27;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // PanelMessage
            // 
            this.PanelMessage.BackColor = System.Drawing.Color.Navy;
            this.PanelMessage.Controls.Add(this.lblGameMessage);
            this.PanelMessage.Controls.Add(this.lblGameMessage1);
            this.PanelMessage.ForeColor = System.Drawing.Color.White;
            this.PanelMessage.Location = new System.Drawing.Point(432, 297);
            this.PanelMessage.Margin = new System.Windows.Forms.Padding(4);
            this.PanelMessage.Name = "PanelMessage";
            this.PanelMessage.Size = new System.Drawing.Size(487, 76);
            this.PanelMessage.TabIndex = 26;
            // 
            // lblGameMessage
            // 
            this.lblGameMessage.AutoSize = true;
            this.lblGameMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblGameMessage.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameMessage.Location = new System.Drawing.Point(45, 20);
            this.lblGameMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameMessage.Name = "lblGameMessage";
            this.lblGameMessage.Size = new System.Drawing.Size(295, 24);
            this.lblGameMessage.TabIndex = 24;
            this.lblGameMessage.Text = "Please Load Bullet and Spin";
            this.lblGameMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGameMessage1
            // 
            this.lblGameMessage1.AutoSize = true;
            this.lblGameMessage1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameMessage1.Location = new System.Drawing.Point(89, 53);
            this.lblGameMessage1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameMessage1.Name = "lblGameMessage1";
            this.lblGameMessage1.Size = new System.Drawing.Size(0, 24);
            this.lblGameMessage1.TabIndex = 25;
            this.lblGameMessage1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(1081, 498);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(268, 64);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // PBBulletL
            // 
            this.PBBulletL.Location = new System.Drawing.Point(432, 137);
            this.PBBulletL.Margin = new System.Windows.Forms.Padding(4);
            this.PBBulletL.Name = "PBBulletL";
            this.PBBulletL.Size = new System.Drawing.Size(45, 31);
            this.PBBulletL.TabIndex = 22;
            this.PBBulletL.TabStop = false;
            // 
            // PBBulletR
            // 
            this.PBBulletR.Location = new System.Drawing.Point(856, 137);
            this.PBBulletR.Margin = new System.Windows.Forms.Padding(4);
            this.PBBulletR.Name = "PBBulletR";
            this.PBBulletR.Size = new System.Drawing.Size(43, 31);
            this.PBBulletR.TabIndex = 21;
            this.PBBulletR.TabStop = false;
            // 
            // PBShootAwayFrame
            // 
            this.PBShootAwayFrame.Location = new System.Drawing.Point(33, 70);
            this.PBShootAwayFrame.Margin = new System.Windows.Forms.Padding(4);
            this.PBShootAwayFrame.Name = "PBShootAwayFrame";
            this.PBShootAwayFrame.Size = new System.Drawing.Size(368, 258);
            this.PBShootAwayFrame.TabIndex = 20;
            this.PBShootAwayFrame.TabStop = false;
            // 
            // pbGameFrame
            // 
            this.pbGameFrame.Location = new System.Drawing.Point(921, 78);
            this.pbGameFrame.Margin = new System.Windows.Forms.Padding(4);
            this.pbGameFrame.Name = "pbGameFrame";
            this.pbGameFrame.Size = new System.Drawing.Size(399, 258);
            this.pbGameFrame.TabIndex = 19;
            this.pbGameFrame.TabStop = false;
            // 
            // PBChamberSpin
            // 
            this.PBChamberSpin.Location = new System.Drawing.Point(507, 126);
            this.PBChamberSpin.Margin = new System.Windows.Forms.Padding(4);
            this.PBChamberSpin.Name = "PBChamberSpin";
            this.PBChamberSpin.Size = new System.Drawing.Size(323, 165);
            this.PBChamberSpin.TabIndex = 18;
            this.PBChamberSpin.TabStop = false;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(1440, 46);
            this.lblC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(46, 17);
            this.lblC.TabIndex = 21;
            this.lblC.Text = "label2";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Controls.Add(this.lblSubTiltle);
            this.groupBox2.Controls.Add(this.lblTitle);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(49, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1384, 140);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // lblSubTiltle
            // 
            this.lblSubTiltle.AutoSize = true;
            this.lblSubTiltle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSubTiltle.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTiltle.ForeColor = System.Drawing.Color.Gold;
            this.lblSubTiltle.Location = new System.Drawing.Point(560, 94);
            this.lblSubTiltle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTiltle.Name = "lblSubTiltle";
            this.lblSubTiltle.Size = new System.Drawing.Size(201, 43);
            this.lblSubTiltle.TabIndex = 1;
            this.lblSubTiltle.Text = "ShootoutGame";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitle.Font = new System.Drawing.Font("Sitka Banner", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblTitle.Location = new System.Drawing.Point(441, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(451, 87);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Russian Roulette";
            // 
            // frmRussianRoulette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1487, 1053);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbTitle);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblChamber);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRussianRoulette";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RUSSIAN ROULETTE GAME";
            this.Load += new System.EventHandler(this.frmRussianRoulette_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbTitle.ResumeLayout(false);
            this.gbTitle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PanelMessage.ResumeLayout(false);
            this.PanelMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBBulletL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBBulletR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBShootAwayFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBChamberSpin)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShootU;
        private System.Windows.Forms.Button btnShootC;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Label lblChamber;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblRounds;
        private System.Windows.Forms.Label lblGameRound;
        private System.Windows.Forms.ProgressBar proBarRounds;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer TimerChamberLoad;
        private System.Windows.Forms.GroupBox gbTitle;
        private System.Windows.Forms.Label lblScoreL;
        private System.Windows.Forms.Label lblWinLoss;
        private System.Windows.Forms.Label lblWL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox PBChamberSpin;
        private System.Windows.Forms.PictureBox pbGameFrame;
        private System.Windows.Forms.PictureBox PBShootAwayFrame;
        private System.Windows.Forms.PictureBox PBBulletR;
        private System.Windows.Forms.PictureBox PBBulletL;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblGameMessage;
        private System.Windows.Forms.Label lblGameMessage1;
        private System.Windows.Forms.Panel PanelMessage;
        private System.Windows.Forms.Label lblProBars;
        private System.Windows.Forms.Label lblProBarBullets1;
        private System.Windows.Forms.Label lblProBarBullets6;
        private System.Windows.Forms.Label lblProBarBullets5;
        private System.Windows.Forms.Label lblProBarBullets4;
        private System.Windows.Forms.Label lblProBarBullets3;
        private System.Windows.Forms.Label lblProBarBullets2;
        private System.Windows.Forms.Label lblSubTiltle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

