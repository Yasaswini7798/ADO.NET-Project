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
    public partial class Insertstaff : Form
    {
        public Insertstaff()
        {
            InitializeComponent();
        }

        private void Insertstaff_Load(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.StaffName = txtname.Text;
            staff.Experience = int.Parse(txtexp.Text);
            staff.CID = int.Parse(txtcid.Text);
           
            Stafflogic ob = new Stafflogic();
            string message = ob.AddData(staff);
            MessageBox.Show(message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 ob = new Form3();
            ob.Show();
        }
    }
}
