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
using System.IO;


namespace admission_registration
{
    public partial class update_student : Form
    {
        public update_student()
        {
            InitializeComponent();
            this.textBox13.Focus();
           
        }

        MySqlConnection conn4 = new MySqlConnection("server=localhost;user id=root;database=rushi;persistsecurityinfo=True;password=system");
        OpenFileDialog openFileDialog3 = new OpenFileDialog();
        byte[] img1 = null;

        int c =0;
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (textBox13.Text != "")
            {
             //   try
               // {
                    conn4.Open();
                    MySqlDataAdapter adp1 = new MySqlDataAdapter("select * from admission where id='" + textBox13.Text + "'", conn4);
                    DataTable dt = new DataTable();
                    adp1.Fill(dt);
                    conn4.Close();

                    if (dt.Rows.Count > 0)
                    {

                        textBox2.Text = dt.Rows[0][1].ToString();
                        textBox3.Text = dt.Rows[0][2].ToString();
                        textBox4.Text = dt.Rows[0][3].ToString();
                        textBox10.Text = dt.Rows[0][4].ToString();
                        textBox11.Text = dt.Rows[0][5].ToString();
                        textBox5.Text = dt.Rows[0][6].ToString();
                        textBox1.Text = dt.Rows[0][7].ToString();
                        textBox12.Text = dt.Rows[0][8].ToString();
                        textBox6.Text = dt.Rows[0][9].ToString();
                        textBox8.Text = dt.Rows[0][10].ToString();
                        textBox7.Text = dt.Rows[0][11].ToString();
                        textBox9.Text = dt.Rows[0][12].ToString();



                        
                            //   byte[]img1 = (byte[])dt.Rows[0][14];
                            //     MemoryStream ms = new MemoryStream(img1);
                          //       Bitmap bitmap = new Bitmap(ms);
                           //    pictureBox3.Image = Image.FromStream(ms);
                          //       adp1.Dispose();
                        


                    }

                    else
                    {
                        MessageBox.Show("please enter correct ID...", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
             //   }
             //   catch(Exception ex)
              //  {
                  
               // }

            
            }
            else
            {
                MessageBox.Show("please enter ID...", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text !="")
            {
                openFileDialog3.InitialDirectory = "c:";
                openFileDialog3.Title = "Open Image";
                openFileDialog3.Filter = "Image files|*.jpg";
                openFileDialog3.ShowDialog();
                pictureBox3.Image = Image.FromFile(openFileDialog3.FileName);
            }
            else
                MessageBox.Show("please enter student ID","warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         if(textBox2.Text=="")
            {
                MessageBox.Show("please fill the proper ID", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox13.Focus();
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("please fill the information", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("please fill the information", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Focus();
                return;
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("please fill the information", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Focus();
                return;
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("please fill the information", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox6.Focus();
                return;
            }
            if (textBox7.Text == "")
            {
                MessageBox.Show("please fill the information", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox7.Focus();
                return;
            }
            if (textBox8.Text == "")
            {
                MessageBox.Show("please fill the information", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox8.Focus();
                return;
            }
            if (textBox9.Text == "")
            {
                MessageBox.Show("please fill the information", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox9.Focus();
                return;
            }
            if (textBox10.Text == "")
            {
                MessageBox.Show("please fill the information", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox10.Focus();
                return;
            }
            if (textBox11.Text == "")
            {
                MessageBox.Show("please fill the information", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox11.Focus();
                return;
            }
            if (textBox12.Text == "")
            {
                MessageBox.Show("please fill the information", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox12.Focus();
                return;
            }
            try
            {
                conn4.Open();
                MySqlCommand cmd6 = new MySqlCommand("update admission set first_name='" + textBox2.Text + "',middle_name='" + textBox3.Text + "',last_name='" + textBox4.Text + "',gender='" + textBox10.Text + "',region='" + textBox11.Text + "',previous_class='" + textBox5.Text + "',marks='" + textBox1.Text + "',new_class='" + textBox12.Text + "',aadhar_number='" + textBox6.Text + "',email_id='" + textBox7.Text + "',address='" + textBox9.Text + "'where id='" + textBox13.Text + "'", conn4);
                int x = cmd6.ExecuteNonQuery();
                conn4.Close();

                if (x == 1)
                {
                    MessageBox.Show("Data updated successfully....", "infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox10.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox13.Clear();
                    textBox13.Focus();
                    pictureBox3.Image = null;
                }
                else
                {
                    MessageBox.Show("Data can't saved..", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {

            }
          
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar)  & (Keys)e.KeyChar != Keys.Back )
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

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back )
            {
                e.Handled = true;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar)  & (Keys)e.KeyChar != Keys.Back )
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & !char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back )
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != ('%') & e.KeyChar != ('.'))
            {
                e.Handled = true;
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & !char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back )
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back )
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (  !char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != ('+') )
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & !char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != ('@') & e.KeyChar != ('.'))
            {
                e.Handled = true;
            }
        }

        private void update_student_Load(object sender, EventArgs e)
        {
          this.textBox13.Focus();
        }
    }
}
