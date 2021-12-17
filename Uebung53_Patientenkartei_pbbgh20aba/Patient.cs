using System;
namespace Uebung53_Patientenkartei_pbbgh20aba
{
    class Patient
    {
        private string name;
        private string vorname;
        private int alter;
        private char geschlecht;
        private double koerpergroesse;
        private double koerpergewicht;

        public string Name { get => name; set => name = value; }
        public string Vorname { get => vorname; set => vorname = value; }
        public int Alter { get => alter; set => alter = value; }
        public char Geschlecht { get => geschlecht; set => geschlecht = value; }
        public double Koerpergroesse { get => koerpergroesse; set => koerpergroesse = value; }
        public double Koerpergewicht { get => koerpergewicht; set => koerpergewicht = value; }

        public Patient(string name, string vorname, int alter, char geschlecht,
                       double koerpergroesse, double koerpergewicht)
        {
            this.name = name;
            this.vorname = vorname;
            this.alter = alter;
            this.geschlecht = geschlecht;
            this.koerpergroesse = koerpergroesse;
            this.koerpergewicht = koerpergewicht;
        }

        public double BerechnenBMI()
        {
            double ergebnis = (koerpergewicht) / (koerpergroesse * koerpergroesse);
            return ergebnis;
        }


        public override string ToString()
        {
            return $"Name: {name}\t" +
                   $"Vorname: {vorname}\t\t" +
                   $"Alter: {alter}\t" +
                   $"Geschlecht: {geschlecht}\t" +
                   $"Körpergröße: {koerpergroesse}\t" +
                   $"Körpergewicht: {koerpergewicht}\t" +
                   $"BMI: {Math.Round(BerechnenBMI(), 2)}\t";
        }
    }
}
