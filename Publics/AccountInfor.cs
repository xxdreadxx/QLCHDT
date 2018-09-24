using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publics
{
   public class AccountInfor
    {
        private string idAccount;
        private string nameAcount;
        private string addressAcount;
        private string phoneNumber;

        public string AddressAcount
        {
            get
            {
                return addressAcount;
            }

            set
            {
                addressAcount = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        public string NameAcount
        {
            get
            {
                return nameAcount;
            }

            set
            {
                nameAcount = value;
            }
        }

        public string IdAccount
        {
            get
            {
                return idAccount;
            }

            set
            {
                idAccount = value;
            }
        }
    }
}
