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
    public partial class StaffDetails : Form
    {
        public StaffDetails()
        {
            InitializeComponent();
        }

        private void StaffDetails_Load(object sender, EventArgs e)
        {
            Stafflogic ob = new Stafflogic();
            dataGridView1.DataSource = ob.getStaffDetails();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 ob = new Form3();
            ob.Show();
            this.Hide();
        }
    }
}
