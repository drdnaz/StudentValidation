using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.Intrinsics.X86;

namespace StudentValidation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            // TextBox'lardan alınan verilerle öğrenci nesnesi oluştur
            Ogrenci ogrenci = new Ogrenci
            {
                Ad = txtAd.Text.Trim(),
                Soyad = txtSoyad.Text.Trim(),
                Bolum = txtBolum.Text.Trim()
            };

            // Doğrulama işlemi
            List<string> hatalar = Validator.Dogrula(ogrenci);
            // Validator.Dogrula(ogrenci) metudu çağrılıyor,Bu metod ogrenci nesnesindeki özellikleri (Ad, Soyad, Bölüm) kontrol ediyor
            if (hatalar.Count > 0)
            {
                MessageBox.Show(string.Join("\n", hatalar), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            //string.Join tek metin haline getirir. MessageBoxButtons.OK OK utonu olacak diyor,MessageBoxButtons.OKCancel tamma ve iptal demek mesela. Error → kırmızı çarpı hatası ikonu gösterir.
            {
                lblSonuc.Text = $"Ad: {ogrenci.Ad}\nSoyad: {ogrenci.Soyad}\nBölüm: {ogrenci.Bolum}";
            }
            // eğer bir özellik boşsa hata mesajı veriyor.

        }
       
        public static class Validator //validator sınıfı static olduğundan doğrudan kullanılır.
        {
            public static List<string> Dogrula(object nesne) //herhangi bir nesneyi alabilir mesela öğrenci nesnesini geriye List<string> döner
            {
                List<string> hatalar = new List<string>();//Burada tüm hata mesajlarını toplayacağımız boş bir liste oluşturuluyor

                Type type = nesne.GetType();//nesne'nin hangi türden olduğunu buluyoruz
                PropertyInfo[] propertyInfos = type.GetProperties(); //Bu türdeki tüm özellikleri alıyoruz:

                foreach (PropertyInfo property in propertyInfos) //Her bir özellik için döngü başlatılıyoruz.
                {
                    object[] attributes = property.GetCustomAttributes(typeof(ZorunluAlanAttribute), true);
                    //O özelliğin üzerinde tanımlı olan ZorunluAlanAttribute var mı, kontrol edilir.

                    foreach (object attr in attributes)
                    {
                        ZorunluAlanAttribute zorunlu = (ZorunluAlanAttribute)attr;
                        object deger = property.GetValue(nesne);

                        if (deger == null || string.IsNullOrWhiteSpace(deger.ToString()))
                        {
                            hatalar.Add(zorunlu.Mesaj);
                        }
                    }
                }

                return hatalar;
            }
        }


        private void lblBolum_Click(object sender, EventArgs e)
        {

        }

        private void textSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAd_Click(object sender, EventArgs e)
        {

        }
    }
}
