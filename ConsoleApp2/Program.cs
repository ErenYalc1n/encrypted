using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encrypted = "Povzhv hvmw z nvhhztv drgs xfiivmg hvhhrlm rm qhlm ulinzg erz gsrh vcznkov - Kvvk orhgvmrmt mvd nvhhztv uli gzhp xlmgvmg! Ylfi ivtrhgizgrlmKvb";
            char[] dizi = encrypted.ToCharArray();                      
            for(int i=0; i<dizi.Length; i++)
            {
                if (Convert.ToString(dizi[i]) == "a")
                    dizi[i] = Convert.ToChar("z");
                else if (Convert.ToString(dizi[i]) == "b")
                    dizi[i] = Convert.ToChar("y");
                else if (Convert.ToString(dizi[i]) == "c")
                    dizi[i] = Convert.ToChar("x");
                else if (Convert.ToString(dizi[i]) == "d")
                    dizi[i] = Convert.ToChar("w");
                else if (Convert.ToString(dizi[i]) == "e")
                    dizi[i] = Convert.ToChar("v");
                else if (Convert.ToString(dizi[i]) == "f")
                    dizi[i] = Convert.ToChar("u");
                else if (Convert.ToString(dizi[i]) == "g")
                    dizi[i] = Convert.ToChar("t");
                else if (Convert.ToString(dizi[i]) == "h")
                    dizi[i] = Convert.ToChar("s");
                else if (Convert.ToString(dizi[i]) == "i")
                    dizi[i] = Convert.ToChar("r");
                else if (Convert.ToString(dizi[i]) == "j")
                    dizi[i] = Convert.ToChar("q");
                else if (Convert.ToString(dizi[i]) == "k")
                    dizi[i] = Convert.ToChar("p");
                else if (Convert.ToString(dizi[i]) == "l")
                    dizi[i] = Convert.ToChar("o");
                else if (Convert.ToString(dizi[i]) == "m")
                    dizi[i] = Convert.ToChar("n");
                else if (Convert.ToString(dizi[i]) == "n")
                    dizi[i] = Convert.ToChar("m");
                else if (Convert.ToString(dizi[i]) == "o")
                    dizi[i] = Convert.ToChar("l");
                else if (Convert.ToString(dizi[i]) == "p")
                    dizi[i] = Convert.ToChar("k");
                else if (Convert.ToString(dizi[i]) == "q")
                    dizi[i] = Convert.ToChar("j");
                else if (Convert.ToString(dizi[i]) == "r")
                    dizi[i] = Convert.ToChar("i");
                else if (Convert.ToString(dizi[i]) == "s")
                    dizi[i] = Convert.ToChar("h");
                else if (Convert.ToString(dizi[i]) == "t")
                    dizi[i] = Convert.ToChar("g");
                else if (Convert.ToString(dizi[i]) == "u")
                    dizi[i] = Convert.ToChar("f");
                else if (Convert.ToString(dizi[i]) == "v")
                    dizi[i] = Convert.ToChar("e");
                else if (Convert.ToString(dizi[i]) == "w")
                    dizi[i] = Convert.ToChar("d");
                else if (Convert.ToString(dizi[i]) == "x")
                    dizi[i] = Convert.ToChar("c");
                else if (Convert.ToString(dizi[i]) == "y")
                    dizi[i] = Convert.ToChar("b");
                else if (Convert.ToString(dizi[i]) == "z")
                    dizi[i] = Convert.ToChar("a");
            }
            for(int j=0; j<dizi.Length; j++)
            {
                Console.Write(dizi[j]);
            }
            
        }
    }
}
