using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace part_3___chapter_problem
{
    public partial class BasicInput : Form
    {
        public BasicInput()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            lblAnswername.Text = "Hello " + Name;

            int age = Convert.ToInt32(nudAge.Value);
            lblAnswerage.Text = "you are " + (82 - age) + " years away from the average life expectancy in Canada";


            
            

        }
    }
}
