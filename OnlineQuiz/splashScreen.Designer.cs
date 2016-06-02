namespace OnlineQuiz
{
    partial class splashScreen
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.pbSplashScreen = new System.Windows.Forms.ProgressBar();
            this.timerSplashScreen = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTitle.Location = new System.Drawing.Point(90, 62);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(102, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quiz";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(80, 130);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(124, 13);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Created by Rohil Sharma";
            // 
            // pbSplashScreen
            // 
            this.pbSplashScreen.Location = new System.Drawing.Point(92, 175);
            this.pbSplashScreen.Maximum = 350;
            this.pbSplashScreen.Name = "pbSplashScreen";
            this.pbSplashScreen.Size = new System.Drawing.Size(100, 23);
            this.pbSplashScreen.TabIndex = 2;
            // 
            // timerSplashScreen
            // 
            this.timerSplashScreen.Tick += new System.EventHandler(this.timerSplashScreen_Tick);
            // 
            // splashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.pbSplashScreen);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Name = "splashScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.ProgressBar pbSplashScreen;
        private System.Windows.Forms.Timer timerSplashScreen;
    }
}

