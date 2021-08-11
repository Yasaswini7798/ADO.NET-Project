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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            StaffDetails ob = new StaffDetails();
            ob.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Insertstaff ob = new Insertstaff();
            ob.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update ob = new Update();
            ob.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Delete ob = new Delete();
            ob.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SearchStaff ob = new SearchStaff();
            ob.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DB1_Details ob = new DB1_Details();
            ob.Show();
            this.Hide();
        }

        private void iNSERTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insertstaff ob = new Insertstaff();
            ob.Show();
            this.Hide();
        }

        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update ob = new Update();
            ob.Show();
            this.Hide();
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete ob = new Delete();
            ob.Show();
            this.Hide();
        }

        private void dETAILSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StaffDetails ob = new StaffDetails();
            ob.Show();
            this.Hide();
        }

        private void sEARCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStaff ob = new SearchStaff();
            ob.Show();
            this.Hide();
        }

        private void dELETEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Delete ob = new Delete();
            ob.Show();
            this.Hide();
        }

        private void dATABASEDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB1_Details ob = new DB1_Details();
            ob.Show();
            this.Hide();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THANK YOU FOR VISITING US");
            Application.Exit();
        }

        private void mAINPAGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ob = new Form2();
            ob.Show();
            this.Hide();
        }
    }
}
