namespace OnlineQuiz
{
    partial class Score
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Score));
            this.lblCongrats = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblNameHolder = new System.Windows.Forms.Label();
            this.lblScoreHolder = new System.Windows.Forms.Label();
            this.btnCalcScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCongrats
            // 
            this.lblCongrats.AutoSize = true;
            this.lblCongrats.BackColor = System.Drawing.Color.Transparent;
            this.lblCongrats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCongrats.Location = new System.Drawing.Point(33, 9);
            this.lblCongrats.Name = "lblCongrats";
            this.lblCongrats.Size = new System.Drawing.Size(420, 24);
            this.lblCongrats.TabIndex = 0;
            this.lblCongrats.Text = "Congratulations! You have finished the quiz!";
            // 
            // btnDone
            // 
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDone.Location = new System.Drawing.Point(400, 226);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblName.Location = new System.Drawing.Point(126, 127);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblScore.Location = new System.Drawing.Point(126, 187);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(51, 20);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score";
            // 
            // lblNameHolder
            // 
            this.lblNameHolder.AutoSize = true;
            this.lblNameHolder.BackColor = System.Drawing.Color.Transparent;
            this.lblNameHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblNameHolder.Location = new System.Drawing.Point(268, 127);
            this.lblNameHolder.Name = "lblNameHolder";
            this.lblNameHolder.Size = new System.Drawing.Size(139, 20);
            this.lblNameHolder.TabIndex = 2;
            this.lblNameHolder.Text = "*InsertNameHere*";
            this.lblNameHolder.Visible = false;
            // 
            // lblScoreHolder
            // 
            this.lblScoreHolder.AutoSize = true;
            this.lblScoreHolder.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblScoreHolder.Location = new System.Drawing.Point(268, 187);
            this.lblScoreHolder.Name = "lblScoreHolder";
            this.lblScoreHolder.Size = new System.Drawing.Size(139, 20);
            this.lblScoreHolder.TabIndex = 2;
            this.lblScoreHolder.Text = "*InsertScoreHere*";
            this.lblScoreHolder.Visible = false;
            // 
            // btnCalcScore
            // 
            this.btnCalcScore.Location = new System.Drawing.Point(145, 47);
            this.btnCalcScore.Name = "btnCalcScore";
            this.btnCalcScore.Size = new System.Drawing.Size(222, 55);
            this.btnCalcScore.TabIndex = 3;
            this.btnCalcScore.Text = "Calculate My Score!";
            this.btnCalcScore.UseVisualStyleBackColor = true;
            this.btnCalcScore.Click += new System.EventHandler(this.btnCalcScore_Click);
            // 
            // Score
            // 
            this.AcceptButton = this.btnDone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnDone;
            this.ClientSize = new System.Drawing.Size(487, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnCalcScore);
            this.Controls.Add(this.lblScoreHolder);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblNameHolder);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblCongrats);
            this.Name = "Score";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Score";
            this.Load += new System.EventHandler(this.Score_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCongrats;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblNameHolder;
        private System.Windows.Forms.Label lblScoreHolder;
        private System.Windows.Forms.Button btnCalcScore;
       
    }
}