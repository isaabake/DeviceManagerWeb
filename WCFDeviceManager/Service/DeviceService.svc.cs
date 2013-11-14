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

        [ChangeInterceptor("Devices")]
        public void OnChangeDevice(Device device, UpdateOperations operations)
        {
            //if (!HttpContext.Current.Request.IsAuthenticated || !HttpContext.Current.User.IsInRole(ADMIN_ROLE))
            //    throw new DataServiceException(400, "Devices can only be modified by an administrator.");
        }

        [ChangeInterceptor("Nodes")]
        public void OnChangeAlbum(Node node, UpdateOperations operations)
        {
            //if (!HttpContext.Current.Request.IsAuthenticated || !HttpContext.Current.User.IsInRole(ADMIN_ROLE))
            //    throw new DataServiceException(400, "Devices can only be modified by an administrator.");
        }

        [ChangeInterceptor("Connections")]
        public void OnChangeAlbum(Connection connection, UpdateOperations operations)
        {
            //if (!HttpContext.Current.Request.IsAuthenticated || !HttpContext.Current.User.IsInRole(ADMIN_ROLE))
            //    throw new DataServiceException(400, "Devices can only be modified by an administrator.");
        }
        
        [ChangeInterceptor("ConnectionTypes")]
        public void OnChangeAlbum(ConnectionType connectionType, UpdateOperations operations)
        {
            //if (!HttpContext.Current.Request.IsAuthenticated || !HttpContext.Current.User.IsInRole(ADMIN_ROLE))
            //    throw new DataServiceException(400, "Devices can only be modified by an administrator.");
        }

        [ChangeInterceptor("DeviceTypes")]
        public void OnChangeAlbum(DeviceType deviceType, UpdateOperations operations)
        {
            //if (!HttpContext.Current.Request.IsAuthenticated || !HttpContext.Current.User.IsInRole(ADMIN_ROLE))
            //    throw new DataServiceException(400, "Devices can only be modified by an administrator.");
        }

        [ChangeInterceptor("Documents")]
        public void OnChangeAlbum(Document document, UpdateOperations operations)
        {
            //if (!HttpContext.Current.Request.IsAuthenticated || !HttpContext.Current.User.IsInRole(ADMIN_ROLE))
            //    throw new DataServiceException(400, "Devices can only be modified by an administrator.");
        }

        [ChangeInterceptor("Folders")]
        public void OnChangeAlbum(Folder folder, UpdateOperations operations)
        {
            //if (!HttpContext.Current.Request.IsAuthenticated || !HttpContext.Current.User.IsInRole(ADMIN_ROLE))
            //    throw new DataServiceException(400, "Devices can only be modified by an administrator.");
        }


    }
}
