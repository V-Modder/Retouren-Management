namespace Retouren_Management
{
    partial class frm_Kunde
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Kunde));
            this.lbl_rechnungsnr = new System.Windows.Forms.Label();
            this.txt_rechnungsnr = new System.Windows.Forms.TextBox();
            this.txt_kundennr = new System.Windows.Forms.TextBox();
            this.lbl_kundennr = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_vorname = new System.Windows.Forms.TextBox();
            this.lbl_vorname = new System.Windows.Forms.Label();
            this.txt_strasse = new System.Windows.Forms.TextBox();
            this.lbl_strasse = new System.Windows.Forms.Label();
            this.txt_firma = new System.Windows.Forms.TextBox();
            this.lbl_firma = new System.Windows.Forms.Label();
            this.txt_plz = new System.Windows.Forms.TextBox();
            this.lbl_plz = new System.Windows.Forms.Label();
            this.txt_ort = new System.Windows.Forms.TextBox();
            this.lbl_ort = new System.Windows.Forms.Label();
            this.txt_land = new System.Windows.Forms.TextBox();
            this.lbl_land = new System.Windows.Forms.Label();
            this.btn_erstattung = new System.Windows.Forms.Button();
            this.lbl_artikel = new System.Windows.Forms.Label();
            this.lbl_zurueck = new System.Windows.Forms.Label();
            this.btn_umtausch = new System.Windows.Forms.Button();
            this.dgv_artikel = new System.Windows.Forms.DataGridView();
            this.artikelnr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vkpreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_zuruck = new System.Windows.Forms.DataGridView();
            this.ean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikelnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_artikel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_zuruck)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_rechnungsnr
            // 
            this.lbl_rechnungsnr.AutoSize = true;
            this.lbl_rechnungsnr.Location = new System.Drawing.Point(13, 13);
            this.lbl_rechnungsnr.Name = "lbl_rechnungsnr";
            this.lbl_rechnungsnr.Size = new System.Drawing.Size(82, 13);
            this.lbl_rechnungsnr.TabIndex = 29;
            this.lbl_rechnungsnr.Text = "Rechnungs-Nr :";
            // 
            // txt_rechnungsnr
            // 
            this.txt_rechnungsnr.Enabled = false;
            this.txt_rechnungsnr.Location = new System.Drawing.Point(122, 10);
            this.txt_rechnungsnr.Name = "txt_rechnungsnr";
            this.txt_rechnungsnr.Size = new System.Drawing.Size(160, 20);
            this.txt_rechnungsnr.TabIndex = 1;
            // 
            // txt_kundennr
            // 
            this.txt_kundennr.Enabled = false;
            this.txt_kundennr.Location = new System.Drawing.Point(122, 36);
            this.txt_kundennr.Name = "txt_kundennr";
            this.txt_kundennr.Size = new System.Drawing.Size(160, 20);
            this.txt_kundennr.TabIndex = 3;
            // 
            // lbl_kundennr
            // 
            this.lbl_kundennr.AutoSize = true;
            this.lbl_kundennr.Location = new System.Drawing.Point(13, 39);
            this.lbl_kundennr.Name = "lbl_kundennr";
            this.lbl_kundennr.Size = new System.Drawing.Size(64, 13);
            this.lbl_kundennr.TabIndex = 2;
            this.lbl_kundennr.Text = "Kunden-Nr :";
            // 
            // txt_name
            // 
            this.txt_name.Enabled = false;
            this.txt_name.Location = new System.Drawing.Point(122, 88);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(160, 20);
            this.txt_name.TabIndex = 7;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(13, 91);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(41, 13);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "Name :";
            // 
            // txt_vorname
            // 
            this.txt_vorname.Enabled = false;
            this.txt_vorname.Location = new System.Drawing.Point(122, 62);
            this.txt_vorname.Name = "txt_vorname";
            this.txt_vorname.Size = new System.Drawing.Size(160, 20);
            this.txt_vorname.TabIndex = 5;
            // 
            // lbl_vorname
            // 
            this.lbl_vorname.AutoSize = true;
            this.lbl_vorname.Location = new System.Drawing.Point(13, 65);
            this.lbl_vorname.Name = "lbl_vorname";
            this.lbl_vorname.Size = new System.Drawing.Size(55, 13);
            this.lbl_vorname.TabIndex = 4;
            this.lbl_vorname.Text = "Vorname :";
            // 
            // txt_strasse
            // 
            this.txt_strasse.Enabled = false;
            this.txt_strasse.Location = new System.Drawing.Point(401, 10);
            this.txt_strasse.Name = "txt_strasse";
            this.txt_strasse.Size = new System.Drawing.Size(156, 20);
            this.txt_strasse.TabIndex = 11;
            // 
            // lbl_strasse
            // 
            this.lbl_strasse.AutoSize = true;
            this.lbl_strasse.Location = new System.Drawing.Point(307, 13);
            this.lbl_strasse.Name = "lbl_strasse";
            this.lbl_strasse.Size = new System.Drawing.Size(61, 13);
            this.lbl_strasse.TabIndex = 10;
            this.lbl_strasse.Text = "Straße, Nr :";
            // 
            // txt_firma
            // 
            this.txt_firma.Enabled = false;
            this.txt_firma.Location = new System.Drawing.Point(122, 114);
            this.txt_firma.Name = "txt_firma";
            this.txt_firma.Size = new System.Drawing.Size(160, 20);
            this.txt_firma.TabIndex = 9;
            // 
            // lbl_firma
            // 
            this.lbl_firma.AutoSize = true;
            this.lbl_firma.Location = new System.Drawing.Point(13, 117);
            this.lbl_firma.Name = "lbl_firma";
            this.lbl_firma.Size = new System.Drawing.Size(38, 13);
            this.lbl_firma.TabIndex = 8;
            this.lbl_firma.Text = "Firma :";
            // 
            // txt_plz
            // 
            this.txt_plz.Enabled = false;
            this.txt_plz.Location = new System.Drawing.Point(401, 36);
            this.txt_plz.Name = "txt_plz";
            this.txt_plz.Size = new System.Drawing.Size(156, 20);
            this.txt_plz.TabIndex = 15;
            // 
            // lbl_plz
            // 
            this.lbl_plz.AutoSize = true;
            this.lbl_plz.Location = new System.Drawing.Point(307, 39);
            this.lbl_plz.Name = "lbl_plz";
            this.lbl_plz.Size = new System.Drawing.Size(33, 13);
            this.lbl_plz.TabIndex = 14;
            this.lbl_plz.Text = "PLZ :";
            // 
            // txt_ort
            // 
            this.txt_ort.Enabled = false;
            this.txt_ort.Location = new System.Drawing.Point(401, 62);
            this.txt_ort.Name = "txt_ort";
            this.txt_ort.Size = new System.Drawing.Size(156, 20);
            this.txt_ort.TabIndex = 17;
            // 
            // lbl_ort
            // 
            this.lbl_ort.AutoSize = true;
            this.lbl_ort.Location = new System.Drawing.Point(307, 65);
            this.lbl_ort.Name = "lbl_ort";
            this.lbl_ort.Size = new System.Drawing.Size(27, 13);
            this.lbl_ort.TabIndex = 16;
            this.lbl_ort.Text = "Ort :";
            // 
            // txt_land
            // 
            this.txt_land.Enabled = false;
            this.txt_land.Location = new System.Drawing.Point(401, 88);
            this.txt_land.Name = "txt_land";
            this.txt_land.Size = new System.Drawing.Size(156, 20);
            this.txt_land.TabIndex = 19;
            // 
            // lbl_land
            // 
            this.lbl_land.AutoSize = true;
            this.lbl_land.Location = new System.Drawing.Point(307, 91);
            this.lbl_land.Name = "lbl_land";
            this.lbl_land.Size = new System.Drawing.Size(37, 13);
            this.lbl_land.TabIndex = 18;
            this.lbl_land.Text = "Land :";
            // 
            // btn_erstattung
            // 
            this.btn_erstattung.Enabled = false;
            this.btn_erstattung.Location = new System.Drawing.Point(482, 463);
            this.btn_erstattung.Name = "btn_erstattung";
            this.btn_erstattung.Size = new System.Drawing.Size(75, 23);
            this.btn_erstattung.TabIndex = 21;
            this.btn_erstattung.Text = "Erstattung";
            this.btn_erstattung.UseVisualStyleBackColor = true;
            this.btn_erstattung.Click += new System.EventHandler(this.btn_erstattung_Click);
            // 
            // lbl_artikel
            // 
            this.lbl_artikel.AutoSize = true;
            this.lbl_artikel.Location = new System.Drawing.Point(12, 154);
            this.lbl_artikel.Name = "lbl_artikel";
            this.lbl_artikel.Size = new System.Drawing.Size(36, 13);
            this.lbl_artikel.TabIndex = 23;
            this.lbl_artikel.Text = "Artikel";
            // 
            // lbl_zurueck
            // 
            this.lbl_zurueck.AutoSize = true;
            this.lbl_zurueck.Location = new System.Drawing.Point(12, 321);
            this.lbl_zurueck.Name = "lbl_zurueck";
            this.lbl_zurueck.Size = new System.Drawing.Size(41, 13);
            this.lbl_zurueck.TabIndex = 24;
            this.lbl_zurueck.Text = "Zurück";
            // 
            // btn_umtausch
            // 
            this.btn_umtausch.Enabled = false;
            this.btn_umtausch.Location = new System.Drawing.Point(384, 463);
            this.btn_umtausch.Name = "btn_umtausch";
            this.btn_umtausch.Size = new System.Drawing.Size(75, 23);
            this.btn_umtausch.TabIndex = 26;
            this.btn_umtausch.Text = "Umtausch";
            this.btn_umtausch.UseVisualStyleBackColor = true;
            this.btn_umtausch.Click += new System.EventHandler(this.btn_umtausch_Click);
            // 
            // dgv_artikel
            // 
            this.dgv_artikel.AllowUserToAddRows = false;
            this.dgv_artikel.AllowUserToDeleteRows = false;
            this.dgv_artikel.AllowUserToResizeRows = false;
            this.dgv_artikel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_artikel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artikelnr,
            this.vkpreis});
            this.dgv_artikel.Enabled = false;
            this.dgv_artikel.Location = new System.Drawing.Point(12, 171);
            this.dgv_artikel.Name = "dgv_artikel";
            this.dgv_artikel.ReadOnly = true;
            this.dgv_artikel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_artikel.Size = new System.Drawing.Size(545, 150);
            this.dgv_artikel.TabIndex = 27;
            // 
            // artikelnr
            // 
            this.artikelnr.HeaderText = "Artikel Nr";
            this.artikelnr.Name = "artikelnr";
            this.artikelnr.ReadOnly = true;
            this.artikelnr.Width = 200;
            // 
            // vkpreis
            // 
            this.vkpreis.HeaderText = "VK-Preis";
            this.vkpreis.Name = "vkpreis";
            this.vkpreis.ReadOnly = true;
            // 
            // dgv_zuruck
            // 
            this.dgv_zuruck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_zuruck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ean,
            this.artikelnummer});
            this.dgv_zuruck.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_zuruck.Location = new System.Drawing.Point(12, 337);
            this.dgv_zuruck.Name = "dgv_zuruck";
            this.dgv_zuruck.Size = new System.Drawing.Size(545, 120);
            this.dgv_zuruck.TabIndex = 0;
            this.dgv_zuruck.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_zuruck_CellLeave);
            // 
            // ean
            // 
            this.ean.HeaderText = "EAN";
            this.ean.Name = "ean";
            // 
            // artikelnummer
            // 
            this.artikelnummer.HeaderText = "Artikel-Nr";
            this.artikelnummer.Name = "artikelnummer";
            this.artikelnummer.ReadOnly = true;
            // 
            // frm_Kunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 495);
            this.Controls.Add(this.dgv_zuruck);
            this.Controls.Add(this.dgv_artikel);
            this.Controls.Add(this.btn_umtausch);
            this.Controls.Add(this.lbl_zurueck);
            this.Controls.Add(this.lbl_artikel);
            this.Controls.Add(this.btn_erstattung);
            this.Controls.Add(this.txt_land);
            this.Controls.Add(this.lbl_land);
            this.Controls.Add(this.txt_ort);
            this.Controls.Add(this.lbl_ort);
            this.Controls.Add(this.txt_plz);
            this.Controls.Add(this.lbl_plz);
            this.Controls.Add(this.txt_strasse);
            this.Controls.Add(this.lbl_strasse);
            this.Controls.Add(this.txt_firma);
            this.Controls.Add(this.lbl_firma);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_vorname);
            this.Controls.Add(this.lbl_vorname);
            this.Controls.Add(this.txt_kundennr);
            this.Controls.Add(this.lbl_kundennr);
            this.Controls.Add(this.txt_rechnungsnr);
            this.Controls.Add(this.lbl_rechnungsnr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Kunde";
            this.Text = "Retouren-Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Kunde_FormClosing);
            this.Load += new System.EventHandler(this.frm_Kunde_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Kunde_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_artikel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_zuruck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_rechnungsnr;
        private System.Windows.Forms.TextBox txt_rechnungsnr;
        private System.Windows.Forms.TextBox txt_kundennr;
        private System.Windows.Forms.Label lbl_kundennr;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_vorname;
        private System.Windows.Forms.Label lbl_vorname;
        private System.Windows.Forms.TextBox txt_strasse;
        private System.Windows.Forms.Label lbl_strasse;
        private System.Windows.Forms.TextBox txt_firma;
        private System.Windows.Forms.Label lbl_firma;
        private System.Windows.Forms.TextBox txt_plz;
        private System.Windows.Forms.Label lbl_plz;
        private System.Windows.Forms.TextBox txt_ort;
        private System.Windows.Forms.Label lbl_ort;
        private System.Windows.Forms.TextBox txt_land;
        private System.Windows.Forms.Label lbl_land;
        private System.Windows.Forms.Button btn_erstattung;
        private System.Windows.Forms.Label lbl_artikel;
        private System.Windows.Forms.Label lbl_zurueck;
        private System.Windows.Forms.Button btn_umtausch;
        private System.Windows.Forms.DataGridView dgv_artikel;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikelnr;
        private System.Windows.Forms.DataGridViewTextBoxColumn vkpreis;
        private System.Windows.Forms.DataGridView dgv_zuruck;
        private System.Windows.Forms.DataGridViewTextBoxColumn ean;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikelnummer;
    }
}