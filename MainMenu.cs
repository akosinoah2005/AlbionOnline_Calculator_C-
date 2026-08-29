using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Albion_Calcu_C3
{
    public partial class MainMenu : Form
    {
        Form1 Refine = new Form1();
        Form2 Graph = new Form2();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnshowRefine.UseWaitCursor = true;
            if (!Refine.Created)
            {
                Refine.Show();
            }
            else
            {
                Refine.Visible = true;
            }
            btnshowRefine.UseWaitCursor = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnGraph.UseWaitCursor = true;

            if (!Graph.Created)
            {
                Graph.Show();
            }
            else
            {
                Graph.Visible = true;
            }
            btnGraph.UseWaitCursor = false;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
            Graph.Visible = false;
            
            Refine.Visible = false;
        }
    }
}
