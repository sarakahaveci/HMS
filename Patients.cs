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

namespace WindowsFormsApp1
{
    public partial class Patients : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAMSUNG\Documents\MHSdb.mdf;Integrated Security=True;Connect Timeout=30");
        public Patients()
        {
            InitializeComponent();
        }
        void populate()
        {
            Con.Open();
            string query = " select * from PatTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var view = new DataSet();
            da.Fill(view);
            PatGV.DataSource = view.Tables[0];
            Con.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "insert into PatTbl values(" + PatID.Text + ", " + PatName.Text + "," + FileNumber.Text + "," + CitizenID.Text + "," + Gender.Text + ", " + Birthdate.Text + ", " + Nationality.Text + ", " + PhoneNum.Text + ", " + Email.Text + "," + Country.Text + "," + City.Text + "," + Street.Text + "," + Address1.Text + "," + Address2.Text + "," + ContactPerson.Text + "," + ContactRelation.Text + "," + ContactPhone.Text + ", " + FirstVIstit.Text + "," + RecordCreationDate.Text + ")";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Patient Added Sucecsfully");
            Con.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void PatGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populate();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PatID.Text == "")
                MessageBox.Show("Enter the Patient ID");
            else
            {
                Con.Open();
                string query = "delete from PatTbl where PatID" + PatID.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient deleted Successfully!");
                Con.Close();
                populate();
            }
        }
    }
}
