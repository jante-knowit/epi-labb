using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using System;
using System.Linq;
using System.Web.Security;

namespace Labb.Business
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class InitializationModule : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            if (Membership.GetAllUsers().Count == 0)
            {
                Roles.CreateRole("Administrators");
                var user = Membership.CreateUser("admin", "Password123!");
                user.IsApproved = true;

                Roles.AddUserToRole("admin", "Administrators");
            }
        }

        public void Uninitialize(InitializationEngine context)
        {
            //Add uninitialization logic
        }
    }
}