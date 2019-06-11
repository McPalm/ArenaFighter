namespace ArenaFighter.ViewController
{
    partial class CareerBrowser
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
            this.BattleList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BattleList
            // 
            this.BattleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BattleList.FormattingEnabled = true;
            this.BattleList.Location = new System.Drawing.Point(0, 0);
            this.BattleList.Name = "BattleList";
            this.BattleList.Size = new System.Drawing.Size(272, 492);
            this.BattleList.TabIndex = 0;
            this.BattleList.SelectedIndexChanged += new System.EventHandler(this.BattleList_SelectedIndexChanged);
            // 
            // CareerBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 492);
            this.Controls.Add(this.BattleList);
            this.Name = "CareerBrowser";
            this.Text = "CareerBrowser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox BattleList;
    }
}