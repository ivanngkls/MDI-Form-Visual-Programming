using System;
using System.Windows.Forms;

namespace TugasPemvisMDI.GUI
{
    public partial class formTimer : Form
    {
        private System.Windows.Forms.Timer timer;
        private int totalDetik;

        public formTimer()
        {
            InitializeComponent();

            // Inisialisasi Timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 detik
            timer.Tick += Timer_Tick;

            // Set tampilan awal
            lblTime.Text = "0:00:00";
        }

        private void btnMulai_Click(object sender, EventArgs e)
        {
            totalDetik = (int)numMinutes1.Value * 60; // Konversi menit ke detik
            UpdateLabel();
            timer.Start();
        }

        private void btnBerhenti_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            totalDetik = 0;
            lblTime.Text = "0:00:00";
            numMinutes1.Value = 1; // Kembali ke nilai default
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (totalDetik > 0)
            {
                totalDetik--;
                UpdateLabel();
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Waktu habis!", "Timer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateLabel()
        {
            int jam = totalDetik / 3600;
            int menit = (totalDetik % 3600) / 60;
            int detik = totalDetik % 60;
            lblTime.Text = $"{jam}:{menit:D2}:{detik:D2}";
        }
    }
}
