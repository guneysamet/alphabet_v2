using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] alfabe ={"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o"
            ,"p","r","s","t","u","v","y","z","w","x"," "};
            Console.Write("metin : ");
            string metin = Console.ReadLine();
            metin = metin.ToLower();
            int alfabelength = alfabe.Length;
            int x = 0;
            string kelime = "";
            for (int i = 0; i < metin.Length; i++)
            {
                while (alfabelength > 0)
                {
                    if (metin.Substring(i, 1) == alfabe[x])
                    {
                        kelime = kelime + metin.Substring(i, 1);
                        Console.WriteLine(kelime);
                        x = 0;
                        alfabelength = alfabe.Length;
                        break;
                    }
                    else if (metin.Substring(i, 1) == "ı" ||
                        metin.Substring(i, 1) == "ö" ||
                        metin.Substring(i, 1) == "ü" ||
                        metin.Substring(i, 1) == "ç" ||
                        metin.Substring(i, 1) == "ş" ||
                        metin.Substring(i, 1) == "ğ")
                    {
                        int tr_karakter = 0;
                        int metinlength = metin.Length;
                        while (tr_karakter < metinlength)
                        {
                            if (metin.Substring(tr_karakter, 1) == "ı")
                            {
                                kelime = kelime + "ı";
                                break;
                            }
                            if (metin.Substring(tr_karakter, 1) == "ö")
                            {
                                kelime = kelime + "ö";
                                break;
                            }
                            if (metin.Substring(tr_karakter, 1) == "ü")
                            {
                                kelime = kelime + "ü";
                                break;
                            }
                            if (metin.Substring(tr_karakter, 1) == "ç")
                            {
                                kelime = kelime + "ç";
                                break;
                            }
                            if (metin.Substring(tr_karakter, 1) == "ş")
                            {
                                kelime = kelime + "ş";
                                break;
                            }
                            if (metin.Substring(tr_karakter, 1) == "ğ")
                            {
                                kelime = kelime + "ğ";
                                break;
                            }
                            tr_karakter++;
                        }
                        Console.WriteLine(kelime);
                        x = 0;
                        metinlength = metin.Length;
                        break;
                    }
                    else
                    {
                        if (i == 0)
                        {
                            Console.WriteLine(alfabe[x]);
                        }
                        if (i != 0)
                        {
                            Console.WriteLine(kelime + alfabe[x]);
                        }
                    }
                    alfabelength--;
                    x++;
                }
            }
            Console.ReadLine();
        }
    }
}
