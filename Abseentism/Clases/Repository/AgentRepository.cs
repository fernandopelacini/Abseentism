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
    public class AgentRepository : IAgent
    {
        private AbseentismEntities _context = new AbseentismEntities();

        /// <summary>
        /// Adds a new agent to the repository
        /// </summary>
        /// <param name="agent">Agent to be added</param>
        public async Task<bool> AddAgent(Agent agent)
        {
            //Validate user doesn't exist.
            
            if (await ValidateAgent(agent.AvayaId, agent.Name, agent.Surname))
            {

                var agentToSave = new Agents();

                agentToSave.avayaId = agent.AvayaId;
                agentToSave.countryId = agent.CountryId;
                agentToSave.name = agent.Name;
                agentToSave.surname = agent.Surname;
                agentToSave.teamId = agent.TeamId;

                _context.Agents.Add(agentToSave);
               await _context.SaveChangesAsync();

                return  true;
            }
            else
            {
                return false;
            }

        }

        //Ver de hacer esto asincronico
        public async Task<bool> EditAgent(Agent agent)
        {
            if (await ValidateAgent(agent.AvayaId, agent.Name, agent.Surname))
            {
                var agentToUpdate = await _context.Agents.FindAsync(agent.Id);
                if (agentToUpdate != null)
                {
                    agentToUpdate.avayaId = agent.AvayaId;
                    agentToUpdate.name = agent.Name;
                    agentToUpdate.surname = agent.Surname;
                    agentToUpdate.countryId = agent.CountryId;
                    agentToUpdate.teamId = agent.TeamId;

                    //_context.Agents.Attach(agentToUpdate);
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


        /// <summary>
        /// Get all the agents associated to an specific team and country.
               /// </summary>
        /// <param name="country">ID of the country, teams names could be duplicate on differents countries, so this ID is to identify the right team</param>
        /// <param name="team">ID of the team the agent belongs to</param>
        /// <returns></returns>
        public async Task<IEnumerable<Agent>> GetAgentsByTeam(int country, int team)
        {
            var agents = await _context.Agents
                .Where(x => x.countryId == country && x.teamId == team)
                .ToListAsync();

            var model = new List<Agent>();

            foreach (var agent in agents)
            {
                Agent tempagent = new Agent();
                tempagent.Name = agent.name;
                tempagent.Surname = agent.surname;
                tempagent.AvayaId = agent.avayaId;
                tempagent.Id = agent.id;
                model.Add(tempagent);
            }
            return model;
        }

        public async Task<IEnumerable<FullAgentViewModel>> GetAgentsFullDetails(string searchpattern)
        {
            var agents = from a in _context.Agents
                         join c in _context.Countries on a.countryId equals c.id
                         join t in _context.Teams on a.teamId equals t.id
                         select new FullAgentViewModel
                         {  //Result Selector
                            Id= a.id,
                            AvayaId= a.avayaId,
                            Name= a.name,
                            Surname= a.surname,
                            CountryId= c.id,
                            Pais= c.country,
                            TeamId= t.id,
                            TeamName= t.name
                         };
            //select a;
            if (!string.IsNullOrEmpty(searchpattern))
            {
                agents = agents.Where(x => x.AvayaId.Contains(searchpattern)
                                    || x.Name.Contains(searchpattern)
                                    || x.Surname.Contains(searchpattern));
            }

            return await agents.ToListAsync();

        }

        /// <summary>
        /// Search for an agent, if no parameter is set for search, it'll return all.
        /// </summary>
        /// <param name="searchpattern">AvayaID, Name or Surname to search for</param>
        /// <returns></returns>
        public async Task<IEnumerable<Agents>> GetAll(string searchpattern)
        {
            var agents = from a in _context.Agents
                         select a;
            if (!string.IsNullOrEmpty(searchpattern))
            {
                agents = agents.Where(x => x.avayaId.Contains(searchpattern)
                                    || x.name.Contains(searchpattern)
                                    || x.surname.Contains(searchpattern));

            }

            return await agents.ToListAsync();

        }

        public async Task<bool> IsValid(Agent agent)
        {
           var result= Task.Run(() => { 
            if (string.IsNullOrEmpty(agent.AvayaId)) return false;
            if (string.IsNullOrEmpty(agent.Name)) return false;
            if (string.IsNullOrEmpty(agent.Surname)) return false;
            if (agent.CountryId == 0) return false;
            if (agent.TeamId == 0) return false;
            return true;
           });
            return await result;
        }

        /// <summary>
        /// Validates the agent doesn't exist in the repository in the combination AvayaID, Name and Surname
        /// It returns true if not combination was found, meaning agent can be added to repository.
        /// </summary>
        /// <param name="avayaid">AvayaID to be search</param>
        /// <param name="name">Agent name to be search</param>
        /// <param name="surname">Agent surname to be search</param>
        /// <returns></returns>
        private async Task<bool> ValidateAgent(string avayaid, string name, string surname)
        {
            var result = await _context.Agents.AsNoTracking().Where(v => v.avayaId == avayaid)
                 .Where(n => n.name == name)
                 .Where(s => s.surname == surname)
                 .Select(x => x.id)
                 .FirstOrDefaultAsync();

            if (result == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
