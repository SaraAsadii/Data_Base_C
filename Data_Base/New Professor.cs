using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Data_Base
{
    public partial class New_Professor : Form
    {
        public New_Professor()
        {
            InitializeComponent();
        }

        private void New_Professor_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string lastname = textBox2.Text;
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\Data_Base\\Data_Base\\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = " INSERT INTO استاد (name,lastname) VALUES ('" + name + "', '" + lastname + "')";
            SqlCommand cmd = new SqlCommand(query, sc);
            cmd.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("!با موفقیت ذخیره شد");
            textBox1.Text = textBox2.Text = "";
        }
    }
}
 