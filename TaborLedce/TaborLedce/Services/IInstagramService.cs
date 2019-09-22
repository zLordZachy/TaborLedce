using System.Threading.Tasks;
using TaborLedce.Models;

namespace TaborLedce.Services
{
    public interface IInstagramService
    {
        Task<RootObject> GetInstagramMetadata();
    }
}
