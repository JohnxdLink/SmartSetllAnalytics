using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartSetll_Analytics_V2.classes
{
    public class GetSetRegisteredAccount
    {
        private string companyName = "";
        
        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        private string firstName = "";

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string middleName = "";

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        private string lastName = "";

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string userName = "";

        public string UserName
        {
            get { return UserName; }
            set { UserName = value; }
        }

        private string password = "";

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string confirmPassword = "";

        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set { confirmPassword = value; }
        }

    }
}