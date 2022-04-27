using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using BoatsMontenegro.Models;

namespace BoatsMontenegro.CustomAuthentication
{
    public class CustomMembershipUser : MembershipUser
    {
        #region User Properties
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role RoleName { get; set; }
        #endregion


        public CustomMembershipUser(User user) : base("CustomMembership", user.Username, user.UserID, user.Email, string.Empty, string.Empty, true, false, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now)
        {
            UserId = user.UserID;
            FirstName = user.FirstName;
            LastName = user.LastName;
            RoleName = user.Role;
        }
    }
}
