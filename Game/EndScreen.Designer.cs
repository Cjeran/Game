namespace Game
{
    partial class EndScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.skullLabel = new System.Windows.Forms.Label();
            this.killLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.playAgain = new System.Windows.Forms.Button();
            this.highscoreLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.Font = new System.Drawing.Font("Millenium BdEx BT", 63.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gameOverLabel.Location = new System.Drawing.Point(0, 0);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(800, 136);
            this.gameOverLabel.TabIndex = 0;
            this.gameOverLabel.Text = "GAME OVER";
            this.gameOverLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gameOverLabel.Click += new System.EventHandler(this.gameOverLabel_Click);
            // 
            // skullLabel
            // 
            this.skullLabel.AutoSize = true;
            this.skullLabel.Font = new System.Drawing.Font("Millenium BdEx BT", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skullLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.skullLabel.Location = new System.Drawing.Point(120, 184);
            this.skullLabel.Name = "skullLabel";
            this.skullLabel.Size = new System.Drawing.Size(63, 56);
            this.skullLabel.TabIndex = 1;
            this.skullLabel.Text = "💀";
            // 
            // killLabel
            // 
            this.killLabel.Font = new System.Drawing.Font("Millenium BdEx BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killLabel.Location = new System.Drawing.Point(83, 250);
            this.killLabel.Name = "killLabel";
            this.killLabel.Size = new System.Drawing.Size(131, 72);
            this.killLabel.TabIndex = 2;
            this.killLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Millenium BdEx BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 62);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score";
            // 
            // scoreLabel
            // 
            this.scoreLabel.Font = new System.Drawing.Font("Millenium BdEx BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(299, 198);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(244, 72);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Millenium BdEx BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(629, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 62);
            this.label3.TabIndex = 5;
            this.label3.Text = "⌛";
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Millenium BdEx BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(570, 250);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(167, 72);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuButton
            // 
            this.menuButton.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuButton.Location = new System.Drawing.Point(620, 403);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(164, 60);
            this.menuButton.TabIndex = 7;
            this.menuButton.Text = "Main Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // playAgain
            // 
            this.playAgain.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playAgain.Location = new System.Drawing.Point(19, 403);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(164, 60);
            this.playAgain.TabIndex = 8;
            this.playAgain.Text = "Play Again";
            this.playAgain.UseVisualStyleBackColor = true;
            this.playAgain.Click += new System.EventHandler(this.button2_Click);
            // 
            // highscoreLabel
            // 
            this.highscoreLabel.Font = new System.Drawing.Font("Millenium BdEx BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreLabel.Location = new System.Drawing.Point(193, 343);
            this.highscoreLabel.Name = "highscoreLabel";
            this.highscoreLabel.Size = new System.Drawing.Size(445, 55);
            this.highscoreLabel.TabIndex = 9;
            this.highscoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Millenium BdEx BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 42);
            this.label4.TabIndex = 10;
            this.label4.Text = "Highscore";
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.highscoreLabel);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.killLabel);
            this.Controls.Add(this.skullLabel);
            this.Controls.Add(this.gameOverLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "EndScreen";
            this.Size = new System.Drawing.Size(800, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label skullLabel;
        private System.Windows.Forms.Label killLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button playAgain;
        private System.Windows.Forms.Label highscoreLabel;
        private System.Windows.Forms.Label label4;
    }
}
