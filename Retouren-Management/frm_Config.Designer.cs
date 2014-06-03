namespace Retouren_Management
{
    partial class frm_Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Config));
            this.lbl_dbpath = new System.Windows.Forms.Label();
            this.txt_dbpath = new System.Windows.Forms.TextBox();
            this.txt_db = new System.Windows.Forms.TextBox();
            this.lbl_db = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.lbl_output = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_dbpath
            // 
            this.lbl_dbpath.AutoSize = true;
            this.lbl_dbpath.Location = new System.Drawing.Point(12, 25);
            this.lbl_dbpath.Name = "lbl_dbpath";
            this.lbl_dbpath.Size = new System.Drawing.Size(97, 13);
            this.lbl_dbpath.TabIndex = 0;
            this.lbl_dbpath.Text = "Datenbank-Server:";
            // 
            // txt_dbpath
            // 
            this.txt_dbpath.Location = new System.Drawing.Point(115, 22);
            this.txt_dbpath.Name = "txt_dbpath";
            this.txt_dbpath.Size = new System.Drawing.Size(187, 20);
            this.txt_dbpath.TabIndex = 1;
            // 
            // txt_db
            // 
            this.txt_db.Location = new System.Drawing.Point(115, 48);
            this.txt_db.Name = "txt_db";
            this.txt_db.Size = new System.Drawing.Size(187, 20);
            this.txt_db.TabIndex = 3;
            // 
            // lbl_db
            // 
            this.lbl_db.AutoSize = true;
            this.lbl_db.Location = new System.Drawing.Point(12, 51);
            this.lbl_db.Name = "lbl_db";
            this.lbl_db.Size = new System.Drawing.Size(63, 13);
            this.lbl_db.TabIndex = 2;
            this.lbl_db.Text = "Datenbank:";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(115, 74);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(187, 20);
            this.txt_user.TabIndex = 5;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(12, 77);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(73, 13);
            this.lbl_user.TabIndex = 4;
            this.lbl_user.Text = "Benutername:";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(115, 100);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(187, 20);
            this.txt_pass.TabIndex = 7;
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(12, 103);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(53, 13);
            this.lbl_pass.TabIndex = 6;
            this.lbl_pass.Text = "Passwort:";
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(115, 126);
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(187, 20);
            this.txt_output.TabIndex = 9;
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Location = new System.Drawing.Point(12, 129);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(52, 13);
            this.lbl_output.TabIndex = 8;
            this.lbl_output.Text = "Ausgabe:";
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(309, 123);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(32, 25);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "...";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(140, 159);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Speichern";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // frm_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 194);
            this.ControlBox = false;
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.txt_db);
            this.Controls.Add(this.lbl_db);
            this.Controls.Add(this.txt_dbpath);
            this.Controls.Add(this.lbl_dbpath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Config";
            this.Text = "Retouren-Management Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dbpath;
        private System.Windows.Forms.TextBox txt_dbpath;
        private System.Windows.Forms.TextBox txt_db;
        private System.Windows.Forms.Label lbl_db;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_save;
    }
}