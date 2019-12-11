            Console.WriteLine("Program 001");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Opgave 1
            //Her skal i fuldføre værdierne så de står rigtigt(Hint: "float" og "String").
            char Lamda = '\u03BB';  //Lamda
            Fart            //Fart
            Frekvens        //Frekvens
            Bølgelængde     //Bølgelængde
            Input           //Det man selv skriver
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*
             * Fart
             */
            //Opgave 2
            //Her skal i skrive resten af komandoen så der bliver skrevet de følgende ting. Du skal også få Input fra Console.
            ("Skriv værdier: ");
            ();
            Console.Write("Fart: ");
            Input =

            //Det her må ikke ændres!
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
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*
             * Frekvens
             */
            //Opgave 3
            //Her skal i skrive resten af komandoen så der bliver skrevet de følgende ting. Du skal også få Input fra Console.
            //Her skal den ene skrives med Console.Write i stedet for Console.WriteLine(Hint: Kig på opgave 2)
            ();
            ("Frekvens: ");
            Input

            //Det her må ikke ændres!
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
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*
             * Bølgelængde
             */
            //Opgave 4
            //Her skal i skrive resten af komandoen så der bliver skrevet de følgende ting. Du skal også få Input fra Console.
            //Her skal den ene skrives med Console.Write i stedet for Console.WriteLine(Hint: Kig på opgave 2 og 3)(Hint 2: Kig efter store og små bogtaver)
            ();
            ("Lamda(Bølgelængde): ");
            input

            //Det her må ikke ændres!
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
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*
             * Facit udregning
             */
            //Opgave 5
            //Du skal bruge funktionen til at skrive i console til at skrive følgende: "Formel: " + "v = " + Lamda + " * f"
            //Det skal ske der hvor der er et semi kolon.
            Console.WriteLine();
            Console.WriteLine();
            ;
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Opgave 6
            //Her mangler hvad consolen skal skrive du skal derfor indsætte de tre følgende i hen holdsvis Nr. 1, 2 og 3
            //"Udregning: " + "v" + " = " + Bølgelængde + " * " + Frekvens
            //"Udregning: " + Fart + " = " + Lamda + " * " + Frekvens
            //"Udregning: " + Fart + " = " + Bølgelængde + " * " + "f"
            if ((Fart == 0) || (Bølgelængde == 0) || (Frekvens == 0))
            {
                if (Fart == 0)
                {
                    // 1
                    Console.WriteLine();
                }
                else if (Bølgelængde == 0)
                {
                    // 2
                    Console.WriteLine();
                }
                else if (Frekvens == 0)
                {
                    // 3
                    Console.WriteLine();
                }

                if (((Fart == 0) && (Bølgelængde == 0)) || ((Fart == 0) && (Frekvens == 0)) || ((Bølgelængde == 0) && (Frekvens == 0)) || ((Frekvens == 0) && (Bølgelængde == 0)) || ((Fart == 0) && (Bølgelængde == 0)))
                {
                    Console.WriteLine("Udregning ugyldig");
                    goto END;
                }
            }
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Opgave 7
            //Her mangler nogle ting find dem og skriv dem ind. Den fulde kommando lyder:
            //Console.WriteLine("Facit: " + Bølgelængde + "(" + Lamda + ")" + " * " + Frekvens + "(f)" + " = " + Fart + "(v)");
            //Hint: Led efter steder med "+ +" og ""

            if ((Fart == 0) || (Bølgelængde == 0) || (Frekvens == 0))
            {
                if (Fart == 0)
                {
                    Fart = Bølgelængde * Frekvens;
                    Console.WriteLine("Facit: " +  + "(" + Lamda + ")" + " * " + Frekvens + "(f)" + " = " + Fart + "(v)");
                }
                else if (Bølgelængde == 0)
                {
                    Bølgelængde = Fart / Frekvens;
                    Console.WriteLine("Facit: " + Bølgelængde + "(" + Lamda + ")" + " * " +  + "(f)" + " = " + Fart + "");
                }
                else if (Frekvens == 0)
                {
                    Frekvens = Fart / Bølgelængde;
                    Console.WriteLine("" + Bølgelængde + "(" +  + ")" + " * " + Frekvens + "(f)" + " = " + Fart + "(v)");
                }
            }
            else
            {
                Console.WriteLine("Facit: " + Bølgelængde + "(" +  + ")" + " * " + Frekvens + "(f)" + " = " +  + "(v)");
            }


            END:;
            /*
             * Hvis du nu ingen fejl har så...
             * Tillykke du har nu lavet et program der kan udregne bølgeformlen.
             * Prøv at trykke Run og afprøv dit program
             * 
             */