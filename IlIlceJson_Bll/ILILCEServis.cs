using IlIlceJson_EntityModels.Classlar;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IlIlceJson_Bll
{
    public class ILILCEServis
    {
        private string JsonString = string.Empty;
        ILServis ilServisi = new ILServis();
        public ILILCEServis()
        {
            VeriKaynaginaBaglan();
                
        }

        private void VeriKaynaginaBaglan()
        {
            using (WebClient istemci=new WebClient())
            {
                byte[] data = istemci.DownloadData(@"C:\Users\103SABAH_BEYZANUR\source\repos\IlIlceJsonOrnek\belediyelerfull.json");
                JsonString = Encoding.UTF8.GetString(data);
            }
        }
        public List<ILILCEBilgileri> BilgileriGetir()
        {
            List<ILILCEBilgileri> liste = new List<ILILCEBilgileri>();
            JObject j = JObject.Parse(JsonString);
            List<string> illerim = ilServisi.ILLERIGetir().Select(x => x.ILAdi).ToList();
            illerim = illerim.Select(x => DilIslemleri.TurkceKarakterleriIngilizceyeCevir(x.ToLower())).ToList();
            foreach (string item in illerim)
            {
                //her bir il için bilgileri belediyelerfull.jsondan çekeceğiz.
                var data = j.SelectToken(item).SelectToken("il");
                ILILCEBilgileri detaylıBilgi = new ILILCEBilgileri();
                detaylıBilgi.Plaka = Convert.ToByte(data["plaka"].ToObject<string>());
                detaylıBilgi.Tel = data["belediye-tel"].ToObject<string>();
                detaylıBilgi.Faks = data["belediye-faks"].ToObject<string>();
                detaylıBilgi.Ismi = data["belediye-ismi"].ToObject<string>();
                detaylıBilgi.Mail=data["belediye-mail"]==null? "" : data["belediye-mail"].ToObject<string>();
                detaylıBilgi.Web = data["belediye-web"]==null? "" : data["belediye-web"].ToObject<string>();
                detaylıBilgi.Nufus = data["nufus"].ToObject<string>();
                detaylıBilgi.Alankodu = data["alankodu"] == null ? "" : data["alankodu"].ToObject<string>();
                detaylıBilgi.Bolge = data["bolge"].ToObject<string>();
                detaylıBilgi.Bilgi = data["bilgi"].ToString();
                liste.Add(detaylıBilgi);
            }
            return liste;
        }
        public List<ILILCEBilgileri> ILAdinaGoreILceleriGetir(string ILAdi)
        {
            List<ILILCEBilgileri> liste = new List<ILILCEBilgileri>();

            JObject j = JObject.Parse(JsonString);

            List<string> ilclerListem =
                ilServisi.ILLERIGetir().Single(x => x.ILAdi == ILAdi).ILceleri;

            //ağrı ---> agri // ismi json içindeki gibi değiştirdik
            ILAdi = DilIslemleri.TurkceKarakterleriIngilizceyeCevir(ILAdi.ToLower()
                );

            //ilçeler de json içinde ingilizce karakterli halde yazıyor.
            // bu nedenle onu da çevirdik
            ilclerListem = ilclerListem.Select(x => DilIslemleri.TurkceKarakterleriIngilizceyeCevir(x.ToLower())).ToList();

            foreach (var item in ilclerListem)
            {
                //var data = j.SelectToken(ILAdi.ToLower()).SelectToken(item);
                var data = j.SelectToken(ILAdi).SelectToken(item);

                // bazı illerin ilçelerinde null gelme durumuna yakalanmayalım.
                if (data != null)
                {
                    ILILCEBilgileri bilgim = new ILILCEBilgileri();
                    bilgim.Ismi = data["belediye-ismi"] == null ? "" : data["belediye-ismi"].ToObject<string>();
                    bilgim.Tel = data["belediye-tel"]==null ? "" :data["belediye-tel"].ToObject<string>();
                    bilgim.Faks = data["belediye-faks"]==null ? "" : data["belediye-faks"].ToObject<string>();
                    bilgim.Mail = data["belediye-mail"] == null ? "" : data["belediye-mail"].ToObject<string>();
                    bilgim.Web = data["belediye-web"] == null ? "" : data["belediye-web"].ToObject<string>();
                    bilgim.Web = data["nufus"] == null ? "" : data["nufus"].ToObject<string>();
                    bilgim.Bilgi = data["bilgi"]==null ? "" : data["bilgi"].ToObject<string>();
                    bilgim.Bilgi = data["bolge"] == null ? "" : data["bolge"].ToObject<string>();

                    bilgim.Alankodu= data["alankodu"]==null ? "" : data["alankodu"].ToObject<string>();
                 //   bilgim.Plaka = Convert.ToByte(data["plaka"].ToObject<string>());

                    liste.Add(bilgim);
                }

            }




            return liste;
        }
    }

}
