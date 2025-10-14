using System.Globalization;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Out__String__StringBuilder
{
    internal class Program
    {
        static void Main()
            //1)  Sətirdəki sözlərin ilk hərfini böyük, qalanlarını kiçik et. 
             //(Məsələn: "hello world" => "Hello World") 
           
        {
            //string sentence = "hello world";
            //TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            //string result = textInfo.ToTitleCase(sentence.ToLower());
            //Console.WriteLine(result); // Hello World

            //2)Verilmiş sətirdən bütün xüsusi simvolları sil (yalnız hərf və rəqəmlər qalsın). 

            //(Məsələn: "Hello@2025!" => "Hello2025")
            //string text = "Hello@2025!";
            //string result = Regex.Replace(text, "[^a-zA-Z0-9]", "");
            //Console.WriteLine(result); // Hello2025

            // 3) Sətir “.com” ilə bitib-bitmədiyini yoxla.



            //string site = "example.com";
            //if (site.EndsWith(".com"))
            //    Console.WriteLine("Setir .com ile bitir");
            //else
            //    Console.WriteLine("Setir .com ile bitmir");

            //3) sualin 2ci usulu :)
           // Console.WriteLine("sozu daxil et :");
            //string soz = Console.ReadLine();
           
            //if (soz.EndsWith(".com"))
            //    Console.WriteLine(".com la bitir soz");
            //else if (soz.EndsWith(".edu"))
            //    Console.WriteLine(".com -la bitmir ");
            //else 
            //    Console.WriteLine(".com -la biten hecne yoxdu ");

        }
       

    }

}
