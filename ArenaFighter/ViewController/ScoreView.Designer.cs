namespace ArenaFighter.Controller
{
    partial class ScoreView
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
            this.CharacterName = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Button();
            this.battle_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CharacterName
            // 
            this.CharacterName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CharacterName.AutoSize = true;
            this.CharacterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterName.Location = new System.Drawing.Point(35, 62);
            this.CharacterName.Name = "CharacterName";
            this.CharacterName.Size = new System.Drawing.Size(213, 37);
            this.CharacterName.TabIndex = 0;
            this.CharacterName.Text = "Rokcy Balboa";
            this.CharacterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Score
            // 
            this.Score.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(45, 184);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(192, 46);
            this.Score.TabIndex = 1;
            this.Score.Text = "Score: 86";
            this.Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // close_button
            // 
            this.close_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.close_button.Location = new System.Drawing.Point(112, 360);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 2;
            this.close_button.Text = "OK";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // battle_button
            // 
            this.battle_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.battle_button.Location = new System.Drawing.Point(112, 425);
            this.battle_button.Name = "battle_button";
            this.battle_button.Size = new System.Drawing.Size(75, 23);
            this.battle_button.TabIndex = 3;
            this.battle_button.Text = "Battle Logs";
            this.battle_button.UseVisualStyleBackColor = true;
            this.battle_button.Click += new System.EventHandler(this.Battle_button_Click);
            // 
            // ScoreView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 541);
            this.Controls.Add(this.battle_button);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.CharacterName);
            this.Name = "ScoreView";
            this.Text = "ScoreView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CharacterName;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button battle_button;
    }
}