using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class ConsoleGame
    {
        Player player;
        Room[,] world; //2 -dimensional array
        Random random = new Random();

        public void Play()
        {
            CreatePlayer();//make player
            CreateWorld();//make world

            do
            {
                Console.Clear();
                DisplayWorld();
                DisplayStats();//display health
                AskForMovement();//this causes the game to pause
            } while (player.Health > 0);

            GameOver();
        }

        private void CreatePlayer()
        {
            player = new Player(30, 0, 0);
        }

        private void CreateWorld()
        {
            world = new Room[20, 5];//go from null to 2-dimensional array
            for (int y = 0; y < world.GetLength(1); y++)//y-axis
            {
                for (int x = 0; x < world.GetLength(0); x++)//x-axis
                {
                    world[x, y] = new Room();

                    int percentage = random.Next(0, 100);
                    if (percentage < 10)
                        world[x, y].Monster = new Monster(30);
                    else if (percentage < 20)
                        world[x, y].Item = new Item("Sword");
                }
            }
        }

        private void DisplayWorld()
        {
            for (int y = 0; y < world.GetLength(1); y++)
            {
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    Room room = world[x, y];//this "room" doesnt change
                    if (player.X == x && player.Y == y)
                        Console.Write("P");
                    else if (room.Monster != null)
                        Console.Write("M");
                    else if (room.Item != null)
                        Console.Write("I");
                    else
                        Console.Write(".");
                }
                Console.WriteLine();
            }
        }

        private void DisplayStats()
        {
            Console.WriteLine($"Health: {player.Health}");
        }

        private void AskForMovement()
        {
            int newX = player.X;//asign to players x value
            int newY = player.Y;
            bool isValidKey = true;

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.RightArrow: newX++; break;
                case ConsoleKey.LeftArrow: newX--; break;
                case ConsoleKey.UpArrow: newY--; break;
                case ConsoleKey.DownArrow: newY++; break;
                default: isValidKey = false; break;
            }

            if (isValidKey &&
                newX >= 0 && newX < world.GetLength(0) &&
                newY >= 0 && newY < world.GetLength(1))
            {
                player.X = newX;
                player.Y = newY;
            }
        }

        private void GameOver()
        {
            Console.Clear();
            Console.WriteLine("Game over...");
            Console.ReadKey();
            Play();
        }
    }
}
