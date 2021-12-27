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
    
    public partial class pass_correction : Form
    {
        public static string a ;
        public pass_correction()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection(@"server = localhost; user id = root; database=rushi;persistsecurityinfo=True; password=system");
       
        private void pass_correction_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Trim() == "")
            {
                MessageBox.Show("please enter the username", "ok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.textBox1.Focus();
              
                return;
            }
            if (this.textBox2.Text.Trim() == "")
            {
                MessageBox.Show("please enter the mobile number", "ok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.textBox2.Focus();
                return;
            }

            if (this.textBox3.Text.Trim() == "")
            {
                MessageBox.Show("please enter the email id", "ok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.textBox3.Focus();
                return;
            }

            try
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("select * from loginform where username='" + this.textBox1.Text + "'and mobile_number='" + textBox2.Text + "'and email_id='" + this.textBox3.Text + "'", conn);
                DataSet dt1 = new DataSet();
                adapter.Fill(dt1);

                if (dt1.Tables[0].Rows.Count > 0)
                {
                    new_pass new_Pass = new new_pass();
                    new_Pass.Show();
                }
                else
                    MessageBox.Show("please enter valid details", "ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("something went wrong", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            a = this.textBox1.Text;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & !char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != ('@') & e.KeyChar != ('.'))
            {
                e.Handled = true;
            }
        }
    }
}
