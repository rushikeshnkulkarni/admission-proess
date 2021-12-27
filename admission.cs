using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace admission_registration
{
    public partial class admission : Form
    {
        public admission()
        {
            InitializeComponent();
        }
     
     
        private void acadamicsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new_admission new_Admission = new new_admission();
          //  this.Hide();
            new_Admission.Show();
           
        }

        private void updateStudentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_student update_Student = new update_student();
           // this.Hide();
            update_Student.Show();
         

        }

        private void deleteAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete_admission delete_Admission = new delete_admission();
          //  this.Hide();
            delete_Admission.Show();
           
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            student_list student_List = new student_list();
         //this.Hide();
            student_List.Show();

        }

        private void studentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
              
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_student search_Student = new search_student();
            search_Student.Show();

        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new_account new_Account = new new_account();
            new_Account.Show();
        }

        private void accountListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acccunt_list acccunt_List = new acccunt_list();
            acccunt_List.Show();
            
        }

        private void admission_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult conform = MessageBox.Show("Do you want to Exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (conform == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (conform == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            catch
            {
                Application.Exit();
            }
        }

        private void admission_Load(object sender, EventArgs e)
        {

        }
    }
}
