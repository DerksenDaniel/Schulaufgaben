namespace ADOKursverwaltung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxKurse = new System.Windows.Forms.ComboBox();
            this.comboBoxTeilnehmer = new System.Windows.Forms.ComboBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxIdKurs = new System.Windows.Forms.TextBox();
            this.labelBezeichnung = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.buttonKursCSV = new System.Windows.Forms.Button();
            this.textBoxBezeichnung = new System.Windows.Forms.TextBox();
            this.textBoxDatum = new System.Windows.Forms.TextBox();
            this.labelIDT = new System.Windows.Forms.Label();
            this.labelIDTeilnehmer = new System.Windows.Forms.Label();
            this.labelNachname = new System.Windows.Forms.Label();
            this.labelVorname = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonTeilnehmerCSV = new System.Windows.Forms.Button();
            this.textBoxIdTeilnehmer = new System.Windows.Forms.TextBox();
            this.textBoxNachname = new System.Windows.Forms.TextBox();
            this.textBoxVorname = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonAnzeigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxKurse
            // 
            this.comboBoxKurse.FormattingEnabled = true;
            this.comboBoxKurse.Location = new System.Drawing.Point(37, 83);
            this.comboBoxKurse.Name = "comboBoxKurse";
            this.comboBoxKurse.Size = new System.Drawing.Size(201, 21);
            this.comboBoxKurse.TabIndex = 0;
            this.comboBoxKurse.SelectedIndexChanged += new System.EventHandler(this.comboBoxKurse_SelectedIndexChanged);
            // 
            // comboBoxTeilnehmer
            // 
            this.comboBoxTeilnehmer.FormattingEnabled = true;
            this.comboBoxTeilnehmer.Location = new System.Drawing.Point(302, 83);
            this.comboBoxTeilnehmer.Name = "comboBoxTeilnehmer";
            this.comboBoxTeilnehmer.Size = new System.Drawing.Size(187, 21);
            this.comboBoxTeilnehmer.TabIndex = 1;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(37, 130);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "ID";
            // 
            // textBoxIdKurs
            // 
            this.textBoxIdKurs.Location = new System.Drawing.Point(116, 130);
            this.textBoxIdKurs.Name = "textBoxIdKurs";
            this.textBoxIdKurs.Size = new System.Drawing.Size(66, 20);
            this.textBoxIdKurs.TabIndex = 3;
            // 
            // labelBezeichnung
            // 
            this.labelBezeichnung.AutoSize = true;
            this.labelBezeichnung.Location = new System.Drawing.Point(37, 174);
            this.labelBezeichnung.Name = "labelBezeichnung";
            this.labelBezeichnung.Size = new System.Drawing.Size(69, 13);
            this.labelBezeichnung.TabIndex = 4;
            this.labelBezeichnung.Text = "Bezeichnung";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(37, 216);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(38, 13);
            this.labelDatum.TabIndex = 5;
            this.labelDatum.Text = "Datum";
            // 
            // buttonKursCSV
            // 
            this.buttonKursCSV.Location = new System.Drawing.Point(37, 295);
            this.buttonKursCSV.Name = "buttonKursCSV";
            this.buttonKursCSV.Size = new System.Drawing.Size(201, 23);
            this.buttonKursCSV.TabIndex = 6;
            this.buttonKursCSV.Text = "Kurs.csv";
            this.buttonKursCSV.UseVisualStyleBackColor = true;
            // 
            // textBoxBezeichnung
            // 
            this.textBoxBezeichnung.Location = new System.Drawing.Point(116, 174);
            this.textBoxBezeichnung.Name = "textBoxBezeichnung";
            this.textBoxBezeichnung.Size = new System.Drawing.Size(122, 20);
            this.textBoxBezeichnung.TabIndex = 7;
            // 
            // textBoxDatum
            // 
            this.textBoxDatum.Location = new System.Drawing.Point(116, 216);
            this.textBoxDatum.Name = "textBoxDatum";
            this.textBoxDatum.Size = new System.Drawing.Size(122, 20);
            this.textBoxDatum.TabIndex = 8;
            // 
            // labelIDT
            // 
            this.labelIDT.AutoSize = true;
            this.labelIDT.Location = new System.Drawing.Point(302, 130);
            this.labelIDT.Name = "labelIDT";
            this.labelIDT.Size = new System.Drawing.Size(0, 13);
            this.labelIDT.TabIndex = 9;
            // 
            // labelIDTeilnehmer
            // 
            this.labelIDTeilnehmer.AutoSize = true;
            this.labelIDTeilnehmer.Location = new System.Drawing.Point(302, 130);
            this.labelIDTeilnehmer.Name = "labelIDTeilnehmer";
            this.labelIDTeilnehmer.Size = new System.Drawing.Size(16, 13);
            this.labelIDTeilnehmer.TabIndex = 10;
            this.labelIDTeilnehmer.Text = "Id";
            // 
            // labelNachname
            // 
            this.labelNachname.AutoSize = true;
            this.labelNachname.Location = new System.Drawing.Point(299, 174);
            this.labelNachname.Name = "labelNachname";
            this.labelNachname.Size = new System.Drawing.Size(59, 13);
            this.labelNachname.TabIndex = 11;
            this.labelNachname.Text = "Nachname";
            // 
            // labelVorname
            // 
            this.labelVorname.AutoSize = true;
            this.labelVorname.Location = new System.Drawing.Point(299, 216);
            this.labelVorname.Name = "labelVorname";
            this.labelVorname.Size = new System.Drawing.Size(49, 13);
            this.labelVorname.TabIndex = 12;
            this.labelVorname.Text = "Vorname";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(299, 259);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 13;
            this.labelEmail.Text = "Email";
            // 
            // buttonTeilnehmerCSV
            // 
            this.buttonTeilnehmerCSV.Location = new System.Drawing.Point(305, 295);
            this.buttonTeilnehmerCSV.Name = "buttonTeilnehmerCSV";
            this.buttonTeilnehmerCSV.Size = new System.Drawing.Size(184, 23);
            this.buttonTeilnehmerCSV.TabIndex = 14;
            this.buttonTeilnehmerCSV.Text = "Teilnehmer.csv";
            this.buttonTeilnehmerCSV.UseVisualStyleBackColor = true;
            // 
            // textBoxIdTeilnehmer
            // 
            this.textBoxIdTeilnehmer.Location = new System.Drawing.Point(369, 130);
            this.textBoxIdTeilnehmer.Name = "textBoxIdTeilnehmer";
            this.textBoxIdTeilnehmer.Size = new System.Drawing.Size(56, 20);
            this.textBoxIdTeilnehmer.TabIndex = 15;
            // 
            // textBoxNachname
            // 
            this.textBoxNachname.Location = new System.Drawing.Point(369, 171);
            this.textBoxNachname.Name = "textBoxNachname";
            this.textBoxNachname.Size = new System.Drawing.Size(120, 20);
            this.textBoxNachname.TabIndex = 16;
            // 
            // textBoxVorname
            // 
            this.textBoxVorname.Location = new System.Drawing.Point(369, 216);
            this.textBoxVorname.Name = "textBoxVorname";
            this.textBoxVorname.Size = new System.Drawing.Size(120, 20);
            this.textBoxVorname.TabIndex = 17;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(369, 259);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(120, 20);
            this.textBoxEmail.TabIndex = 18;
            // 
            // buttonAnzeigen
            // 
            this.buttonAnzeigen.Location = new System.Drawing.Point(37, 40);
            this.buttonAnzeigen.Name = "buttonAnzeigen";
            this.buttonAnzeigen.Size = new System.Drawing.Size(452, 23);
            this.buttonAnzeigen.TabIndex = 19;
            this.buttonAnzeigen.Text = "Daten anzeigen";
            this.buttonAnzeigen.UseVisualStyleBackColor = true;
            this.buttonAnzeigen.Click += new System.EventHandler(this.buttonAnzeigen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 358);
            this.Controls.Add(this.buttonAnzeigen);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxVorname);
            this.Controls.Add(this.textBoxNachname);
            this.Controls.Add(this.textBoxIdTeilnehmer);
            this.Controls.Add(this.buttonTeilnehmerCSV);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelVorname);
            this.Controls.Add(this.labelNachname);
            this.Controls.Add(this.labelIDTeilnehmer);
            this.Controls.Add(this.labelIDT);
            this.Controls.Add(this.textBoxDatum);
            this.Controls.Add(this.textBoxBezeichnung);
            this.Controls.Add(this.buttonKursCSV);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelBezeichnung);
            this.Controls.Add(this.textBoxIdKurs);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.comboBoxTeilnehmer);
            this.Controls.Add(this.comboBoxKurse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKurse;
        private System.Windows.Forms.ComboBox comboBoxTeilnehmer;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxIdKurs;
        private System.Windows.Forms.Label labelBezeichnung;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Button buttonKursCSV;
        private System.Windows.Forms.TextBox textBoxBezeichnung;
        private System.Windows.Forms.TextBox textBoxDatum;
        private System.Windows.Forms.Label labelIDT;
        private System.Windows.Forms.Label labelIDTeilnehmer;
        private System.Windows.Forms.Label labelNachname;
        private System.Windows.Forms.Label labelVorname;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonTeilnehmerCSV;
        private System.Windows.Forms.TextBox textBoxIdTeilnehmer;
        private System.Windows.Forms.TextBox textBoxNachname;
        private System.Windows.Forms.TextBox textBoxVorname;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonAnzeigen;
    }
}

