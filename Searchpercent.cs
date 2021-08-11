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
    public partial class Searchpercent : Form
    {
        Studentlogic ob = new Studentlogic();
        public Searchpercent()
        {
            InitializeComponent();
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            float per = float.Parse(txtPer.Text);
            dataGridView1.DataSource = ob.getStudentPercent(per);
            float Totalfees = dataGridView1.Rows.Cast<DataGridViewRow>().Sum(t => float.Parse(t.Cells[5].Value.ToString()));
            label3.Text = Totalfees.ToString();
        }
    }
}
