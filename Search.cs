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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Value);
            Studentlogic ob = new Studentlogic();
            dataGridView1.DataSource = ob.GetSearchData(id).Tables[0];
            dataGridView1.Visible = true;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
                this.Hide();
                Form1 ob = new Form1();
                ob.Show();
            }
        }
    }

