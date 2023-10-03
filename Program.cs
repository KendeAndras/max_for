namespace food_max_select
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bemenet
            int fcount;

            //kimenet
            int maxfindex;
            int maxf;

            //ellenorzeshez
            string inputText;
            bool error;

            //beolv
            do
            {
                Console.WriteLine("ennyi kaja(ertelem szeruen pozitiv szam): ");
                inputText = Console.ReadLine();
                error = !int.TryParse(inputText, out fcount);
                if (error)
                {
                    Console.WriteLine("a valamennyi kaja szamabol lehet csak legnagyobb, na ujra ");
                }

            } while (error);

            //tomb
            int[] foodCount = new int[fcount + 1];
            for (int i = 1; i <= fcount; i++)
            {
                do {
                    Console.WriteLine("add meg a szamukat(ertelem szeruen pozitiv szam)");
                    inputText = Console.ReadLine();
                    error = !int.TryParse(inputText, out foodCount[i]);
                    if (error)
                    {
                        Console.WriteLine("nehez ennyi kedvenc kajanak lennie... az egy szam, ha nem vagod, ami pozitiv... nehez negativ kedvenc kajaval. ujra.");
                    }
                }while (error);
            }

            maxf = foodCount[1];
            maxfindex = 1;

            
            for (int i = 2; i <= fcount; i++)
            {
                if (foodCount[i] > maxf)
                {
                    maxf = foodCount[i];
                    maxfindex = i;
                }
            }

            Console.WriteLine("a legtobb {0} es {1} eszik ennyit", maxf, maxfindex);

        }
    }
}