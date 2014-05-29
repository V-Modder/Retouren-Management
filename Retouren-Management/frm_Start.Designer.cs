namespace Retouren_Management
{
    partial class frm_Start
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
            this.btn_start = new System.Windows.Forms.Button();
            this.pic_doc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_doc)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.BackgroundImage = global::Retouren_Management.Properties.Resources.Button;
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_start.Location = new System.Drawing.Point(0, 0);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(318, 47);
            this.btn_start.TabIndex = 0;
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            this.btn_start.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_start_MouseDown);
            // 
            // pic_doc
            // 
            this.pic_doc.Image = global::Retouren_Management.Properties.Resources.Pin;
            this.pic_doc.Location = new System.Drawing.Point(262, 16);
            this.pic_doc.Name = "pic_doc";
            this.pic_doc.Size = new System.Drawing.Size(15, 15);
            this.pic_doc.TabIndex = 2;
            this.pic_doc.TabStop = false;
            this.pic_doc.Click += new System.EventHandler(this.pic_doc_Click);
            // 
            // frm_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(319, 48);
            this.Controls.Add(this.pic_doc);
            this.Controls.Add(this.btn_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Start";
            this.ShowInTaskbar = false;
            this.Text = "Retouren-Management";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Start_FormClosing);
            this.Load += new System.EventHandler(this.frm_Start_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_Start_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pic_doc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.PictureBox pic_doc;
    }
}

