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
    public partial class Form1 : Form
    {
        private int ticks;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            login_page frm2 = new login_page();
            ticks++;
            if (ticks == 25)
            {
                this.Hide();


            }
            if (ticks == 25)
            {
                frm2.Show();
            }
        }
    }
}
