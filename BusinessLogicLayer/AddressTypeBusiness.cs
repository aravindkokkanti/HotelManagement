﻿using BusinessObjects;
using DataAccessLayer.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogicLayer
{
    public class AddressTypeBusiness
    {
        AddressTypeDataAccess atd = new AddressTypeDataAccess();

        public List<AddressTypeModel> GetAllAddressTypes()
        {
            return atd.GetAllAddressTypes();
        }

        public void AddAddressType(AddressTypeModel atm)
        {
            atd.AddAddressType(atm);
        }

        public AddressTypeModel GetAddressTypeById(int addressTypeId)
        {
            return atd.GetAddressTypeById(addressTypeId);
        }

        public void UpdateAddressType(AddressTypeModel tbladdressType)
        {
            atd.UpdateAddressType(tbladdressType);
        }

        public void DeleteAddressType(int addressTypeId)
        {
            atd.DeleteAddressType(addressTypeId);
        }


    }
}
