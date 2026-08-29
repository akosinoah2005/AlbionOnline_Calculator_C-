using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Albion_Calcu_C3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void Form2_Load(object sender, EventArgs e)
        {

            Refine_Charts refine_chart = new Refine_Charts(this);
            panel1.Controls.Clear();
            panel1.Controls.Add(refine_chart);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {


            DialogResult result = MessageBox.Show("Would you like to exit?", "COnfirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) 
            {
                e.Cancel = true;
                this.Visible = false;
            }
            
        }
    }
}
