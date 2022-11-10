using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataAccess
{
    public class RoleDataAccess
    {
        HotelManagement_Context _Context = new HotelManagement_Context();

        public List<RoleModel> GetAllRoles()
        {
            List<tblRole> roleList = _Context.tblRoles.ToList();
            List<RoleModel> roleListBo = new List<RoleModel>();
           

            foreach (tblRole role in roleList)
            {
                RoleModel roleModel = new RoleModel
                {
                    Id = role.Id,
                    Name = role.Name,
                    CREATEDBY = role.CREATEDBY,
                    CREATEDDATE = role.CREATEDDATE,
                    MODIFIEDBY = role.MODIFIEDBY,
                    MODIFIEDDATE = role.MODIFIEDDATE,
                    ISACTIVE = role.ISACTIVE

                };
                roleListBo.Add(roleModel);
            }

            return roleListBo;

        }

        public void AddRole(RoleModel tblRole)
        {
            tblRole tR = new tblRole()
            {
                Name = tblRole.Name,
                Code=tblRole.Code,
                ISACTIVE = tblRole.ISACTIVE,
                CREATEDDATE = tblRole.CREATEDDATE,
                CREATEDBY = tblRole.CREATEDBY
            };
            _Context.tblRoles.Add(tR);
            _Context.SaveChanges();
        }

        public RoleModel GetRoleById(int roleId)
        {
            tblRole role = _Context.tblRoles.Where(x => x.Id == roleId).FirstOrDefault();

            RoleModel roleModel = new RoleModel()
            {
                Name = role.Name,
                CREATEDDATE = role.CREATEDDATE,
                CREATEDBY = role.CREATEDBY,
                ISACTIVE = role.ISACTIVE
            };
            return roleModel;
        }

        public void UpdateRole(RoleModel roleModel)
        {
            var role = _Context.tblRoles.Where(x => x.Id == roleModel.Id).FirstOrDefault();
            if (role != null)
            {
                role.Name = roleModel.Name;
                role.MODIFIEDDATE = DateTime.Now;
                role.MODIFIEDBY = 1;
                role.ISACTIVE = true;
                _Context.SaveChanges();
            }
        }

        public void DeleteRole(int roleId)
        {
            var role = _Context.tblRoles.Where(x => x.Id == roleId).FirstOrDefault();
            if (role != null)
            {
                role.MODIFIEDDATE = DateTime.Now;
                role.MODIFIEDBY = 1;
                role.ISACTIVE = false;
                _Context.SaveChanges();
            }

            _Context.SaveChanges();
        }

    }
}
