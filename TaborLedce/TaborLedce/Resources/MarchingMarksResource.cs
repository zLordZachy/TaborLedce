using TaborLedce.Models;

namespace TaborLedce.Resources
{
    public class MarchingMarksResource : ResourcesLoader<MarchingMarksResource, MarchingMarks>
    {
        public MarchingMarksResource()
        {
            LoadResources("MarchingMarks.json");
        }
    }
}
