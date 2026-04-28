namespace WinFormsApp1
{
    partial class CustomStyledForm
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
            panel1 = new Panel();
            btnMinimize = new Button();
            label1 = new Label();
            btnMiddleTab = new Button();
            btnClose = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnMiddleTab);
            panel1.Controls.Add(btnClose);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 26);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnMinimize
            // 
            btnMinimize.Location = new Point(722, 2);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(23, 23);
            btnMinimize.TabIndex = 3;
            btnMinimize.Text = "-";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 6);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 1;
            label1.Text = "Text формы";
            label1.Click += label1_Click;
            // 
            // btnMiddleTab
            // 
            btnMiddleTab.Location = new Point(747, 2);
            btnMiddleTab.Name = "btnMiddleTab";
            btnMiddleTab.Size = new Size(26, 23);
            btnMiddleTab.TabIndex = 2;
            btnMiddleTab.Text = "□";
            btnMiddleTab.UseVisualStyleBackColor = true;
            btnMiddleTab.Click += btnMiddleTab_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(775, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(24, 23);
            btnClose.TabIndex = 1;
            btnClose.Text = "x";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // CustomStyledForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "CustomStyledForm";
            Text = "CustomStyledForm";
            Load += CustomStyledForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnClose;
        private Button btnMiddleTab;
        private Button btnMinimize;
    }
}