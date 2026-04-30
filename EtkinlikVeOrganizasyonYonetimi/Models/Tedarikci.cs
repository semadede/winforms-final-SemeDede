using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtkinlikVeOrganizasyonYonetimi.Models
{
    public class Tedarikci
    {
        public int TedarikciId { get; set; }
        public string FirmaAdi { get; set; }
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public string Telefon { get; set; }
        public bool Aktif { get; set; }


    }
}
