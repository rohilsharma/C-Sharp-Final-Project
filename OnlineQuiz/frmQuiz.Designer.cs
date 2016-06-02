namespace OnlineQuiz
{
    partial class frmQuiz
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.BSQuestions = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new OnlineQuiz.LibraryDataSet();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.questionsTableAdapter = new OnlineQuiz.LibraryDataSetTableAdapters.QuestionsTableAdapter();
            this.lblAns = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BSQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSQuestions, "QuestionText", true));
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblQuestion.Location = new System.Drawing.Point(25, 46);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(160, 25);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "*QuestionHere*";
            // 
            // BSQuestions
            // 
            this.BSQuestions.DataMember = "Questions";
            this.BSQuestions.DataSource = this.libraryDataSet;
            this.BSQuestions.CurrentChanged += new System.EventHandler(this.BSQuestion_CurrentChanged);
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSQuestions, "Choice1", true));
            this.rbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rbA.Location = new System.Drawing.Point(60, 111);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(125, 29);
            this.rbA.TabIndex = 0;
            this.rbA.TabStop = true;
            this.rbA.Text = "*Choice1*";
            this.rbA.UseVisualStyleBackColor = true;
            this.rbA.CheckedChanged += new System.EventHandler(this.rbA_CheckedChanged);
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSQuestions, "Choice3", true));
            this.rbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rbC.Location = new System.Drawing.Point(60, 229);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(125, 29);
            this.rbC.TabIndex = 2;
            this.rbC.TabStop = true;
            this.rbC.Text = "*Choice3*";
            this.rbC.UseVisualStyleBackColor = true;
            this.rbC.CheckedChanged += new System.EventHandler(this.rbC_CheckedChanged);
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSQuestions, "Choice2", true));
            this.rbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rbB.Location = new System.Drawing.Point(386, 111);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(125, 29);
            this.rbB.TabIndex = 1;
            this.rbB.TabStop = true;
            this.rbB.Text = "*Choice2*";
            this.rbB.UseVisualStyleBackColor = true;
            this.rbB.CheckedChanged += new System.EventHandler(this.rbB_CheckedChanged);
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSQuestions, "Choice4", true));
            this.rbD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rbD.Location = new System.Drawing.Point(386, 229);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(125, 29);
            this.rbD.TabIndex = 3;
            this.rbD.TabStop = true;
            this.rbD.Text = "*Choice4*";
            this.rbD.UseVisualStyleBackColor = true;
            this.rbD.CheckedChanged += new System.EventHandler(this.rbD_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 391);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(574, 391);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // questionsTableAdapter
            // 
            this.questionsTableAdapter.ClearBeforeFill = true;
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSQuestions, "CorrectAnswer", true));
            this.lblAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblAns.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAns.Location = new System.Drawing.Point(293, 391);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(50, 13);
            this.lblAns.TabIndex = 6;
            this.lblAns.Text = "*Answer*";
            // 
            // frmQuiz
            // 
            this.AcceptButton = this.btnNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(661, 426);
            this.ControlBox = false;
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rbD);
            this.Controls.Add(this.rbB);
            this.Controls.Add(this.rbC);
            this.Controls.Add(this.rbA);
            this.Controls.Add(this.lblQuestion);
            this.Name = "frmQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question";
            this.Load += new System.EventHandler(this.frmQuiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BSQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.BindingSource BSQuestions;
        private LibraryDataSet libraryDataSet;
        private LibraryDataSetTableAdapters.QuestionsTableAdapter questionsTableAdapter;
        private System.Windows.Forms.Label lblAns;
    }
}