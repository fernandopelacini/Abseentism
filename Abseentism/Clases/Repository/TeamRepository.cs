using Abseentism.Clases.Interfaces;
using Abseentism.Data;
using Abseentism.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abseentism.Clases.Repository
{
    public class TeamRepository : ITeam
    {
        private AbseentismEntities _context = new AbseentismEntities();

        public async Task<bool> AddTeam(Teams team)
        {
            bool validate = await ValidateTeam(team.TeamName, team.CountryId);
            if ( !validate)
            {

                var teamToSave = new Data.Teams();

                teamToSave.name = team.TeamName;
                teamToSave.idCountry = team.CountryId;

                _context.Teams.Add(teamToSave);
               await _context.SaveChangesAsync();

                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> EditTeam(Teams team)
        {
            bool validate = await ValidateTeam(team.TeamName, team.CountryId);
            if (!validate)
            {
                var teamToUpdate = _context.Teams.Find(team.Id);
                if (teamToUpdate != null)
                {
                    teamToUpdate.name = team.TeamName;

                   await _context.SaveChangesAsync();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public async Task<IEnumerable<TeamCountryViewModel>> GetAll(string searchpattern)
        {
            var teams = from t in _context.Teams
                         join c in _context.Countries on t.idCountry equals c.id
                         select new TeamCountryViewModel 
                         { //result selector
                            Id = t.id,
                            Team = t.name,
                            Country = c.country
                            //Flag = GetFlag(c.country)

                         };
            //select a;
            if (!string.IsNullOrEmpty(searchpattern))
            {
                teams = teams.Where(x => x.Team.Contains(searchpattern)
                                    ||x.Country.Contains(searchpattern));
            }

            return await teams.ToListAsync();
        }
         

        public async Task<IEnumerable<Teams>> GetTeamsByCountry(int idCountry)
        {
            try
            {
                var teams =await _context.Teams
                                    .AsNoTracking()
                                    .Where(x => x.idCountry == idCountry)
                                    .ToListAsync();

                if (teams == null)
                {
                    return null;
                }
                else
                {
                    var model = new List<Teams>();

                    Teams temp = new Teams();
                    temp.Id = 0;
                    temp.TeamName = Constants.SELECT_A_TEAM;
                    model.Add(temp);

                    foreach (var team in teams)
                    {
                        Teams equipo = new Teams();
                        equipo.Id = team.id;
                        equipo.TeamName = team.name;

                        model.Add(equipo);
                    }
                    return model;
                }

            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Validates the country doesn't exist in the repository 
        /// It returns true country does not exists
        /// </summary>
        /// <param name="teamname">country to be search</param>
        /// <param name="countryId">Id from the country to associate the team</param>

        /// <returns></returns>
        private async Task<bool> ValidateTeam(string teamname, int countryId)
        {
            return await _context.Teams.Where(t => t.name == teamname && t.idCountry== countryId).AnyAsync();
        }

    }
}
