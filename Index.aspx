<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SmartSetll_Analytics_V2.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>SmartSell | Home</title>

    <link href="css/Style.css" rel="stylesheet" />
    <link href="resources/images/logos/SmartSell-Analytics-Logo.png" rel="icon" />
</head>
<body>
    <form id="indexFormId" runat="server">

        <% /* N: Whole container */ %>
        <div class="page">

            <% /* N: Home COntent */ %>
            <div class="home-page-content">
                <header class="header-content">

                    <% /* N: Navigation Bar */ %>
                    <section class="navbar-section">
                        <div>
                            <p class="navbar-layout">Home</p>
                        </div>
                        <div>
                            <p class="navbar-layout">About</p>
                        </div>
                        <div>
                            <p class="navbar-layout">Feedback</p>
                        </div>
                        <div>
                            <p class="navbar-layout">Terms And Policy</p>
                        </div>
                    </section>

                    <% /* N: Navigation Bard Right Section */ %>
                    <section class="navbar-section">
                        <div>
                            <p class="navbar-layout" onclick="showModalContent('signin-modal-id')">Sign-in</p>
                        </div>
                        <div>
                            <p>|</p>
                        </div>
                        <div>
                            <p class="navbar-layout" onclick="showModalContent('signup-modal-id')">Sign-up</p>
                        </div>
                    </section>
                </header>

                <% /* N: Main Content */ %>
                <main class="main-content">
                    <section class="main-left-content">
                        <div class="logo-content">
                            <div>
                                <img class="img-logo-layout" src="resources/images/logos/SmartSell-Analytics-Logo.png" alt="Alternate Text" />
                            </div>

                            <div class="logo-text-layout">
                                <h1>SmartSell Analytics</h1>
                                <h5>Simplified Financial Model System</h5>
                            </div>
                        </div>

                        <div class="smartsell-definition">
                            <p>The inception of SmartSell Analytics finds its roots in the ever-growing significance of data analytics and financial modeling within contemporary business practices. In an era characterized by rapid technological advancements and an exponential surge in accessible data, businesses must evolve to maintain their competitiveness.</p>
                        </div>

                        <% /* N: Launch SmartSell Analytics */ %>
                        <div class="launch-button-content">
                            <a class="launch-button-layout" href="pages/SmartSell.aspx">Launch</a>
                        </div>
                    </section>

                    <section class="main-right-content">
                        <img class="illustration-layout floating-animation-v2" src="resources/images/illustrations/At the office-amico.png" alt="Alternate Text" />
                    </section>
                </main>
            </div>
        </div>
        <% /* N: End of DIV Page Content */ %>

        <% /* N: Modal Container */ %>
        <div id="signin-modal-id" class="modal-content w3-animate-opacity">

            <% /* N: Signin Modal Content */ %>
            <div class="signin-modal-container w3-animate-zoom">
                <div class="close-content">
                    <p class="close-layout" onclick="closeModalContent('signin-modal-id')">x</p>
                </div>

                <div class="login-content">
                    <h1 class="login-layout">LOGIN HERE</h1>
                </div>

                <div class="login-form-content">
                    <div class="username-content user-pass-content">
                        <div>
                            <img class="signup-icons-layout" src="resources/images/icons/user.png" alt="Alternate Text" />
                        </div>
                        <div>

                            <% /* N: Username Textboxes */ %>
                            <asp:TextBox ID="Txb_Login_Username" CssClass="txb-layout" runat="server" Placeholder="Username" Type="text" />
                        </div>
                    </div>
                    <div class="password-content user-pass-content">
                        <div>
                            <img class="signup-icons-layout" src="resources/images/icons/lock.png" alt="Alternate Text" />
                        </div>
                        <div>

                            <% /* N: Password Textboxes */ %>
                            <asp:TextBox ID="Txb_Login_Password" CssClass="txb-layout" runat="server" Placeholder="Password" Type="password" />
                        </div>
                    </div>
                </div>

                <div class="forgot-content">
                    <asp:Button CssClass="forgot-pass-layout" Text="Forgot Password" runat="server" />
                </div>

                <% /* N: Signin Button */ %>
                <div class="signin-content">
                    <asp:Button ID="Btn_Signin" CssClass="signin-button-layout" Text="Sign-in" runat="server" OnClick="Btn_Signin_Click" />
                </div>
            </div>
        </div>
        <% /* N: End of Div Signin Modal Content */ %>

        <% /* N: Signup Modal Container */ %>
        <div id="signup-modal-id" class="modal-content w3-animate-opacity">

            <% /* N: Signup Modal Content */ %>
            <div class="signup-modal-container w3-animate-zoom">
                <div class="close-content">
                    <p class="close-layout" onclick="closeModalContent('signup-modal-id')">x</p>
                </div>

                <div class="register-content">
                    <section class="illustration-section floating-animation-v2">
                        <img class="signup-illustration-layout" src="resources/images/illustrations/Sign up-amico.png" alt="Alternate Text" />
                    </section>
                    <section class="signup-section">
                        <div class="sign-up-content">
                            <h1 class="login-layout">CREATE ACCOUNT</h1>
                        </div>

                        <% /* N: Signup Form Container */ %>
                        <div class="signup-form-content">

                            <% /* N: Company */%>
                            <div class="sign-up-form-layout">
                                <div>
                                    <img class="signup-icons-layout" src="resources/images/icons/office.png" alt="Alternate Text" />
                                </div>
                                <div>
                                    <asp:TextBox ID="Txb_Company_Name" CssClass="signup-txb-layout" runat="server" Placeholder="Comapny Name" Type="text" />
                                </div>
                            </div>

                            <% /* N: First Name */%>
                            <div class="sign-up-form-layout">
                                <div>
                                    <img class="signup-icons-layout" src="resources/images/icons/profile.png" alt="Alternate Text" />
                                </div>
                                <div>
                                    <asp:TextBox ID="Txb_FirstName" CssClass="signup-txb-layout" runat="server" Placeholder="First Name" Type="text" />
                                </div>
                            </div>

                            <% /* N: Middle Name */%>
                            <div class="sign-up-form-layout">
                                <div>
                                    <img class="signup-icons-layout" src="resources/images/icons/profile.png" alt="Alternate Text" />
                                </div>
                                <div>
                                    <asp:TextBox ID="Txb_MiddleName" CssClass="signup-txb-layout" runat="server" Placeholder="Middle Name" Type="text" />
                                </div>
                            </div>

                            <% /* N: Last Name */%>
                            <div class="sign-up-form-layout">
                                <div>
                                    <img class="signup-icons-layout" src="resources/images/icons/profile.png" alt="Alternate Text" />
                                </div>
                                <div>
                                    <asp:TextBox ID="Txb_LastName" CssClass="signup-txb-layout" runat="server" Placeholder="Last Name" Type="text" />
                                </div>
                            </div>

                            <% /* N: Usename */%>
                            <div class="sign-up-form-layout">
                                <div>
                                    <img class="signup-icons-layout" src="resources/images/icons/user.png" alt="Alternate Text" />
                                </div>
                                <div>
                                    <asp:TextBox ID="Txb_Username" CssClass="signup-txb-layout" runat="server" Placeholder="Username" Type="text" />
                                </div>
                            </div>

                            <% /* N: Password */%>
                            <div class="sign-up-form-layout">
                                <div>
                                    <img class="signup-icons-layout" src="resources/images/icons/lock.png" alt="Alternate Text" />
                                </div>
                                <div>
                                    <asp:TextBox ID="Txb_Password" CssClass="signup-txb-layout" runat="server" Placeholder="Password" Type="password" />
                                </div>
                            </div>

                            <% /* N: Confirm Password */%>
                            <div class="sign-up-form-layout">
                                <div>
                                    <img class="signup-icons-layout" src="resources/images/icons/lock.png" alt="Alternate Text" />
                                </div>
                                <div>
                                    <asp:TextBox ID="Txb_Confirm_Password" CssClass="signup-txb-layout" runat="server" Placeholder=" Confirm Password" Type="password" />
                                </div>
                            </div>

                            <% /* N: Email */%>
                            <div class="sign-up-form-layout">
                                <div>
                                    <img class="signup-icons-layout" src="resources/images/icons/email.png" alt="Alternate Text" />
                                </div>
                                <div>
                                    <asp:TextBox ID="Txb_Email" CssClass="signup-txb-layout" runat="server" Placeholder="Email" Type="text" />
                                </div>
                            </div>

                            <% /* N: Signup Button */%>
                            <div class="signup-form-button-layout">
                                <asp:Button ID="Btn_Sign_Up" CssClass="signup-button-layout" Text="Sign-up" runat="server" OnClick="Btn_Sign_Up_Click" />
                            </div>

                            <div class="terms-agreement-content">
                                <p class="terms-agreement-layout">By Signing up; you agree to SmartSell Analytics Rules. Terms of Services and Privacy Policy.</p>
                            </div>
                        </div>
                    </section>
                </div>
            </div>
        </div>

        <% /* N: Modal For Validation of Login Account using C# Server */ %>
        <% /* N: Login Sucessfully Side Modal Content */ %>
        <div id="loginModalContentID" class="modal-server-side-content w3-animate-opacity" runat="server" visible="false">
            <div class="modal-server-side w3-animate-top">
                <div>
                    <img class="login-notification-icon-layout" src="resources/images/icons/check.png" alt="Alternate Text" />
                </div>

                <div class="notification-login">
                    <div>
                        <asp:Label CssClass="label-notification-layout" Text="LOGIN SUCESSFULLY" runat="server" />
                    </div>

                    <div style="display: flex; justify-content: right;">
                        <asp:Button ID="Btn_Login_Success" CssClass="notification-button login-success-notif" Text="Proceed" runat="server" OnClick="Btn_Login_Success_Click" />
                    </div>
                </div>
            </div>
        </div>

        <% /* N: Login Failed Server Side Modal Content */ %>
        <div id="failedModalContentID" class="modal-server-side-content w3-animate-opacity" runat="server" visible="false">
            <div class="modal-server-side w3-animate-top">
                <div>
                    <img class="login-notification-icon-layout" src="resources/images/icons/notice.png" alt="Alternate Text" />
                </div>

                <div class="notification-login" style="width: 100%;">
                    <div>
                        <asp:Label CssClass="label-notification-layout" Text="LOGIN FAILED" runat="server" />
                    </div>

                    <div>
                        <p style="font-size: 14px;">Please Try Again</p>
                    </div>

                    <div style="display: flex; justify-content: right;">
                        <asp:Button ID="Btn_login_Failed" CssClass="notification-button login-failed-notif" Text="Continue" runat="server" OnClick="Btn_login_Failed_Click" />
                    </div>
                </div>
            </div>
        </div>

        <% /* N: SmartSell Server Side Modal Content */ %>
        <div id="smartsellModalContentID" class="modal-server-side-content w3-animate-opacity" runat="server" visible="false">
            <div class="modal-server-side w3-animate-top">
                <div>
                    <img class="login-notification-icon-layout" src="resources/images/logos/SmartSell-Analytics-Logo.png" alt="Alternate Text" />
                </div>

                <div class="notification-login" style="width: 100%;">
                    <div>
                        <asp:Label CssClass="label-notification-layout" Text="NO SMARTSELL EXIST" runat="server" />
                    </div>

                    <div>
                        <p style="font-size: 14px;">You need to go at SmartSell page first</p>
                    </div>

                    <div style="display: flex; justify-content: right;">
                        <asp:Button CssClass="notification-button smartsell-notif" Text="Launch" runat="server" />
                    </div>
                </div>
            </div>
        </div>

        <% /* ! This Modal Need Functionality */ %>
    </form>

    <script src="js/Script.js"></script>
</body>
</html>
