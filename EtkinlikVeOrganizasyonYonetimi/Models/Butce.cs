using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtkinlikVeOrganizasyonYonetimi.Models
{
    public class Butce
    {
        public int ButceId { get; set; }
        public int EtkinlikId { get; set; }
        public decimal PlanlananButce { get; set; }
        public bool YoneticiOnayi { get; set; }
    }
}
