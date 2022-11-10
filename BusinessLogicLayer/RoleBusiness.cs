using BusinessObjects;
using DataAccessLayer.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class RoleBusiness
    {
        RoleDataAccess rda = new RoleDataAccess();
        public List<RoleModel> GetAllRoles()
        {
            return rda.GetAllRoles();
        }

        public void AddRole(RoleModel roleModel)
        {
            rda.AddRole(roleModel);
        }

        public RoleModel GetRoleById(int roleId)
        {
            return rda.GetRoleById(roleId);
        }

        public void UpdateRole(RoleModel tblrole)
        {
            rda.UpdateRole(tblrole);
        }

        public void DeleteRole(int roleId)
        {
            rda.DeleteRole(roleId);
        }
    }
}
