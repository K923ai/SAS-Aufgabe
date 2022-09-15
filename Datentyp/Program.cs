// Console.WriteLine($"size of short: {short.MaxValue}");
// Console.WriteLine($"size of short: {short.MinValue}");
//bit 16

using System;

namespace Konsolenausgabe
{
    internal class program
    {
        static void Main(string[] args)
        {

            // Aufgabe 1

            Console.WriteLine(" .-.\r\n(o o)\r\n| O |\r\n| |\r\n'~~~'\r\n");

            //AUfgabe 2+3


            string Vorname;
            string Nachname;
            string Alter;
            string Klasse;

            Console.Write("Gebe deinen Vornamen ein:  ");
            Vorname = Console.ReadLine();
            Console.Write("Gebe dein Nachnamen ein:  ");
            Nachname = Console.ReadLine();
            Console.WriteLine("Gebe dein Alter ein:  ");
            Alter = Console.ReadLine();
            Console.WriteLine("In welche Klasse gehst du:  ");
            Klasse = Console.ReadLine();


            Console.WriteLine(Vorname + " " + Nachname + " ist " + Alter + " Jahre alt und besucht die " + Klasse + " des Georg-Simon-Ohm Berufskollegs. ");




        }

    }

}