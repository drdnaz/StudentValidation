using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentValidation
{
    public class Ogrenci
    {
        [ZorunluAlan("Ad boş bırakılamaz.")]
        public string Ad { get; set; }

        [ZorunluAlan("Soyad boş bırakılamaz.")]
        public string Soyad { get; set; }

        [ZorunluAlan("Bölüm boş bırakılamaz.")]
        public string Bolum { get; set; }
    }

}
// Bu sınıf, TextBox'lardan alacağımız verileri tutacak.