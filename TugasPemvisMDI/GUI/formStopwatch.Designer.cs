namespace TugasPemvisMDI.GUI
{
    partial class formStopwatch
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
            stopwatch = new Label();
            lblstopwatch = new Label();
            mulai_btn = new Button();
            berhenti_btn = new Button();
            SuspendLayout();
            // 
            // stopwatch
            // 
            stopwatch.AutoSize = true;
            stopwatch.Font = new Font("Arial", 20F);
            stopwatch.Location = new Point(196, 28);
            stopwatch.Name = "stopwatch";
            stopwatch.Size = new Size(141, 32);
            stopwatch.TabIndex = 0;
            stopwatch.Text = "Stopwatch";
            // 
            // lblstopwatch
            // 
            lblstopwatch.AutoSize = true;
            lblstopwatch.Font = new Font("Arial", 24F);
            lblstopwatch.Location = new Point(207, 122);
            lblstopwatch.Name = "lblstopwatch";
            lblstopwatch.Size = new Size(114, 36);
            lblstopwatch.TabIndex = 1;
            lblstopwatch.Text = "00 : 00";
            lblstopwatch.TextAlign = ContentAlignment.TopRight;
            // 
            // mulai_btn
            // 
            mulai_btn.BackColor = Color.Lime;
            mulai_btn.Location = new Point(125, 191);
            mulai_btn.Name = "mulai_btn";
            mulai_btn.Size = new Size(100, 40);
            mulai_btn.TabIndex = 2;
            mulai_btn.Text = "Mulai";
            mulai_btn.UseVisualStyleBackColor = false;
            // 
            // berhenti_btn
            // 
            berhenti_btn.BackColor = Color.Red;
            berhenti_btn.Location = new Point(319, 191);
            berhenti_btn.Name = "berhenti_btn";
            berhenti_btn.Size = new Size(100, 40);
            berhenti_btn.TabIndex = 3;
            berhenti_btn.Text = "Berhenti";
            berhenti_btn.UseVisualStyleBackColor = false;
            // 
            // formStopwatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(534, 284);
            Controls.Add(berhenti_btn);
            Controls.Add(mulai_btn);
            Controls.Add(lblstopwatch);
            Controls.Add(stopwatch);
            Name = "formStopwatch";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label stopwatch;
        private Label lblstopwatch;
        private Button mulai_btn;
        private Button berhenti_btn;
    }
}