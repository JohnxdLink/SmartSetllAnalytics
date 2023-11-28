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
        RetrieveUserAccount getRetrieveAccount = new RetrieveUserAccount();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Signin_Click(object sender, EventArgs e)
        {
            string username = Txb_Login_Username.Text;
            string password = Txb_Login_Password.Text;

            var loginResult = getRetrieveAccount.Retrieve_User_Account(username, password);

            if (loginResult.Item1) //  Check if login is successful
            {
                // Store the company ID and company name in session for later use
                Session["Company_ID"] = loginResult.Item2;
                Session["Company_Name"] = loginResult.Item3;

                loginModalContentID.Visible = true;
            }
            else
            {
                failedModalContentID.Visible = true;
            }
        }

        protected void Btn_Login_Success_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/pages/User.aspx");
        }

        protected void Btn_login_Failed_Click(object sender, EventArgs e)
        {
            failedModalContentID.Visible = false;
        }

        protected void Btn_Sign_Up_Click(object sender, EventArgs e)
        {
            // N: Instanstiating InsetGeneralSmartSellDAta
            InsertGeneralSmartSellData obj_InsertAccount = new InsertGeneralSmartSellData();

            getSetRegisteredAccount.CompanyName = Txb_Company_Name.Text; getSetRegisteredAccount.FirstName = Txb_FirstName.Text; getSetRegisteredAccount.MiddleName = Txb_MiddleName.Text; getSetRegisteredAccount.LastName = Txb_LastName.Text; getSetRegisteredAccount.UserName = Txb_Username.Text; getSetRegisteredAccount.Password = Txb_Password.Text; getSetRegisteredAccount.ConfirmPassword = Txb_Confirm_Password.Text; getSetRegisteredAccount.Email = Txb_Email.Text;
            obj_InsertAccount.Insert_Registered_Account(getSetRegisteredAccount.CompanyName, getSetRegisteredAccount.FirstName, getSetRegisteredAccount.MiddleName, getSetRegisteredAccount.LastName, getSetRegisteredAccount.UserName, getSetRegisteredAccount.Password, getSetRegisteredAccount.ConfirmPassword, getSetRegisteredAccount.Email);
        }
    }
}