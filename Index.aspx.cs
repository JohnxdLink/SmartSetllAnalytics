using SmartSetll_Analytics_V2.classes;
using System;

namespace SmartSetll_Analytics_V2
{
    /* 
    * Project: SmartSell Analytics
    * Developer: Castro JOhn Christian
    * Message: starting Working Backend at Index Page
    * Date Started: 11/25/2023
    */

    public partial class Index : System.Web.UI.Page
    {
        GetSetRegisteredAccount getSetRegisteredAccount = new GetSetRegisteredAccount();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Btn_Sign_Up_Click(object sender, EventArgs e)
        {
            // N: Instanstiating InsetGeneralSmartSellDAta
            InsertGeneralSmartSellData obj_InsertAccount = new InsertGeneralSmartSellData();

            getSetRegisteredAccount.CompanyName = Txb_Company_Name.Text;
            getSetRegisteredAccount.FirstName = Txb_FirstName.Text;
            getSetRegisteredAccount.MiddleName = Txb_MiddleName.Text;
            getSetRegisteredAccount.LastName = Txb_LastName.Text;
            getSetRegisteredAccount.UserName = Txb_Username.Text;
            getSetRegisteredAccount.Password = Txb_Password.Text;
            getSetRegisteredAccount.ConfirmPassword = Txb_Confirm_Password.Text;
            getSetRegisteredAccount.Email = Txb_Email.Text;

            obj_InsertAccount.Insert_Registered_Account(getSetRegisteredAccount.CompanyName, getSetRegisteredAccount.FirstName, getSetRegisteredAccount.MiddleName, getSetRegisteredAccount.LastName, getSetRegisteredAccount.UserName, getSetRegisteredAccount.Password, getSetRegisteredAccount.ConfirmPassword, getSetRegisteredAccount.Email);
        }
    }
}