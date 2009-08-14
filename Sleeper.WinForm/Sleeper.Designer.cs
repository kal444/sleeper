namespace Sleeper.WinForm
{
    partial class Sleeper
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
            this.exit_btn = new System.Windows.Forms.Button();
            this.sleepProgress = new System.Windows.Forms.ProgressBar();
            this.alertText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // exit_btn
            // 
            this.exit_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit_btn.Location = new System.Drawing.Point(197, 140);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 23);
            this.exit_btn.TabIndex = 2;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // sleepProgress
            // 
            this.sleepProgress.Location = new System.Drawing.Point(12, 106);
            this.sleepProgress.Name = "sleepProgress";
            this.sleepProgress.Size = new System.Drawing.Size(260, 23);
            this.sleepProgress.TabIndex = 3;
            // 
            // alertText
            // 
            this.alertText.Location = new System.Drawing.Point(13, 13);
            this.alertText.Name = "alertText";
            this.alertText.ReadOnly = true;
            this.alertText.Size = new System.Drawing.Size(259, 87);
            this.alertText.TabIndex = 4;
            this.alertText.Text = "Exit now if you would not want the computer to go to sleep!";
            // 
            // Sleeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.exit_btn;
            this.ClientSize = new System.Drawing.Size(284, 179);
            this.Controls.Add(this.alertText);
            this.Controls.Add(this.sleepProgress);
            this.Controls.Add(this.exit_btn);
            this.MaximizeBox = false;
            this.Name = "Sleeper";
            this.Text = "Sleeper";
            this.Load += new System.EventHandler(this.Sleeper_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.ProgressBar sleepProgress;
        private System.Windows.Forms.RichTextBox alertText;
    }
}

