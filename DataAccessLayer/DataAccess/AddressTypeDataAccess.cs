using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataAccess
{
     public class AddressTypeDataAccess
    {
        HotelManagement_Context _Context = new HotelManagement_Context();
        public List<AddressTypeModel> GetAllAddressTypes()
        {
            List<tblAddressType> addressTypeList = _Context.tblAddressTypes.ToList();
            List<AddressTypeModel> addressTypeListBo = new List<AddressTypeModel>();
            //addressTypeListBo = addressTypeList;

            foreach (tblAddressType addressType in addressTypeList)
            {
                AddressTypeModel addressTypeModel = new AddressTypeModel
                {
                    Id = addressType.Id,
                    Name = addressType.Name,
                    CREATEDBY=addressType.CREATEDBY,
                    CREATEDDATE=addressType.CREATEDDATE,
                    MODIFIEDBY=addressType.MODIFIEDBY,
                    MODIFIEDDATE=addressType.MODIFIEDDATE,
                    ISACTIVE = addressType.ISACTIVE

                };
                addressTypeListBo.Add(addressTypeModel);
            }

            return addressTypeListBo;

        }

        public void AddAddressType(AddressTypeModel tblAddressType)
        {
            tblAddressType tat = new tblAddressType()
            {
                Name = tblAddressType.Name,
                ISACTIVE = tblAddressType.ISACTIVE,
                CREATEDDATE = tblAddressType.CREATEDDATE,
                CREATEDBY = tblAddressType.CREATEDBY
            };
            _Context.tblAddressTypes.Add(tat);
            _Context.SaveChanges();
        }       
    }
}
