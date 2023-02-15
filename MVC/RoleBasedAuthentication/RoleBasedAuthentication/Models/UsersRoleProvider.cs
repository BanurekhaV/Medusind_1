using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using RoleBasedAuthentication.Models;

namespace RoleBasedAuthentication.Models
{
    public class UsersRoleProvider : RoleProvider
    {
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            using(SecurityDBEntities db= new SecurityDBEntities())
            {
                var userroles = (from u in db.Users
                                 join urm in db.UserRoleMappings
                                 on u.ID equals urm.UserID
                                 join role in db.RoleMasters
                                 on urm.RoleID equals role.ID
                                 where u.UserName == username
                                 select role.RoleName).ToArray();
                return userroles;
            }
            
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}