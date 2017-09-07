using System;
using System.Collections.Generic;
using System.Linq;
using TaskovExercise.Entities;

namespace TaskovExercise
{
    internal class StartUp
    {
        public static void Main(string[] args)
        {
            List<Tondeuse> tondeuses = new List<Tondeuse>();

            var surfaceArgs = Console.ReadLine().Split(' ').ToList();
            int xMaxCoordinate = int.Parse(surfaceArgs[0]);
            int yMaxCoordinate = int.Parse(surfaceArgs[1]);

            Surface surface = new Surface(xMaxCoordinate, yMaxCoordinate);

            string inputLine;

            while ((inputLine = Console.ReadLine()) != "Stop")
            {
                char[] tondeuseArgs = inputLine.Where(c => !Char.IsWhiteSpace(c)).ToArray();

                if (Char.IsDigit(tondeuseArgs[0]))
                {
                    Tondeuse tondeuse = new Tondeuse(int.Parse(tondeuseArgs[0].ToString()), int.Parse(tondeuseArgs[1].ToString()), tondeuseArgs[2]);
                    tondeuses.Add(tondeuse);
                }
                else
                {
                    foreach (char input in tondeuseArgs)
                    {
                        if (input == 'A')
                        {
                            tondeuses[tondeuses.Count - 1].Move(surface);
                        }
                        else
                        {
                            tondeuses[tondeuses.Count - 1].Rotate(input);
                        }
                    }

                    Console.WriteLine(tondeuses[tondeuses.Count - 1].ToString());
                }
            }
        }
    }
}