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
    public partial class new_account : Form
    {
        public new_account()
        {
            InitializeComponent();
        }
        MySqlConnection con9 = new MySqlConnection("server=localhost;user id=root;database=rushi;persistsecurityinfo=True;password=system");
        private void button1_Click(object sender, EventArgs e)
        {
          
            if (textBox1.Text.Trim()=="")
            {
         
                MessageBox.Show("please fill username","warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if (textBox2.Text.Trim()=="")
            {
                MessageBox.Show("please fill mobile number", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }
            if (textBox3.Text.Trim() == "")
            {
                MessageBox.Show("please fill email id", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }
            if (textBox4.Text.Trim() == "")
            {
                MessageBox.Show("please fill password", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Focus();
                return;
            }
            if (textBox5.Text.Trim() == "")
            {
                MessageBox.Show("please fill conform pasword", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Focus();
                return;
            }
            if (textBox6.Text=="")
            {
                MessageBox.Show("please Enter First Name", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox6.Focus();
                return;
            }
            if (textBox7.Text.Trim() == "")
            {
                MessageBox.Show("please Enter Middle Name", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox7.Focus();
                return;
            }
            if (textBox8.Text.Trim() == "")
            {
                MessageBox.Show("please Enter Last Name", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox8.Focus();
                return;
            }

            if (textBox4.Text.Trim() == textBox5.Text.Trim())
            {
             
              
                con9.Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select * from loginform where username='" + textBox1.Text + "'", con9);
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);
                con9.Close();
                if (dt.Rows.Count >0)
                {
                    MessageBox.Show("this username is already exist", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return ;
                }
                else
                {
                    try
                    {
                        con9.Open();
                        MySqlCommand cmd = new MySqlCommand("insert into loginform (username,f_name,m_name,l_name,mobile_number,email_id,password,created_by,date_of_creation) values('" + textBox1.Text + "','"+this.textBox6.Text+"','"+this. textBox7.Text.Trim()+"','"+this.textBox8.Text+"','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" +this. textBox5.Text + "','" + login_form.us + "','" + this.dateTimePicker1.Text + "')", con9);                     
                        int v = cmd.ExecuteNonQuery();
                        con9.Close();
                        if (v == 1)
                        {
                            MessageBox.Show("Account created successfully...", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(" account creation failed", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    catch(Exception)
                    {
                        MessageBox.Show(" something went wrong....", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            else
            {
                MessageBox.Show(" pasword mismatched", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Focus();
                return;

            }
            

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar)  & (Keys)e.KeyChar != Keys.Back )
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back )
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar)  & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != ('+') )
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }
    }
}
