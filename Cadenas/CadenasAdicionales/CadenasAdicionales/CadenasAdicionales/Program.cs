using System;

namespace CadenasAdicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("CadenasAdicionales");
            Console.WriteLine("--------------------");
            Console.WriteLine("1.- MarcaSubCadena");
            Console.WriteLine("2.- EscribeNombres");
            Console.WriteLine("3.- CuentaLetras");
            Console.WriteLine("4.- MayusculasMinusculas");
            Console.WriteLine("5.- EliminaTags");
            Console.WriteLine("6.- OrdenaPalabrasComas");
            Console.WriteLine("7.- AcentosHTML");
            Console.WriteLine("8.- PalabrasMismaLetra");
            Console.WriteLine("9.- NumeroTexto99");
            Console.WriteLine("10.- LimpiaCadena");
            Console.WriteLine("11.- CompruebaEmail");
            Console.WriteLine("12.- PalarasImpares");
            Console.WriteLine("13.- CuentaDiptongos");
            Console.WriteLine();
            Console.WriteLine();
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    {
                        string a = "Me gusta comer macarrones porque comer macarrones es bueno comer macarrones";
                        string b = "comer macarrones";
                        Console.WriteLine(MarcaSubCadena(a, b));
                    }
                    break;
                case 2:
                    {
                        string a = "Galvan Poley Javier Jones Garcias Francisco";
                        EscribeNombres(a);
                    }
                    break;
                case 3:
                    {
                        string a = "Me gusta comer palomitaaaaa";
                        EscribeArray(CuentaLetras(a));
                    }
                    break;
                case 4:
                    {
                        string a = "A mi me gusta comer popitos. viva el betis coño";
                        Console.WriteLine(MayusculasMinusculas(a, 4));
                    }
                    break;
                case 5:
                    {
                        string a = "<b> como porongas jaja <strohfhgfhgfhgfhgng> <b>Hilario es puto</strong><br> jajajaj <p><p>";
                        Console.WriteLine(EliminaTags(a));
                    }
                    break;
                case 6:
                    {
                        string a = "aleman,marroquí,irlandés,ruso,albacete,maria,juan,pepe";
                        Console.WriteLine(a);
                        Console.WriteLine(OrdenaPalabrasComas(a));
                    }
                    break;
                case 7:
                    {
                        string a = "al<perrójajaÜpacÓ";
                        Console.WriteLine(AcentosHTML(a));
                    }
                    break;
                case 8:
                    {
                        string a = "Amanda tiene tres serpientes";
                        EscribeArrayString(PalabrasMismaLetra(a));
                    }
                    break;
                case 9:
                    {
                        Console.WriteLine(NumeroTexto9(5));
                        Console.WriteLine(NumeroTexto99(75));
                        Console.WriteLine(NumeroTexto999(800));
                    }
                    break;
                case 10:
                    {
                        string a = "         Hola,¿qué tal? Soy amigo de Poti-Poti  ";
                        Console.WriteLine(LimpiaCadena(a));
                    }
                    break;
                case 11:
                    {
                        string a = "admin@mailserver1-";
                        Console.WriteLine(CompruebaEmail(a));


                    }
                    break;
                case 12:
                    {
                        string a = "EL perro de san Roque";
                        Console.WriteLine(PalbrasImpares(a));
                    }
                    break;
                case 13:
                    {
                        string a="Puede caer una bien buena";
                        Console.WriteLine(CuentaDiptongos(a));
                    }
                    break;
            }
        }
        static string MarcaSubCadena(string a, string b)
        {
            int i, j;
            bool igual = true;
            for (i = 0; i < (a.Length - b.Length) + 1; i++)
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
        static void EscribeNombres(string a)
        {
            int i;
            string[] palabras = a.Split(" ");
            for (i = 0; i < palabras.Length - 2; i = i + 3)
            {
                Console.Write(palabras[i + 2] + " " + palabras[i] + " " + palabras[i + 1]);
                Console.WriteLine();

            }
        }
        static int[] CuentaLetras(string a)
        {
            int[] contar = new int[27];
            string b = "abcdefghijklmnñopqrstuvwxyz";
            int i, j;
            for (i = 0; i < a.Length; i++)
            {
                for (j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        contar[j] = contar[j] + 1;
                    }
                }
            }
            return contar;
        }
        static void EscribeArray(int[] array)
        {
            int i;
            Console.Write("[");
            for (i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    Console.Write(array[i]);
                }
                else
                {
                    Console.Write(array[i] + ",");
                }

            }
            Console.Write("]");
            Console.WriteLine();
        }
        static void EscribeArrayString(string[] array)
        {
            int i;
            Console.Write("[");
            for (i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    Console.Write(array[i]);
                }
                else
                {
                    Console.Write(array[i] + ",");
                }

            }
            Console.Write("]");
            Console.WriteLine();
        }
        static string MayusculasMinusculas(string a, int n)
        {
            bool frase = true;
            switch (n)
            {
                case 1: a = a.ToLower(); break;
                case 2: a = a.ToUpper(); break;
                case 3: a = MayusculasPrimera(a); break;
                case 4:
                    for (int i = 0; i < a.Length; i++)
                    {

                        if (a[i] == '.')
                        {
                            frase = true;
                        }
                        if (frase && char.IsLetter(a[i]))
                        {
                            a = a.Substring(0, i) + char.ToUpper(a[i]) + a.Substring(i + 1);
                            frase = false;
                        }
                    }
                    break;

            }
            return a;
        }
        static string MayusculasPrimera(string a)
        {
            int i;
            string b = "";
            string[] palabras = a.Split(" ");
            for (i = 0; i < palabras.Length; i++)
            {
                if (palabras[i].Length > 1)
                {
                    palabras[i] = char.ToUpper(palabras[i][0]) + palabras[i].Substring(1);
                }
                else
                {
                    palabras[i] = palabras[i].ToUpper();
                }

            }
            b = String.Join(' ', palabras);
            return b;
        }
        static string EliminaTags(string a)
        {
            int i;
            bool escribo = true;
            string aux = "";
            for (i = 0; i < a.Length; i++)
            {
                if (escribo)
                {
                    if (a[i] == '<')
                    {
                        escribo = false;
                    }
                    else
                    {
                        aux = aux + a[i];
                    }
                }
                else
                {
                    if (a[i] == '>')
                    {
                        escribo = true;
                    }
                }
            }
            return aux;
        }
        static string OrdenaPalabrasComas(string a)
        {
            int i, j;
            string result = "";
            string aux = "";
            string[] palabras = a.Split(",");
            for (j = 0; j < palabras.Length - 1; j++)
            {
                for (i = 0; i < palabras.Length - 1; i++)
                {
                    if (palabras[i].CompareTo(palabras[i + 1]) > 0)
                    {
                        aux = palabras[i];
                        palabras[i] = palabras[i + 1];
                        palabras[i + 1] = aux;

                    }
                }
            }

            result = string.Join(',', palabras);
            return result;
        }
        static string AcentosHTML(string a)
        {
            string[] simbol = { "&lt", "&gt;", "&amp;", "&quot;", "&aacute;", "&Aacute", "&aecute", "&Eacute", "&iacute", "&Iacute", "&oacute", "&Oacute", "&uacute", "Uacute", "&ntilde", "&Ntilde", "&uuml", "&Uuml" };
            string signos = "<>&\"áÁéÉiÍóÓúÚñNüÜ";
            string aux = "";
            bool encontrado = false;
            int i, j;
            for (i = 0; i < a.Length; i++)
            {
                for (j = 0; j < signos.Length; j++)
                {
                    if (a[i] == signos[j])
                    {
                        aux = aux + simbol[j];
                        j = signos.Length;
                        encontrado = true;
                    }



                }
                if (encontrado)
                {
                    encontrado = false;
                }
                else
                {
                    aux = aux + a[i];
                }


            }
            return aux;

        }
        static string[] PalabrasMismaLetra(string a)
        {
            a = a.ToLower();
            string[] palabras;
            string[] final;
            string aux = "";
            int i, j = 0, cont = 0;
            for (i = 0; i < a.Length; i++)
            {
                if (char.IsLetter(a[i]))
                {
                    aux = aux + a[i];
                }
                else
                {
                    aux = aux + " ";
                }
            }
            palabras = aux.Split(" ");
            for (i = 0; i < palabras.Length; i++)
            {
                if (palabras[i][0] == palabras[i][palabras[i].Length - 1])
                {
                    cont++;
                }
            }
            final = new string[cont];
            for (i = 0; i < palabras.Length; i++)
            {
                if (palabras[i][0] == palabras[i][palabras[i].Length - 1])
                {
                    final[j] = palabras[i];
                    j++;
                }
            }
            return final;
        }
        static string NumeroTexto99(int num)
        {

            string[] dieci = { "diez", "once", "doce", "trece", "catorce", "quince" };
            string resultado = "";
            if (num < 0 || num > 99)
            {
                Console.WriteLine("Error");
            }
            else
            {
                if (num < 10)
                {
                    NumeroTexto9(num);
                }
                else
                {
                    if (num < 16)
                    {
                        resultado = dieci[num % 10];
                    }
                    else
                    {
                        if (num < 20)
                        {
                            resultado = "dieci" + dieci[num % 10];
                        }
                        else
                        {
                            if (num < 30)
                            {
                                resultado = "veinti" + dieci[num % 10];
                            }
                            else
                            {
                                switch (num / 10)
                                {
                                    case 3: resultado = "treinta"; break;
                                    case 4: resultado = "cuarenta"; break;
                                    case 5: resultado = "cincuenta"; break;
                                    case 6: resultado = "sesenta"; break;
                                    case 7: resultado = "setenta"; break;
                                    case 8: resultado = "ochenta"; break;
                                    case 9: resultado = "noventa"; break;

                                }
                                if (num % 10 != 0)
                                {
                                    resultado = resultado + " y " + NumeroTexto9(num % 10);
                                }

                            }


                        }
                    }
                }

            }
            return resultado;

        }
        static string NumeroTexto9(int num)
        {
            string resultado = "";
            string[] unoanueve = { "cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
            if (num < 0 || num > 9)
            {
                Console.WriteLine("Error");
            }
            else
            {
                resultado = unoanueve[num];
            }
            return resultado;

        }
        static string NumeroTexto999(int num)
        {
            string resultado = "";
            if (num < 0 || num > 999)
            {
                Console.WriteLine("Error");
            }
            else
            {
                if (num <= 99)
                {
                    resultado = NumeroTexto99(num);
                }
                else
                {
                    if (num == 100)
                    {
                        Console.WriteLine("cien");
                    }
                    else
                    {
                        switch (num / 100)
                        {
                            case 1: resultado = "ciento"; break;
                            case 2: resultado = "doscientos"; break;
                            case 3: resultado = "trescientos"; break;
                            case 4: resultado = "cuatrocientos"; break;
                            case 5: resultado = "quinientos"; break;
                            case 6: resultado = "seiscientos"; break;
                            case 7: resultado = "setecientos"; break;
                            case 8: resultado = "ochocientos"; break;
                            case 9: resultado = "novecientos"; break;
                        }
                        if (num % 100 > 0)
                        {
                            resultado = resultado + " " + NumeroTexto99(num % 100);
                        }
                    }
                }
            }
            return resultado;
        }
        static string LimpiaCadena(string a)
        {
            int i;
            string final = "";
            for (i = 0; i < a.Length; i++)
            {
                if (char.IsLetter(a[i]))
                {
                    final = final + a[i];
                }
                else
                {
                    final = final + " ";
                }
            }

            for (i = 0; i < final.Length - 1; i++)
            {
                if (final[i] == ' ' && final[i + 1] == ' ')
                {
                    final = final.Substring(0, i) + final.Substring(i + 1);
                    i--;
                }
            }
            final = final.TrimStart();
            final = final.TrimEnd();
            return final;
        }
        static bool CompruebaEmail(string a)
        {
            int i, cont = 0, j, k;
            string[] partes;
            string error = "ñÑáÁéÉíÍóÓúÚ";
            if (a[0] == '@' || a[a.Length - 1] == '@')
            {
                return false;
            }
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == '@')
                {
                    cont++;
                }
            }
            if (cont != 1)
            {
                return false;
            }
            partes = a.Split("@");
            for (i = 0; i < partes.Length; i++)
            {
                for (j = 0; j < partes[i].Length; j++)
                {
                    for (k = 0; k < error.Length; k++)
                    {
                        if (partes[i][j] == error[k])
                        {
                            return false;
                        }
                    }
                }
            }
            for (i = 0; i < partes.Length; i++)
            {
                if (partes[i][0] == '-' || partes[i][partes[i].Length - 1] == '-' || partes[i][0] == '.' || partes[i][partes[i].Length - 1] == '.')
                {
                    return false;
                }
            }
            for (i = 0; i < partes.Length; i++)
            {
                for (j = 0; j < partes[i].Length - 1; j++)
                {
                    if (partes[i][j] == '.' && partes[i][j + 1] == '.')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static string PalbrasImpares(string a)
        {
            int i;
            string aux = "";
            a = LimpiaCadena(a);
            string[] palabras = a.Split(" ");
            for (i = 0; i < palabras.Length; i++)
            {
                if (palabras[i].Length % 2 != 0)
                {
                    aux = aux + palabras[i] + " ";
                }
            }
            return aux;
        }
        static int CuentaDiptongos(string a)
        {
            string[] diptongos = { "uo", "ui", "ue", "ua", "iu", "iu", "ie", "ia", "ou", "oi", "eu", "ei", "au", "ai" ,"io","oy","ay","ey","uy","uó","ué","uá","áu","iá","ió","ah","eh","ih","oh","uh"};
            int i, j, cont = 0;
            a = a.ToLower();
            //a = LimpiaCadena(a);
            for (i = 0; i < a.Length-1; i++)
            {
                for (j = 0; j < diptongos.Length; j++)
                {
                    if (a[i] == diptongos[j][0] && a[i + 1] == diptongos[j][1])
                    {
                        cont++;
                    }
                }
            }
            return cont;
        }
        static bool EsVocal(char a)
        {
            bool vocal = true;
            if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u')
            {
                vocal= true;
            }
            else
            {
                vocal= false;
            }
            return vocal;
        }

    } 

}

