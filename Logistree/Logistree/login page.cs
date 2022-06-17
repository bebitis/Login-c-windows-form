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

namespace Logistree
{
    public partial class login_page : Form
    {
        public login_page()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit(bool value)
        {
            textBox1.Enabled = value;
            textBox2.Enabled = value;
        }

            private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                tableBindingSource.EndEdit();
                tableTableAdapter.Update(database1DataSet.Table);
                textBox1.Focus();
                
                

            }
            catch (Exception ex)
            {
                database1DataSet.Table.RejectChanges();
            }
          
        }

        private void login_page_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.database1DataSet.Table);
            Edit(false);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                database1DataSet.Table.AddTableRow(database1DataSet.Table.NewTableRow());
                tableBindingSource.MoveLast();
                textBox1.Focus();
            }
            catch (Exception ex)
            {

                database1DataSet.Table.RejectChanges();
            }
        }
    }
}
