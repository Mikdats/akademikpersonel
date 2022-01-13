using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akademik_personel
{
    class Program
    {
        static void Main(string[] args)
        {
            akademikpersonel personel = new akademikpersonel();
            personel.personelad = "İlber";
            personel.personelsoyad = "Ortaylı";
            personel.personelunvan = "PROF.DR";
            personel.personelmail = "İlbergmail.com";

            Console.WriteLine("Personelin adı: " + personel.personelad);
            Console.WriteLine("Personelin soyadı: " + personel.personelsoyad);
            Console.WriteLine("Personelin unvan: " + personel.personelunvan);
            Console.WriteLine("Personelin mail: " + personel.personelmail);

            Console.ReadLine();

        }
    }
}
