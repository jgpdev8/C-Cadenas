using System;

namespace Ejemplocadenas
{
    class Program
    {
        static void Main(string[] args)
        {

            //------------------------
            //Funciones Integradas de Cadenas

            //s.Contains
            //s.EndsWith
            //s.StartsWith

            string s = "patata.com";
            Console.WriteLine(s.Contains('P'));
            if (s.EndsWith(".com"))
            {
                Console.WriteLine("Es un sitio web");
            }



            //s.IndexOf
            //s.LastIndexOf

            string s2 = "pepino";
            Console.WriteLine(s2.IndexOf('p'));
            Console.WriteLine(s2.LastIndexOf('p'));


            //s.Insert
            //s.Remove

            string s3 = "patata";
            s3 = s3.Remove(0, 1);
            s3 = s3.Insert(0, "P");
            Console.WriteLine(s3);

            s3 = s3.Remove(4, 1).Insert(4, "X");

            //s.Substring
            string s4 = "camaleón";

            Console.WriteLine(s4.Substring(0,4));
            Console.WriteLine(s4.Substring(4,4));
            Console.WriteLine(s4.Substring(4));

            string s5 = s4.Substring(0, 4) + "X" + s4.Substring(4);
            Console.WriteLine(s5);

            string s6 = s5.Substring(0, 4) + s5.Substring(5);
            Console.WriteLine(s6);

            string s7 = "C" + s6.Substring(1);
            Console.WriteLine(s7);

            string s8 = s7.Substring(0, 4) + 'L' + s7.Substring(5);
            Console.WriteLine(s8);

            //s.Replace

            string s9 = "patata";
            s9 = s9.Replace('p', 'P');
            Console.WriteLine(s9);

            //s.Trim
            //s.TrimStart
            //s.TrimEnd

            string s10 = "      patata      ";
            Console.WriteLine(">"+s10.TrimStart()+"<");
            Console.WriteLine(">" + s10.TrimEnd() + "<");
            Console.WriteLine(">" + s10.Trim() + "<");

            //s.ToLower
            //s.ToUpper

            string s11 = "patata TOMATE";
            Console.WriteLine(s11);
            Console.WriteLine(s11.ToUpper());
            Console.WriteLine(s11.ToLower());

            string s12 = char.ToUpper(s11[0]) + s11.Substring(1);
            //s12 = s11.Substring(0, 1).ToUpper() + s11.Substring(1);
            Console.WriteLine(s12);

            //s.PadLeft
            //s.PadRight

            Console.WriteLine("232,57 $".PadLeft(11));
            Console.WriteLine("1,35 $".PadLeft(11));
            Console.WriteLine("94.584,48 $".PadLeft(11));
            Console.WriteLine("45,00 $".PadLeft(11));

            //Maniobras con los for
            int i,cont = 1;
            string s13 = "patata";
            string s14 = "";

            for (i = 0; i < s13.Length; i++)
            {
                if (s13[i] != 'a')
                {
                    s14 = s14 + s13[i];
                }
                else
                {
                    s14 = s14 + cont;
                    cont++;
                }
            }
            Console.WriteLine(s14);

            //s.Split
            //String.Join

            string s15 = "hola don pepito hola don josé";
            string[] palabras = s15.Split(" ");

            for (i = 0; i < palabras.Length; i++)
            {
                Console.WriteLine(palabras[i]);
            }

            Console.WriteLine(palabras[2][0]);

            palabras[2] = "juanito";

            string s16 = string.Join(' ', palabras);
            Console.WriteLine(s16);




        }
    }
}
