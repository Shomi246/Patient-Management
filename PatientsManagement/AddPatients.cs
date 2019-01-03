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
    public partial class AddPatients : Form
    {
        public AddPatients()
        {
            InitializeComponent();
        }

        private string sq = "Data Source=DESKTOP-DRE63AO\\SQLEXPRESS;Initial Catalog = Patients; Integrated Security = True";
        private void save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sq);
            
            SqlCommand cmd = new SqlCommand("Insert Into Rec(Name, Age, Phone, Date, Time) values('" + txtn.Text + "','" + txta.Text + "', '" + txtp.Text + "', '"+ txtd.Text +"' , '"+ txtt.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            
            MessageBox.Show("SAVED");
        }

        private void search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sq);
            string que = "Select Name, Age, Phone, Date, Time from Rec where id = '" + txtid.Text + "'";
            SqlDataAdapter adadpt = new SqlDataAdapter(que, con);
            DataTable dt = new DataTable();
            adadpt.Fill(dt);

            if (dt.Rows.Count > 0)
            {

                txtn.Text = Convert.ToString(dt.Rows[0][0]);
                txta.Text = Convert.ToString(dt.Rows[0][1]);
                txtp.Text = Convert.ToString(dt.Rows[0][2]);
                txtd.Text = Convert.ToString(dt.Rows[0][3]);
                txtt.Text = Convert.ToString(dt.Rows[0][4]);

            }

            con.Close();
            MessageBox.Show("Done");
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sq);
            SqlCommand cmd = new SqlCommand("Update Rec set Name = '" + txtn.Text + "', Age = '" + txta.Text + "', Phone = '" + txtp.Text + "', Date = '" + txtd.Text + "', Time = '" + txtt.Text + "' where id= '" + txtid.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sq);
            SqlCommand cmd = new SqlCommand("Delete Rec where id= '" + txtid.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted");
        }

        private void back_Click(object sender, EventArgs e)
        {
            PatientsDetails pd = new PatientsDetails();
            pd.Show();

            this.Hide();
        }

    }
}
