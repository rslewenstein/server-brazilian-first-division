using server_brazilian_first_division.Repository.interfaces;

namespace server_brazilian_first_division.Repository
{
    public class FirstDivisionRepository : IFirstDivisionRepository
    {
        public List<string> GetAllTeams()
        {
            return GetTeams();
        }

        private List<String> GetTeams()
        {
            string[] mockTeam = 
            { 
                    "Palmeiras",
                    "Flamengo",
                    "Cruzeiro",
                    "Internacional",
                    "Fluminense",
                    "Corinthians",
                    "Athletico-PR",
                    "Atlético",
                    "Fortaleza",
                    "São Paulo",
                    "América",
                    "Botafogo",
                    "Santos",
                    "Goiás",
                    "Red Bull Bragantino",
                    "Coritiba",
                    "Cuiabá",
                    "Grêmio",
                    "Vasco",
                    "Bahia"  
            };

            var teamList = new List<String>();
            teamList.AddRange(mockTeam);
            return teamList; 
        }
    }
}