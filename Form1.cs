using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONETPROJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Details ob = new Details();
            ob.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InsertData ob = new InsertData();
            ob.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Search ob = new Search();
            ob.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DBdetails ob = new DBdetails();
            ob.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateData ob = new UpdateData();
            ob.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteData ob = new DeleteData();
            ob.Show();
            this.Hide();
        }

        private void iNSERTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertData ob = new InsertData();
            ob.Show();
            this.Hide();
        }

        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateData ob = new UpdateData();
            ob.Show();
            this.Hide();
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteData ob = new DeleteData();
            ob.Show();
            this.Hide();
        }

       

        private void sEARCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search ob = new Search();
            ob.Show();
            this.Hide();
        }

        private void dELETEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteData ob = new DeleteData();
            ob.Show();
            this.Hide();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THANK YOU FOR VISITING US");
            Application.Exit();
        }

        private void dETAILSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Details ob = new Details();
            ob.Show();
            this.Hide();
        }

        private void dATABASEDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBdetails ob = new DBdetails();
            ob.Show();
            this.Hide();
        }

        private void sEARCHPERCENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Searchpercent ob = new Searchpercent();
            ob.Show();
            this.Hide();
        }

       
    }
}
