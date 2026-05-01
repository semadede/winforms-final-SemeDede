using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtkinlikVeOrganizasyonYonetimi.Models
{
    public class EtkinlikTedarikci
    {
        public int Id { get; set; }
        public int EtkinlikId { get; set; }
        public int TedarikciId { get; set; }
        public string FirmaAdi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public bool TeslimOnaylandi { get; set; }
        public string Notlar { get; set; }
        public string Durum { get; set; }
    }
}
