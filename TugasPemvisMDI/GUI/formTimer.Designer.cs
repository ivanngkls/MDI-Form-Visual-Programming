namespace TugasPemvisMDI.GUI
{
    partial class formTimer
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
            lblTitle = new Label();
            lblAturWaktu = new Label();
            numMinutes1 = new NumericUpDown();
            lblTime = new Label();
            btnMulai = new Button();
            btnBerhenti = new Button();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)numMinutes1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 14F);
            lblTitle.Location = new Point(154, 50);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(70, 22);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TIMER";
            // 
            // lblAturWaktu
            // 
            lblAturWaktu.AutoSize = true;
            lblAturWaktu.Font = new Font("Arial", 14F);
            lblAturWaktu.Location = new Point(25, 94);
            lblAturWaktu.Name = "lblAturWaktu";
            lblAturWaktu.Size = new Size(111, 22);
            lblAturWaktu.TabIndex = 1;
            lblAturWaktu.Text = "Atur Waktu :";
            // 
            // numMinutes1
            // 
            numMinutes1.Location = new Point(157, 96);
            numMinutes1.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numMinutes1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMinutes1.Name = "numMinutes1";
            numMinutes1.Size = new Size(120, 23);
            numMinutes1.TabIndex = 2;
            numMinutes1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Arial", 20F);
            lblTime.Location = new Point(138, 135);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(107, 32);
            lblTime.TabIndex = 3;
            lblTime.Text = "0 : 0 : 0";
            // 
            // btnMulai
            // 
            btnMulai.BackColor = Color.LightGreen;
            btnMulai.Location = new Point(61, 197);
            btnMulai.Name = "btnMulai";
            btnMulai.Size = new Size(75, 23);
            btnMulai.TabIndex = 4;
            btnMulai.Text = "Mulai";
            btnMulai.UseVisualStyleBackColor = false;
            btnMulai.Click += btnMulai_Click;
            // 
            // btnBerhenti
            // 
            btnBerhenti.BackColor = Color.Red;
            btnBerhenti.Location = new Point(250, 197);
            btnBerhenti.Name = "btnBerhenti";
            btnBerhenti.Size = new Size(75, 23);
            btnBerhenti.TabIndex = 5;
            btnBerhenti.Text = "Berhenti";
            btnBerhenti.UseVisualStyleBackColor = false;
            btnBerhenti.Click += btnBerhenti_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(157, 197);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // formTimer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(384, 256);
            Controls.Add(btnReset);
            Controls.Add(btnBerhenti);
            Controls.Add(btnMulai);
            Controls.Add(lblTime);
            Controls.Add(numMinutes1);
            Controls.Add(lblAturWaktu);
            Controls.Add(lblTitle);
            Name = "formTimer";
            Text = "formTimer";
            ((System.ComponentModel.ISupportInitialize)numMinutes1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblAturWaktu;
        private NumericUpDown numMinutes1;
        private Label lblTime;
        private Button btnMulai;
        private Button btnBerhenti;
        private Button btnReset;
    }
}