using System;

namespace hafta3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************  Müşteri Sipariş CLI *****************");
            
            //Veri tabanı kullanmadığım için 2 değer tutmak açısından burada default bir müşteri tuttum
            Musteri musteri = new Musteri();
            musteri.tcNo ="12398745685";
            musteri.telNo="52632589654";
            musteri.customerName="İris Gümüş";
            musteri.productName="Ekmek";
            musteri.productQuandity="2";

            //Yeni gelecek müşterinin bilgilerini tutmak için yeni bir müşteri oluşturdum
            Musteri musteri1 = new Musteri();

            
            //Kayıtlı ya da kaydı olmayan müşterileri ayırt etmek için soru soruyoruz
            Console.Write("Üye misiniz? Üyeyseniz 1'i  seçiniz. Değilseniz 2'yi seçiniz.");
            int questionOne = int.Parse(Console.ReadLine());

            //Eğer evet(1) derse bu koşula girer
            if (questionOne == 1)
            {
                Console.WriteLine("TC Kimlik Numaranızı Giriniz");
                string tcInfo = Convert.ToString(Console.ReadLine());

                //Default olarak tanımlanmış müşteri ile bilgileri eşleşiyorsa bu döngüden devam eder
                if (musteri.tcNo == tcInfo)
                {
                    Console.WriteLine("Hoş Geldiniz," + musteri.customerName + " Bey/Hanım");

                    Console.WriteLine("Ne almak istersiniz?");
                    musteri.productName = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Kaç Adet Almak İsterdiniz?");
                    musteri.productQuandity = Convert.ToString(Console.ReadLine());

                }
                //Eğer eşleşmiyor ise yeni bir kayıt oluşturur
                else
                {
                    Console.WriteLine(tcInfo + " Numaralı kayıtlı müşteri bulunamadı. Sizlere yeni Kayıt oluşturuyoruz.");
                    musteri1.tcNo = tcInfo;

                    Console.Write("Adınızı Soyadınızı Giriniz: ");
                    musteri1.customerName = Convert.ToString(Console.ReadLine());

                    Console.Write("Telefon Numaranızı Giriniz Giriniz: ");
                    musteri1.telNo = Convert.ToString(Console.ReadLine());

                    Console.Write("Almak istediğiniz ürünü giriniz.");
                    musteri1.productName = Convert.ToString(Console.ReadLine());

                    Console.Write("Ürün miktarını giriniz.");
                    musteri1.productQuandity = Convert.ToString(Console.ReadLine());
                }



                Console.WriteLine(musteri.tcNo);
                Console.WriteLine(musteri.customerName);
                Console.WriteLine(musteri.telNo);
                Console.WriteLine(musteri.productName);
                Console.WriteLine(musteri.productQuandity);
                Console.WriteLine("------------------");
            }
            //Müşteri Hayır (2) dediyse yeni müşteri oluşturmak için bu koşuldaki bilgiler atacanaktır yeni müşteriye

            else
            {
                Console.WriteLine("Kayıt olmak için TC Kimlik Numaranızı Giriniz");
                musteri1.tcNo = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Kayıt olmak için Telefon Numaranızı Giriniz");
                musteri1.telNo = Convert.ToString(Console.ReadLine());
        
                Console.WriteLine("Kayıt Olmak için Adınızı ve Soyadınızı Giriniz");
                musteri1.customerName = Convert.ToString(Console.ReadLine());
                

                Console.WriteLine("Kayıt Olmak için Ürün Adını Giriniz");
                musteri1.productName = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Kayıt Olmak için Ürün Miktarını Giriniz");
                musteri1.productQuandity = Convert.ToString(Console.ReadLine());

                Console.WriteLine(musteri1.tcNo);
                Console.WriteLine(musteri1.customerName);
                Console.WriteLine(musteri1.telNo);
                Console.WriteLine(musteri1.productName);
                Console.WriteLine(musteri1.productQuandity);
                Console.WriteLine("------------------");

            }
        }
    }

    //Yeni Musteri sınıfı oluşturarak get ve set metodları ile müşterinin bilgilerini tutarız ve alırız
    class Musteri
    {
        
        public string tcNo { get; set; }
        public string telNo { get; set; }
        public string customerName { get; set; }
        public string productName { get; set; }
        public string productQuandity { get; set; }



    }
}
