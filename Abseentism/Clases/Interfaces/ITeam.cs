using Abseentism.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abseentism.Clases.Interfaces
{
    public interface ITeam
    {
        Task<IEnumerable<Teams>> GetTeamsByCountry(int idCountry );
        Task<IEnumerable<TeamCountryViewModel>> GetAll(string searchPattern);
        Task<bool> AddTeam(Teams team);
        Task<bool> EditTeam(Teams team);
    }
}
