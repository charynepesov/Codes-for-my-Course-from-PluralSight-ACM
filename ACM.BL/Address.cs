using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Address
    {
        public Address()
        {

        }
        public Address(int addressId)
        {
            this.AddressId = addressId;
        }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
        public string AddressType { get; set; }
        public int AddressId { get; private set; }

        /// <summary>
        /// Validates the address data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            bool isValid = true;

            if (PostalCode == null) isValid = false;

            return isValid;
        }
    }
}
