namespace LeJustePrix
{
    public class LeJustePrix
    {
        public static int IncrementJeu { get; set; }

        public static void Lancer()
        {
            Console.WriteLine("Un chiffre va être choisie au hasard");
            int chiffreAuHasard = UtilitairesConsole.NombreAleatoire();

            LeJustePrix.LeJusteNombre(chiffreAuHasard);
            Console.WriteLine($"Tu a reussi en : {IncrementJeu} tentative");
        }

        public static int LeJusteNombre(int chiffreATrouver)
        {
            IncrementJeu = 0;
            int ChiffreMinimum = 0;
            int ChiffreMaximum = 100;
            while (true)
            {
                IncrementJeu++;
                Console.WriteLine($"Veuiller saisie un chiffre entre {ChiffreMinimum} et {ChiffreMaximum}");
                int Chiffre = UtilitairesConsole.SaisieNombre();

                if (Chiffre < chiffreATrouver)
                {
                    Console.WriteLine("+");
                }
                if (Chiffre > chiffreATrouver)
                {
                    Console.WriteLine("-");
                }
                if (Chiffre == chiffreATrouver)
                    return Chiffre;
            }
        }
    }
}
