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
    public partial class Update : Form
    {
        Stafflogic ob = new Stafflogic();
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            panel1.Visible = false;
            btnupdate.Visible = false;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form3 ob = new Form3();
            ob.Show();
            this.Hide();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            int CID = Convert.ToInt32(txtcid.Value.ToString());
            DataSet res = ob.GetSearchData(CID);
            if (Convert.ToInt32(res.Tables[0].Rows.Count.ToString()) > 0)
            {
                panel1.Visible = true;
                textname.Text = res.Tables[0].Rows[0]["StaffName"].ToString();
                textexp.Text = res.Tables[0].Rows[0]["Experience"].ToString();
                textcid.Text = res.Tables[0].Rows[0]["CID"].ToString();
                btnupdate.Visible = true;
            }
            else
            {
                MessageBox.Show("Record wrt doesnt exist");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Staff s = new Staff();
            s.Id = Convert.ToInt32(txtcid.Value);
            s.StaffName = textname.Text;
            s.Experience = int.Parse(textexp.Text);
            s.CID = int.Parse(textcid.Text);
            string msg = ob.Update(s);
            MessageBox.Show(msg);
            dataGridView1.DataSource = ob.getStaffDetails();
            dataGridView1.Visible = true;
        }
    }
}

