﻿namespace RockPaperScissors{
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChoiceRock = new System.Windows.Forms.Button();
            this.ChoicePaper = new System.Windows.Forms.Button();
            this.ChoiceScissors = new System.Windows.Forms.Button();
            this.buttonComputersChoice = new System.Windows.Forms.Button();
            this.text_player = new System.Windows.Forms.Label();
            this.text_computer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonPlayersChoice = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.score_otherplayer = new System.Windows.Forms.Label();
            this.score_player = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.count_draws = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(394, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.newGameToolStripMenuItem.Text = "New game - Singleplayer";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newSinglePlayerGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ChoiceRock
            // 
            this.ChoiceRock.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoiceRock.Location = new System.Drawing.Point(12, 378);
            this.ChoiceRock.Name = "ChoiceRock";
            this.ChoiceRock.Size = new System.Drawing.Size(120, 50);
            this.ChoiceRock.TabIndex = 1;
            this.ChoiceRock.Text = "Rock";
            this.ChoiceRock.UseVisualStyleBackColor = true;
            this.ChoiceRock.Click += new System.EventHandler(this.button_click);
            // 
            // ChoicePaper
            // 
            this.ChoicePaper.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoicePaper.Location = new System.Drawing.Point(138, 378);
            this.ChoicePaper.Name = "ChoicePaper";
            this.ChoicePaper.Size = new System.Drawing.Size(120, 50);
            this.ChoicePaper.TabIndex = 2;
            this.ChoicePaper.Text = "Paper";
            this.ChoicePaper.UseVisualStyleBackColor = true;
            this.ChoicePaper.Click += new System.EventHandler(this.button_click);
            // 
            // ChoiceScissors
            // 
            this.ChoiceScissors.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoiceScissors.Location = new System.Drawing.Point(264, 378);
            this.ChoiceScissors.Name = "ChoiceScissors";
            this.ChoiceScissors.Size = new System.Drawing.Size(120, 50);
            this.ChoiceScissors.TabIndex = 3;
            this.ChoiceScissors.Text = "Scissors";
            this.ChoiceScissors.UseVisualStyleBackColor = true;
            this.ChoiceScissors.Click += new System.EventHandler(this.button_click);
            // 
            // buttonComputersChoice
            // 
            this.buttonComputersChoice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComputersChoice.ForeColor = System.Drawing.Color.Chartreuse;
            this.buttonComputersChoice.Location = new System.Drawing.Point(138, 113);
            this.buttonComputersChoice.Name = "buttonComputersChoice";
            this.buttonComputersChoice.Size = new System.Drawing.Size(120, 80);
            this.buttonComputersChoice.TabIndex = 4;
            this.buttonComputersChoice.UseVisualStyleBackColor = true;
            this.buttonComputersChoice.Click += new System.EventHandler(this.buttonComputersChoice_Click);
            // 
            // text_player
            // 
            this.text_player.AutoSize = true;
            this.text_player.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_player.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.text_player.Location = new System.Drawing.Point(176, 345);
            this.text_player.Name = "text_player";
            this.text_player.Size = new System.Drawing.Size(43, 17);
            this.text_player.TabIndex = 5;
            this.text_player.Text = "Player";
            // 
            // text_computer
            // 
            this.text_computer.AutoSize = true;
            this.text_computer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_computer.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.text_computer.Location = new System.Drawing.Point(167, 95);
            this.text_computer.Name = "text_computer";
            this.text_computer.Size = new System.Drawing.Size(66, 17);
            this.text_computer.TabIndex = 6;
            this.text_computer.Text = "Computer";
            this.text_computer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Chartreuse;
            this.button1.Location = new System.Drawing.Point(264, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 50);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Chartreuse;
            this.button2.Location = new System.Drawing.Point(138, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 50);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Chartreuse;
            this.button3.Location = new System.Drawing.Point(12, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 50);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonPlayersChoice
            // 
            this.buttonPlayersChoice.Enabled = false;
            this.buttonPlayersChoice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayersChoice.ForeColor = System.Drawing.Color.Chartreuse;
            this.buttonPlayersChoice.Location = new System.Drawing.Point(138, 265);
            this.buttonPlayersChoice.Name = "buttonPlayersChoice";
            this.buttonPlayersChoice.Size = new System.Drawing.Size(120, 80);
            this.buttonPlayersChoice.TabIndex = 12;
            this.buttonPlayersChoice.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(163, 199);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Score:";
            // 
            // score_otherplayer
            // 
            this.score_otherplayer.AutoSize = true;
            this.score_otherplayer.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_otherplayer.Location = new System.Drawing.Point(73, 89);
            this.score_otherplayer.Name = "score_otherplayer";
            this.score_otherplayer.Size = new System.Drawing.Size(0, 18);
            this.score_otherplayer.TabIndex = 17;
            // 
            // score_player
            // 
            this.score_player.AutoSize = true;
            this.score_player.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_player.Location = new System.Drawing.Point(340, 357);
            this.score_player.Name = "score_player";
            this.score_player.Size = new System.Drawing.Size(0, 18);
            this.score_player.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 19;
            // 
            // count_draws
            // 
            this.count_draws.AutoSize = true;
            this.count_draws.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_draws.Location = new System.Drawing.Point(73, 214);
            this.count_draws.Name = "count_draws";
            this.count_draws.Size = new System.Drawing.Size(0, 18);
            this.count_draws.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 441);
            this.Controls.Add(this.count_draws);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.score_player);
            this.Controls.Add(this.score_otherplayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonPlayersChoice);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_computer);
            this.Controls.Add(this.text_player);
            this.Controls.Add(this.buttonComputersChoice);
            this.Controls.Add(this.ChoiceScissors);
            this.Controls.Add(this.ChoicePaper);
            this.Controls.Add(this.ChoiceRock);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button ChoiceRock;
        private System.Windows.Forms.Button ChoicePaper;
        private System.Windows.Forms.Button ChoiceScissors;
        private System.Windows.Forms.Button buttonComputersChoice;
        private System.Windows.Forms.Label text_player;
        private System.Windows.Forms.Label text_computer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonPlayersChoice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label score_otherplayer;
        private System.Windows.Forms.Label score_player;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label count_draws;
    }
}

