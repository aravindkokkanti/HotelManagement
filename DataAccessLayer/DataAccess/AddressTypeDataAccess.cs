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

        public AddressTypeModel GetAddressTypeById(int addressTypeId)
        {
            tblAddressType addressType = _Context.tblAddressTypes.Where(x => x.Id == addressTypeId).FirstOrDefault();

            AddressTypeModel addressTypeModel = new AddressTypeModel()
            {
                Name = addressType.Name,
                CREATEDDATE = addressType.CREATEDDATE,
                CREATEDBY = addressType.CREATEDBY,
                ISACTIVE = addressType.ISACTIVE
            };
            return addressTypeModel;
        }

        public void UpdateAddressType(AddressTypeModel addressTypeModel)
        {
            var addressType = _Context.tblAddressTypes.Where(x => x.Id == addressTypeModel.Id).FirstOrDefault();
            if (addressType != null)
            {
                addressType.Name = addressTypeModel.Name;
                addressType.MODIFIEDDATE = DateTime.Now;
                addressType.MODIFIEDBY = 1;
                addressType.ISACTIVE = true;
                _Context.SaveChanges();
            }
        }

        public void DeleteAddressType(int addressTypeId)
        {
            var addressType = _Context.tblAddressTypes.Where(x => x.Id == addressTypeId).FirstOrDefault();
            if (addressType != null)
            {
                addressType.MODIFIEDDATE = DateTime.Now;
                addressType.MODIFIEDBY = 1;
                addressType.ISACTIVE = false;
                _Context.SaveChanges();
            }
            
            _Context.SaveChanges();
        }
    }
}
