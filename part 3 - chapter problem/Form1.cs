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
            lblAnswerage.Visible = true;
            lblAnswerheight.Visible =true;
            lblAnswername.Visible = true;






            string name = txtName.Text;
            lblAnswername.Text = "Hello " + name;

            int age = Convert.ToInt32(nudAge.Value);
            lblAnswerage.Text = "You are " + (82 - age) + " years away from the average life expectancy in Canada.";

            double height = (double)Convert.ToDouble(txtHeight.Text);
            lblAnswerheight.Text = "You are " +Math.Round (2.72 - height,2)+ " merters shorter than the tallest person ever.";




        }
    }
}
