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

namespace Data_Base
{
    public partial class New_Student : Form
    {
        public New_Student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string lastname = textBox2.Text;
            string phonenumber = textBox3.Text;
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\Data_Base\\Data_Base\\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = " INSERT INTO دانشجو (name,lastname,phonenumber) VALUES ('" + name + "', '" + lastname + "', '" + phonenumber + "')";
            SqlCommand cmd = new SqlCommand(query, sc);
            cmd.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("!با موفقیت ذخیره شد");
            textBox1.Text = textBox2.Text = "";
        }

        private void New_Student_Load(object sender, EventArgs e)
        {

        }
    }
}
