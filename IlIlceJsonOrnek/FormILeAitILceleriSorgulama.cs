using IlIlceJson_Bll;
using IlIlceJson_EntityModels.Classlar;
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
    public partial class FormILeAitILceleriSorgulama : Form
    {
        public FormILeAitILceleriSorgulama()
        {
            InitializeComponent();
        }
        ILServis ilServisim = new ILServis();
        ILILCEServis ilceServis = new ILILCEServis();
        private void FormILeAitILceleriSorgulama_Load(object sender, EventArgs e)
        {
            comboBoxILLER.DataSource = ilServisim.ILLERIGetir();
            comboBoxILLER.DisplayMember = "ILAdi";
            comboBoxILLER.ValueMember = "PlakaKodu";

        }

        private void comboBoxILLER_SelectedIndexChanged(object sender, EventArgs e)
        {
            IL secilenIL = comboBoxILLER.SelectedItem as IL;
            List<ILILCEBilgileri> sehreAitILcelerListem =ilceServis.ILAdinaGoreILceleriGetir(secilenIL.ILAdi);
            listView1.Items.Clear();
            foreach (var item in sehreAitILcelerListem)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.Ismi;
                li.Tag = item;
                li.SubItems.Add(item.Tel);
                li.SubItems.Add(item.Mail);

                listView1.Items.Add(li);
            }

        }
    }
}
