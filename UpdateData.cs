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
   
    public partial class UpdateData : Form
    {
        Studentlogic ob = new Studentlogic();
        public UpdateData()
        {
            InitializeComponent();
        }

        private void UpdateData_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            panel1.Visible = false;
            btnupdate.Visible = false;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 ob = new Form1();
            ob.Show();
            this.Hide();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Value.ToString());
            DataSet res = ob.GetSearchData(id);
            /*Student stu = new Student();
           
                stu.Id = id;
                stu.Name = res.Tables[0].Rows[0]["StudentName"].ToString();
                stu.Email = res.Tables[0].Rows[0]["Email"].ToString();
                stu.Phone = res.Tables[0].Rows[0]["Phone"].ToString();
                stu.Fees = float.Parse(res.Tables[0].Rows[0]["Fees"].ToString());
                stu.Percent = float.Parse(res.Tables[0].Rows[0]["Percent"].ToString());

                MessageBox.Show(stu.ToString());
            }*/
            if (Convert.ToInt32(res.Tables[0].Rows.Count.ToString()) > 0)
            {
                panel1.Visible = true;
                textname.Text = res.Tables[0].Rows[0]["StudentName"].ToString();
                textemail.Text = res.Tables[0].Rows[0]["Email"].ToString();
                textphone.Text = res.Tables[0].Rows[0]["Phone"].ToString();
                textfees.Text = res.Tables[0].Rows[0]["Fees"].ToString();
                textpercent.Text = res.Tables[0].Rows[0]["Percent"].ToString();
                btnupdate.Visible = true;
            }
            else
            {
                MessageBox.Show("Record wrt doesnt exist");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Id = Convert.ToInt32(txtid.Value);
            s.Name = textname.Text;
            s.Email = textemail.Text;
            s.Phone = textphone.Text;
            s.Fees = float.Parse(textfees.Text.ToString());
            s.Percent = float.Parse(textpercent.Text.ToString());
            string msg = ob.UpdateData(s);
            MessageBox.Show(msg);
            dataGridView1.DataSource = ob.getStudentDetails();
            dataGridView1.Visible = true;
        }

        
    }
}
