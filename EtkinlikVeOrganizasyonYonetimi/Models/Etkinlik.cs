using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtkinlikVeOrganizasyonYonetimi.Models
{
    public class Etkinlik
    {

        public int EtkinlikId { get; set; }
        public string EtkinlikAdi { get; set; }
        public int TurId { get; set; }
        public string TurAdi { get; set; }
        public int MekanId { get; set; }
        public string MekanAdi { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriTelefon { get; set; }
        public string Durum { get; set; }
        public decimal SozlesmeBedeli { get; set; }
        public int OlusturanKullaniciId { get; set; }


    }
}
