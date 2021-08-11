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
    public partial class InsertData : Form
    {
        public InsertData()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = txtname.Text;
            student.Email = txtemail.Text;
            student.Phone = txtphone.Text;
            student.Fees = float.Parse(txtFees.Text);
            student.Percent = float.Parse(txtPercent.Text);
            //MessageBox.Show(student.ToString());
            Studentlogic ob = new Studentlogic();
            string message = ob.AddData(student);
            MessageBox.Show(message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ob = new Form1();
            ob.Show();
        }

       
    }
}
