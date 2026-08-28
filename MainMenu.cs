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
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if(!Refine.Created)
            {
                Refine.Show();
            }
        }
    }
}
