namespace Albion_Calcu_C3
{
    partial class Refine_Charts
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            plotRefine = new ScottPlot.WinForms.FormsPlot();
            groupBox1 = new GroupBox();
            label4 = new Label();
            cmbType = new ComboBox();
            btnRefresh = new Button();
            checkTier = new CheckedListBox();
            label2 = new Label();
            cmbResource = new ComboBox();
            label1 = new Label();
            cmbLocation = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // plotRefine
            // 
            plotRefine.Location = new Point(56, 46);
            plotRefine.Name = "plotRefine";
            plotRefine.Size = new Size(1454, 682);
            plotRefine.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbType);
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(checkTier);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbResource);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbLocation);
            groupBox1.Controls.Add(plotRefine);
            groupBox1.ForeColor = SystemColors.ActiveCaption;
            groupBox1.Location = new Point(15, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1528, 960);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Refine Craft";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 845);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 10;
            label4.Text = "Resource Type";
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Raw", "Refined" });
            cmbType.Location = new Point(56, 868);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(151, 28);
            cmbType.TabIndex = 9;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.IndianRed;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.ForeColor = SystemColors.HighlightText;
            btnRefresh.Location = new Point(56, 915);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // checkTier
            // 
            checkTier.BackColor = SystemColors.InactiveCaptionText;
            checkTier.CheckOnClick = true;
            checkTier.ForeColor = SystemColors.InactiveBorder;
            checkTier.FormattingEnabled = true;
            checkTier.Items.AddRange(new object[] { "2.0", "3.0", "4.0", "4.1", "4.2", "4.3", "4.4", "5.0", "5.1", "5.2", "5.3", "5.4", "6.0", "6.1", "6.2", "6.3", "6.4", "7.0", "7.1", "7.2", "7.3", "7.4", "8.0", "8.1", "8.2", "8.3", "8.4" });
            checkTier.Location = new Point(222, 734);
            checkTier.MultiColumn = true;
            checkTier.Name = "checkTier";
            checkTier.Size = new Size(954, 114);
            checkTier.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 788);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 4;
            label2.Text = "Resource";
            // 
            // cmbResource
            // 
            cmbResource.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbResource.FormattingEnabled = true;
            cmbResource.Items.AddRange(new object[] { "ORE", "HIDE", "CLOTH", "WOOD", "ROCK" });
            cmbResource.Location = new Point(56, 811);
            cmbResource.Name = "cmbResource";
            cmbResource.Size = new Size(151, 28);
            cmbResource.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 734);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 2;
            label1.Text = "Location";
            // 
            // cmbLocation
            // 
            cmbLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLocation.FormattingEnabled = true;
            cmbLocation.Items.AddRange(new object[] { "Bridgewatch", "Martlock", "Thetford", "FortSterling", "Lymhurst" });
            cmbLocation.Location = new Point(56, 757);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(151, 28);
            cmbLocation.TabIndex = 1;
            // 
            // Refine_Charts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Refine_Charts";
            Size = new Size(1942, 1075);
            Load += Refine_Charts_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot plotRefine;
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox cmbResource;
        private Label label1;
        private ComboBox cmbLocation;
        private Button btnRefresh;
        private CheckedListBox checkTier;
        private Label label4;
        private ComboBox cmbType;
    }
}
