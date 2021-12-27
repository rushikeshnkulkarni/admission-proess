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
    public partial class delete_admission : Form
    {
        public delete_admission()
        {
            InitializeComponent();
        }

        MySqlConnection conn5 = new MySqlConnection("server=localhost;user id=root;database=rushi;persistsecurityinfo=True;password=system");

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("please enter  student id..", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            conn5.Open();
            MySqlCommand cmd5 = new MySqlCommand("delete  from admission where id='" + textBox1.Text + "'", conn5);
            cmd5.CommandType = CommandType.Text;
            int v = cmd5.ExecuteNonQuery();
            conn5.Close();
            if(v==1)
            {
                MessageBox.Show("admission deleted..", "information",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show(" id not found", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            textBox1.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back )
            {
                e.Handled = true;
            }
        }
    }
}
