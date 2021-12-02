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
        public List<IL> ILLERİGetir()
        {
            return JsonConvert.DeserializeObject<List<IL>>(JSonString);
        }
    }

}
