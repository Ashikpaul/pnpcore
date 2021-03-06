using System.Linq;

namespace PnP.Core.Model.SharePoint
{
    /// <summary>
    /// Public interface to define a collection of TimeZone objects
    /// </summary>
    public interface ITimeZoneCollection : IQueryable<ITimeZone>, IDataModelCollection<ITimeZone>
    {
    }
}