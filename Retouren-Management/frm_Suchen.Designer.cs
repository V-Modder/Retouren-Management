namespace Retouren_Management
{
    partial class frm_Suchen
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
            this.btn_suchen = new System.Windows.Forms.Button();
            this.lbl_rechnungsnr = new System.Windows.Forms.Label();
            this.txt_rechnungsnr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_suchen
            // 
            this.btn_suchen.Location = new System.Drawing.Point(84, 43);
            this.btn_suchen.Name = "btn_suchen";
            this.btn_suchen.Size = new System.Drawing.Size(75, 23);
            this.btn_suchen.TabIndex = 0;
            this.btn_suchen.Text = "Suchen";
            this.btn_suchen.UseVisualStyleBackColor = true;
            this.btn_suchen.Click += new System.EventHandler(this.btn_suchen_Click);
            // 
            // lbl_rechnungsnr
            // 
            this.lbl_rechnungsnr.AutoSize = true;
            this.lbl_rechnungsnr.Location = new System.Drawing.Point(12, 20);
            this.lbl_rechnungsnr.Name = "lbl_rechnungsnr";
            this.lbl_rechnungsnr.Size = new System.Drawing.Size(82, 13);
            this.lbl_rechnungsnr.TabIndex = 1;
            this.lbl_rechnungsnr.Text = "Rechnungs-Nr.:";
            // 
            // txt_rechnungsnr
            // 
            this.txt_rechnungsnr.Location = new System.Drawing.Point(100, 17);
            this.txt_rechnungsnr.Name = "txt_rechnungsnr";
            this.txt_rechnungsnr.Size = new System.Drawing.Size(130, 20);
            this.txt_rechnungsnr.TabIndex = 2;
            this.txt_rechnungsnr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_rechnungsnr_KeyDown);
            // 
            // frm_Suchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 76);
            this.Controls.Add(this.txt_rechnungsnr);
            this.Controls.Add(this.lbl_rechnungsnr);
            this.Controls.Add(this.btn_suchen);
            this.KeyPreview = true;
            this.Name = "frm_Suchen";
            this.Text = "Suchen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Suchen_FormClosing);
            this.Load += new System.EventHandler(this.frm_Suchen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Suchen_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_suchen;
        private System.Windows.Forms.Label lbl_rechnungsnr;
        private System.Windows.Forms.TextBox txt_rechnungsnr;
    }
}