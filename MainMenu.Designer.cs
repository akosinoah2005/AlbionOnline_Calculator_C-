namespace Albion_Calcu_C3
{
    partial class MainMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnshowRefine = new Button();
            btnGraph = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // btnshowRefine
            // 
            btnshowRefine.Cursor = Cursors.Hand;
            btnshowRefine.Location = new Point(12, 12);
            btnshowRefine.Name = "btnshowRefine";
            btnshowRefine.Size = new Size(154, 70);
            btnshowRefine.TabIndex = 0;
            btnshowRefine.Text = "Refine";
            btnshowRefine.UseVisualStyleBackColor = true;
            btnshowRefine.Click += button1_Click;
            // 
            // btnGraph
            // 
            btnGraph.Location = new Point(12, 88);
            btnGraph.Name = "btnGraph";
            btnGraph.Size = new Size(154, 70);
            btnGraph.TabIndex = 1;
            btnGraph.Text = "Graph";
            btnGraph.UseVisualStyleBackColor = true;
            btnGraph.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 164);
            button3.Name = "button3";
            button3.Size = new Size(154, 70);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 267);
            Controls.Add(button3);
            Controls.Add(btnGraph);
            Controls.Add(btnshowRefine);
            Name = "MainMenu";
            Text = "MainMenu";
            Load += MainMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnshowRefine;
        private Button btnGraph;
        private Button button3;
    }
}