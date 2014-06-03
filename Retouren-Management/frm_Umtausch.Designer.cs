namespace Retouren_Management
{
    partial class frm_Umtausch
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
            this.rdb_s = new System.Windows.Forms.RadioButton();
            this.rdb_m = new System.Windows.Forms.RadioButton();
            this.rdb_xl = new System.Windows.Forms.RadioButton();
            this.rdb_xxl = new System.Windows.Forms.RadioButton();
            this.rdb_3xl = new System.Windows.Forms.RadioButton();
            this.rdb_4xl = new System.Windows.Forms.RadioButton();
            this.rdb_5xl = new System.Windows.Forms.RadioButton();
            this.rdb_sonstiges = new System.Windows.Forms.RadioButton();
            this.rdb_massanfertigung = new System.Windows.Forms.RadioButton();
            this.txt_sonstiges = new System.Windows.Forms.TextBox();
            this.btn_fertig = new System.Windows.Forms.Button();
            this.rdb_l = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rdb_s
            // 
            this.rdb_s.AutoSize = true;
            this.rdb_s.Location = new System.Drawing.Point(12, 13);
            this.rdb_s.Name = "rdb_s";
            this.rdb_s.Size = new System.Drawing.Size(32, 17);
            this.rdb_s.TabIndex = 0;
            this.rdb_s.TabStop = true;
            this.rdb_s.Text = "S";
            this.rdb_s.UseVisualStyleBackColor = true;
            this.rdb_s.CheckedChanged += new System.EventHandler(this.rdb_5xl_CheckedChanged);
            // 
            // rdb_m
            // 
            this.rdb_m.AutoSize = true;
            this.rdb_m.Location = new System.Drawing.Point(12, 36);
            this.rdb_m.Name = "rdb_m";
            this.rdb_m.Size = new System.Drawing.Size(34, 17);
            this.rdb_m.TabIndex = 1;
            this.rdb_m.TabStop = true;
            this.rdb_m.Text = "M";
            this.rdb_m.UseVisualStyleBackColor = true;
            this.rdb_m.CheckedChanged += new System.EventHandler(this.rdb_5xl_CheckedChanged);
            // 
            // rdb_xl
            // 
            this.rdb_xl.AutoSize = true;
            this.rdb_xl.Location = new System.Drawing.Point(12, 82);
            this.rdb_xl.Name = "rdb_xl";
            this.rdb_xl.Size = new System.Drawing.Size(38, 17);
            this.rdb_xl.TabIndex = 2;
            this.rdb_xl.TabStop = true;
            this.rdb_xl.Text = "XL";
            this.rdb_xl.UseVisualStyleBackColor = true;
            this.rdb_xl.CheckedChanged += new System.EventHandler(this.rdb_5xl_CheckedChanged);
            // 
            // rdb_xxl
            // 
            this.rdb_xxl.AutoSize = true;
            this.rdb_xxl.Location = new System.Drawing.Point(113, 13);
            this.rdb_xxl.Name = "rdb_xxl";
            this.rdb_xxl.Size = new System.Drawing.Size(45, 17);
            this.rdb_xxl.TabIndex = 3;
            this.rdb_xxl.TabStop = true;
            this.rdb_xxl.Text = "XXL";
            this.rdb_xxl.UseVisualStyleBackColor = true;
            this.rdb_xxl.CheckedChanged += new System.EventHandler(this.rdb_5xl_CheckedChanged);
            // 
            // rdb_3xl
            // 
            this.rdb_3xl.AutoSize = true;
            this.rdb_3xl.Location = new System.Drawing.Point(113, 36);
            this.rdb_3xl.Name = "rdb_3xl";
            this.rdb_3xl.Size = new System.Drawing.Size(44, 17);
            this.rdb_3xl.TabIndex = 4;
            this.rdb_3xl.TabStop = true;
            this.rdb_3xl.Text = "3XL";
            this.rdb_3xl.UseVisualStyleBackColor = true;
            this.rdb_3xl.CheckedChanged += new System.EventHandler(this.rdb_5xl_CheckedChanged);
            // 
            // rdb_4xl
            // 
            this.rdb_4xl.AutoSize = true;
            this.rdb_4xl.Location = new System.Drawing.Point(113, 59);
            this.rdb_4xl.Name = "rdb_4xl";
            this.rdb_4xl.Size = new System.Drawing.Size(44, 17);
            this.rdb_4xl.TabIndex = 5;
            this.rdb_4xl.TabStop = true;
            this.rdb_4xl.Text = "4XL";
            this.rdb_4xl.UseVisualStyleBackColor = true;
            this.rdb_4xl.CheckedChanged += new System.EventHandler(this.rdb_5xl_CheckedChanged);
            // 
            // rdb_5xl
            // 
            this.rdb_5xl.AutoSize = true;
            this.rdb_5xl.Location = new System.Drawing.Point(113, 82);
            this.rdb_5xl.Name = "rdb_5xl";
            this.rdb_5xl.Size = new System.Drawing.Size(44, 17);
            this.rdb_5xl.TabIndex = 6;
            this.rdb_5xl.TabStop = true;
            this.rdb_5xl.Text = "5XL";
            this.rdb_5xl.UseVisualStyleBackColor = true;
            this.rdb_5xl.CheckedChanged += new System.EventHandler(this.rdb_5xl_CheckedChanged);
            // 
            // rdb_sonstiges
            // 
            this.rdb_sonstiges.AutoSize = true;
            this.rdb_sonstiges.Location = new System.Drawing.Point(12, 105);
            this.rdb_sonstiges.Name = "rdb_sonstiges";
            this.rdb_sonstiges.Size = new System.Drawing.Size(71, 17);
            this.rdb_sonstiges.TabIndex = 8;
            this.rdb_sonstiges.TabStop = true;
            this.rdb_sonstiges.Text = "Sonstiges";
            this.rdb_sonstiges.UseVisualStyleBackColor = true;
            this.rdb_sonstiges.CheckedChanged += new System.EventHandler(this.rdb_5xl_CheckedChanged);
            // 
            // rdb_massanfertigung
            // 
            this.rdb_massanfertigung.AutoSize = true;
            this.rdb_massanfertigung.Location = new System.Drawing.Point(12, 211);
            this.rdb_massanfertigung.Name = "rdb_massanfertigung";
            this.rdb_massanfertigung.Size = new System.Drawing.Size(99, 17);
            this.rdb_massanfertigung.TabIndex = 9;
            this.rdb_massanfertigung.TabStop = true;
            this.rdb_massanfertigung.Text = "Maßanfertigung";
            this.rdb_massanfertigung.UseVisualStyleBackColor = true;
            this.rdb_massanfertigung.CheckedChanged += new System.EventHandler(this.rdb_5xl_CheckedChanged);
            // 
            // txt_sonstiges
            // 
            this.txt_sonstiges.Enabled = false;
            this.txt_sonstiges.Location = new System.Drawing.Point(29, 128);
            this.txt_sonstiges.Multiline = true;
            this.txt_sonstiges.Name = "txt_sonstiges";
            this.txt_sonstiges.Size = new System.Drawing.Size(208, 77);
            this.txt_sonstiges.TabIndex = 10;
            this.txt_sonstiges.TextChanged += new System.EventHandler(this.txt_sonstiges_TextChanged);
            // 
            // btn_fertig
            // 
            this.btn_fertig.Location = new System.Drawing.Point(58, 234);
            this.btn_fertig.Name = "btn_fertig";
            this.btn_fertig.Size = new System.Drawing.Size(75, 23);
            this.btn_fertig.TabIndex = 12;
            this.btn_fertig.Text = "Fertig";
            this.btn_fertig.UseVisualStyleBackColor = true;
            this.btn_fertig.Click += new System.EventHandler(this.btn_fertig_Click);
            // 
            // rdb_l
            // 
            this.rdb_l.AutoSize = true;
            this.rdb_l.Location = new System.Drawing.Point(12, 59);
            this.rdb_l.Name = "rdb_l";
            this.rdb_l.Size = new System.Drawing.Size(31, 17);
            this.rdb_l.TabIndex = 13;
            this.rdb_l.TabStop = true;
            this.rdb_l.Text = "L";
            this.rdb_l.UseVisualStyleBackColor = true;
            this.rdb_l.CheckedChanged += new System.EventHandler(this.rdb_5xl_CheckedChanged);
            // 
            // frm_Umtausch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 269);
            this.ControlBox = false;
            this.Controls.Add(this.rdb_l);
            this.Controls.Add(this.btn_fertig);
            this.Controls.Add(this.txt_sonstiges);
            this.Controls.Add(this.rdb_massanfertigung);
            this.Controls.Add(this.rdb_sonstiges);
            this.Controls.Add(this.rdb_5xl);
            this.Controls.Add(this.rdb_4xl);
            this.Controls.Add(this.rdb_3xl);
            this.Controls.Add(this.rdb_xxl);
            this.Controls.Add(this.rdb_xl);
            this.Controls.Add(this.rdb_m);
            this.Controls.Add(this.rdb_s);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Umtausch";
            this.ShowInTaskbar = false;
            this.Text = "Umtausch";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Umtausch_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_s;
        private System.Windows.Forms.RadioButton rdb_m;
        private System.Windows.Forms.RadioButton rdb_xl;
        private System.Windows.Forms.RadioButton rdb_xxl;
        private System.Windows.Forms.RadioButton rdb_3xl;
        private System.Windows.Forms.RadioButton rdb_4xl;
        private System.Windows.Forms.RadioButton rdb_5xl;
        private System.Windows.Forms.RadioButton rdb_sonstiges;
        private System.Windows.Forms.RadioButton rdb_massanfertigung;
        private System.Windows.Forms.TextBox txt_sonstiges;
        private System.Windows.Forms.Button btn_fertig;
        private System.Windows.Forms.RadioButton rdb_l;
    }
}