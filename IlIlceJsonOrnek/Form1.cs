using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlIlceJsonOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ILSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //açık bir form varsa onu kapatmalıyız.
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Hide();
            }
            FormILSorgulama formILSorgulama = new FormILSorgulama();
            formILSorgulama.MdiParent = this;
            formILSorgulama.Show();
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void ILCESorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild!=null)
            {
                this.ActiveMdiChild.Hide();

            }
            FormILeAitILceleriSorgulama frmIlce = new FormILeAitILceleriSorgulama();
            frmIlce.MdiParent = this;
            frmIlce.Show();
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
