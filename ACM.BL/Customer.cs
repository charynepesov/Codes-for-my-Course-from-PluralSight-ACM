using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public Customer(): this(0)
        {

        }
        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            this.AddressList = new List<Address>();
        }
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public List<Address> AddressList { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        // Backing field of LastName property
        private string _lastName;
        public string LastName 
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public static int InstanceCount { get; set; }
        public override string ToString() => FullName;
        /// <summary>
        /// Validates the customer data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
