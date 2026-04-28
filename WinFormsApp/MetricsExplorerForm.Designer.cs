namespace WinFormsApp1
{
    partial class MetricsExplorerForm
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
            sravni = new Button();
            Update = new Button();
            dataGridView1 = new DataGridView();
            Parametr = new DataGridViewTextBoxColumn();
            Znachenie = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // sravni
            // 
            sravni.Location = new Point(562, 400);
            sravni.Name = "sravni";
            sravni.Size = new Size(129, 23);
            sravni.TabIndex = 5;
            sravni.Text = "Сравнить с экраном";
            sravni.UseVisualStyleBackColor = true;
            sravni.Click += sravni_Click;
            // 
            // Update
            // 
            Update.Location = new Point(48, 400);
            Update.Name = "Update";
            Update.Size = new Size(75, 23);
            Update.TabIndex = 4;
            Update.Text = "Обновить";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Parametr, Znachenie });
            dataGridView1.Location = new Point(48, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(643, 339);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Parametr
            // 
            Parametr.HeaderText = "Параметр";
            Parametr.Name = "Parametr";
            Parametr.Width = 300;
            // 
            // Znachenie
            // 
            Znachenie.HeaderText = "Значение";
            Znachenie.Name = "Znachenie";
            Znachenie.Width = 300;
            // 
            // MetricsExplorerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 450);
            Controls.Add(dataGridView1);
            Controls.Add(sravni);
            Controls.Add(Update);
            Name = "MetricsExplorerForm";
            Text = "MetricsExplorerForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button sravni;
        private Button Update;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Parametr;
        private DataGridViewTextBoxColumn Znachenie;
    }
}