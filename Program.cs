using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_Rank
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int numTournaments = int.Parse(Console.ReadLine());
                int initialPoints = int.Parse(Console.ReadLine());

                int totalPoints = initialPoints;
                int totalWins = 0;

                for (int i = 0; i < numTournaments; i++)
                {
                    string stage = Console.ReadLine();

                    switch (stage)
                    {
                        case "W":
                            totalPoints += 2000;
                            totalWins++;
                            break;
                        case "F":
                            totalPoints += 1200;
                            break;
                        case "SF":
                            totalPoints += 720;
                            break;
                    }
                }

                int averagePoints = (totalPoints - initialPoints) / numTournaments;
                double percentageWon = (double)totalWins / numTournaments * 100;

                Console.WriteLine($"Final points: {totalPoints}");
                Console.WriteLine($"Average points: {averagePoints}");
                Console.WriteLine($"{percentageWon:F2}%");
            }
        }
    }
   
