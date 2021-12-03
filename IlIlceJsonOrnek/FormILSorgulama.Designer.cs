
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detayGosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSec = new System.Windows.Forms.Button();
            this.comboXILSecimi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxIL = new System.Windows.Forms.GroupBox();
            this.richTextBoxIL = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBoxIL.SuspendLayout();
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
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(30, 81);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(926, 524);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detayGosterToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 28);
            // 
            // detayGosterToolStripMenuItem
            // 
            this.detayGosterToolStripMenuItem.Name = "detayGosterToolStripMenuItem";
            this.detayGosterToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.detayGosterToolStripMenuItem.Text = "Detay Göster";
            this.detayGosterToolStripMenuItem.Click += new System.EventHandler(this.detayGosterToolStripMenuItem_Click);
            // 
            // btnSec
            // 
            this.btnSec.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSec.Location = new System.Drawing.Point(862, 25);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(94, 29);
            this.btnSec.TabIndex = 13;
            this.btnSec.Text = "SEÇ";
            this.btnSec.UseVisualStyleBackColor = false;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // comboXILSecimi
            // 
            this.comboXILSecimi.BackColor = System.Drawing.Color.Silver;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "İl Hakkında Bilgiler";
            // 
            // groupBoxIL
            // 
            this.groupBoxIL.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxIL.Controls.Add(this.richTextBoxIL);
            this.groupBoxIL.Controls.Add(this.label2);
            this.groupBoxIL.Location = new System.Drawing.Point(1001, 81);
            this.groupBoxIL.Name = "groupBoxIL";
            this.groupBoxIL.Size = new System.Drawing.Size(349, 524);
            this.groupBoxIL.TabIndex = 17;
            this.groupBoxIL.TabStop = false;
            this.groupBoxIL.Text = "groupBox1";
            // 
            // richTextBoxIL
            // 
            this.richTextBoxIL.Location = new System.Drawing.Point(14, 58);
            this.richTextBoxIL.Name = "richTextBoxIL";
            this.richTextBoxIL.ReadOnly = true;
            this.richTextBoxIL.Size = new System.Drawing.Size(312, 438);
            this.richTextBoxIL.TabIndex = 16;
            this.richTextBoxIL.Text = "";
            // 
            // FormILSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 664);
            this.Controls.Add(this.groupBoxIL);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.comboXILSecimi);
            this.Controls.Add(this.label1);
            this.Name = "FormILSorgulama";
            this.Text = "FormILSorgulama";
            this.Load += new System.EventHandler(this.FormILSorgulama_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBoxIL.ResumeLayout(false);
            this.groupBoxIL.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxIL;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem detayGosterToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBoxIL;
    }
}