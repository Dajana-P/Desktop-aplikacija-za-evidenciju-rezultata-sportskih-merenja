namespace KorisnickiInterfejs
{
    partial class frmEvidencijaRezultataSportskihMerenja
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
			this.txtFilter = new System.Windows.Forms.TextBox();
			this.btnSve = new System.Windows.Forms.Button();
			this.btnExportXML = new System.Windows.Forms.Button();
			this.btnFiltriraj = new System.Windows.Forms.Button();
			this.btnOdustani = new System.Windows.Forms.Button();
			this.groupBoxTabelarniPrikazIFiltriranje = new System.Windows.Forms.GroupBox();
			this.cmbNacinFiltriranja = new System.Windows.Forms.ComboBox();
			this.dgvSpisakSportista = new System.Windows.Forms.DataGridView();
			this.groupBoxSportista = new System.Windows.Forms.GroupBox();
			this.numUpDownStarost = new System.Windows.Forms.NumericUpDown();
			this.numUpDownBrojSklekova = new System.Windows.Forms.NumericUpDown();
			this.numUpDownBrojTrbusnjaka = new System.Windows.Forms.NumericUpDown();
			this.numUpDownTezina = new System.Windows.Forms.NumericUpDown();
			this.numUpDownVisina = new System.Windows.Forms.NumericUpDown();
			this.lblBrojSklekova = new System.Windows.Forms.Label();
			this.lblBrojTrbusnjaka = new System.Windows.Forms.Label();
			this.cmbPol = new System.Windows.Forms.ComboBox();
			this.lblTezina = new System.Windows.Forms.Label();
			this.lblVisina = new System.Windows.Forms.Label();
			this.lblStarost = new System.Windows.Forms.Label();
			this.lblPol = new System.Windows.Forms.Label();
			this.btnIzmena = new System.Windows.Forms.Button();
			this.btnBrisanje = new System.Windows.Forms.Button();
			this.btnSnimi = new System.Windows.Forms.Button();
			this.btnUnos = new System.Windows.Forms.Button();
			this.txtPrezime = new System.Windows.Forms.TextBox();
			this.txtIme = new System.Windows.Forms.TextBox();
			this.lblPrezime = new System.Windows.Forms.Label();
			this.lblIme = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.groupBoxTabelarniPrikazIFiltriranje.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSpisakSportista)).BeginInit();
			this.groupBoxSportista.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numUpDownStarost)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDownBrojSklekova)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDownBrojTrbusnjaka)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDownTezina)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDownVisina)).BeginInit();
			this.SuspendLayout();
			// 
			// txtFilter
			// 
			this.txtFilter.Location = new System.Drawing.Point(181, 218);
			this.txtFilter.Name = "txtFilter";
			this.txtFilter.Size = new System.Drawing.Size(101, 20);
			this.txtFilter.TabIndex = 13;
			// 
			// btnSve
			// 
			this.btnSve.Location = new System.Drawing.Point(477, 210);
			this.btnSve.Name = "btnSve";
			this.btnSve.Size = new System.Drawing.Size(68, 28);
			this.btnSve.TabIndex = 11;
			this.btnSve.Text = "SVE";
			this.btnSve.UseVisualStyleBackColor = true;
			this.btnSve.Click += new System.EventHandler(this.btnSve_Click);
			// 
			// btnExportXML
			// 
			this.btnExportXML.Location = new System.Drawing.Point(731, 222);
			this.btnExportXML.Name = "btnExportXML";
			this.btnExportXML.Size = new System.Drawing.Size(85, 27);
			this.btnExportXML.TabIndex = 14;
			this.btnExportXML.Text = "Export XML";
			this.btnExportXML.UseVisualStyleBackColor = true;
			this.btnExportXML.Click += new System.EventHandler(this.btnExportXML_Click);
			// 
			// btnFiltriraj
			// 
			this.btnFiltriraj.Location = new System.Drawing.Point(319, 212);
			this.btnFiltriraj.Name = "btnFiltriraj";
			this.btnFiltriraj.Size = new System.Drawing.Size(75, 28);
			this.btnFiltriraj.TabIndex = 10;
			this.btnFiltriraj.Text = "FILTRIRAJ";
			this.btnFiltriraj.UseVisualStyleBackColor = true;
			this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
			// 
			// btnOdustani
			// 
			this.btnOdustani.Location = new System.Drawing.Point(707, 210);
			this.btnOdustani.Name = "btnOdustani";
			this.btnOdustani.Size = new System.Drawing.Size(97, 31);
			this.btnOdustani.TabIndex = 13;
			this.btnOdustani.Text = "ODUSTANI";
			this.btnOdustani.UseVisualStyleBackColor = true;
			this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
			// 
			// groupBoxTabelarniPrikazIFiltriranje
			// 
			this.groupBoxTabelarniPrikazIFiltriranje.Controls.Add(this.cmbNacinFiltriranja);
			this.groupBoxTabelarniPrikazIFiltriranje.Controls.Add(this.btnExportXML);
			this.groupBoxTabelarniPrikazIFiltriranje.Controls.Add(this.txtFilter);
			this.groupBoxTabelarniPrikazIFiltriranje.Controls.Add(this.btnSve);
			this.groupBoxTabelarniPrikazIFiltriranje.Controls.Add(this.btnFiltriraj);
			this.groupBoxTabelarniPrikazIFiltriranje.Controls.Add(this.dgvSpisakSportista);
			this.groupBoxTabelarniPrikazIFiltriranje.Location = new System.Drawing.Point(17, 311);
			this.groupBoxTabelarniPrikazIFiltriranje.Name = "groupBoxTabelarniPrikazIFiltriranje";
			this.groupBoxTabelarniPrikazIFiltriranje.Size = new System.Drawing.Size(984, 284);
			this.groupBoxTabelarniPrikazIFiltriranje.TabIndex = 11;
			this.groupBoxTabelarniPrikazIFiltriranje.TabStop = false;
			this.groupBoxTabelarniPrikazIFiltriranje.Text = "TABELARNI PRIKAZ I FILITRIRANJE";
			// 
			// cmbNacinFiltriranja
			// 
			this.cmbNacinFiltriranja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbNacinFiltriranja.FormattingEnabled = true;
			this.cmbNacinFiltriranja.Location = new System.Drawing.Point(21, 217);
			this.cmbNacinFiltriranja.Name = "cmbNacinFiltriranja";
			this.cmbNacinFiltriranja.Size = new System.Drawing.Size(121, 21);
			this.cmbNacinFiltriranja.TabIndex = 15;
			// 
			// dgvSpisakSportista
			// 
			this.dgvSpisakSportista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSpisakSportista.Location = new System.Drawing.Point(21, 31);
			this.dgvSpisakSportista.Name = "dgvSpisakSportista";
			this.dgvSpisakSportista.Size = new System.Drawing.Size(942, 154);
			this.dgvSpisakSportista.TabIndex = 9;
			this.dgvSpisakSportista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSpisakSportista_CellClick);
			this.dgvSpisakSportista.SelectionChanged += new System.EventHandler(this.dgvSpisakSportista_SelectionChanged);
			// 
			// groupBoxSportista
			// 
			this.groupBoxSportista.Controls.Add(this.numUpDownStarost);
			this.groupBoxSportista.Controls.Add(this.numUpDownBrojSklekova);
			this.groupBoxSportista.Controls.Add(this.numUpDownBrojTrbusnjaka);
			this.groupBoxSportista.Controls.Add(this.numUpDownTezina);
			this.groupBoxSportista.Controls.Add(this.numUpDownVisina);
			this.groupBoxSportista.Controls.Add(this.lblBrojSklekova);
			this.groupBoxSportista.Controls.Add(this.lblBrojTrbusnjaka);
			this.groupBoxSportista.Controls.Add(this.cmbPol);
			this.groupBoxSportista.Controls.Add(this.lblTezina);
			this.groupBoxSportista.Controls.Add(this.lblVisina);
			this.groupBoxSportista.Controls.Add(this.lblStarost);
			this.groupBoxSportista.Controls.Add(this.lblPol);
			this.groupBoxSportista.Controls.Add(this.btnIzmena);
			this.groupBoxSportista.Controls.Add(this.btnBrisanje);
			this.groupBoxSportista.Controls.Add(this.btnOdustani);
			this.groupBoxSportista.Controls.Add(this.btnSnimi);
			this.groupBoxSportista.Controls.Add(this.btnUnos);
			this.groupBoxSportista.Controls.Add(this.txtPrezime);
			this.groupBoxSportista.Controls.Add(this.txtIme);
			this.groupBoxSportista.Controls.Add(this.lblPrezime);
			this.groupBoxSportista.Controls.Add(this.lblIme);
			this.groupBoxSportista.Controls.Add(this.txtID);
			this.groupBoxSportista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxSportista.Location = new System.Drawing.Point(17, 19);
			this.groupBoxSportista.Name = "groupBoxSportista";
			this.groupBoxSportista.Size = new System.Drawing.Size(984, 258);
			this.groupBoxSportista.TabIndex = 10;
			this.groupBoxSportista.TabStop = false;
			this.groupBoxSportista.Text = "SPORTISTA";
			// 
			// numUpDownStarost
			// 
			this.numUpDownStarost.Location = new System.Drawing.Point(87, 199);
			this.numUpDownStarost.Name = "numUpDownStarost";
			this.numUpDownStarost.Size = new System.Drawing.Size(137, 20);
			this.numUpDownStarost.TabIndex = 33;
			// 
			// numUpDownBrojSklekova
			// 
			this.numUpDownBrojSklekova.Location = new System.Drawing.Point(477, 199);
			this.numUpDownBrojSklekova.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.numUpDownBrojSklekova.Name = "numUpDownBrojSklekova";
			this.numUpDownBrojSklekova.Size = new System.Drawing.Size(120, 20);
			this.numUpDownBrojSklekova.TabIndex = 32;
			// 
			// numUpDownBrojTrbusnjaka
			// 
			this.numUpDownBrojTrbusnjaka.Location = new System.Drawing.Point(477, 147);
			this.numUpDownBrojTrbusnjaka.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.numUpDownBrojTrbusnjaka.Name = "numUpDownBrojTrbusnjaka";
			this.numUpDownBrojTrbusnjaka.Size = new System.Drawing.Size(120, 20);
			this.numUpDownBrojTrbusnjaka.TabIndex = 31;
			// 
			// numUpDownTezina
			// 
			this.numUpDownTezina.Location = new System.Drawing.Point(477, 92);
			this.numUpDownTezina.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.numUpDownTezina.Name = "numUpDownTezina";
			this.numUpDownTezina.Size = new System.Drawing.Size(120, 20);
			this.numUpDownTezina.TabIndex = 30;
			// 
			// numUpDownVisina
			// 
			this.numUpDownVisina.Location = new System.Drawing.Point(477, 41);
			this.numUpDownVisina.Maximum = new decimal(new int[] {
            210,
            0,
            0,
            0});
			this.numUpDownVisina.Name = "numUpDownVisina";
			this.numUpDownVisina.Size = new System.Drawing.Size(120, 20);
			this.numUpDownVisina.TabIndex = 29;
			// 
			// lblBrojSklekova
			// 
			this.lblBrojSklekova.AutoSize = true;
			this.lblBrojSklekova.Location = new System.Drawing.Point(370, 201);
			this.lblBrojSklekova.Name = "lblBrojSklekova";
			this.lblBrojSklekova.Size = new System.Drawing.Size(71, 13);
			this.lblBrojSklekova.TabIndex = 28;
			this.lblBrojSklekova.Text = "Broj sklekova";
			// 
			// lblBrojTrbusnjaka
			// 
			this.lblBrojTrbusnjaka.AutoSize = true;
			this.lblBrojTrbusnjaka.Location = new System.Drawing.Point(370, 147);
			this.lblBrojTrbusnjaka.Name = "lblBrojTrbusnjaka";
			this.lblBrojTrbusnjaka.Size = new System.Drawing.Size(77, 13);
			this.lblBrojTrbusnjaka.TabIndex = 27;
			this.lblBrojTrbusnjaka.Text = "Broj trbušnjaka";
			// 
			// cmbPol
			// 
			this.cmbPol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPol.FormattingEnabled = true;
			this.cmbPol.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cmbPol.Location = new System.Drawing.Point(87, 147);
			this.cmbPol.Name = "cmbPol";
			this.cmbPol.Size = new System.Drawing.Size(137, 21);
			this.cmbPol.TabIndex = 26;
			// 
			// lblTezina
			// 
			this.lblTezina.AutoSize = true;
			this.lblTezina.Location = new System.Drawing.Point(368, 94);
			this.lblTezina.Name = "lblTezina";
			this.lblTezina.Size = new System.Drawing.Size(39, 13);
			this.lblTezina.TabIndex = 23;
			this.lblTezina.Text = "Težina";
			// 
			// lblVisina
			// 
			this.lblVisina.AutoSize = true;
			this.lblVisina.Location = new System.Drawing.Point(370, 43);
			this.lblVisina.Name = "lblVisina";
			this.lblVisina.Size = new System.Drawing.Size(35, 13);
			this.lblVisina.TabIndex = 22;
			this.lblVisina.Text = "Visina";
			// 
			// lblStarost
			// 
			this.lblStarost.AutoSize = true;
			this.lblStarost.Location = new System.Drawing.Point(28, 201);
			this.lblStarost.Name = "lblStarost";
			this.lblStarost.Size = new System.Drawing.Size(40, 13);
			this.lblStarost.TabIndex = 19;
			this.lblStarost.Text = "Starost";
			// 
			// lblPol
			// 
			this.lblPol.AutoSize = true;
			this.lblPol.Location = new System.Drawing.Point(28, 150);
			this.lblPol.Name = "lblPol";
			this.lblPol.Size = new System.Drawing.Size(22, 13);
			this.lblPol.TabIndex = 18;
			this.lblPol.Text = "Pol";
			// 
			// btnIzmena
			// 
			this.btnIzmena.Location = new System.Drawing.Point(707, 115);
			this.btnIzmena.Name = "btnIzmena";
			this.btnIzmena.Size = new System.Drawing.Size(97, 29);
			this.btnIzmena.TabIndex = 17;
			this.btnIzmena.Text = "IZMENA";
			this.btnIzmena.UseVisualStyleBackColor = true;
			this.btnIzmena.Click += new System.EventHandler(this.btnIzmena_Click);
			// 
			// btnBrisanje
			// 
			this.btnBrisanje.Location = new System.Drawing.Point(707, 68);
			this.btnBrisanje.Name = "btnBrisanje";
			this.btnBrisanje.Size = new System.Drawing.Size(97, 29);
			this.btnBrisanje.TabIndex = 16;
			this.btnBrisanje.Text = "BRISANJE";
			this.btnBrisanje.UseVisualStyleBackColor = true;
			this.btnBrisanje.Click += new System.EventHandler(this.btnBrisanje_Click);
			// 
			// btnSnimi
			// 
			this.btnSnimi.Location = new System.Drawing.Point(707, 164);
			this.btnSnimi.Name = "btnSnimi";
			this.btnSnimi.Size = new System.Drawing.Size(97, 29);
			this.btnSnimi.TabIndex = 12;
			this.btnSnimi.Text = "SNIMI";
			this.btnSnimi.UseVisualStyleBackColor = true;
			this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
			// 
			// btnUnos
			// 
			this.btnUnos.Location = new System.Drawing.Point(707, 21);
			this.btnUnos.Name = "btnUnos";
			this.btnUnos.Size = new System.Drawing.Size(97, 29);
			this.btnUnos.TabIndex = 11;
			this.btnUnos.Text = "UNOS";
			this.btnUnos.UseVisualStyleBackColor = true;
			this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
			// 
			// txtPrezime
			// 
			this.txtPrezime.Location = new System.Drawing.Point(87, 97);
			this.txtPrezime.Name = "txtPrezime";
			this.txtPrezime.Size = new System.Drawing.Size(137, 20);
			this.txtPrezime.TabIndex = 10;
			// 
			// txtIme
			// 
			this.txtIme.Location = new System.Drawing.Point(87, 46);
			this.txtIme.Name = "txtIme";
			this.txtIme.Size = new System.Drawing.Size(137, 20);
			this.txtIme.TabIndex = 9;
			// 
			// lblPrezime
			// 
			this.lblPrezime.AutoSize = true;
			this.lblPrezime.Location = new System.Drawing.Point(28, 97);
			this.lblPrezime.Name = "lblPrezime";
			this.lblPrezime.Size = new System.Drawing.Size(44, 13);
			this.lblPrezime.TabIndex = 8;
			this.lblPrezime.Text = "Prezime";
			// 
			// lblIme
			// 
			this.lblIme.AutoSize = true;
			this.lblIme.Location = new System.Drawing.Point(28, 46);
			this.lblIme.Name = "lblIme";
			this.lblIme.Size = new System.Drawing.Size(24, 13);
			this.lblIme.TabIndex = 7;
			this.lblIme.Text = "Ime";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(87, 46);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(137, 20);
			this.txtID.TabIndex = 34;
			this.txtID.Visible = false;
			// 
			// frmEvidencijaRezultataSportskihMerenja
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1030, 607);
			this.Controls.Add(this.groupBoxTabelarniPrikazIFiltriranje);
			this.Controls.Add(this.groupBoxSportista);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmEvidencijaRezultataSportskihMerenja";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Evidencija rezultata sportskih merenja";
			this.Load += new System.EventHandler(this.frmSaViseslojnimSopstvenimKlasama_Load);
			this.groupBoxTabelarniPrikazIFiltriranje.ResumeLayout(false);
			this.groupBoxTabelarniPrikazIFiltriranje.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSpisakSportista)).EndInit();
			this.groupBoxSportista.ResumeLayout(false);
			this.groupBoxSportista.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numUpDownStarost)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDownBrojSklekova)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDownBrojTrbusnjaka)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDownTezina)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numUpDownVisina)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnSve;
        private System.Windows.Forms.Button btnExportXML;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.GroupBox groupBoxTabelarniPrikazIFiltriranje;
        private System.Windows.Forms.DataGridView dgvSpisakSportista;
        private System.Windows.Forms.GroupBox groupBoxSportista;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
		private System.Windows.Forms.ComboBox cmbNacinFiltriranja;
		private System.Windows.Forms.Button btnIzmena;
		private System.Windows.Forms.Button btnBrisanje;
		private System.Windows.Forms.ComboBox cmbPol;
		private System.Windows.Forms.Label lblTezina;
		private System.Windows.Forms.Label lblVisina;
		private System.Windows.Forms.Label lblStarost;
		private System.Windows.Forms.Label lblPol;
		private System.Windows.Forms.NumericUpDown numUpDownStarost;
		private System.Windows.Forms.NumericUpDown numUpDownBrojSklekova;
		private System.Windows.Forms.NumericUpDown numUpDownBrojTrbusnjaka;
		private System.Windows.Forms.NumericUpDown numUpDownTezina;
		private System.Windows.Forms.NumericUpDown numUpDownVisina;
		private System.Windows.Forms.Label lblBrojSklekova;
		private System.Windows.Forms.Label lblBrojTrbusnjaka;
		private System.Windows.Forms.TextBox txtID;
	}
}