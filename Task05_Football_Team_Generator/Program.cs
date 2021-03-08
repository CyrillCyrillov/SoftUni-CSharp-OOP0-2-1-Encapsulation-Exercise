using System;
using System.Collections.Generic;
using System.Linq;

namespace Task05_Football_Team_Generator
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            List<Team> allTeams = new List<Team>();

            string nextComand = string.Empty;
            while ((nextComand = Console.ReadLine()) != "END")
            {
                string[] datas = nextComand.Split(';', StringSplitOptions.RemoveEmptyEntries).ToArray();

                try
                {
                    //datas[0] -> Type of the comand
                    switch (datas[0])
                    {
                        case "Team":
                            //datas[1] -> Name of the new team
                            allTeams.Add(new Team(datas[1]));
                            break;

                        case "Add":
                            //datas[1] -> Name of the team, datas[2] -> Name of the player, datas[3 ... 7] - skil levels
                            Team teamToAddPlayer = allTeams.FirstOrDefault(n => n.Name == datas[1]);

                            if (teamToAddPlayer == null)
                            {
                                throw new ArgumentException($"Team {datas[1]} does not exist.");
                            }
                            else
                            {
                                teamToAddPlayer.AddPlayer(new Player(datas[2], int.Parse(datas[3]), int.Parse(datas[4]), int.Parse(datas[5]), int.Parse(datas[6]), int.Parse(datas[7])));
                            }
                            break;

                        case "Remove":
                            //datas[1] -> Name of the team, datas[2] -> Name of the player
                            Team teamToRemovePlayer = allTeams.FirstOrDefault(n => n.Name == datas[1]);
                            teamToRemovePlayer.RemovePlayer(datas[2]);
                            break;

                        case "Rating":
                            //datas[1] -> Name of the team
                            Team teamToRating = allTeams.FirstOrDefault(n => n.Name == datas[1]);
                            if (teamToRating == null)
                            {
                                throw new ArgumentException($"Team {datas[1]} does not exist.");
                            }
                            else
                            {
                                Console.WriteLine(teamToRating);
                            }
                            break;
                        
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
            
            
            //Console.WriteLine("Hello World!");
        }
    }
}
