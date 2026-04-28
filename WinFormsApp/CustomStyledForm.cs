using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class CustomStyledForm : Form
    {
        public CustomStyledForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.MinimizeBox = true;
            InitializeComponent();
        }

        private void CustomStyledForm_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Dock = DockStyle.Top;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMiddleTab_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
            btnClose.Dock = DockStyle.Right;
            btnMiddleTab.Dock = DockStyle.Right;
            btnMinimize.Dock = DockStyle.Right;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
