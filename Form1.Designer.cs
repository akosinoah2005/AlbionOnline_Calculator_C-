using System.Resources;

namespace Albion_Calcu_C3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            cmbChooseResource = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            cmbBonus = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            numAmount = new NumericUpDown();
            numUsageFee = new NumericUpDown();
            cmbLocation = new ComboBox();
            label7 = new Label();
            lblReturnRate = new Label();
            pnlRefine = new Panel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            numMasteryT8 = new NumericUpDown();
            label11 = new Label();
            numMasteryT7 = new NumericUpDown();
            label10 = new Label();
            numMasteryT6 = new NumericUpDown();
            label9 = new Label();
            numMasteryT5 = new NumericUpDown();
            label8 = new Label();
            numMasteryT4 = new NumericUpDown();
            label1 = new Label();
            groupBox3 = new GroupBox();
            chkSelectAll = new CheckBox();
            cmbOrder = new ComboBox();
            btnPull = new Button();
            cmbPull_Location = new ComboBox();
            checkTier = new CheckedListBox();
            label12 = new Label();
            cmbType = new ComboBox();
            label14 = new Label();
            label15 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            statusToolStripMenuItem = new ToolStripMenuItem();
            premiumToolStripMenuItem = new ToolStripMenuItem();
            stripClearAll = new ToolStripMenuItem();
            stripStation = new ToolStripMenuItem();
            stripPrices = new ToolStripMenuItem();
            stripProduct = new ToolStripMenuItem();
            stripResource = new ToolStripMenuItem();
            stripMastery = new ToolStripMenuItem();
            stripTime = new ToolStripMenuItem();
            stripTime_Resource = new ToolStripMenuItem();
            stripTime_Product = new ToolStripMenuItem();
            hideConfigToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUsageFee).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMasteryT8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMasteryT7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMasteryT6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMasteryT5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMasteryT4).BeginInit();
            groupBox3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Name = "label2";
            // 
            // cmbChooseResource
            // 
            cmbChooseResource.Cursor = Cursors.Hand;
            cmbChooseResource.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbChooseResource.FormattingEnabled = true;
            cmbChooseResource.Items.AddRange(new object[] { resources.GetString("cmbChooseResource.Items"), resources.GetString("cmbChooseResource.Items1"), resources.GetString("cmbChooseResource.Items2"), resources.GetString("cmbChooseResource.Items3"), resources.GetString("cmbChooseResource.Items4") });
            resources.ApplyResources(cmbChooseResource, "cmbChooseResource");
            cmbChooseResource.Name = "cmbChooseResource";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Name = "label4";
            // 
            // cmbBonus
            // 
            cmbBonus.Cursor = Cursors.Hand;
            cmbBonus.DisplayMember = "0";
            cmbBonus.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(cmbBonus, "cmbBonus");
            cmbBonus.FormattingEnabled = true;
            cmbBonus.Items.AddRange(new object[] { resources.GetString("cmbBonus.Items"), resources.GetString("cmbBonus.Items1"), resources.GetString("cmbBonus.Items2") });
            cmbBonus.Name = "cmbBonus";
            cmbBonus.SelectedIndexChanged += cmbBonus_SelectedIndexChanged;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Name = "label6";
            // 
            // numAmount
            // 
            numAmount.Cursor = Cursors.IBeam;
            numAmount.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            resources.ApplyResources(numAmount, "numAmount");
            numAmount.Maximum = new decimal(new int[] { -1486618624, 232830643, 0, 0 });
            numAmount.Name = "numAmount";
            numAmount.ValueChanged += Usage_Amound_valueChanged;
            numAmount.KeyPress += numKeyPress;
            numAmount.Validated += numAmount_Validated;
            // 
            // numUsageFee
            // 
            numUsageFee.Cursor = Cursors.IBeam;
            resources.ApplyResources(numUsageFee, "numUsageFee");
            numUsageFee.Maximum = new decimal(new int[] { -1486618624, 232830643, 0, 0 });
            numUsageFee.Name = "numUsageFee";
            numUsageFee.ValueChanged += Usage_Amound_valueChanged;
            numUsageFee.KeyPress += numKeyPress;
            numUsageFee.Validated += numUsageFee_Validated;
            // 
            // cmbLocation
            // 
            cmbLocation.Cursor = Cursors.Hand;
            cmbLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(cmbLocation, "cmbLocation");
            cmbLocation.FormattingEnabled = true;
            cmbLocation.Items.AddRange(new object[] { resources.GetString("cmbLocation.Items"), resources.GetString("cmbLocation.Items1") });
            cmbLocation.Name = "cmbLocation";
            cmbLocation.SelectedIndexChanged += cmbLocation_SelectedIndexChanged;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Name = "label7";
            // 
            // lblReturnRate
            // 
            resources.ApplyResources(lblReturnRate, "lblReturnRate");
            lblReturnRate.ForeColor = Color.Blue;
            lblReturnRate.Name = "lblReturnRate";
            // 
            // pnlRefine
            // 
            resources.ApplyResources(pnlRefine, "pnlRefine");
            pnlRefine.BackColor = SystemColors.ActiveCaptionText;
            pnlRefine.Name = "pnlRefine";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.Add(lblReturnRate);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbLocation);
            groupBox1.Controls.Add(cmbBonus);
            groupBox1.Controls.Add(numUsageFee);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(numAmount);
            groupBox1.Controls.Add(label6);
            groupBox1.ForeColor = Color.SandyBrown;
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numMasteryT8);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(numMasteryT7);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(numMasteryT6);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(numMasteryT5);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(numMasteryT4);
            groupBox2.Controls.Add(label1);
            groupBox2.ForeColor = Color.SandyBrown;
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // numMasteryT8
            // 
            resources.ApplyResources(numMasteryT8, "numMasteryT8");
            numMasteryT8.Name = "numMasteryT8";
            numMasteryT8.KeyPress += numKeyPress;
            numMasteryT8.Validated += nummastery_Validated;
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.ForeColor = Color.Wheat;
            label11.Name = "label11";
            // 
            // numMasteryT7
            // 
            resources.ApplyResources(numMasteryT7, "numMasteryT7");
            numMasteryT7.Name = "numMasteryT7";
            numMasteryT7.KeyPress += numKeyPress;
            numMasteryT7.Validated += nummastery_Validated;
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.ForeColor = Color.Wheat;
            label10.Name = "label10";
            // 
            // numMasteryT6
            // 
            resources.ApplyResources(numMasteryT6, "numMasteryT6");
            numMasteryT6.Name = "numMasteryT6";
            numMasteryT6.KeyPress += numKeyPress;
            numMasteryT6.Validated += nummastery_Validated;
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.ForeColor = Color.Wheat;
            label9.Name = "label9";
            // 
            // numMasteryT5
            // 
            resources.ApplyResources(numMasteryT5, "numMasteryT5");
            numMasteryT5.Name = "numMasteryT5";
            numMasteryT5.KeyPress += numKeyPress;
            numMasteryT5.Validated += nummastery_Validated;
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.ForeColor = Color.Wheat;
            label8.Name = "label8";
            // 
            // numMasteryT4
            // 
            resources.ApplyResources(numMasteryT4, "numMasteryT4");
            numMasteryT4.Name = "numMasteryT4";
            numMasteryT4.KeyPress += numKeyPress;
            numMasteryT4.Validated += nummastery_Validated;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.Wheat;
            label1.Name = "label1";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ActiveCaptionText;
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(chkSelectAll);
            groupBox3.Controls.Add(cmbOrder);
            groupBox3.Controls.Add(btnPull);
            groupBox3.Controls.Add(cmbPull_Location);
            groupBox3.Controls.Add(checkTier);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(cmbType);
            groupBox3.Controls.Add(cmbChooseResource);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label15);
            groupBox3.ForeColor = SystemColors.ButtonFace;
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
            // 
            // chkSelectAll
            // 
            resources.ApplyResources(chkSelectAll, "chkSelectAll");
            chkSelectAll.Name = "chkSelectAll";
            chkSelectAll.UseVisualStyleBackColor = true;
            chkSelectAll.CheckedChanged += chkSelectAll_CheckedChanged;
            // 
            // cmbOrder
            // 
            cmbOrder.Cursor = Cursors.Hand;
            cmbOrder.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrder.FormattingEnabled = true;
            cmbOrder.Items.AddRange(new object[] { resources.GetString("cmbOrder.Items"), resources.GetString("cmbOrder.Items1") });
            resources.ApplyResources(cmbOrder, "cmbOrder");
            cmbOrder.Name = "cmbOrder";
            // 
            // btnPull
            // 
            btnPull.BackColor = Color.Peru;
            btnPull.Cursor = Cursors.Hand;
            btnPull.ForeColor = SystemColors.ActiveCaptionText;
            resources.ApplyResources(btnPull, "btnPull");
            btnPull.Name = "btnPull";
            btnPull.UseVisualStyleBackColor = false;
            btnPull.Click += button1_Click;
            // 
            // cmbPull_Location
            // 
            cmbPull_Location.Cursor = Cursors.Hand;
            cmbPull_Location.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPull_Location.FormattingEnabled = true;
            cmbPull_Location.Items.AddRange(new object[] { resources.GetString("cmbPull_Location.Items"), resources.GetString("cmbPull_Location.Items1"), resources.GetString("cmbPull_Location.Items2"), resources.GetString("cmbPull_Location.Items3"), resources.GetString("cmbPull_Location.Items4"), resources.GetString("cmbPull_Location.Items5") });
            resources.ApplyResources(cmbPull_Location, "cmbPull_Location");
            cmbPull_Location.Name = "cmbPull_Location";
            // 
            // checkTier
            // 
            checkTier.BackColor = SystemColors.InactiveCaptionText;
            checkTier.CheckOnClick = true;
            checkTier.ForeColor = SystemColors.InactiveBorder;
            checkTier.FormattingEnabled = true;
            checkTier.Items.AddRange(new object[] { resources.GetString("checkTier.Items"), resources.GetString("checkTier.Items1"), resources.GetString("checkTier.Items2"), resources.GetString("checkTier.Items3"), resources.GetString("checkTier.Items4"), resources.GetString("checkTier.Items5"), resources.GetString("checkTier.Items6"), resources.GetString("checkTier.Items7"), resources.GetString("checkTier.Items8"), resources.GetString("checkTier.Items9"), resources.GetString("checkTier.Items10"), resources.GetString("checkTier.Items11"), resources.GetString("checkTier.Items12"), resources.GetString("checkTier.Items13"), resources.GetString("checkTier.Items14"), resources.GetString("checkTier.Items15"), resources.GetString("checkTier.Items16"), resources.GetString("checkTier.Items17"), resources.GetString("checkTier.Items18"), resources.GetString("checkTier.Items19"), resources.GetString("checkTier.Items20"), resources.GetString("checkTier.Items21"), resources.GetString("checkTier.Items22"), resources.GetString("checkTier.Items23"), resources.GetString("checkTier.Items24"), resources.GetString("checkTier.Items25"), resources.GetString("checkTier.Items26") });
            resources.ApplyResources(checkTier, "checkTier");
            checkTier.MultiColumn = true;
            checkTier.Name = "checkTier";
            checkTier.ItemCheck += ItemCheck;
            checkTier.Validated += checkTier_Validated;
            // 
            // label12
            // 
            resources.ApplyResources(label12, "label12");
            label12.Name = "label12";
            // 
            // cmbType
            // 
            cmbType.Cursor = Cursors.Hand;
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { resources.GetString("cmbType.Items"), resources.GetString("cmbType.Items1") });
            resources.ApplyResources(cmbType, "cmbType");
            cmbType.Name = "cmbType";
            // 
            // label14
            // 
            resources.ApplyResources(label14, "label14");
            label14.Name = "label14";
            // 
            // label15
            // 
            resources.ApplyResources(label15, "label15");
            label15.Name = "label15";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, settingsToolStripMenuItem, helpToolStripMenuItem });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { statusToolStripMenuItem, stripClearAll, hideConfigToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(settingsToolStripMenuItem, "settingsToolStripMenuItem");
            // 
            // statusToolStripMenuItem
            // 
            statusToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { premiumToolStripMenuItem });
            statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            resources.ApplyResources(statusToolStripMenuItem, "statusToolStripMenuItem");
            // 
            // premiumToolStripMenuItem
            // 
            premiumToolStripMenuItem.Name = "premiumToolStripMenuItem";
            resources.ApplyResources(premiumToolStripMenuItem, "premiumToolStripMenuItem");
            // 
            // stripClearAll
            // 
            stripClearAll.DropDownItems.AddRange(new ToolStripItem[] { stripStation, stripPrices, stripMastery, stripTime });
            stripClearAll.Name = "stripClearAll";
            resources.ApplyResources(stripClearAll, "stripClearAll");
            // 
            // stripStation
            // 
            stripStation.Name = "stripStation";
            resources.ApplyResources(stripStation, "stripStation");
            stripStation.Click += stripStation_Clicked;
            // 
            // stripPrices
            // 
            stripPrices.DropDownItems.AddRange(new ToolStripItem[] { stripProduct, stripResource });
            stripPrices.Name = "stripPrices";
            resources.ApplyResources(stripPrices, "stripPrices");
            // 
            // stripProduct
            // 
            stripProduct.Name = "stripProduct";
            resources.ApplyResources(stripProduct, "stripProduct");
            // 
            // stripResource
            // 
            stripResource.Name = "stripResource";
            resources.ApplyResources(stripResource, "stripResource");
            // 
            // stripMastery
            // 
            stripMastery.Name = "stripMastery";
            resources.ApplyResources(stripMastery, "stripMastery");
            stripMastery.Click += stripMastery_Clicked;
            // 
            // stripTime
            // 
            stripTime.DropDownItems.AddRange(new ToolStripItem[] { stripTime_Resource, stripTime_Product });
            stripTime.Name = "stripTime";
            resources.ApplyResources(stripTime, "stripTime");
            // 
            // stripTime_Resource
            // 
            stripTime_Resource.Name = "stripTime_Resource";
            resources.ApplyResources(stripTime_Resource, "stripTime_Resource");
            // 
            // stripTime_Product
            // 
            stripTime_Product.Name = "stripTime_Product";
            resources.ApplyResources(stripTime_Product, "stripTime_Product");
            // 
            // hideConfigToolStripMenuItem
            // 
            hideConfigToolStripMenuItem.CheckOnClick = true;
            hideConfigToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            hideConfigToolStripMenuItem.Name = "hideConfigToolStripMenuItem";
            resources.ApplyResources(hideConfigToolStripMenuItem, "hideConfigToolStripMenuItem");
            hideConfigToolStripMenuItem.CheckedChanged += hideConfigToolStripMenuItem_CheckedChanged;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(pnlRefine);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ButtonHighlight;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            WindowState = FormWindowState.Maximized;
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUsageFee).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMasteryT8).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMasteryT7).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMasteryT6).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMasteryT5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMasteryT4).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion



        //drop-down shits
        private Label label2;
        private Label label3;
        
        private Label label4;
        private ComboBox cmbBonus;
        private Label label5;
        
        private Label label6;
        private NumericUpDown numAmount;
        private NumericUpDown numUsageFee;
        private ComboBox cmbLocation;
        private Label label7;
        private Label lblReturnRate;
        private Panel pnlRefine;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private NumericUpDown numMasteryT4;
        private Label label1;
        private NumericUpDown numMasteryT8;
        private Label label11;
        private NumericUpDown numMasteryT7;
        private Label label10;
        private NumericUpDown numMasteryT6;
        private Label label9;
        private NumericUpDown numMasteryT5;
        private Label label8;
        private GroupBox groupBox3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem statusToolStripMenuItem;
        private ToolStripMenuItem premiumToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem stripClearAll;
        private Label label12;
        private Label label14;
        protected internal Button btnPull;
        protected internal ComboBox cmbChooseResource;
        protected internal ComboBox cmbPull_Location;
        protected internal CheckedListBox checkTier;
        protected internal ComboBox cmbType;
        private Label label15;
        private CheckBox chkSelectAll;
        protected internal ComboBox cmbOrder;
        private ToolStripMenuItem stripStation;
        private ToolStripMenuItem stripPrices;
        private ToolStripMenuItem stripMastery;
        private ToolStripMenuItem stripProduct;
        private ToolStripMenuItem stripResource;
        private ToolStripMenuItem stripTime;
        private ToolStripMenuItem stripTime_Resource;
        private ToolStripMenuItem stripTime_Product;
        private ToolStripMenuItem hideConfigToolStripMenuItem;
    }
}
