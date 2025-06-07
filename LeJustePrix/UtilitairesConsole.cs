namespace LeJustePrix
{
    public class UtilitairesConsole
    {
        //public int ChiffreMinimum { get; set; } = 0;
        //public int ChiffreMaximum { get; set; } = 10;

        public static int SaisieNombre()
        {
            do
            {
                string saise = Console.ReadLine();
                bool estNombre = (int.TryParse(saise, out int nombre));

                if (estNombre)
                    return nombre;

            } while (true);
        }

        public static int NombreAleatoire()
        {
            Random random = new Random();
            int nombreAleatoire = random.Next(0, 10);
            return nombreAleatoire;
        }

    }
}
