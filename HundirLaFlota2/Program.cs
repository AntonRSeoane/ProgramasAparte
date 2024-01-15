using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HundirLaFlota2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Hundir La Flota II";
            Console.WriteLine("  _    _                 _ _        _         ______ _       _          ___  \r\n | |  | |               | (_)      | |       |  ____| |     | |        |__ \\ \r\n | |__| |_   _ _ __   __| |_ _ __  | | __ _  | |__  | | ___ | |_ __ _     ) |\r\n |  __  | | | | '_ \\ / _` | | '__| | |/ _` | |  __| | |/ _ \\| __/ _` |   / / \r\n | |  | | |_| | | | | (_| | | |    | | (_| | | |    | | (_) | || (_| |  / /_ \r\n |_|  |_|\\__,_|_| |_|\\__,_|_|_|    |_|\\__,_| |_|    |_|\\___/ \\__\\__,_| |____|\r\n                                                                             \r\n                                                                             ");
            Thread.Sleep(3000);
            Console.WriteLine("\n       Pulse enter para comenzar");
            Console.ReadLine();

            Console.Clear();

            Random rdm = new Random();
            int vidas2 = 1;
            int[,] array56 = new int[10, 10];
            int[,] jugador = new int[10, 10];
            int restantes2 = 1;
            bool fin2 = false;

            for (int eo = 0; eo < jugador.GetLength(0); eo++)
            {
                for (int ns = 0; ns < jugador.GetLength(1); ns++)
                {
                    jugador[eo, ns] = 0;
                }
            }

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            if (nombre == "ANIAS2023")
            {
                Console.WriteLine("Hola querid@ jugador/a, soy Antón hablando a través del programa y quiero deciros que lo pasé muy bien programando junto a vosotr@s. \r\n Me quedé bastante triste al enterarme de que no podría venir más y tener que dejaros atrás. \r\n Un día vendré de visita, así también podréis decirme si os gusto el juego ;). \r\n Dadle las gracias al profe, que aguantó todas nuestras historias xd. \r\n\n ¡Suerte con la partida!");
                Console.WriteLine("\n\n\n       Pulsa enter para continuar...");
                Console.ReadLine();
            }
            Console.Write("Posición horizontal donde colocar su barco (0 - 9): ");
            int H1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Posición vertical donde colocar su barco (0 - 9): ");
            int V1 = Convert.ToInt32(Console.ReadLine());

            
            if (H1 > 9 || V1 > 9)
            {
                Console.WriteLine("Las coordenadas tienen que estar entre 0 y 9. Vuelva a empezar.");
                do
                {
                    Console.Write("Posición horizontal donde colocar su barco (0 - 9): ");
                    H1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Posición vertical donde colocar su barco (0 - 9): ");
                    V1 = Convert.ToInt32(Console.ReadLine());
                }while (H1 > 9 || H1 < 0 || V1 > 9 || V1 < 0);
            }

            jugador[H1, V1] = 1;

            for (int eo = 0; eo < array56.GetLength(0); eo++)
            {
                for (int ns = 0; ns < array56.GetLength(1); ns++)
                {
                    array56[eo, ns] = 0;
                }
            }

            for (int e = 0; e < 1; e++)
            {
                array56[rdm.Next(0, array56.GetLength(0) - 1), rdm.Next(0, array56.GetLength(1) - 1)] = 1;
            }

            int hor;
            int ver;

            do
            {
                Console.WriteLine("\nTurno de NPC.");
                Thread.Sleep(rdm.Next(1000, 4000));
                hor = rdm.Next(0, jugador.GetLength(0) - 1);
                ver = rdm.Next(0, jugador.GetLength(1) - 1);
                if (jugador[hor, ver] == 1)
                {
                    vidas2 -= 1;
                    Console.WriteLine($"¡Tocado y hundido!");
                }
                else
                {
                    Console.WriteLine($"¡Agua!");
                }
                Thread.Sleep(2000);

                Console.WriteLine($"\nTurno de {nombre}.");
                Console.Write($"Inserte una posición horizontal: ");
                int h = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inserte una posición vertical: ");
                int v = Convert.ToInt32(Console.ReadLine());

                if (array56[h, v] == 1)
                {
                    restantes2 -= 1;
                    Console.WriteLine($"¡Tocado y hundido!");
                }
                else
                {
                    Console.WriteLine($"¡Agua!");
                }

                if (vidas2 == 0)
                {
                    Console.WriteLine("\nFin del juego...");
                }
                else
                {
                    Console.WriteLine($"\n¡Ánimo {nombre}!");
                }

                if (restantes2 == 0 && vidas2 != 0)
                {
                    Console.WriteLine("\n¡Enhorabuena!¡Ha ganado!");
                }

                if (restantes2 == 0 || vidas2 == 0)
                {
                    fin2 = true;
                }
                else
                {
                    fin2 = false;
                }
                Thread.Sleep(2000);
            } while (fin2 == false);

            Console.ReadLine();
        }
    }
}
