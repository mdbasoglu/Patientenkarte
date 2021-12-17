using System;
using System.Collections;

namespace Uebung53_Patientenkartei_pbbgh20aba
{
    class MainClass
    {

        public static void Main(string[] args)
        {

            Patient[] patienten = new Patient[10];

            patienten[0] = new Patient("Basoglu", "Murat", 32, 'M', 1.80, 100);
            patienten[1] = new Patient("Mener", "Gudrun", 40, 'F', 1.76, 70);
            patienten[2] = new Patient("Merlin", "Kah", 44, 'F', 1.51, 78);
            patienten[3] = new Patient("Nimels", "Kummrah", 51, 'F', 1.89, 78);
            patienten[4] = new Patient("Manne", "Esset", 61, 'M', 1.81, 78);
            patienten[5] = new Patient("Burry", "Harry", 31, 'F', 1.41, 78);
            patienten[6] = new Patient("Bech", "Kirn", 37, 'F', 1.61, 78);
            patienten[7] = new Patient("Tesla", "Nikola", 39, 'M', 1.99, 78);
            patienten[8] = new Patient("Murry", "Gerppries", 31, 'F', 1.56, 78);
            patienten[9] = new Patient("Arassy", "Maurice", 31, 'F', 1.71, 78);







            Console.WriteLine();


            // Create and initialize a new array.
            String[] patientnamen = {
                                      "\tBasoglu, Murat\t\t BMI:\t 21.60",
                                      "\tTesla, Nicola\t\t BMI:\t 25.81",
                                      "\tKlein, Stella\t\t BMI:\t 38.97",
                                      "\tNewton, Isaac\t\t BMI:\t 34.43",
                                      "\tKrupa, Varah\t\t BMI:\t 56.65",
                                      "\tStella, Jane\t\t BMI:\t 12.34",
                                      "\tKlein, Hannah\t\t BMI:\t 34.56",
                                      "\tBerk, Yaman\t\t BMI:\t 32.45",
                                      "\tDemir, Caglar\t\t BMI:\t 56.67",
                                      "\tLoli, Krispa\t\t BMI:\t 23.23",
                                      "\tBasoglu, Murat\t\t BMI:\t 21.60"
                                      };
            Double[] bmis = { 21.60, 25.81, 38.97, 34.43, 56.65, 12.34, 34.56, 32.45, 56.67, 23.23 };

            // Instantiate the reverse comparer.
            IComparer revComparer = new ReverseComparer();

            // Display the values of the array.
            DisplayValues(patientnamen);

            //----------------------------------------------------------------------
            // Summe deklarieren und initialisieren
            double summe = 0.0;

            // jedes Element des Arrays zur Summe hinzuaddieren
            for (int index = 0; index < bmis.Length; index++)
            {
                summe = summe + bmis[index];
            }
            if (bmis.Length > 0)
            {
                Console.WriteLine("Die Summe ist:   " + summe);
                Console.WriteLine("Der Durchschnitt ist: " + summe / bmis.Length);
            }
            else
                Console.WriteLine("Das Array enthält keine Elemente.");
            //----------------------------------------------------------------------

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }



        public class ReverseComparer : IComparer
        {
            // Call CaseInsensitiveComparer.Compare with the parameters reversed.
            public int Compare(Object x, Object y)
            {
                return (new CaseInsensitiveComparer()).Compare(y, x);
            }
        }

        public static void DisplayValues(String[] array)
        {
            for (int i = 1; i <= array.GetUpperBound(0); i++)
            {
                Console.WriteLine("{0}. Patient : {1} ", i, array[i]);
            }
            Console.WriteLine();
        }
    }
}

