using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Data_Base
{
    public partial class PhoneNumber : Form
    {
        public PhoneNumber()
        {
            InitializeComponent();
        }

        private void PhoneNumber_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studentcode = textBox1.Text;
            string phonenumber = textBox5.Text;
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\Data_Base\\Data_Base\\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = "SELECT شماره موبایل FROM دانشجو WHERE کد دانشجویی ='" + studentcode + "'";
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader read = cmd.ExecuteReader();
            string phone = read["شماره موبایل "].ToString();
            textBox2.Text = phonenumber;
            sc.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox3.Text;
            string lastname = textBox4.Text;
            string phonenumber = textBox5.Text;
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\Data_Base\\Data_Base\\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = " UPDATE دانشجو SET شماره موبایل='" + phonenumber +"' WHERE نام='" + name + "' , نام خانوادگی='" + lastname + "' ";
            SqlCommand cmd = new SqlCommand(query, sc);
            cmd.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("ویرایش صورت گرفت!");
            textBox3.Text = textBox4.Text = textBox5.Text = "";
        }
    }
}
