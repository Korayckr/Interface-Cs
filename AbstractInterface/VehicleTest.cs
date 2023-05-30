using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterface
{

    // İnterfaceler arayüzlerdir ve içerisinde sözleşme benzeri yapıar barındırır.
    // Banka örneği verecek olursak hesap açmak için  belirli bir miktar para koymanız gereklidir
    // ancak işlem detaylarını burada belirtemezsiniz
    // -Araç örneği üzerinden gidecek olursak;
    // * Gitme Durma
    // * Uçabilme
    // * Binilebilme
    // Gibi durumlar benim sözleşmelerimdir İçerisindeki metodların tamamını
    // bu interfacei secen her class sağlamak zorundadır.Sözleşmeler içerisinde kod barındıramaz
    //ancak implement eden classda işlemler gerçekleştirebilir.
   

    public interface IVehicleTest
    {
        void go();

        void stop();

        
        
    }

    public interface IRideable
    {
        void ride();

    }

    public interface IFlyable
    {
        void soar();
    }

    // Araba sınıfı taşıt arayüzünü implement ederek içerisindeki bütün methodlara ulaşıp kullanılabilir.
    // İmplement edilen sözleşmelerin tamamını karşılamak zorundadır.


    public class Car : IVehicleTest
    {
        public void go()
        {
            Console.WriteLine("Arabanın Hızı Ortalama 220" );
        }

       

        public void stop()
        {
            Console.WriteLine("Arabanın Durma Saniyesi: 18");
        }

        

    }
    // Bisiklet sınıfı bu arayüzlerin birden fazlasına uymaktadır.
    public class Bike : IVehicleTest, IRideable
    {
        public void go()
        {
            Console.WriteLine("Bisikletin Hızı: 35 ");
        }

        public void ride()
        {
            Console.WriteLine("Bisiklet Vites Sayısı: 18 ");
        }

       

        public void stop()
        {
            Console.WriteLine("Bisikletin Durma Saniyesi: 4");
        }

    }

    public class Plane : IFlyable
    {
        public void soar()
        {
            Console.WriteLine("Uçağın Havalanma Süresi: 12 ");
        }
    }

}
