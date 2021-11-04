using System;
using System.Collections.Generic;

namespace ApplicationMedecin
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            List<Medecin> liste = new List<Medecin>();
            Cardiologue cardio = new Cardiologue("M12345", "Paul", "Faye", 10, 100, "Medecin Chef");
            Chirurgien chirugien = new Chirurgien("F1234", "Sophie", "Faye", 12, 14, "Expert Chef");
            Console.WriteLine("Cardiologie:");
            Console.WriteLine(cardio.ToString());
            Console.WriteLine();
            Console.WriteLine("Chirurgie:");
            Console.WriteLine(chirugien.ToString());
            //ajout dans la liste
            liste.Add(chirugien);
            liste.Add(cardio);
            foreach (Medecin medecin in liste)
                medecin.Soigner();
        }
    }
}
