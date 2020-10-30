namespace RegisztracioAlkalmazas
{
    partial class Form1
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
            this.listBoxHobbi = new System.Windows.Forms.ListBox();
            this.textbox_Nev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rafioFerfi = new System.Windows.Forms.RadioButton();
            this.radioNo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.szul_datum = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox_ujHobbi = new System.Windows.Forms.TextBox();
            this.button_Hozzaad = new System.Windows.Forms.Button();
            this.buttonMentes = new System.Windows.Forms.Button();
            this.buttonBetoltes = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // listBoxHobbi
            // 
            this.listBoxHobbi.FormattingEnabled = true;
            this.listBoxHobbi.Items.AddRange(new object[] {
            "Úszás",
            "Horgászat",
            "Futás"});
            this.listBoxHobbi.Location = new System.Drawing.Point(267, 41);
            this.listBoxHobbi.Name = "listBoxHobbi";
            this.listBoxHobbi.Size = new System.Drawing.Size(98, 95);
            this.listBoxHobbi.TabIndex = 9;
            this.listBoxHobbi.Tag = "";
            // 
            // textbox_Nev
            // 
            this.textbox_Nev.Location = new System.Drawing.Point(90, 11);
            this.textbox_Nev.Name = "textbox_Nev";
            this.textbox_Nev.Size = new System.Drawing.Size(100, 20);
            this.textbox_Nev.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Szül. dátum";
            // 
            // rafioFerfi
            // 
            this.rafioFerfi.AutoSize = true;
            this.rafioFerfi.Location = new System.Drawing.Point(90, 72);
            this.rafioFerfi.Name = "rafioFerfi";
            this.rafioFerfi.Size = new System.Drawing.Size(31, 17);
            this.rafioFerfi.TabIndex = 4;
            this.rafioFerfi.TabStop = true;
            this.rafioFerfi.Text = "F";
            this.rafioFerfi.UseVisualStyleBackColor = true;
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Location = new System.Drawing.Point(157, 72);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(33, 17);
            this.radioNo.TabIndex = 5;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "N";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nem:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kedvenc hobbi:";
            // 
            // szul_datum
            // 
            this.szul_datum.Location = new System.Drawing.Point(90, 41);
            this.szul_datum.MaxDate = new System.DateTime(2020, 10, 29, 0, 0, 0, 0);
            this.szul_datum.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.szul_datum.Name = "szul_datum";
            this.szul_datum.Size = new System.Drawing.Size(164, 20);
            this.szul_datum.TabIndex = 8;
            this.szul_datum.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Új hobbi:";
            // 
            // textbox_ujHobbi
            // 
            this.textbox_ujHobbi.Location = new System.Drawing.Point(267, 164);
            this.textbox_ujHobbi.Name = "textbox_ujHobbi";
            this.textbox_ujHobbi.Size = new System.Drawing.Size(100, 20);
            this.textbox_ujHobbi.TabIndex = 11;
            // 
            // button_Hozzaad
            // 
            this.button_Hozzaad.Location = new System.Drawing.Point(292, 210);
            this.button_Hozzaad.Name = "button_Hozzaad";
            this.button_Hozzaad.Size = new System.Drawing.Size(75, 23);
            this.button_Hozzaad.TabIndex = 12;
            this.button_Hozzaad.Text = "Hozzáad";
            this.button_Hozzaad.UseVisualStyleBackColor = true;
            this.button_Hozzaad.Click += new System.EventHandler(this.button_Hozzaad_Click);
            // 
            // buttonMentes
            // 
            this.buttonMentes.Location = new System.Drawing.Point(213, 262);
            this.buttonMentes.Name = "buttonMentes";
            this.buttonMentes.Size = new System.Drawing.Size(75, 23);
            this.buttonMentes.TabIndex = 13;
            this.buttonMentes.Text = "Mentés";
            this.buttonMentes.UseVisualStyleBackColor = true;
            this.buttonMentes.Click += new System.EventHandler(this.buttonMentes_Click);
            // 
            // buttonBetoltes
            // 
            this.buttonBetoltes.Location = new System.Drawing.Point(294, 262);
            this.buttonBetoltes.Name = "buttonBetoltes";
            this.buttonBetoltes.Size = new System.Drawing.Size(75, 23);
            this.buttonBetoltes.TabIndex = 14;
            this.buttonBetoltes.Text = "Betöltés";
            this.buttonBetoltes.UseVisualStyleBackColor = true;
            this.buttonBetoltes.Click += new System.EventHandler(this.buttonBetoltes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 313);
            this.Controls.Add(this.radioNo);
            this.Controls.Add(this.rafioFerfi);
            this.Controls.Add(this.buttonBetoltes);
            this.Controls.Add(this.buttonMentes);
            this.Controls.Add(this.button_Hozzaad);
            this.Controls.Add(this.textbox_ujHobbi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxHobbi);
            this.Controls.Add(this.szul_datum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_Nev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_Nev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rafioFerfi;
        private System.Windows.Forms.RadioButton radioNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker szul_datum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbox_ujHobbi;
        private System.Windows.Forms.Button button_Hozzaad;
        private System.Windows.Forms.Button buttonMentes;
        private System.Windows.Forms.Button buttonBetoltes;
        private System.Windows.Forms.ListBox listBoxHobbi;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

