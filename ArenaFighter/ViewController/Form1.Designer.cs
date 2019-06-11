namespace ArenaFighter
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textLog = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.playerLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.enemyLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textLog, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.42567F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.57432F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 573);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textLog
            // 
            this.textLog.AccessibleDescription = "";
            this.textLog.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ArenaFighter.Properties.Settings.Default, "Log", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textLog.Location = new System.Drawing.Point(50, 400);
            this.textLog.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.textLog.Name = "textLog";
            this.textLog.Size = new System.Drawing.Size(700, 170);
            this.textLog.TabIndex = 0;
            this.textLog.Text = global::ArenaFighter.Properties.Settings.Default.Log;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.playerLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.enemyLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 391);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // playerLabel
            // 
            this.playerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(181, 226);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(35, 13);
            this.playerLabel.TabIndex = 1;
            this.playerLabel.Text = "label1";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(60, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // enemyLabel
            // 
            this.enemyLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enemyLabel.AutoSize = true;
            this.enemyLabel.Location = new System.Drawing.Point(578, 226);
            this.enemyLabel.Name = "enemyLabel";
            this.enemyLabel.Size = new System.Drawing.Size(35, 13);
            this.enemyLabel.TabIndex = 2;
            this.enemyLabel.Text = "label2";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(457, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(277, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.RichTextBox textLog;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label playerLabel;
        public System.Windows.Forms.Label enemyLabel;
        public System.Windows.Forms.Button button2;
    }
}

