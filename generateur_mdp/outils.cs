using System;
using System.Collections.Generic;
using System.Text;



namespace FormationCS
{
    static class outils
    {
        public static int DemanderNombrePositifNonNul(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue, "ERREUR: Le nombre doit être positif et non nul");
        }

        public static int DemanderNombreEntre(string question, int min, int max, string messageErreurPresonnalise = null)
        {

            int nombre = DemanderNombre(question);
            if ((nombre >= min) && (nombre <= max))
            {
                return nombre;
            }
            if (messageErreurPresonnalise == null)
            {
                Console.WriteLine("ERREUR : Le nombre doit être compris entre " + min + " et " + max);
            }
            else
            {
                Console.WriteLine(messageErreurPresonnalise);
            }

            Console.WriteLine();

            return DemanderNombreEntre(question, min, max);
        }

        public static int DemanderNombre(string question)
        {
            while (true)
            {
                Console.Write(question);
                string reponse = Console.ReadLine();
                try
                {
                    int reponseInt = int.Parse(reponse);
                    return reponseInt;
                }
                catch
                {
                    Console.WriteLine("ERREUR : Vous devez rentrer un nombre");
                    Console.WriteLine();
                }
            }
        }

    }
}
