using System;
using System.Drawing;
using System.Windows.Forms;

namespace TugasPemvisMDI.GUI
{
    public partial class formStopwatch: Form
    {
        private int menit = 0;
        private int detik = 0;
        private System.Windows.Forms.Timer timer;
       

        public formStopwatch()
        {
            InitializeComponent();

            // Inisialisasi Timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 detik
            timer.Tick += Timer_Tick;

            // Tambahkan event handler untuk tombol
            mulai_btn.Click += btnMulai_Click;
            berhenti_btn.Click += btnBerhenti_Click;
        }
            private void Timer_Tick(object? sender, EventArgs e)
        {
            detik++;
            if (detik == 60)
            {
                detik = 0;
                menit++;
            }
            lblstopwatch.Text = $"{menit:D2} : {detik:D2}"; // Format "00 : 00"

        }
        private void btnMulai_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void btnBerhenti_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
    }

