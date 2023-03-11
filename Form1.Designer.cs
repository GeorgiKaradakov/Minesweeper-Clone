namespace Minesweeper_clone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.emoji = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Label();
            this.flag_count = new System.Windows.Forms.Label();
            this.time_counter = new System.Windows.Forms.Timer(this.components);
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBG = new System.Windows.Forms.Button();
            this.btnENG = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emoji)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.emoji);
            this.panel1.Controls.Add(this.timer);
            this.panel1.Controls.Add(this.flag_count);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 88);
            this.panel1.TabIndex = 0;
            // 
            // emoji
            // 
            this.emoji.BackColor = System.Drawing.Color.Transparent;
            this.emoji.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.emoji.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emoji.Image = global::Minesweeper_clone.Properties.Resources.Smiley_face;
            this.emoji.Location = new System.Drawing.Point(242, 12);
            this.emoji.Name = "emoji";
            this.emoji.Size = new System.Drawing.Size(65, 65);
            this.emoji.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emoji.TabIndex = 0;
            this.emoji.TabStop = false;
            this.emoji.Tag = "reset";
            this.emoji.Click += new System.EventHandler(this.Reset_Game);
            // 
            // timer
            // 
            this.timer.BackColor = System.Drawing.Color.Black;
            this.timer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timer.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timer.ForeColor = System.Drawing.Color.Red;
            this.timer.Location = new System.Drawing.Point(446, 27);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(73, 35);
            this.timer.TabIndex = 2;
            this.timer.Text = "000";
            this.timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flag_count
            // 
            this.flag_count.BackColor = System.Drawing.Color.Black;
            this.flag_count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flag_count.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.flag_count.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.flag_count.ForeColor = System.Drawing.Color.Red;
            this.flag_count.Location = new System.Drawing.Point(28, 27);
            this.flag_count.Name = "flag_count";
            this.flag_count.Size = new System.Drawing.Size(56, 35);
            this.flag_count.TabIndex = 1;
            this.flag_count.Text = "000";
            this.flag_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time_counter
            // 
            this.time_counter.Interval = 1000;
            this.time_counter.Tick += new System.EventHandler(this.TimerTick);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewGame.Location = new System.Drawing.Point(169, 153);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(224, 61);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDetails.Location = new System.Drawing.Point(169, 252);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(224, 61);
            this.btnDetails.TabIndex = 2;
            this.btnDetails.Text = "How to play ?";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(169, 347);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(224, 61);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBG
            // 
            this.btnBG.BackgroundImage = global::Minesweeper_clone.Properties.Resources.Flag_of_Bulgaria_svg;
            this.btnBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBG.Location = new System.Drawing.Point(216, 453);
            this.btnBG.Name = "btnBG";
            this.btnBG.Size = new System.Drawing.Size(62, 48);
            this.btnBG.TabIndex = 4;
            this.btnBG.UseVisualStyleBackColor = true;
            this.btnBG.Click += new System.EventHandler(this.btnBG_Click);
            // 
            // btnENG
            // 
            this.btnENG.BackgroundImage = global::Minesweeper_clone.Properties.Resources.Flag_of_the_United_Kingdom__1_2__svg;
            this.btnENG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnENG.Location = new System.Drawing.Point(284, 453);
            this.btnENG.Name = "btnENG";
            this.btnENG.Size = new System.Drawing.Size(62, 48);
            this.btnENG.TabIndex = 5;
            this.btnENG.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(557, 531);
            this.Controls.Add(this.btnENG);
            this.Controls.Add(this.btnBG);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emoji)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox emoji;
        private Label flag_count;
        private Label timer;
        private System.Windows.Forms.Timer time_counter;
        private Button btnNewGame;
        private Button btnDetails;
        private Button btnExit;
        private Button btnBG;
        private Button btnENG;
    }
}