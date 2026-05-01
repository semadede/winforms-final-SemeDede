using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtkinlikVeOrganizasyonYonetimi.Models
{
    public class GerceklesenMaliyet
    {
        public int MaliyetId { get; set; }
        public int ButceId { get; set; }
        public string Aciklama { get; set; }
        public decimal Tutar { get; set; }
        public DateTime Tarih { get; set; }
    }
}
