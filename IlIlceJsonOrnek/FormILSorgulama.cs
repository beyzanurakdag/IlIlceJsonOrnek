using IlIlceJson_Bll;
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
    public partial class FormILSorgulama : Form
    {
        public FormILSorgulama()
        {
            InitializeComponent();
        }
        ILServis ilServisim = new ILServis();

        private void FormILSorgulama_Load(object sender, EventArgs e)
        {
            //form yüklenirken burası çalışacak
            comboXILSecimi.DataSource = ilServisim.ILLERİGetir();
            comboXILSecimi.DisplayMember = "il";
        }
    }
}
