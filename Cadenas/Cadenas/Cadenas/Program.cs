using System;

namespace Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("Menú de Cadenas");
            Console.WriteLine("---------------");
            Console.WriteLine("1.- NumeroEspacios");
            Console.WriteLine("2.- NumeroVocales");
            Console.WriteLine("3.- EsPalindromo");
            Console.WriteLine("4.- Contiene");
            Console.WriteLine("5.- RepiteCaracter");
            //Console.WriteLine("6.- PadLeft & PadRight");
            Console.WriteLine("6.- QuitaEspacios");
            Console.WriteLine("7.- QuitaEspaciosTrim");
            Console.WriteLine("8.- SustituyeCaracter");
            Console.WriteLine("9.- CuentaPalabras");
            Console.WriteLine("10.- EsNumero");
            Console.WriteLine("11.- BorraCaracter");
            Console.WriteLine("12.- QuitaCaracter");
            Console.WriteLine("13.- InvierteCadena");
            Console.WriteLine("14.- VecesCaracter");
            Console.WriteLine("15.- VecesPalabra");
            Console.WriteLine("16.- MayusculasPrimera");
            Console.WriteLine("17.- SustituyePalabra");
            Console.WriteLine("18.- InviertePalabras");
            Console.WriteLine("19.- MarcaSubCadena");
            Console.WriteLine("20.- QuitaEspaciosSobrantes");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    {
                        string s = " hola pepito ";
                        Console.WriteLine(NumeroEspacios(s)); 
                    }
                    break;
                case 2:
                    {
                        string s = "perro";
                        Console.WriteLine(NumeroVocales(s));
                    }
                    break;
                case 3:
                    {
                        string a = "A luna ese anula";
                        Console.WriteLine(EsPalindromo(a));
                    }
                    break;
                case 4:
                    {
                        string s = "Polaca";
                        Console.WriteLine(Contiene(s,'p'));
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine(RepiteCaracter('a',5));
                    }
                    break;
                case 6:
                    {
                        string s = " ay ay ay    ";
                        QuitaEspacios(ref s);
                        Console.WriteLine(s);
                    }
                    break;
                case 7:
                    {
                        string s = "   peope a la carrill jajaja un    ";
                        s=QuitaEspaciosTrimv2(s);
                        Console.WriteLine(s+"<");
                    }
                    break;
                case 8:
                    {
                        string a = " calabacin al jamon";
                        Console.WriteLine(SustituyeCaracter(a,'x','a'));
                    }
                    break;
                case 9:
                    {
                        string a = " alab aknsf asjfb askjbf akjsfkj a a    asjbf abs";
                        Console.WriteLine(CuentaPalabras(a));
                    }
                    break;
                case 10:
                    {
                        string a = "19785 ";
                        Console.WriteLine(EsNumero(a));
                    }
                    break;
                case 11:
                    {
                        string a = "alameda arape";
                        Console.WriteLine(BorraCaracter(a,'e'));
                    }
                    break;
                case 12:
                    {
                        string a = "ámare pichón";
                        Console.WriteLine(QuitaAcentos(a));
                    }
                    break;
                case 13:
                    {
                        string a = "anamaria";
                        Console.WriteLine(InvierteCadena(a));
                    }
                    break;
                case 14:
                    {
                        string a = "amante bandido";
                        Console.WriteLine(VecesCaracter(a,'a'));
                    }
                    break;
                case 15:
                    {
                        string a = " me fui al zoologico a ver al gorila y no estaba el gorila albino";
                        string b = "gorila";
                        Console.WriteLine(VecesPalabra(a,b));
                    }
                    break;
                case 16:
                    {
                        string a = " ayer fui al cine  ompare";
                        Console.WriteLine(MayusculasPrimera(a));
                    }
                    break;
                case 17:
                    {
                        string a = "Maria del pilar sabe nadar en el mar";
                        Console.WriteLine(SustituyePalabra(a,"cagar","nadar"));
                    }
                    break;
                case 18:
                    {
                        string a = "Maria ya no consume coca";
                        Console.WriteLine(InviertePalabra(a));
                    }
                    break;
                case 19:
                    {
                        string a= "Me gusta comer macarrones todos los dias porque comer macarrones es maravilloso comer macarrones";
                        string b= "comer macarrones";
                        Console.WriteLine(MarcaSubCadena(a,b));
                    }
                    break;
                case 20:
                    {
                        string a = "     Vi    5va la virgen de    Lourdes    ";
                        Console.WriteLine(QuitaEspaciosSobrantes(a));
                    }
                    break;
            }

        }
        static int NumeroEspacios(string a)
        {
            int i, cont=0;
            for (i = 0; i < a.Length; i++)
            {
                if(a[i]==' ')
                {
                    cont++;
                }
            }
            return cont;
        }
        static int NumeroVocales(string a)
        {
            int i, cont = 0;
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == 'a'|| a[i]=='e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u')
                {
                    cont++;
                }
            }
            return cont;
        }
        static bool EsPalindromo(string s)
        {
            string a="";
            int i;
            s = s.ToLower();
            for (i = 0; i < s.Length; i++)
            {
                if(s[i]==' ')
                {
                    s= s.Remove(i, 1);
                }
            }
            
            for (i = s.Length-1; i >=0 ; i--)
            {
                a = a + s[i];
            }
            ;
            if (a == s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool Contiene(string s,char a)
        {
            int i;
            int cont=0;
            for (i = 0; i < s.Length; i++)
            {
                if (s[i] == a)
                {
                    cont++;
                }
                
            }
            if (cont > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string RepiteCaracter (char a,int num)
        {
            int i;
            string s = "";
            for (i = 0; i < num; i++)
            {
                s = s + a;
            }
            return s;
        }
        //static void PadLeft(ref string s,int longitud)
        //{
        //    string a = "";
        //    int i;
        //    for(i=0;i<(longitud - s.Length); i++)
        //    {
        //        a = a + " ";
        //    }
        //    s = a + s;
        //}
        //static void PadRight(ref string s, int longitud)
        //{
        //    string a = "";
        //    int i;
        //    for (i = 0; i < (longitud - s.Length); i++)
        //    {
        //        a = a + " ";
        //    }
        //    s = s+a;
        //}
        static void QuitaEspacios(ref string s)
        {
            int i;
            for (i = 0; i < s.Length; i++)
            {
                if(s[i]==' ')
                {
                    s = s.Remove(i, 1);
                }
            }
        }
        static string QuitaEspaciosTrim(string a)
        {
            string s = a;
            
            
            while(s[0]==' ')
            {
                s = s.Remove(0, 1);
                
            }
            while (s[s.Length-1] == ' ')
            {
                s = s.Remove(s.Length-1, 1);

            }
            return s;
        }
        static string QuitaEspaciosTrimv2(string a)
        {
            string s = a;
            int pos1=0, pos2=s.Length-1;
            while(s[pos1]==' ')
            {
                pos1++;
            }
            while(s[pos2]==' ')
            {
                pos2--;
            }
            s = s.Substring(pos1, (pos2-pos1)+1);
            return s;
        }
        static string SustituyeCaracter(string a,char nuevo,char borrar)
        {
            int i; 
            string aux = "";
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == borrar)
                {
                    aux = aux + nuevo;
                }
                else
                {
                    aux = aux + a[i];
                }
            }
            return aux;

        }
        static int CuentaPalabras(string a)
        {
            int cont=0, i;
            a = QuitaEspaciosTrimv2(a);
            for (i = 0; i < a.Length-1; i++)
            {
                if(a[i]==' '&&a[i+1]!=' ')
                {
                    cont++;
                }

            
                    
            }
            cont = cont + 1;
            return cont;  
        }
        static bool EsNumero(string a)
        {
            int i;
            for (i = 0; i < a.Length; i++)
            {
                if (char.IsDigit(a[i])==false)
                {
                    return false;
                }
            } 
                return true;
        }
        static string BorraCaracter(string a,char borrar)
        {
            int i;
            string aux = "";
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] != borrar)
                {
                    aux = aux + a[i];
                }
            }
            return aux;

        }
        static string QuitaAcentos(string a)
        {
            int i, j;
            bool acent = false; ;
            string acentos = "áéíóú";
            string sinacentos = "aeiou";
            string result = "";
            for (i = 0; i < a.Length; i++)
            {
                
                for (j = 0; j < acentos.Length; j++)
                {
                    if (a[i] == acentos[j])
                    {
                        result = result + sinacentos[j];
                        acent = true;
                    }
                   
                }
                if (acent == false)
                {
                    result = result + a[i];
                }
                acent = false;
            }
            return result;
        }
        static string InvierteCadena(string a)
        {
            string b = "";
            int i;
            for (i = a.Length-1; i >= 0; i--)
            {
                b = b + a[i];
            }
            return b;
        }
        static int VecesCaracter(string a,char c)
        {
            int i, cont = 0;
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == c)
                {
                    cont++;
                }
            }
            return cont;
        }
        static int VecesPalabra(string a,string b)
        {
            int i, cont = 0;
            a = QuitaEspaciosTrimv2(a);
            string[] palabras = a.Split(" ");
            for (i = 0; i < palabras.Length; i++)
            {
                if (palabras[i] == b)
                {
                    cont++;
                }
            }

            return cont;
        }
        static string MayusculasPrimera(string a)
        {
            int i;
            string b="";
            string[] palabras = a.Split(" ");
            for (i = 0; i < palabras.Length; i++)
            {
                if (palabras[i].Length > 1)
                {
                    palabras[i] =char.ToUpper(palabras[i][0]) + palabras[i].Substring(1);
                }
                else
                {
                    palabras[i]= palabras[i].ToUpper();
                }
                
            }
            b = String.Join(' ', palabras);
            return b;
        }
        static string SustituyePalabra(string a,string nueva,string borrar)
        {
            int i;
            string[] palabras = a.Split(" ");
            string result = "";
            for (i = 0; i < palabras.Length; i++)
            {
                if (palabras[i] == borrar)
                {
                    palabras[i] = nueva;
                }
            }
            result = string.Join(' ', palabras);
            return result;
        }
        static string InviertePalabra(string a)
        {
            string[] palabras = a.Split(" ");
            int i, j;
            string aux = "";
            for (i = 0; i < palabras.Length; i++)
            {
                for (j = palabras[i].Length-1; j >= 0; j--)
                {
                    aux = aux + palabras[i][j];
                }
                palabras[i] = aux;
                aux = "";
            }
            aux = string.Join(' ', palabras);
            return aux;
        }
        static string MarcaSubCadena(string a, string b)
        {
            int i, j;
            bool igual = true;
            for (i = 0; i < (a.Length-b.Length)+1; i++)
            {
                if (a[i] == b[0])
                {
                    igual = true;
                    for (j = 0; j < b.Length; j++)
                    {
                        if (a[i + j] != b[j])
                        {
                            igual = false;
                        }
                    }
                    if (igual == true)
                    {
                        a = a.Substring(0, i) + "*" + a.Substring(i + 1);
                    }
                }
                
            }
            return a;

        }
        static string QuitaEspaciosSobrantes(string a)
        {
            
            int i;
            
            a = a.TrimStart();
            a = a.TrimEnd();
            for (i = 0; i < a.Length-1; i++)
            {
                if(a[i]==' '&&a[i+1]==' ')
                {
                    a = a.Substring(0, i) + a.Substring(i + 1);
                    i = i - 1;
                }
            }
            return a;
        }
        
    }
}
