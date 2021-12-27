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
    public partial class acccunt_list : Form
    {
        DataTable dt = new DataTable();
        public acccunt_list()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {          
                
            
        }

        private void acccunt_list_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rushiDataSet3.loginform' table. You can move, or remove it, as needed.
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=rushi;persistsecurityinfo=True;password=system");
            con.Open();
            MySqlDataAdapter ad = new MySqlDataAdapter("select id,username,f_name,m_name,l_name,created_by,date_of_creation  from loginform", con);
            
            ad.Fill(dt);
            con.Close();
            dataGridView1.DataSource= dt;
          
        }
    }
}
