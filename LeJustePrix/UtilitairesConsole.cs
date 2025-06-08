namespace LeJustePrix;

public static class UtilitairesConsole
{
    public static int DemanderNombre(int min, int max)
    {
        do
        {
            Console.Write($"Veuillez saisir un nombre entre {min} et {max} : ");
            string saisie = Console.ReadLine() ?? string.Empty;
            bool estNombre = int.TryParse(saisie, out int nombre);

            if (estNombre)
            {
                bool estInterval = (nombre >= min && nombre <= max);

                if (estInterval)
                    return nombre;
            }

        } while (true);
    }

    public static int GenererNombreAleatoire(int min, int max) => Random.Shared.Next(min, max + 1);
}
