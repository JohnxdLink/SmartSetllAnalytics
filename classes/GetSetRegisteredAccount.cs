using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartSetll_Analytics_V2.classes
{
    public class GetSetRegisteredAccount
    {
        private string companyName = ""; // ! Private Company Name Empty Field
        
        // ? Get Set Company Name
        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        private string firstName = ""; // ! Private First Name Empty Field

        // ? Get Set First Name
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string middleName = ""; // ! Private Middle Name Empty Field

        // ? Get Set Middle Name
        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        private string lastName = ""; // ! Private Last Name Empty Field

        // ? Get Set Last Name
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string userName = ""; // ! Private USername Empty Field

        // ? Get Set Username
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string password = ""; // ! Private Password Empty Field

        // ? Get SEt Password
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string confirmPassword = ""; // ! Private Confirm Password Empty Field

        // ? Get Set Confirm Password
        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set { confirmPassword = value; }
        }

        private string email = ""; // ! Private Email Empty Field

        // ? Get Set Email
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}