using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publics
{
   public static class AccountInfor
    {
        private static string idAccount;
        private static string nameAcount;
        private static string addressAcount;
        private static string phoneNumber;

        public static string AddressAcount
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

        public static string PhoneNumber
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

        public static string NameAcount
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

        public static string IdAccount
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
