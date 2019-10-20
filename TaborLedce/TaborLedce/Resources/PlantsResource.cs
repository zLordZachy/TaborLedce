using TaborLedce.Models;

namespace TaborLedce.Resources
{
    public class PlantsResource : ResourcesLoader<PlantsResource,Plant>
    {
        public PlantsResource()
        {
            LoadResources("Plants.json");
        }
    }
}
