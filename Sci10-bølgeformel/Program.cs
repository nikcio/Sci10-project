using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sci10_bølgeformel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Program 001");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            char Lamda = '\u03BB';  //Lamda
            float Fart = 0;         //Fart
            float Frekvens = 0;     //Frekvens
            float Bølgelængde = 0;  //Bølgelængde
            string Input = "";      //Det man selv skriver

            /*
             * Fart
             */
            Console.WriteLine("Skriv værdier: ");
            Console.WriteLine();
            Console.Write("Fart(m/s): ");
            Input = Console.ReadLine();

            //Her ændre vi kommaet til et punktum, fordi alt er engelsk bruges komma og punktum omvendt
            if (float.TryParse(Input, out Bølgelængde))
            {
                if (Input.Contains(","))
                {
                    Input = Input.Replace(",", ".");
                }
                Fart = float.Parse(Input);
            }

            if (Input == "")
            {
                Fart = 0;
            }

            /*
             * Frekvens
             */
            Console.WriteLine();
            Console.Write("Frekvens(hertz): ");
            Input = Console.ReadLine();

            //Her ændre vi kommaet til et punktum, fordi alt er engelsk bruges komma og punktum omvendt
            if (float.TryParse(Input, out Bølgelængde))
            {
                if (Input.Contains(","))
                {
                    Input = Input.Replace(",", ".");
                }
                Frekvens = float.Parse(Input);
            }

            if (Input == "")
            {
                Frekvens = 0;
            }

            /*
             * Bølgelængde
             */
            Console.WriteLine();
            Console.Write("Bølgelængde(meter): ");
            Input = Console.ReadLine();

            //Her ændre vi kommaet til et punktum, fordi alt er engelsk bruges komma og punktum omvendt
            if (float.TryParse(Input, out Bølgelængde))
            {
                if (Input.Contains(","))
                {
                    Input = Input.Replace(",", ".");
                }
                Bølgelængde = float.Parse(Input);
            }

            if (Input == "")
            {
                Bølgelængde = 0;
            }

            /*
             * Facit udregning
             */
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Formel: " + "v = " + Lamda + " * f");

            if ((Fart == 0) || (Bølgelængde == 0) || (Frekvens == 0))
            {
                if (Fart == 0)
                {
                    Console.WriteLine("Udregning: " + "v" + " = " + Bølgelængde + " * " + Frekvens);
                }
                else if (Bølgelængde == 0)
                {
                    Console.WriteLine("Udregning: " + Fart + " = " + Lamda + " * " + Frekvens);
                }
                else if (Frekvens == 0)
                {
                    Console.WriteLine("Udregning: " + Fart + " = " + Bølgelængde + " * " + "f");
                }

                if (((Fart == 0) && (Bølgelængde == 0)) || ((Fart == 0) && (Frekvens == 0)) || ((Bølgelængde == 0) && (Frekvens == 0)) || ((Frekvens == 0) && (Bølgelængde == 0)) || ((Fart == 0) && (Bølgelængde == 0)))
                {
                    Console.WriteLine("Udregning ugyldig");
                    goto END;
                }
            }

            if ((Fart == 0) || (Bølgelængde == 0) || (Frekvens == 0))
            {
                if (Fart == 0)
                {
                    Fart = Bølgelængde * Frekvens;
                    Console.WriteLine("Facit: " + Bølgelængde + "(" + Lamda + ")" + " * " + Frekvens + "(f)" + " = " + Fart + "(v)");
                }
                else if (Bølgelængde == 0)
                {
                    Bølgelængde = Fart / Frekvens;
                    Console.WriteLine("Facit: " + Bølgelængde + "(" + Lamda + ")" + " * " + Frekvens + "(f)" + " = " + Fart + "(v)");
                }
                else if (Frekvens == 0)
                {
                    Frekvens = Fart / Bølgelængde;
                    Console.WriteLine("Facit: " + Bølgelængde + "(" + Lamda + ")" + " * " + Frekvens + "(f)" + " = " + Fart + "(v)");
                }
            }
            else
            {
                Console.WriteLine("Facit: " + Bølgelængde + "(" + Lamda + ")" + " * " + Frekvens + "(f)" + " = " + Fart + "(v)");
            }


        END:;
        }
    }
}

