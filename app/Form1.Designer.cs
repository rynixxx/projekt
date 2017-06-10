namespace app
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playground = new System.Windows.Forms.Panel();
            this.deska = new System.Windows.Forms.PictureBox();
            this.pilka = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deska)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilka)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.Controls.Add(this.pilka);
            this.playground.Controls.Add(this.deska);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(1064, 529);
            this.playground.TabIndex = 0;
            // 
            // deska
            // 
            this.deska.BackColor = System.Drawing.SystemColors.Desktop;
            this.deska.Location = new System.Drawing.Point(431, 497);
            this.deska.Name = "deska";
            this.deska.Size = new System.Drawing.Size(150, 20);
            this.deska.TabIndex = 0;
            this.deska.TabStop = false;
            // 
            // pilka
            // 
            this.pilka.BackColor = System.Drawing.Color.DarkRed;
            this.pilka.Location = new System.Drawing.Point(427, 110);
            this.pilka.Name = "pilka";
            this.pilka.Size = new System.Drawing.Size(20, 20);
            this.pilka.TabIndex = 1;
            this.pilka.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 529);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deska)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox pilka;
        private System.Windows.Forms.PictureBox deska;
        private System.Windows.Forms.Timer timer1;
    }
}

