using System.Security.Policy;
using Newtonsoft.Json;
using PrintApplication.Interfaces;

namespace PrintApplication.PrintViewModel
{
    public class AboutViewModel : IApplicationMappable<AboutViewModel>
    {
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        public AboutViewModel PopulateFromApplication(string dbString, int appId)
        {
            // get info from db
            var app = new DbContext(dbString, appId);
            LastName = app.NAME_LAST;
            FirstName = app.NAME_FIRST;
            return this;
        }

        public AboutViewModel PersistByApplication(string dbString, int appId)
        {
            throw new System.NotImplementedException();
        }
    }
}
