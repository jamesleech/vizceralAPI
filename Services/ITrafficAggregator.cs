using System.Threading.Tasks;
using VizceralAPI.Models;

namespace VizceralAPI.Services
{
    public interface ITrafficAggregator
    {
        Task<Traffic> Latest(int minutes);
    }
}