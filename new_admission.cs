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
    public partial class new_admission : Form
    {
        public new_admission()
        {
            InitializeComponent();
        }
       public static string b;
        int n;
    //  public  MySqlTransaction tran = null;
       

        MySqlConnection conn2 = new MySqlConnection("server=localhost;user id=root;database=rushi;persistsecurityinfo=True; password=system");
        
       
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b = textBox2.Text;
            if (this.textBox2.Text.Trim() == "")
            {
                MessageBox.Show("please fill the information", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.textBox2.Focus();
                return;
            }
            if (this.textBox1.Text.Trim() == "")
            {
                MessageBox.Show("please fill the information", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.textBox1.Focus();
                return;
            }
          
         
            if (this.textBox3.Text.Trim() == "")
            {
                MessageBox.Show("please fill the information", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.textBox3.Focus();
                return;
            }
            if (this.textBox3.Text.Trim() == "")
            {
                MessageBox.Show("please fill the information", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.textBox3.Focus();
                return;
            }
            if (this.textBox4.Text.Trim() == "")
            {
                MessageBox.Show("please fill the information", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.textBox4.Focus();
                return;
            }
            if (this.textBox5.Text.Trim() == "")
            {
                MessageBox.Show("please fill the information", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.textBox5.Focus();
                return;
            }
            if (this.textBox6.Text.Trim() == "")
            {
                MessageBox.Show("please fill the information", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.textBox6.Focus();
                return;
            }
            if (this.textBox7.Text.Trim() == "")
            {
                MessageBox.Show("please fill the information", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.textBox7.Focus();
                return;
            }
            if (this.textBox8.Text.Trim() == "")
            {
                MessageBox.Show("please fill the information", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.textBox8.Focus();
                return;
            }
            if (this.textBox9.Text.Trim() == "")
            {
                MessageBox.Show("please fill the information", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.textBox9.Focus();
                return;
            }
            if (this.comboBox1.Text.Trim() == "")
            {
                MessageBox.Show("please fill the information", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.comboBox1.Focus();
                return;
            }
            if (this.comboBox2.Text.Trim() == "")
            {
                MessageBox.Show("please fill the information", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.comboBox2.Focus();
                return;
            }             
            if (this.comboBox3.Text.Trim() == "")
            {
                MessageBox.Show("please fill the information", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.comboBox3.Focus();
                return;
            }

            try
            {
                 
                conn2.Open();
              //  tran = conn2.BeginTransaction();
                MySqlCommand cmd = new MySqlCommand("insert into admission (first_name,middle_name,last_name,gender,region,previous_class,marks,new_class,aadhar_number,mobile_number,email_id,address,admissinBy,ondate) values ('" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "','" + this.comboBox1.Text + "','" + this.comboBox3.Text + "','" + this.textBox5.Text + "','" + this.textBox1.Text + "','" + this.comboBox2.Text + "','" + this.textBox6.Text + "','" + this.textBox8.Text + "','" + this.textBox7.Text + "','" + this.textBox9.Text + "','" + login_form.us + "','" + this.dateTimePicker1.Text + "')", conn2);
                cmd.CommandType = CommandType.Text;
                n = cmd.ExecuteNonQuery();
                conn2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("something went wrong", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (n > 0)
                    MessageBox.Show("data saved successfully...", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     
                else
                {
                    MessageBox.Show("data can not saved", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            this.textBox1.Clear();
           // this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
            this.textBox5.Clear();
            this.textBox6.Clear();
            this.textBox7.Clear();
            this.textBox8.Clear();
            this.textBox9.Clear();
            

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void new_admission_Load(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //    if (n > 0)
            //   {
            // conn2.Open();
            //tran.Commit();

            //     MySqlDataAdapter adapter = new MySqlDataAdapter("select * from admission", conn2);
            //   DataSet ds = new DataSet();
            // adapter.Fill(ds);
          //  conn2.Close();

            upload_photo upload_Photo = new upload_photo();
                this.Hide();
              
                upload_Photo.Show();
        ///    }
           // else
                MessageBox.Show("please save the data","warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          // b = this.textBox2.Text;
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
           dateTimePicker1.Value = DateTime.Today;
        }

        private void textBox10_TextChanged_1(object sender, EventArgs e)
        {
          //  textBox10.Text = login_form.us;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar)&(Keys)e.KeyChar!=Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
                e.Handled = true;
          
         
            
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
           
                e.Handled = true;
          


        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar)&!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & !char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar !=('@')&e.KeyChar !=('.'))
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back &e.KeyChar !=('+'))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
                e.Handled = true;
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar !=('.') & e.KeyChar !=('%'))
            {
                e.Handled = true;
            }
        }

        private void new_admission_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
             //  tran.Rollback();
              // conn2.Close();
            }
            catch (Exception )
            {

            }
        }
    }
}