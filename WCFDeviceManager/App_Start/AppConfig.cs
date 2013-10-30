using System.Web.Security;
using WCFDeviceManager.Filters;
using WebMatrix.WebData;

namespace WCFDeviceManager
{
    public static class AppConfig
    {
        public static void Configure()
        {
            System.Data.Entity.Database.DefaultConnectionFactory.CreateConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Isaac\Projects\DeviceManagerWeb\WCFDeviceManager\App_Data\DeviceDatabase.mdf;Integrated Security=True");

            CreateAdminUser();
        }

        private static void CreateAdminUser()
        {
            const string username = "Owner";
            const string password = "p@ssword123";
            const string role = "Administrator";

            new InitializeSimpleMembershipAttribute().OnActionExecuting(null);

            if (!WebSecurity.UserExists(username))
                WebSecurity.CreateUserAndAccount(username, password);

            if (!Roles.RoleExists(role))
                Roles.CreateRole(role);

            if (!Roles.IsUserInRole(username, role))
                Roles.AddUserToRole(username, role);
        }
    }
}