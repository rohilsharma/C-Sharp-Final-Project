using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OnlineQuiz
{
    public partial class frmQuiz : Form
    {
        string ans;
        int score = 0;

        public frmQuiz()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("If you quit now, your final score may be affected. Quit?", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)) == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (BSQuestions.Position < BSQuestions.Count - 1)
            {
                calcScore();
                BSQuestions.MoveNext();
                rbA.Checked = true;
            }
            else
            {
                long studentID = 0;
                studentID = frmLogin.studentID;

                calcScore();
                btnNext.Enabled = false;
                
                //Saving score to database
                string sqlCode;
                sqlCode = "Update Members " + 
                    " Set FinalScore = " + score + 
                    " Where StudentID = " + studentID;

                insertToSQL.ExecuteSQL(sqlCode);

                if (MessageBox.Show("Your score is " + score.ToString() + " out of " + BSQuestions.Count, "Final Score", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void BSQuestion_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void frmQuiz_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Questions' table. You can move, or remove it, as needed.
            this.questionsTableAdapter.Fill(this.libraryDataSet.Questions);
            // TODO: This line of code loads data into the 'libraryDataSet.Members' table. You can move, or remove it, as needed.
        }

        private void calcScore()
        {
            if (ans.Equals(lblAns.Text))
            {
                score++;
            }
        }

        #region RadioButton Text
        private void rbA_CheckedChanged(object sender, EventArgs e)
        {
            ans = rbA.Text;
        }

        private void rbB_CheckedChanged(object sender, EventArgs e)
        {
            ans = rbB.Text;
        }
        private void rbC_CheckedChanged(object sender, EventArgs e)
        {
            ans = rbC.Text;
        }

        private void rbD_CheckedChanged(object sender, EventArgs e)
        {
            ans = rbD.Text;
        }
        #endregion
    }
}
