using System;

namespace PrintApplication.Interfaces
{
    /// <summary>
    /// generating view model from database for user based on ID
    /// </summary>
    /// <typeparam name="Tmodel"></typeparam>
    public interface IApplicationMappable <out Tmodel>
    {
        Tmodel PopulateFromApplication(string dbString, int appId);
        Tmodel PersistByApplication(string dbString, int appId);
    }
}
