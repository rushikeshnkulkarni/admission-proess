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
    public partial class new_pass : Form
    {
        
        
        public new_pass()
        {
            InitializeComponent();
        }
        MySqlConnection conn1 = new MySqlConnection("server=localhost;user id=root;database=rushi;persistsecurityinfo=True;password=system");
        private void button1_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text.Trim() == "")
            {
                MessageBox.Show("please enter password","warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            if (this.textBox2.Text.Trim() == "")
            {
                MessageBox.Show("please enter new password", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if(textBox1.Text==textBox2.Text)
            {

                try
                {

                    conn1.Open();
                    MySqlCommand cmd = new MySqlCommand("update loginform set password ='" + textBox1.Text + "'where username='" + pass_correction.a + "'", conn1);
                    cmd.CommandType = CommandType.Text;

                    int n = cmd.ExecuteNonQuery();
                    conn1.Close();


                    if (n > 0)
                    {
                        MessageBox.Show("password successfully changed", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(" sorry..! password can not changed", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("something went wrong", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
          
        }

        private void new_pass_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
