using Abseentism.Data;
using Abseentism.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abseentism.Clases.Interfaces
{
   public interface IAgent
    {
        // bool ValidateAgent(string avayaid, string name, string surname);
       Task<bool> AddAgent(Agent agent);
         Task<IEnumerable<Agents>> GetAll(string searchpattern);
         Task<IEnumerable<FullAgentViewModel>> GetAgentsFullDetails(string searchpattern);
         Task<bool> EditAgent(Agent agent);
         Task<bool> IsValid(Agent agent);

        Task<IEnumerable<Agent>> GetAgentsByTeam(int country, int team);
        
    }
}
