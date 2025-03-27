using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasPemvisMDI.GUI
{
    public partial class Menu_Utama : Form
    {
        private int childFormNumber = 0;

        public Menu_Utama()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK) 
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK) 
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {              
                childForm.Close();
            }
        }

        private void OpenStopwatchForm()
        {
            // mengecek apakah form stopwatch sudah dibuka sebelumnya
            foreach (Form child in MdiChildren)
            {
                if (child is formStopwatch)
                {
                    child.Activate(); // Jika sudah ada, fokuskan ke form tersebut
                    return;
                }
            }

            // Jika belum ada, buat instance baru
            formStopwatch stopwatchForm = new formStopwatch();
            stopwatchForm.MdiParent = this; // Menjadikan form stopwatch sebagai child MDI
            stopwatchForm.Show();
        }

        private void submenu_stopwatch_Click(object sender, EventArgs e)
        {
            OpenStopwatchForm(); // memanggil method untuk membuka stopwatch
        }

        private void OpenTimerForm()
        {
            foreach (Form child in MdiChildren)
            {
                if (child is formTimer)
                {
                    child.Activate(); // Fokus ke form jika sudah terbuka
                    return;
                }
            }

            formTimer timerForm = new formTimer();
            timerForm.MdiParent = this; // Jadikan child MDI
            timerForm.Show();
        }

        private void submenu_timer_Click(object sender, EventArgs e)
        {
            OpenTimerForm(); // Memanggil method untuk membuka form timer
        }



    }
}
