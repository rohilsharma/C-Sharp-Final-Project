using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace OnlineQuiz
{
    public partial class frmLogin : Form
    {
        public static long studentID = 0;

        Form F;
        public frmLogin()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string sqlCode = "Delete Members where Email = 'emmaw@school.com'";
            insertToSQL.ExecuteSQL(sqlCode);
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
             if (txtName.Text.Equals("") || txtName.Text.Equals(" "))
            {
                MessageBox.Show("Please enter a valid name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtID.Text.Equals("") || txtID.Text.Equals(" "))
            {
                MessageBox.Show("Please enter a valid student ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (rdoFemale.Checked == false && rdoMale.Checked == false)
            {
                MessageBox.Show("Please select a gender!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string gender = string.Empty;
                if (rdoFemale.Checked == true)
                    gender = "F";
                else if (rdoMale.Checked == true)
                    gender = "M";

                studentID = Convert.ToInt64(txtID.Text);

                //SQL connection stuff here
                string sqlCode;

                /*
                 * SQL Code:
                 * Insert into Members (StudentID, Name, Email, DateTest, Gender)
                 * Values (ID, Name, Email, DateTest, Gender)
                 * */

                
                sqlCode = 
                    "Insert into Members " +
                    " (StudentID, Name, Email, DateTest, Gender)" +
                    " Values (" +
                    txtID.Text + ", " +
                    " ' " + txtName.Text + " ' , '" +
                    txtEmail.Text + " ' , '" + lblDate.Text + "' , '" +
                    gender + "')";
                
                insertToSQL.ExecuteSQL(sqlCode);
                
                F = new frmQuiz();
                F.Show();
                this.Hide();
            }
        }

        private void txtID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
