namespace LeJustePrix;

public class LeJustePrix(int chiffreMinimum = 0, int chiffreMaximum = 100)
{
    public int NombreEssais { get; private set; }

    private readonly int _chiffreMinimum = chiffreMinimum;
    private readonly int _chiffreMaximum = chiffreMaximum;

    public void Lancer()
    {
        int chiffreAuHasard = UtilitairesConsole.GenererNombreAleatoire(_chiffreMinimum, _chiffreMaximum);
        Console.WriteLine($"Un nombre a été choisi au hasard entre {_chiffreMinimum} et {_chiffreMaximum}, essayez de le découvrir !\r\n");

        VerifierLeJusteNombre(chiffreAuHasard);
        Console.WriteLine($"Bravo ! Tu as réussi en {NombreEssais} tentative(s)");
    }

    public int VerifierLeJusteNombre(int chiffreATrouver)
    {
        NombreEssais = 0;
        while (true)
        {
            NombreEssais++;
            int Chiffre = UtilitairesConsole.DemanderNombre(_chiffreMinimum, _chiffreMaximum);

            //switch (Chiffre)
            //{
            //    case < chiffreATrouver : Console.WriteLine("+")
            //}

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
