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
    public partial class search_student : Form
    {
        public search_student()
        {
            InitializeComponent();
        }
        MySqlConnection conn12 = new MySqlConnection("server=localhost;user id=root;database=rushi;persistsecurityinfo=True;password=system");
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                try
                {
                    conn12.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("select id, first_name,middle_name,last_name from admission where first_name='" + textBox1.Text + "'and last_name='"+textBox2.Text+"'", conn12);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    conn12.Close();
                    if (dt.Rows.Count >0)
                    {
                        MessageBox.Show(""+dt.Rows.Count+" Record found...", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                            dataGridView1.Visible = true;
                        dataGridView1.DataSource = dt;
                     
                    }
                    else
                    {
                        MessageBox.Show(" Record not found...", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                   
                }
                catch(Exception)
                {
                    MessageBox.Show("something went wrong", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show(" please enter name...", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.textBox1.Focus();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void search_student_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible =  false;
            

            
            // TODO: This line of code loads data into the 'rushiDataSet4.admission' table. You can move, or remove it, as needed.
           // this.admissionTableAdapter.Fill(this.rushiDataSet4.admission);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
