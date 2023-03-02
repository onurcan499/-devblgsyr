using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    public class pc
    {
        public string kalite = "4k";
        public int açma = 0;
        public int kapatama = 0;
        public int uygulamalar = 0;
        public int birincioyun = 0;
        public int ikincioyun = 0;
        public void birincio()
        {
            
            Console.Clear();
            Console.WriteLine("Oyunu Tek mi ?(1) yoksa 2 Kişilik mi Oynamak İstersiniz ?(2) ");
            int seçim = Convert.ToInt32(Console.ReadLine());
            if (seçim == 1)
            {
                Console.WriteLine("Oyun Kaç Defa Tekrar Etsin ?");
                int tekrar = Convert.ToInt32(Console.ReadLine());
                if (tekrar == 0)
                {
                    Console.WriteLine("Geçerli bir sayı giriniz ;");
                    int tekrar2 = Convert.ToInt32(Console.ReadLine());

                }
                else
                {
                    Console.Clear();
                    int puan = 0;
                    for (int a = 0; a < tekrar; a++)
                    {
                        int[] sayilar = new int[10];
                        Random rnd = new Random();
                        int i;
                        i = rnd.Next(1, 10);
                        Console.WriteLine("Tahminizi girin;");
                        int tahmin = Convert.ToInt32(Console.ReadLine());
                        if (tahmin == i)
                        {
                            Console.WriteLine("tahmin doğru");
                            puan = +5;
                        }
                        else
                        {
                            Console.WriteLine("tahmin yanlış");
                            Console.WriteLine(i);
                            if (tahmin > i)
                            {
                                int sonuc = tahmin - i;
                                Console.WriteLine("doğru tahmini " + sonuc + " kadar sayıyla kaçırdınız");
                                if (sonuc < 5)
                                {
                                    puan = +3;
                                }
                                else
                                {
                                    puan--;
                                }


                            }
                            else
                            {
                                int sonuc1 = i - tahmin;
                                Console.WriteLine("doğru tahmini " + sonuc1 + " kadar sayıyla kaçırdınız");
                                if (sonuc1 < 5)
                                {
                                    puan = +3;
                                }
                                else
                                {
                                    puan--;
                                }
                            }
                            Console.Clear();
                            Console.WriteLine("Puanınız : " + puan);
                      
                            ;
                        }
                       

                    }

                }
          


            }
            Console.Clear();
            if (seçim == 2)
            {
                int puan1 = 0;
                int puan2 = 0;
                Console.WriteLine("Oyun Kaç defa Tekrar Etsin ?");
                int tekrar = Convert.ToInt32(Console.ReadLine());
                if (tekrar == 0)
                {
                    Console.WriteLine(" Lütfen Geçerli Bir Sayı Girin?");
                    int tekrar1 = Convert.ToInt32(Console.ReadLine());

                }
                else
                {
                    for (int i = 0; i < tekrar; i++)
                    {
                        int[] sayılar = new int[10];
                        Random rnd = new Random();
                        int a;
                        a = rnd.Next(1, 10);
                        Console.WriteLine("1. Oyuncunun Tahminini");
                        int kullanıcı1 = Convert.ToInt32(Console.ReadLine());
                        if (kullanıcı1 == a)
                        {
                            Console.WriteLine("Doğru Tahmin");
                            puan1 = +10;

                        }
                        else
                        {
                            if (kullanıcı1 > a)
                            {
                                int sonuc = kullanıcı1 - a;
                                if (sonuc == 1 || sonuc == 2 || sonuc == 3)
                                {

                                    puan1 = +2;
                                }
                                else if (sonuc == 4 || sonuc == 5 || sonuc == 6)
                                {
                                    puan1 = +5;
                                }
                                else if (sonuc == 7 || sonuc == 8 || sonuc == 9)
                                {
                                    puan1 = +7;
                                }
                            }
                            else
                            {
                                int sonuc = a - kullanıcı1;
                                if (sonuc == 1 || sonuc == 2 || sonuc == 3)
                                {

                                    puan1 = +2;
                                }
                                else if (sonuc == 4 || sonuc == 5 || sonuc == 6)
                                {
                                    puan1 = +5;
                                }
                                else if (sonuc == 7 || sonuc == 8 || sonuc == 9)
                                {
                                    puan1 = +7;
                                }

                            }
                           
                        }
                        Console.Clear();
                        Console.WriteLine("2. Oyuncunu Tahmini");
                        int kullanıcı2 = Convert.ToInt32(Console.ReadLine());
                        if (kullanıcı2 == a)
                        {
                            Console.WriteLine("Doğru Tahmin");
                        }
                        if (kullanıcı2 > a)
                        {
                            int sonuc = kullanıcı2 - a;
                            if (sonuc == 1 || sonuc == 2 || sonuc == 3)
                            {

                                puan2 = +2;
                            }
                            else if (sonuc == 4 || sonuc == 5 || sonuc == 6)
                            {
                                puan2 = +5;
                            }
                            else if (sonuc == 7 || sonuc == 8 || sonuc == 9)
                            {
                                puan2 = +7;
                            }
                            Console.Clear();
                        }
                        else
                        {
                            int sonuc = a - kullanıcı2;
                            ;
                            if (sonuc == 1 || sonuc == 2 || sonuc == 3)
                            {

                                puan2 = +2;
                            }
                            else if (sonuc == 4 || sonuc == 5 || sonuc == 6)
                            {
                                puan2 = +5;
                            }
                            else if (sonuc == 7 || sonuc == 8 || sonuc == 9)
                            {
                                puan2 = +7;
                            }

                            Console.Clear();
                            Console.WriteLine("1.Oyuncunun Puanı: " + puan1);
                            Console.WriteLine("2.Oyuncunun Puanı: " + puan2);
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("1.Oyuncunun Puanı: " + puan1);
                    Console.WriteLine("2.Oyuncunun Puanı: " + puan2);
                    if (puan1 < puan2)
                    {
                        Console.WriteLine("2. Oyuncu kazandı");

                    }
                    else if (puan2 < puan1)
                    {
                        Console.WriteLine("1. Oyuncu kazandı");

                    }
                    else if (puan1 == puan2)
                    {
                        Console.WriteLine("Berabere");

                    }
                    
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("-                         -");
                    Console.WriteLine("-     Geri dönmek için(1) -");
                    Console.WriteLine("-                         -");
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("-                              -");
                    Console.WriteLine("- Bilgisayara kapatmak için(2) -");
                    Console.WriteLine("-                              -");
                    Console.WriteLine("--------------------------------");                                 

                }
               

            }            
            }
        public void kapatma()
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("-                                                                    -");
            Console.WriteLine("-                                                                    -");
            Console.WriteLine("-                                                                    -");
            Console.WriteLine("-                                                                    -");
            Console.WriteLine("-                     Bilgisayar Kapatıldı                           -");
            Console.WriteLine("-                        Açmak İçin(1)                               -");
            Console.WriteLine("-                                                                    -");
            Console.WriteLine("-                                                                    -");
            Console.WriteLine("-                                                                    -");
            Console.WriteLine("-                                                                    -");
            Console.WriteLine("-                                                                    -");
            Console.WriteLine("----------------------------------------------------------------------");
            

        }


        public void açılış()
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("-                                                                    -");
            Console.WriteLine("-                                                                    -");
            Console.WriteLine("-                       Sayı Tahmini(1)                              -"); 
            Console.WriteLine("-                                                                    -");
            Console.WriteLine("-                                                                    -");
            Console.WriteLine("-                                                                    -");
            Console.WriteLine("-                                                                    -");                  
            Console.WriteLine("-                                                                    -");
            Console.WriteLine("-                        Pc Kapatma(2)                               -");
            Console.WriteLine("-                                                                    -");
            Console.WriteLine("-                                                                    -");
            Console.WriteLine("----------------------------------------------------------------------");
        }

    }


    internal class Program
    {

        static void Main(string[] args)
        {
            pc p1c = new pc();

            Console.ForegroundColor
                = ConsoleColor.Red;
            int seçim = 0;
            
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("-                                                                    -");
            Console.WriteLine("-                                                                    -");
            Console.WriteLine("-                                                                    -");
            Console.WriteLine("-                                                                    -");
            Console.WriteLine("-                   Bilgisayarı Açmak İçin 1                         -");
            Console.WriteLine("-                                                                    -");
            Console.WriteLine("-                                                                    -");
            Console.WriteLine("-                                                                    -");
            Console.WriteLine("-                                                                    -");
            Console.WriteLine("-                                                                    -");
            Console.WriteLine("-                                                                    -");
            Console.WriteLine("----------------------------------------------------------------------");
            int se1çim = Convert.ToInt32(Console.ReadLine());
            if (se1çim == 1)
            {
                Console.Clear();
                p1c.açılış();
                int se1çim1 = Convert.ToInt32(Console.ReadLine());
                if (se1çim1 == 1)
                {
                    Console.Clear();
                    p1c.birincio();
                    int se1çim3= Convert.ToInt32(Console.ReadLine());
                    if (se1çim3 == 1)
                    {
                       Console.Clear();
                        p1c.açılış();
                        int se1çim4 = Convert.ToInt32(Console.ReadLine());
                        if (se1çim == 1)
                        {
                            p1c.birincio();
                        }
                        else if (se1çim4 == 2)
                        {
                            p1c.kapatma();
                        }
                    }
                    else if(se1çim3 == 2)
                    {
                        Console.Clear();
                        p1c.kapatma();
                    }
                }

                if (se1çim1==2)
                {
                    Console.Clear();

                    p1c.kapatma();
                    int se1çim2 = Convert.ToInt32(Console.ReadLine());
                    if (se1çim2 == 1)
                    {
                        Console.Clear();
                        p1c.açılış();
                    }
                }



            }
            Console.ReadKey();
        }

    }
}