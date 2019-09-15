using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        private static double[] power = new double[5];

        public static void getPowerseries() {
            for (int i = 1; i <= 5; i++)
            {
                power[i-1] = Math.Pow(2,i);
            }

        }

        public static List<MatchupModel> CreateRoundOne(TournamentModel tournament) {
            //create matchups
            //order our list randomly of teams

            getPowerseries();
            double teamCount = 0;
            foreach (int count in power) {
                //if team count is in 2,4,8,16,32....
                if (tournament.EnteredTeams.Count == count)
                {
                    teamCount = count;
                    break;
                }
            }
            
            List<TeamModel> byes = new List<TeamModel>();
            //if team is not in 2,4,8,16,....
            if (teamCount==0) {
                for (int i = 0; i <power.Length; i++)
                {
                    //if substraction is not minus then its the count of byes we need
                    if (tournament.EnteredTeams.Count-power[i]>0)
                    {
                        for (int j = 1; j <= tournament.EnteredTeams.Count - power[i]; j++)
                        {
                            byes.Add(new TeamModel {TeamName="byes"+j });
                        }
                        break;
                    }
                }

            }

            List<MatchupModel> matchups = new List<MatchupModel>();

            List<TeamModel> teams =new List<TeamModel>();
            teams = tournament.EnteredTeams;

            if (byes.Count!=0) {
                teams.AddRange(byes);
            }

            while (teams.Count!=0) {
                int teamNum1 = new Random().Next(0, teams.Count);
                int teamNum2 = new Random().Next(0, teams.Count);

                if (teams.Count==0) {
                    break;
                }

                while (teamNum1!=teamNum2) {
                    TeamModel team1 = teams[teamNum1];
                    TeamModel team2 = teams[teamNum2];

                    List<MatchupEntryModel> matchupentery = new List<MatchupEntryModel>();
                    matchupentery.Add(new MatchupEntryModel { Score=0,TeamCompeting=team1 });
                    matchupentery.Add(new MatchupEntryModel { Score = 0, TeamCompeting = team2 });
                    
                    matchups.Add(new MatchupModel {Entries=matchupentery, MatchupRound=1});

                    teams.Remove(team1);
                    teams.Remove(team2);

                    break;
                }
            }

            return matchups;
        }
    }
}
