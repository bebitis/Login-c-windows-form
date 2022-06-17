using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logistree
{
    public partial class signup : Form
    {



        public signup()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login_page frm2 = new login_page();
            this.Close();
            frm2.Show();
        }

        private void Edit(bool value)
        {
            textBox1.Enabled = value;
            textBox2.Enabled = value;

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }
    }
}
