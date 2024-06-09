using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



       

        private void btnClick_Click(object sender, EventArgs e)
        {
            String fname = txtBox1.Text;
            String lname = txtBox2.Text;
            String fullname = $"{fname} {lname}";
            MessageBox.Show("Your Full Name is: "+ fullname);
        }

        
    }
}
