using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PlayerAppProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] players = new Player[5]
            {
                new Player(101,"Harsh",25),
                new Player(102,"Abhishek",35),
                new Player(103,"Amit", 22),
                new Player(104, "Riya",24),
                new Player(105, "Ram", 34)
            };

            bool continueProgram = true;

            while (continueProgram)
            {
                Console.Write("Enter the Player Id to perform actions (or enter 0 to exit): ");
                int playerId = int.Parse(Console.ReadLine());

                if (playerId == 0)
                {
                    continueProgram = false;
                    break;
                }

                Player selectedPlayer = null;

                foreach (Player player in players)
                {
                    if (player.GetPlayerId() == playerId)
                    {
                        selectedPlayer = player;
                        break;
                    }
                }

                if (selectedPlayer != null)
                {
                    bool continueTransactions = true;
                    while (continueTransactions)
                    {
                        Console.WriteLine("\n------Select transaction:------\nPress 1 for Player Name\nPress 2 for Player Age\nPress 3 for Oldest Player\nPress 4 to exit");
                        int selectTransaction = int.Parse(Console.ReadLine());

                        switch (selectTransaction)
                        {
                            case 1:
                                Console.WriteLine($"The Player's Name : {selectedPlayer.GetPlayerName()}");
                                break;
                            case 2:
                                Console.WriteLine($"The Player's Age : {selectedPlayer.GetPlayerAge()}");
                                break;
                            case 3:
                                selectedPlayer.ReturnWhoIsElder(players, out int elderPlayerId, out string elderPlayerName, out int elderPlayerAge);
                                Console.WriteLine($"The Oldest Player's Id : {elderPlayerId}");
                                Console.WriteLine($"The Oldest Player's Name : {elderPlayerName}");
                                Console.WriteLine($"The Oldest Player's Age : {elderPlayerAge}");
                                break;
                            case 4:
                                continueTransactions = false;
                                break;
                            default:
                                Console.WriteLine("Select Transaction again...");
                                break;
                        }
                    }
                }
                else
                    Console.WriteLine("Account not found. Please try again.");
            }
        }
    }
}