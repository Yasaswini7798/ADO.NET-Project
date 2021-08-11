using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADONETPROJ.Model;

namespace ADONETPROJ
{
    public partial class DBdetails : Form
    {
        Studentlogic ob = new Studentlogic();
        public DBdetails()
        {
            InitializeComponent();
        }

        private void DBdetails_Load(object sender, EventArgs e)
        {

            cbtables.DataSource = ob.GettableData().Tables[0];
            cbtables.DisplayMember = "name";

        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            int i = cbtables.SelectedIndex;
            i++;
            dataGridView1.DataSource = ob.GettableData().Tables[i];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ob = new Form1();
            ob.Show();
            this.Hide();
        }
    }
}
