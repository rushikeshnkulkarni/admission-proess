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
    public partial class student_list : Form
    {
        public student_list()
        {
            InitializeComponent();
        }
        MySqlConnection conn6 = new MySqlConnection("server=localhost;user id=root;database=rushi;persistsecurityinfo=True;password=system");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            

        }

        private void student_list_Load(object sender, EventArgs e)
        {
            conn6.Open();
            MySqlDataAdapter adp3 = new MySqlDataAdapter("select * from admission", conn6);
            DataTable ds = new DataTable();
            conn6.Close();
            adp3.Fill(ds);
            dataGridView1.DataSource = ds;

        }

        private void loginformBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
