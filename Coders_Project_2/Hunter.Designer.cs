
namespace Coders_Project_2
{
    partial class Hunter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hunter));
            this.gbGameMenu = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.gbDifficulty = new System.Windows.Forms.GroupBox();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.timerEnd = new System.Windows.Forms.Timer(this.components);
            this.timerAnimalMove = new System.Windows.Forms.Timer(this.components);
            this.pbAnimal = new System.Windows.Forms.PictureBox();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.gbGameMenu.SuspendLayout();
            this.gbDifficulty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGameMenu
            // 
            this.gbGameMenu.BackColor = System.Drawing.SystemColors.Info;
            this.gbGameMenu.Controls.Add(this.buttonExit);
            this.gbGameMenu.Controls.Add(this.labelScore);
            this.gbGameMenu.Controls.Add(this.labelTime);
            this.gbGameMenu.Controls.Add(this.gbDifficulty);
            this.gbGameMenu.Controls.Add(this.buttonStart);
            this.gbGameMenu.Controls.Add(this.labelWelcome);
            this.gbGameMenu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gbGameMenu.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGameMenu.Location = new System.Drawing.Point(0, -2);
            this.gbGameMenu.Name = "gbGameMenu";
            this.gbGameMenu.Size = new System.Drawing.Size(166, 674);
            this.gbGameMenu.TabIndex = 0;
            this.gbGameMenu.TabStop = false;
            this.gbGameMenu.Text = "GameMenu";
            // 
            // buttonExit
            // 
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(12, 551);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(129, 37);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelScore
            // 
            this.labelScore.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(0, 460);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(160, 75);
            this.labelScore.TabIndex = 4;
            this.labelScore.Text = "Score";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(0, 360);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(160, 75);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "Time";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbDifficulty
            // 
            this.gbDifficulty.Controls.Add(this.rbHard);
            this.gbDifficulty.Controls.Add(this.rbMedium);
            this.gbDifficulty.Controls.Add(this.rbEasy);
            this.gbDifficulty.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDifficulty.Location = new System.Drawing.Point(6, 209);
            this.gbDifficulty.Name = "gbDifficulty";
            this.gbDifficulty.Size = new System.Drawing.Size(154, 114);
            this.gbDifficulty.TabIndex = 2;
            this.gbDifficulty.TabStop = false;
            this.gbDifficulty.Text = "Difficulty";
            // 
            // rbHard
            // 
            this.rbHard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbHard.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbHard.Location = new System.Drawing.Point(6, 81);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(140, 23);
            this.rbHard.TabIndex = 3;
            this.rbHard.TabStop = true;
            this.rbHard.Text = "Hard";
            this.rbHard.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMedium.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedium.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbMedium.Location = new System.Drawing.Point(7, 53);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(140, 23);
            this.rbMedium.TabIndex = 2;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbEasy
            // 
            this.rbEasy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEasy.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEasy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbEasy.Location = new System.Drawing.Point(8, 25);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(140, 23);
            this.rbEasy.TabIndex = 1;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "Easy";
            this.rbEasy.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(27, 123);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(110, 40);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(0, 29);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(166, 73);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome User!";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerEnd
            // 
            this.timerEnd.Interval = 1000;
            this.timerEnd.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerAnimalMove
            // 
            this.timerAnimalMove.Enabled = true;
            this.timerAnimalMove.Tick += new System.EventHandler(this.timerAnimalMove_Tick);
            // 
            // pbAnimal
            // 
            this.pbAnimal.BackColor = System.Drawing.Color.Transparent;
            this.pbAnimal.Image = global::Coders_Project_2.Properties.Resources.bison;
            this.pbAnimal.Location = new System.Drawing.Point(472, 192);
            this.pbAnimal.Name = "pbAnimal";
            this.pbAnimal.Size = new System.Drawing.Size(137, 131);
            this.pbAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnimal.TabIndex = 1;
            this.pbAnimal.TabStop = false;
            this.pbAnimal.Visible = false;
            this.pbAnimal.Click += new System.EventHandler(this.pictureBox1_Click_1);
            this.pbAnimal.MouseEnter += new System.EventHandler(this.pbAnimal_MouseEnter);
            this.pbAnimal.MouseLeave += new System.EventHandler(this.pbAnimal_MouseLeave);
            // 
            // labelGameOver
            // 
            this.labelGameOver.BackColor = System.Drawing.Color.Transparent;
            this.labelGameOver.Font = new System.Drawing.Font("Segoe Script", 42F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOver.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelGameOver.Location = new System.Drawing.Point(200, 48);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(752, 504);
            this.labelGameOver.TabIndex = 2;
            this.labelGameOver.Text = "GAME OVER!";
            this.labelGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGameOver.Visible = false;
            // 
            // Hunter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(971, 598);
            this.Controls.Add(this.pbAnimal);
            this.Controls.Add(this.gbGameMenu);
            this.Controls.Add(this.labelGameOver);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hunter";
            this.Text = "Hunter";
            this.Load += new System.EventHandler(this.Hunter_Load);
            this.gbGameMenu.ResumeLayout(false);
            this.gbDifficulty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGameMenu;
        private System.Windows.Forms.GroupBox gbDifficulty;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.PictureBox pbAnimal;
        private System.Windows.Forms.Timer timerEnd;
        private System.Windows.Forms.Timer timerAnimalMove;
        private System.Windows.Forms.Label labelGameOver;
    }
}