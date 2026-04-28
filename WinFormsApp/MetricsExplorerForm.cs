using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MetricsExplorerForm : Form
    {
        private DataGridView dgvMetrics;

        private void AddRow()
        {
            dataGridView1.Rows.Clear();

            dataGridView1.Rows.Add("Размер монитора", $"{SystemInformation.PrimaryMonitorSize.Width}x{SystemInformation.PrimaryMonitorSize.Height}");
            dataGridView1.Rows.Add("Рабочая область экрана", $"{SystemInformation.WorkingArea.Width}x{SystemInformation.WorkingArea.Height}");
            dataGridView1.Rows.Add("Толщина границы окон", SystemInformation.BorderSize);
            dataGridView1.Rows.Add("Высота заголовка", SystemInformation.CaptionHeight);
            dataGridView1.Rows.Add("Высота заголовка инструментального окна", SystemInformation.ToolWindowCaptionHeight);
            dataGridView1.Rows.Add("Высота меню", SystemInformation.MenuHeight);
            dataGridView1.Rows.Add("Размер полосы прокрутки", $"{SystemInformation.HorizontalScrollBarHeight}, {SystemInformation.VerticalScrollBarWidth}");
            dataGridView1.Rows.Add("Максимальный размер окна при растягивании", $"{SystemInformation.MaxWindowTrackSize.Width}x{SystemInformation.MaxWindowTrackSize.Height}");
            dataGridView1.Rows.Add("Размер свернутого окна", $"{SystemInformation.MinimizedWindowSize.Width}x{SystemInformation.MinimizedWindowSize.Height}");
            dataGridView1.Rows.Add("Минимальный размер окна при растягивании", $"{SystemInformation.MinWindowTrackSize.Width}x{SystemInformation.MinWindowTrackSize.Height}");
        }

        public MetricsExplorerForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.ShowInTaskbar = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            AddRow();
        }

        private void sravni_Click(object sender, EventArgs e)
        {
            var PM2 = SystemInformation.PrimaryMonitorSize.Height;

            var PM1 = SystemInformation.PrimaryMonitorSize.Width;

            var WA2 = SystemInformation.WorkingArea.Height;

            var WA1 = SystemInformation.WorkingArea.Width;

            var srav1 = SystemInformation.PrimaryMonitorSize.Height - SystemInformation.WorkingArea.Height;

            var srav2 = SystemInformation.PrimaryMonitorSize.Width - SystemInformation.WorkingArea.Width;

            MessageBox.Show($"Ваш монитор ({PM1} x {PM2}) больше чем рабочая область ({WA1} x {WA2}) на ({PM1-WA1}x{PM2-WA2}), так как рабочая область не учитывает системные панели (например панель задач)", "Сравнение", MessageBoxButtons.OK);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
