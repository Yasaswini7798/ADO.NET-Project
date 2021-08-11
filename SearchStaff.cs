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
    public partial class SearchStaff : Form
    {
        Stafflogic ob = new Stafflogic();
        public SearchStaff()
        {
            InitializeComponent();
        }

        private void SearchStaff_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            int CID = Convert.ToInt32(txtid.Value);
            Stafflogic ob = new Stafflogic();
            dataGridView1.DataSource = ob.GetSearchData(CID).Tables[0];
            dataGridView1.Visible = true;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 ob = new Form3();
            ob.Show();
        }
    }
}
