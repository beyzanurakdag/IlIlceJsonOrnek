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
    public partial class FormILSorgulama : Form
    {
        public FormILSorgulama()
        {
            InitializeComponent();
        }
        ILServis ilServisim = new ILServis();
        ILILCEServis ILILCEServisim = new ILILCEServis();
        private object comboBoxILSecimi;
        private IL secilenIL;

        public object ListView1 { get; private set; }

        private void FormILSorgulama_Load(object sender, EventArgs e)
        {
            //form yüklenirken burası çalışacak
            comboXILSecimi.DataSource = ilServisim.ILLERIGetir();
            comboXILSecimi.DisplayMember = "ILAdi";
            comboXILSecimi.ValueMember = "PlakaKodu";
            List<ILILCEBilgileri> SehireAitBilgilerListesi = ILILCEServisim.BilgileriGetir();
            foreach (var item in SehireAitBilgilerListesi)
            {
                ListViewItem deger = new ListViewItem()
                {
                    Text=item.Ismi,
                    Tag=item
                };
                deger.SubItems.Add(item.Tel);
                deger.SubItems.Add(item.Faks);
                deger.SubItems.Add(item.Mail);
                deger.SubItems.Add(item.Web);

                listView1.Items.Add(deger);
            }
            groupBoxIL.Enabled = false;
            groupBoxIL.Visible = false;
           
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            secilenIL = comboXILSecimi.SelectedItem as IL;
            //comboboxta hangi ili seçtiyse onun bilgilerini listview de görelim.
            //IL SecilenIL = (IL)comboBoxILSecimi.SelectedItem;
            ILILCEBilgileri secilenILBilgisi = ILILCEServisim.BilgileriGetir().Where(x => x.Plaka == secilenIL.PlakaKodu).FirstOrDefault();
            listView1.Items.Clear();
            ListViewItem deger = new ListViewItem();
            deger.Text = secilenILBilgisi.Ismi;
            deger.Tag = secilenILBilgisi;
            deger.SubItems.Add(secilenILBilgisi.Tel);
            deger.SubItems.Add(secilenILBilgisi.Faks);
            deger.SubItems.Add(secilenILBilgisi.Mail);
            deger.SubItems.Add(secilenILBilgisi.Web);
            listView1.Items.Add(deger);

        }

        private void detayGosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxIL.Visible = true;
            groupBoxIL.Enabled = true;
            ILILCEBilgileri secilenIL = (ILILCEBilgileri)
            listView1.FocusedItem.Tag;
            richTextBoxIL.Text = secilenIL.Bilgi;
        }
    }
}
