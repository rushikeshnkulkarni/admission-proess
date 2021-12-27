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
    public partial class login_form : Form
    {
         public static string us;
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=rushi;persistsecurityinfo=True;password=system");
        
        string uname, pass;
        public login_form()
        {
            InitializeComponent();
           
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            us = textBox1.Text;
            if (textBox1.Text.Trim() == "" && textBox2.Text.Trim() == "")
            {
                MessageBox.Show("please enter username and pasword", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox1.Text.Trim() == "")
            {                                       
                MessageBox.Show("please enter username", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("please enter password", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }
            try
            {
                con.Open();
                MySqlDataAdapter adp = new MySqlDataAdapter("select username , password from loginform where username='" + this.textBox1.Text + "'and  password='" + this.textBox2.Text + "'", con);
                DataSet dt = new DataSet();
                adp.Fill(dt);
                uname = dt.Tables[0].Rows[0]["username"].ToString();
                pass = dt.Tables[0].Rows[0]["password"].ToString();
                con.Close();
                if (uname==this.textBox1.Text && pass==this.textBox2.Text) 
                {
                    admission ad = new admission();
                     this.Hide();
                    ad.Show();

                }
                else
                {
                    MessageBox.Show("please enter correct username or password", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                }

             

            }
            catch(Exception)
            {
                MessageBox.Show("something went wrong","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }   
         }

     

        private void button3_Click(object sender, EventArgs e)
        {
           
            login_form login_Form = new login_form();
           this.Hide();
            pass_correction pass_Correction = new pass_correction();

            pass_Correction.Show();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);          
        }                          
                                                           
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}