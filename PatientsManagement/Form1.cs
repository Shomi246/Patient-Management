using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PatientsManagement
{
    public partial class PatientsDetails : Form
    {
        public PatientsDetails()
        {
            InitializeComponent();
            LoadGridData();
        }

        private int id = 0;
        private string sq = "Data Source=DESKTOP-DRE63AO\\SQLEXPRESS; Initial Catalog=Patients; Integrated Security=True";
        private void LoadGridData()
        {
            SqlConnection con = new SqlConnection(sq);
            SqlDataAdapter adadpt = new SqlDataAdapter("Select * from Rec", con);
            DataTable dt = new DataTable();
            adadpt.Fill(dt);

            datagrid.DataSource = dt;
            con.Close();
        }

        private void newp_Click(object sender, EventArgs e)
        {
            AddPatients add = new AddPatients();
            add.Show();
            this.Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(sq);
            string que = "Select Name, Age, Phone, Date, Time from Rec where id = '"+txtid.Text+"'";
            SqlDataAdapter adadpt = new SqlDataAdapter(que, con);
            DataTable dt = new DataTable();
            adadpt.Fill(dt);

            datagrid.DataSource = dt;
            con.Close();
            MessageBox.Show("Done");
        }

       
    }
}
