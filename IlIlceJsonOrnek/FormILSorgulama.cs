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
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            //ILILCEServis deneme = new ILILCEServis();
            //deneme.BilgileriGetir();
        }
    }
}
