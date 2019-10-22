using System.Collections.ObjectModel;
using TaborLedce.Models;
using TaborLedce.Resources;

namespace TaborLedce.ViewModels
{
    public class MarchingMarksViewModel : BaseViewModel
    {
        public ObservableCollection<MarchingMarks> MarchingMarks { get; set; }

        public MarchingMarksViewModel()
        {
            MarchingMarks = new ObservableCollection<MarchingMarks>();
            MarchingMarksResource resource = MarchingMarksResource.Instance;
            foreach (MarchingMarks marchingMarkse in resource.Data)
            {
                MarchingMarks.Add(marchingMarkse);
            }
        }
    }
}
