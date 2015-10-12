using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrintApplication.Interfaces;

namespace PrintApplication.PrintViewModel
{
    public class ApplicationViewModel<TEducationViewModel, TTestScoresViewModel> :
        IApplicationMappable<ApplicationViewModel<TEducationViewModel, TTestScoresViewModel>>
        where TEducationViewModel : IApplicationMappable<TEducationViewModel>, new()
        where TTestScoresViewModel : IApplicationMappable<TTestScoresViewModel>, new()
    {
        public TEducationViewModel Academic { get; set; }
        public TTestScoresViewModel Tests { get; set; }
        public AboutViewModel About { get; set; }

        public ApplicationViewModel()
        {
            About = new AboutViewModel();
            Tests = new TTestScoresViewModel();
            Academic = new TEducationViewModel();
        } 

        public ApplicationViewModel<TEducationViewModel, TTestScoresViewModel> PopulateFromApplication(string dbString,
        int appId)
        {
            About.PopulateFromApplication(dbString, appId);
            Academic.PopulateFromApplication(dbString, appId);
            Tests.PopulateFromApplication(dbString, appId);
            return this;
        }

        public ApplicationViewModel<TEducationViewModel, TTestScoresViewModel> PersistByApplication(string dbString,
            int appId)
        {
            throw new NotImplementedException();
        }
    }
}
