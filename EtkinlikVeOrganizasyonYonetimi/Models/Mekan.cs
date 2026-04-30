using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtkinlikVeOrganizasyonYonetimi.Models
{
    public class Mekan
    {

        public int MekanId { get; set; }
        public string MekanAdi { get; set; }
        public int Kapasite { get; set; }
        public string Adres { get; set; }
        public int KurulumSuresiSaat { get; set; }


    }
}
