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
    public partial class DeleteData : Form
    {
        Studentlogic ob = new Studentlogic();
        public DeleteData()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {

            Form1 ob = new Form1();
            ob.Show();
            this.Hide();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Value.ToString());
            DataSet res = ob.GetSearchData(id);
            if (Convert.ToInt32(res.Tables[0].Rows.Count.ToString()) > 0)
            {
                string msg = ob.GetDeletedata(id);
                MessageBox.Show(msg);
            }
            else
            {
                MessageBox.Show("id doesnt exist");
            }
        }

        
    }
}
