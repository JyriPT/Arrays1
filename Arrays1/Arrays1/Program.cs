using System;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kaikki tehtävät tehty yhteen, tehtävien tarkistus tehdään valikon kautta
            string input;
            Console.WriteLine("Select the assignment you wish to check (number 1-2):");
            Console.WriteLine("");
            //Laitetaan käyttäjän valinta string arvoon
            input = Console.ReadLine();
            Console.WriteLine("");
            //Käsitellään edellä annettu arvo.
            //Jos mahdollista muuttaa int arvoksi, tarkistetaan mikä numero.
            //Jos annettu arvo ei ole numero väliltä 1-2, mitään ei tapahdu.
            if (int.TryParse(input, out int select) == true)
            {
                //Tehtävä 1 valinta
                if (select == 1)
                {
                    //Alustetaan taulukot
                    decimal[] productPrice = new decimal[3] { 7.96m, 72.00m, 99.90m};
                    int[] productAmount = new int[3] { 1, 3, 2};
                    decimal[] productTotalPrice = new decimal[3];

                    //Luodaan arvot productTotalPrice taulukolle
                    for (int i = 0; i < 3; i++)
                    {
                        productTotalPrice[i] = productPrice[i] * productAmount[i];
                    }

                    //Tulostetaan taulukon productTotalPrice arvot
                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine("Tuote " + (j + 1) + ": " + productTotalPrice[j] + " euroa.");
                    }
                }
                //Tehtävä 2 valinta
                else if (select == 2)
                {
                    //Luodaan tarvittavat muuttujat
                    int[] iT = new int[100];
                    Random rnd = new Random();
                    int sum = 0;

                    //Arvotaan taulukolle iT arvot
                    for (int i = 0; i < 100; i++)
                    {
                        iT[i] = rnd.Next(51);
                    }

                    //Lasketaan taulukon iT arvot yhteen sum muuttujaan
                    for (int j = 0; j < 100; j++)
                    {
                        sum += iT[j];
                    }
                    //Lasketaan keskiarvo
                    decimal average = Decimal.Divide(sum, 100);

                    //Tulostetaan vastaukset
                    for (int k = 0; k < 100; k++)
                    {
                        Console.WriteLine(k + ". " + iT[k]);
                    }
                    Console.WriteLine("Average: " + average);
                }
                
                else
                {
                    Console.WriteLine("Invalid selection, please reboot.");
                }
            }
            else
            {
                Console.WriteLine("Invalid selection, please reboot.");
            }
        }
    }
}
