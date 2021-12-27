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
    public partial class upload_photo : Form
    {
        public upload_photo()
        {
            InitializeComponent();
        }
        new_admission new_Admission = new new_admission();
        MySqlConnection conn3 = new MySqlConnection("server=localhost;user id=root;database=rushi;persistsecurityinfo=True;password=system");
        OpenFileDialog openFileDialog2 = new OpenFileDialog();
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
       
       
        private void upload_photo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:";
            openFileDialog1.Title = "Open Image";
            openFileDialog1.Filter = "Image files|*.jpg";
            openFileDialog1.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
      
            openFileDialog2.InitialDirectory = "c:";
            openFileDialog2.Title = "Open Image";
            openFileDialog2.Filter = "Image files|*.jpg";
            openFileDialog2.ShowDialog();
            pictureBox2.Image = Image.FromFile(openFileDialog2.FileName);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
        

            if(openFileDialog1.FileName =="" && openFileDialog2.FileName=="")
            {
                MessageBox.Show("please fill the document.", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                
                   MemoryStream ms = new MemoryStream();
                   pictureBox1.Image.Save(ms,pictureBox1.Image.RawFormat);
                   byte[] img1 = ms.ToArray();                        
                 
              
                  
                MySqlCommand cmd = new MySqlCommand("update  admission set photo1= @img1 where first_name='"+new_admission.b+"'", conn3);
                MySqlParameter blob = new MySqlParameter("@img1", MySqlDbType.LongBlob, img1.Length);
                blob.Value = img1;
                cmd.Parameters.Add(blob);
                cmd.CommandType = CommandType.Text;
                conn3.Open();
                int   n = cmd.ExecuteNonQuery();
                conn3.Close();

           /*    MemoryStream ms2 = new MemoryStream();
               pictureBox2.Image.Save(ms2, pictureBox2.Image.RawFormat);
               byte[] img2 = ms2.ToArray();
              
             
                MySqlCommand cmd3 = new MySqlCommand("update  admission set photo2=' "+ img2 +" 'where first_name='" + new_admission.b + "'", conn3);
                cmd3.CommandType = CommandType.Text;
                conn3.Open();
                int  p = cmd3.ExecuteNonQuery();
                conn3.Close();
              */
                if (n > 0)
                {
                    MessageBox.Show("data uploaded successfully...", "information", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
                else
                {
                    MessageBox.Show("data not saved", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void upload_photo_FormClosing(object sender, FormClosingEventArgs e)
        {
          
               
        }
    }
}