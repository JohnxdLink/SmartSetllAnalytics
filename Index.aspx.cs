using SmartSetll_Analytics_V2.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartSetll_Analytics_V2
{
    public partial class Index : System.Web.UI.Page
    {
        GetSetRegisteredAccount getSetRegisteredAccount = new GetSetRegisteredAccount();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Btn_Sign_Up_Click(object sender, EventArgs e)
        {
            getSetRegisteredAccount.CompanyName = Txb_Company_Name.Text;
            getSetRegisteredAccount.FirstName = Txb_FirstName.Text;
            getSetRegisteredAccount.MiddleName = Txb_MiddleName.Text;
            getSetRegisteredAccount.LastName = Txb_LastName.Text;
            getSetRegisteredAccount.UserName = Txb_Username.Text;
            getSetRegisteredAccount.Password = Txb_Password.Text;
            getSetRegisteredAccount.ConfirmPassword = Txb_Confirm_Password.Text;
            getSetRegisteredAccount.Email = Txb_Email.Text;
        }
    }
}