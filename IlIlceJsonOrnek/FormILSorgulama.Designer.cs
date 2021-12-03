
namespace IlIlceJsonOrnek
{
    partial class FormILSorgulama
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.btnSec = new System.Windows.Forms.Button();
            this.comboXILSecimi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(30, 81);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(949, 524);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İsim";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Telefon";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fax";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Eposta";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Web Site";
            this.columnHeader5.Width = 100;
            // 
            // btnSec
            // 
            this.btnSec.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSec.Location = new System.Drawing.Point(885, 24);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(94, 29);
            this.btnSec.TabIndex = 13;
            this.btnSec.Text = "SEÇ";
            this.btnSec.UseVisualStyleBackColor = false;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // comboXILSecimi
            // 
            this.comboXILSecimi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboXILSecimi.FormattingEnabled = true;
            this.comboXILSecimi.Location = new System.Drawing.Point(148, 25);
            this.comboXILSecimi.Name = "comboXILSecimi";
            this.comboXILSecimi.Size = new System.Drawing.Size(565, 28);
            this.comboXILSecimi.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "İl Adı";
            // 
            // FormILSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 664);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.comboXILSecimi);
            this.Controls.Add(this.label1);
            this.Name = "FormILSorgulama";
            this.Text = "FormILSorgulama";
            this.Load += new System.EventHandler(this.FormILSorgulama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.ComboBox comboXILSecimi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}