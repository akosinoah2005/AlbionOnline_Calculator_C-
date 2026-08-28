using System.Reflection.Emit;

namespace Albion_Calcu_C3
{
    public partial class Form1 : Form
    {
        public ComboBox get_cmbBonus()
        {
            return cmbBonus;
        }
        public ComboBox get_cmbLocation()
        {
            return cmbLocation;
        }
        public ToolStripMenuItem get_stripTime()
        {
            return stripTime;
        }

        public ToolStripMenuItem get_stripTime_Resource()
        {
            return stripTime_Resource;
        }

        public ToolStripMenuItem get_stripTime_Product()
        {
            return stripTime_Product;
        }

        public ToolStripMenuItem get_Prices()
        {

            return stripPrices;
        }
        public ToolStripMenuItem get_stripProduct()
        {
            return stripProduct;
        }
        public ToolStripMenuItem get_stripResource()
        {
            return stripResource;
        }
        public NumericUpDown get_numAmount()
        {

            return numAmount;
        }
        public NumericUpDown get_numUsageFee()
        {

            return numUsageFee;
        }
        public ToolStripMenuItem get_stripClearAll()
        {
            return stripClearAll;
        }

        public float Get_rrr()
        {
            return rrr;
        }
        public uint Get_Amount()
        {
            return Amount;
        }

        public uint Get_UsageFee()
        {
            return UsageFee;
        }

        //user-made variables
        private Dictionary<string, float> Bonuses = new Dictionary<string, float> {
            {"royal city", 18f},
            {"royal city with bonus",58f },
            {"+10%",10f },
            {"+20%",20f },
            {"None",0f }
        };
        private float rrr;
        private uint Amount;
        private uint UsageFee;


        private void stealfocus_Form1() => label10.Focus();
        private void Load_Defaults()
        {
            cmbOrder.SelectedIndex = 0;
            cmbPull_Location.SelectedIndex = 0;
            cmbType.SelectedIndex = 0;
            cmbChooseResource.SelectedIndex = 0;
            cmbLocation.SelectedIndex = 1;
            cmbBonus.SelectedIndex = 0;
            lblReturnRate.Text = (Get_ReturnRate() * 100).ToString("0.00") + "%";

            //populate the panel with UserControl1.cs and pass the instance of the Form1
            Form1 instance_form1 = this;
            UserControl new_refine = new UserControl1(instance_form1);

            pnlRefine.Controls.Clear();

            pnlRefine.Controls.Add(new_refine);
        }

        public DialogResult msg_results(string text, string caption, MessageBoxButtons msgButton)
        {
            DialogResult result = MessageBox.Show(text, caption, msgButton);
            return result;
        }

        private float Get_ReturnRate()
        {

            float product_bonus = Bonuses.GetValueOrDefault(cmbBonus.Text) + Bonuses.GetValueOrDefault(cmbLocation.Text);
            rrr = 1 - (1 / (1 + (product_bonus / 100)));

            return rrr;
        }

        private void Get_zeros(NumericUpDown numchecker)
        {

            if (numchecker.Text == "")
            {
                numchecker.Text = "0";
            }
        }
        private string Get_Type()
        {
            if (cmbType.Text == "Raw")
            {
                switch (cmbChooseResource.SelectedIndex)
                {
                    case 0:
                        return "ORE";

                    case 1:
                        return "CLOTH";
                    case 2:
                        return "HIDE";
                    case 3:
                        return "ROCK";
                    case 4:
                        return "WOOD";

                }
            }

            if (cmbType.Text == "Refined")
            {
                switch (cmbChooseResource.SelectedIndex)
                {
                    case 0:
                        return "METALBAR";

                    case 1:
                        return "FIBER";
                    case 2:
                        return "LEATHER";
                    case 3:
                        return "STONEBLOCK";
                    case 4:
                        return "PLANKS";

                }
            }
            return "";
        }
        public Form1()
        {
            InitializeComponent();

        }



        //EVENTS
        private void Form1_Load(object sender, EventArgs e)
        {
            
            Load_Defaults();
        }

        private void numUsageFee_Validated(object sender, EventArgs e)
        {
            Get_zeros(numUsageFee);
        }

        private void numAmount_Validated(object sender, EventArgs e)
        {
            Get_zeros(numAmount);
        }

        private void cmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblReturnRate.Text = (Get_ReturnRate() * 100).ToString("0.00") + "%";

        }

        private void cmbBonus_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblReturnRate.Text = (Get_ReturnRate() * 100).ToString("0.00") + "%";
        }


        private void numKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                stealfocus_Form1();
            }
        }



        private void nummastery_Validated(object sender, EventArgs e)
        {

            Get_zeros((NumericUpDown)sender);
        }

        private void Usage_Amound_valueChanged(object sender, EventArgs e)
        {
            NumericUpDown obj = (NumericUpDown)sender;
            if (obj.Value <= UInt32.MaxValue)
            {
                if (obj.Name == "numUsageFee") UsageFee = Convert.ToUInt32(obj.Value);
                if (obj.Name == "numAmount") Amount = Convert.ToUInt32(obj.Value);
            }
            else
            {
                MessageBox.Show("Invalid Quantity", "Try Again");
                obj.Text = "0";
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

            string location_pull;
            string item_ID_pull;
            CheckedListBox check = checkTier;
            item_ID_pull = "";
            location_pull = cmbPull_Location.Text;
            for (int i = 0; i < check.CheckedItems.Count; i++)
            {

                string[]? split = (check.CheckedItems[i]?.ToString())?.Split('.');
                item_ID_pull += $"T{split?[0]}_{Get_Type()}";

                if (Convert.ToInt16(split?[1]) > 0)
                {
                    item_ID_pull += $"_LEVEL{split?[1]}@{split?[1]}";
                }

                if (i < check.CheckedItems.Count - 1)
                {
                    item_ID_pull += ",";
                }



            }


        }

        private void ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }



        private void checkTier_Validated(object sender, EventArgs e)
        {

        }
        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            bool check = false;

            if (chkSelectAll.Checked)
            {

                check = true;
            }
            else
            {
                check = false;
            }

            for (int i = 0; i < checkTier.Items.Count; i++)
            {
                checkTier.SetItemChecked(i, check);
            }

        }
        private void stripMastery_Clicked(object sender, EventArgs e)
        {


            if (msg_results("Would you like to clear Mastery?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                numMasteryT4.Value = 0;
                numMasteryT5.Value = 0;
                numMasteryT6.Value = 0;
                numMasteryT7.Value = 0;
                numMasteryT8.Value = 0;
            }

        }

        private void stripStation_Clicked(object sender, EventArgs e)
        {
            if (msg_results("Would you like to clear Station Config?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                numUsageFee.Value = 0;
                numAmount.Value = 0;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (msg_results("Would you like to close the application?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void hideConfigToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (hideConfigToolStripMenuItem.Checked)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                pnlRefine.Dock = DockStyle.Fill;
            }
            else
            {
                pnlRefine.Dock = DockStyle.Bottom;
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
            }
        }
    }
}
