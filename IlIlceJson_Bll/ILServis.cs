using IlIlceJson_EntityModels.Classlar;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IlIlceJson_Bll
{
    public class ILServis
    {
        private string JSonString = string.Empty;
        public ILServis()
        {
            VeriKaynaginaBaglan();
        }
        private void VeriKaynaginaBaglan()
        {
            using (WebClient istemci=new WebClient())
            {
                byte[] data=istemci.DownloadData(@"C:\Users\103SABAH_BEYZANUR\source\repos\IlIlceJsonOrnek\belediyeler.json");
                JSonString = Encoding.UTF8.GetString(data);
            }
        }
        public List<IL> ILLERIGetir()
        {

            List<IL> ILListesi = new List<IL>();
            var jsonData = JsonConvert.DeserializeObject<List<ILJson>>(JSonString);
            foreach (var item in jsonData)
            {
                ILListesi.Add(
                    new IL()
                    {
                        ILAdi=item.il,
                        PlakaKodu=Convert.ToByte(item.plaka),
                        ILceleri=item.ilceleri
                    });
            }
            return ILListesi;

        }
    }

}
