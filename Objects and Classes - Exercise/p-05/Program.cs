using System;
using System.Collections.Generic;
using System.Linq;

namespace p_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamCount = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamCount; i++)
            {
                string[] splitetInput = Console.ReadLine().Split("-");

                string creator = splitetInput[0];
                string teamName = splitetInput[1];

                bool isTeamExist = teams.Select(x => x.TeamName).Contains(teamName);
                bool isCretorAllRedyExist = teams.Select(x => x.CreatorName).Contains(creator);

                if (isTeamExist == false && isCretorAllRedyExist == false)
                {

                    Team team = new Team(teamName, creator);
                    teams.Add(team);

                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
                else if (isTeamExist == true)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (isCretorAllRedyExist == true)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split("->");

                if (input[0] == "end of assignment")
                {
                    break;
                }

                string member = input[0];
                string wishestTeam = input[1];

                bool isTeamExist = teams.Select(x => x.TeamName).Contains(wishestTeam);
                bool isAllReady = teams.Any(x => x.Members.Contains(member)||x.CreatorName.Contains(member));

                if (isTeamExist == false)
                {
                    Console.WriteLine($"Team {wishestTeam} does not exist!");
                    
                }
                if (isAllReady)
                {
                    Console.WriteLine($"Member {member} cannot join team {wishestTeam}!");
                    
                }
                if (isTeamExist && isAllReady == false)
                {
                    int indexOfTeam = teams.FindIndex(x => x.TeamName == wishestTeam);

                    teams[indexOfTeam].Members.Add(member);
                }
            }

            List<Team> teamWithMembers = teams.Where(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.TeamName)
                .ToList();

            List<Team> teamWithoutMembers = teams.Where(x => x.Members.Count == 0)
               .OrderBy(x => x.TeamName)
               .ToList();

            foreach (var item in teamWithMembers)
            {
                Console.WriteLine(item.TeamName);
                Console.WriteLine($"- {item.CreatorName}");
                Console.WriteLine(string.Join(Environment.NewLine ,item.Members.Select(x=>$"-- {x}")));
            }

            Console.WriteLine("Teams to disband:");

            foreach (var item in teamWithoutMembers)
            {
                Console.WriteLine(item.TeamName);
            }
        }
    }
    class Team
    {
        public Team(string teamName, string creatorName)
        {
            TeamName = teamName;
            CreatorName = creatorName;
            Members = new List<string>(); 
        }

        public string TeamName { get; set; }
        public string CreatorName { get; set; }
        public List<string> Members { get; set; }
    }
}
