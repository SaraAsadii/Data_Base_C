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
    public partial class List_P : Form
    {
        public List_P()
        {
            InitializeComponent();
        }

        private void List_P_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string lastname = textBox2.Text;
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\Data_Base\\Data_Base\\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = " DELETE FROM استاد WHERE نام,نام خانوادگی ='" + name + "', '" + lastname + "'";
            SqlCommand cmd = new SqlCommand(query, sc);
            cmd.ExecuteNonQuery();
            sc.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\Data_Base\\Data_Base\\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = " SELECT نام , نام خانوادگی FROM استاد ";
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader["نام , نام خانوادگی"].ToString();
                comboBox1.Items.Add(name);
            }
            sc.Close();
        }
    }
}
