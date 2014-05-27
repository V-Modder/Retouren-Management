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
            this.chk_move = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(0, 0);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(116, 50);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Retoure";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // chk_move
            // 
            this.chk_move.Location = new System.Drawing.Point(117, 40);
            this.chk_move.Margin = new System.Windows.Forms.Padding(0);
            this.chk_move.Name = "chk_move";
            this.chk_move.Size = new System.Drawing.Size(10, 10);
            this.chk_move.TabIndex = 1;
            this.chk_move.UseVisualStyleBackColor = true;
            // 
            // frm_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(130, 50);
            this.Controls.Add(this.chk_move);
            this.Controls.Add(this.btn_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Start";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Start_FormClosing);
            this.Load += new System.EventHandler(this.frm_Start_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_Start_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.CheckBox chk_move;
    }
}

