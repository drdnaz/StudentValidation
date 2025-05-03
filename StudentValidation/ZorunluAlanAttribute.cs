using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentValidation
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ZorunluAlanAttribute : Attribute
    {
        public string Mesaj { get; }

        public ZorunluAlanAttribute(string mesaj)
        {
            Mesaj = mesaj;
        }
    }


    //bir özel (custom)attribute tanımının hangi alanlara uygulanabileceğini belirlemek için kullanılır.
    //yani bir attribute'u kontrol eden başka bir attribute

    // [AttributeUsage(AttributeTargets.Property)] diyorki 
    //Benim yazdığım ZorunluAlanAttribute sadece property’ler üzerinde kullanılabilir diyor.
    /*
     * Yani bu attribute'ü aşağıdakilerde kullanamazsın:

    sınıflar: [ZorunluAlan] class Ogrenci {}

    metodlar:  [ZorunluAlan] void Kaydet() {}

    alanlar: [ZorunluAlan] private string isim;

    Ama şuralarda kullanabilirsin:

     public string Ad { get; set; }


     ama [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)] dersek  hem property hem de field alanlarda kullanılabilir.
    Doğrulamak istediğin şeyler hep property (örneğin: Ad, Soyad, Bolum)
    Bunlar nesnede dışarıya açık olduğu için ve reflection ile okunacağı için property'ler tercih edilir.
    Bu yüzden biz de AttributeTargets.Property yazıyoruz. Böylece yanlış yerde kullanılmaz, kodun temiz kalır.

    */



}



