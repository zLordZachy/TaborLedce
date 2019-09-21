using System.Collections.Generic;
using TaborLedce.Models;

namespace TaborLedce.Services
{
    public interface ILocalDataManager
    {
        void SaveTransaltions(List<TranslationItem> localDataDTO);
        List<TranslationItem> LoadTransalations();
    }
}
