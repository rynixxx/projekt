﻿namespace app
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
            this.gameover = new System.Windows.Forms.Label();
            this.punkty = new System.Windows.Forms.Label();
            this.wynik = new System.Windows.Forms.Label();
            this.pilka = new System.Windows.Forms.PictureBox();
            this.deska = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pilka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deska)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.Controls.Add(this.gameover);
            this.playground.Controls.Add(this.punkty);
            this.playground.Controls.Add(this.wynik);
            this.playground.Controls.Add(this.pilka);
            this.playground.Controls.Add(this.deska);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(1064, 529);
            this.playground.TabIndex = 0;
            // 
            // gameover
            // 
            this.gameover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameover.AutoSize = true;
            this.gameover.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameover.Location = new System.Drawing.Point(344, 89);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(321, 220);
            this.gameover.TabIndex = 4;
            this.gameover.Text = "Game Over\r\n\r\nF1 - nowa gra\r\nEsc - wyjście";
            this.gameover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // punkty
            // 
            this.punkty.AutoSize = true;
            this.punkty.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.punkty.Location = new System.Drawing.Point(175, 9);
            this.punkty.Name = "punkty";
            this.punkty.Size = new System.Drawing.Size(51, 55);
            this.punkty.TabIndex = 3;
            this.punkty.Text = "0";
            // 
            // wynik
            // 
            this.wynik.AutoSize = true;
            this.wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik.Location = new System.Drawing.Point(12, 9);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(167, 55);
            this.wynik.TabIndex = 2;
            this.wynik.Text = "Wynik:";
            // 
            // pilka
            // 
            this.pilka.BackColor = System.Drawing.Color.DarkRed;
            this.pilka.Location = new System.Drawing.Point(100, 107);
            this.pilka.Name = "pilka";
            this.pilka.Size = new System.Drawing.Size(20, 20);
            this.pilka.TabIndex = 1;
            this.pilka.TabStop = false;
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
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pilka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deska)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox pilka;
        private System.Windows.Forms.PictureBox deska;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label punkty;
        private System.Windows.Forms.Label wynik;
        private System.Windows.Forms.Label gameover;
    }
}

