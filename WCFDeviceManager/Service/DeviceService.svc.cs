using System.Data.Services;
using System.Data.Services.Common;
using System.Web;
using WCFDeviceManager.Models;

namespace WCFDeviceManager.Services
{
    [System.ServiceModel.ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class DeviceService : DataService<DeviceDatabaseEntities>
    {
        private const string ADMIN_ROLE = "Administrator";

        public static void InitializeService(DataServiceConfiguration config)
        {
            config.SetEntitySetAccessRule("*", EntitySetRights.All);
            config.SetServiceOperationAccessRule("*", ServiceOperationRights.All);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
            config.UseVerboseErrors = true;
        }

        /// <summary>
        /// Only admin users can modify Albums.
        /// </summary>
        //[ChangeInterceptor("Albums")]
        //public void OnChangeAlbum(Album album, UpdateOperations operations)
        //{
        //    if (!HttpContext.Current.Request.IsAuthenticated || !HttpContext.Current.User.IsInRole(ADMIN_ROLE))
        //        throw new DataServiceException(400, "Albums can only be modified by an administrator.");
        //} 
    }
}
