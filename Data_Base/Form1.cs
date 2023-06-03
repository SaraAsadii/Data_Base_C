using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Base
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        New_Professor NP = new New_Professor();
        New_Student NS = new New_Student();
        List_P LP = new List_P();
        List_S LS = new List_S();
        PhoneNumber PN = new PhoneNumber();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NP.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NS.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LP.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LS.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PN.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
