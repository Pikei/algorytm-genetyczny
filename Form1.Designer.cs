namespace algorytm_generyczny
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
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.populacja = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.zakresOd = new System.Windows.Forms.NumericUpDown();
            this.zakresDo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tolerancja = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.iteracje = new System.Windows.Forms.NumericUpDown();
            this.populacja_po_x_iteracjach = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.populacjaLabel = new System.Windows.Forms.Label();
            this.wyswietl_po = new System.Windows.Forms.RadioButton();
            this.koniec = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.populacja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakresOd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakresDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tolerancja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iteracje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populacja_po_x_iteracjach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "liczebność populacji: ";
            // 
            // populacja
            // 
            this.populacja.Location = new System.Drawing.Point(142, 35);
            this.populacja.Name = "populacja";
            this.populacja.Size = new System.Drawing.Size(54, 20);
            this.populacja.TabIndex = 1;
            this.populacja.ValueChanged += new System.EventHandler(this.populacja_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "zakres losowanych wartości:";
            // 
            // zakresOd
            // 
            this.zakresOd.Location = new System.Drawing.Point(173, 88);
            this.zakresOd.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.zakresOd.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.zakresOd.Name = "zakresOd";
            this.zakresOd.Size = new System.Drawing.Size(57, 20);
            this.zakresOd.TabIndex = 3;
            this.zakresOd.ValueChanged += new System.EventHandler(this.zakresOd_ValueChanged);
            // 
            // zakresDo
            // 
            this.zakresDo.Location = new System.Drawing.Point(246, 88);
            this.zakresDo.Name = "zakresDo";
            this.zakresDo.Size = new System.Drawing.Size(56, 20);
            this.zakresDo.TabIndex = 4;
            this.zakresDo.ValueChanged += new System.EventHandler(this.zakresDo_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "kryterium tolerancyjne:";
            // 
            // tolerancja
            // 
            this.tolerancja.DecimalPlaces = 1;
            this.tolerancja.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tolerancja.Location = new System.Drawing.Point(146, 134);
            this.tolerancja.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.tolerancja.Name = "tolerancja";
            this.tolerancja.Size = new System.Drawing.Size(62, 20);
            this.tolerancja.TabIndex = 6;
            this.tolerancja.ValueChanged += new System.EventHandler(this.tolerancja_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ilość iteracji:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iteracje
            // 
            this.iteracje.Location = new System.Drawing.Point(98, 182);
            this.iteracje.Name = "iteracje";
            this.iteracje.Size = new System.Drawing.Size(58, 20);
            this.iteracje.TabIndex = 9;
            this.iteracje.ValueChanged += new System.EventHandler(this.iteracje_ValueChanged);
            // 
            // populacja_po_x_iteracjach
            // 
            this.populacja_po_x_iteracjach.Location = new System.Drawing.Point(168, 321);
            this.populacja_po_x_iteracjach.Name = "populacja_po_x_iteracjach";
            this.populacja_po_x_iteracjach.Size = new System.Drawing.Size(61, 20);
            this.populacja_po_x_iteracjach.TabIndex = 12;
            this.populacja_po_x_iteracjach.ValueChanged += new System.EventHandler(this.populacja_po_x_iteracjach_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "iteracjach";
            // 
            // populacjaLabel
            // 
            this.populacjaLabel.AutoSize = true;
            this.populacjaLabel.Location = new System.Drawing.Point(17, 17);
            this.populacjaLabel.Name = "populacjaLabel";
            this.populacjaLabel.Size = new System.Drawing.Size(54, 13);
            this.populacjaLabel.TabIndex = 0;
            this.populacjaLabel.Text = "Populacja";
            // 
            // wyswietl_po
            // 
            this.wyswietl_po.AutoSize = true;
            this.wyswietl_po.Location = new System.Drawing.Point(31, 321);
            this.wyswietl_po.Name = "wyswietl_po";
            this.wyswietl_po.Size = new System.Drawing.Size(131, 17);
            this.wyswietl_po.TabIndex = 15;
            this.wyswietl_po.TabStop = true;
            this.wyswietl_po.Text = "Wyświetl populację po";
            this.wyswietl_po.UseVisualStyleBackColor = true;
            this.wyswietl_po.CheckedChanged += new System.EventHandler(this.wyswietl_po_CheckedChanged);
            // 
            // koniec
            // 
            this.koniec.AutoSize = true;
            this.koniec.Location = new System.Drawing.Point(31, 278);
            this.koniec.Name = "koniec";
            this.koniec.Size = new System.Drawing.Size(163, 17);
            this.koniec.TabIndex = 16;
            this.koniec.TabStop = true;
            this.koniec.Text = "Wyświetl końcową populację";
            this.koniec.UseVisualStyleBackColor = true;
            this.koniec.CheckedChanged += new System.EventHandler(this.koniec_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 390);
            this.Controls.Add(this.koniec);
            this.Controls.Add(this.wyswietl_po);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.populacja_po_x_iteracjach);
            this.Controls.Add(this.iteracje);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tolerancja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.zakresDo);
            this.Controls.Add(this.zakresOd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.populacja);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Algorytm generyczny";
            ((System.ComponentModel.ISupportInitialize)(this.populacja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakresOd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakresDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tolerancja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iteracje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populacja_po_x_iteracjach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown populacja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown zakresOd;
        private System.Windows.Forms.NumericUpDown zakresDo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown tolerancja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown iteracje;
        private System.Windows.Forms.NumericUpDown populacja_po_x_iteracjach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label populacjaLabel;
        private System.Windows.Forms.RadioButton wyswietl_po;
        private System.Windows.Forms.RadioButton koniec;
    }
}

