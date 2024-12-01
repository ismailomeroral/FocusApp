namespace FocusApp.Models.Forms
{
    partial class frmTimerShowBox
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
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnTimeOut = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Verdana", 24F);
            this.lblTimer.Location = new System.Drawing.Point(12, 9);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(167, 38);
            this.lblTimer.TabIndex = 10;
            this.lblTimer.Text = "00:00:00";
            // 
            // btnTimeOut
            // 
            this.btnTimeOut.Font = new System.Drawing.Font("Verdana", 12F);
            this.btnTimeOut.Location = new System.Drawing.Point(185, 9);
            this.btnTimeOut.Name = "btnTimeOut";
            this.btnTimeOut.Size = new System.Drawing.Size(91, 43);
            this.btnTimeOut.TabIndex = 11;
            this.btnTimeOut.Text = "breather";
            this.btnTimeOut.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmTimerShowBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(284, 64);
            this.Controls.Add(this.btnTimeOut);
            this.Controls.Add(this.lblTimer);
            this.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.MaximumSize = new System.Drawing.Size(300, 103);
            this.MinimumSize = new System.Drawing.Size(300, 103);
            this.Name = "frmTimerShowBox";
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnTimeOut;
        private System.Windows.Forms.Timer timer;
    }
}