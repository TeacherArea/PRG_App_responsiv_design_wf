namespace PRG_App_responsiv_design_wf
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
            panel_top = new Panel();
            label_A = new Label();
            panel_bottom = new Panel();
            label_G = new Label();
            tableLayout_Middle = new TableLayoutPanel();
            panel_F = new Panel();
            label_F = new Label();
            label_B = new Label();
            label_E = new Label();
            panel_C = new Panel();
            label_C = new Label();
            label_D = new Label();
            panel_top.SuspendLayout();
            panel_bottom.SuspendLayout();
            tableLayout_Middle.SuspendLayout();
            panel_F.SuspendLayout();
            panel_C.SuspendLayout();
            SuspendLayout();
            // 
            // panel_top
            // 
            panel_top.BackColor = SystemColors.ActiveCaption;
            panel_top.Controls.Add(label_A);
            panel_top.Dock = DockStyle.Top;
            panel_top.Location = new Point(0, 0);
            panel_top.Margin = new Padding(4, 5, 4, 5);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(1029, 153);
            panel_top.TabIndex = 0;
            // 
            // label_A
            // 
            label_A.Dock = DockStyle.Fill;
            label_A.Location = new Point(0, 0);
            label_A.Name = "label_A";
            label_A.Size = new Size(1029, 153);
            label_A.TabIndex = 0;
            label_A.Text = "A";
            label_A.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_bottom
            // 
            panel_bottom.BackColor = SystemColors.ScrollBar;
            panel_bottom.Controls.Add(label_G);
            panel_bottom.Dock = DockStyle.Bottom;
            panel_bottom.Location = new Point(0, 537);
            panel_bottom.Margin = new Padding(4, 5, 4, 5);
            panel_bottom.Name = "panel_bottom";
            panel_bottom.Size = new Size(1029, 153);
            panel_bottom.TabIndex = 1;
            // 
            // label_G
            // 
            label_G.Dock = DockStyle.Fill;
            label_G.Location = new Point(0, 0);
            label_G.Name = "label_G";
            label_G.Size = new Size(1029, 153);
            label_G.TabIndex = 1;
            label_G.Text = "G";
            label_G.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayout_Middle
            // 
            tableLayout_Middle.ColumnCount = 3;
            tableLayout_Middle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayout_Middle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayout_Middle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayout_Middle.Controls.Add(panel_F, 2, 0);
            tableLayout_Middle.Controls.Add(label_B, 0, 0);
            tableLayout_Middle.Controls.Add(label_D, 0, 1);
            tableLayout_Middle.Controls.Add(label_E, 0, 1);
            tableLayout_Middle.Controls.Add(panel_C, 1, 0);
            tableLayout_Middle.Dock = DockStyle.Fill;
            tableLayout_Middle.Location = new Point(0, 153);
            tableLayout_Middle.Margin = new Padding(4, 5, 4, 5);
            tableLayout_Middle.Name = "tableLayout_Middle";
            tableLayout_Middle.RowCount = 2;
            tableLayout_Middle.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayout_Middle.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayout_Middle.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayout_Middle.Size = new Size(1029, 384);
            tableLayout_Middle.TabIndex = 2;
            // 
            // panel_F
            // 
            panel_F.BackColor = Color.RosyBrown;
            panel_F.Controls.Add(label_F);
            panel_F.Dock = DockStyle.Fill;
            panel_F.Location = new Point(774, 3);
            panel_F.Name = "panel_F";
            tableLayout_Middle.SetRowSpan(panel_F, 2);
            panel_F.Size = new Size(252, 378);
            panel_F.TabIndex = 3;
            // 
            // label_F
            // 
            label_F.Anchor = AnchorStyles.Right;
            label_F.AutoSize = true;
            label_F.Location = new Point(223, 181);
            label_F.Name = "label_F";
            label_F.Size = new Size(20, 23);
            label_F.TabIndex = 1;
            label_F.Text = "F";
            label_F.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_B
            // 
            label_B.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label_B.AutoSize = true;
            label_B.Location = new Point(3, 84);
            label_B.Name = "label_B";
            label_B.Size = new Size(508, 23);
            label_B.TabIndex = 1;
            label_B.Text = "B";
            label_B.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_E
            // 
            label_E.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label_E.AutoSize = true;
            label_E.Location = new Point(517, 276);
            label_E.Name = "label_E";
            label_E.Size = new Size(251, 23);
            label_E.TabIndex = 1;
            label_E.Text = "E";
            label_E.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_C
            // 
            panel_C.BackColor = Color.RosyBrown;
            panel_C.Controls.Add(label_C);
            panel_C.Dock = DockStyle.Fill;
            panel_C.Location = new Point(517, 3);
            panel_C.Name = "panel_C";
            panel_C.Size = new Size(251, 186);
            panel_C.TabIndex = 2;
            // 
            // label_C
            // 
            label_C.Dock = DockStyle.Fill;
            label_C.Location = new Point(0, 0);
            label_C.Name = "label_C";
            label_C.Size = new Size(251, 186);
            label_C.TabIndex = 3;
            label_C.Text = "C";
            label_C.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_D
            // 
            label_D.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label_D.AutoSize = true;
            label_D.Location = new Point(3, 276);
            label_D.Name = "label_D";
            label_D.Size = new Size(508, 23);
            label_D.TabIndex = 1;
            label_D.Text = "D";
            label_D.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1029, 690);
            Controls.Add(tableLayout_Middle);
            Controls.Add(panel_bottom);
            Controls.Add(panel_top);
            Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Responsiv app-design";
            panel_top.ResumeLayout(false);
            panel_bottom.ResumeLayout(false);
            tableLayout_Middle.ResumeLayout(false);
            tableLayout_Middle.PerformLayout();
            panel_F.ResumeLayout(false);
            panel_F.PerformLayout();
            panel_C.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_top;
        private Panel panel_bottom;
        private TableLayoutPanel tableLayout_Middle;
        private Label label_A;
        private Label label_G;
        private Label label_E;
        private Label label_B;
        private Panel panel_C;
        private Label label_C;
        private Panel panel_F;
        private Label label_F;
        private Label label_D;
    }
}