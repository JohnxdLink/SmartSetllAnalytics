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

        <%-- Whole Container --%>
        <div class="page">

            <%-- Home Content --%>
            <div class="home-page-content">
                <header class="header-content">

                    <%-- Naviation Bar --%>
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

                    <%-- Navigation Bard Right Section --%>
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

                <%-- Main Content --%>
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

                        <%-- Launch SmartSell Analytics --%>
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
        <!-- End of Div Page Content -->

        <%-- Modal Container --%>
        <div id="signin-modal-id" class="modal-content w3-animate-opacity">

            <%-- Signin Modal Content --%>
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
                            <asp:TextBox CssClass="txb-layout" runat="server" Placeholder="Username" Type="text" />
                        </div>
                    </div>
                    <div class="password-content user-pass-content">
                        <div>
                            <img class="signup-icons-layout" src="resources/images/icons/lock.png" alt="Alternate Text" />
                        </div>
                        <div>
                            <asp:TextBox CssClass="txb-layout" runat="server" Placeholder="Password" Type="password" />
                        </div>
                    </div>
                </div>

                <div class="forgot-content">
                    <asp:Button CssClass="forgot-pass-layout" Text="Forgot Password" runat="server" />
                </div>

                <div class="signin-content">
                    <asp:Button CssClass="signin-button-layout" Text="Sign-in" runat="server" />
                </div>
            </div>
        </div>
        <%-- End of Div Signin Modal Content --%>

        <%-- Signup Modal Container --%>
        <div id="signup-modal-id" class="modal-content w3-animate-opacity">

            <%-- Signup Modal Content --%>
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

                        <%-- Signup Form Container --%>
                        <div class="signup-form-content">

                            <%-- Company --%>
                            <div class="sign-up-form-layout">
                                <div>
                                    <img class="signup-icons-layout" src="resources/images/icons/office.png" alt="Alternate Text" />
                                </div>
                                <div>
                                    <asp:TextBox CssClass="signup-txb-layout" runat="server" Placeholder="Comapny Name" Type="text" />
                                </div>
                            </div>

                            <%-- First Name --%>
                            <div class="sign-up-form-layout">
                                <div>
                                    <img class="signup-icons-layout" src="resources/images/icons/profile.png" alt="Alternate Text" />
                                </div>
                                <div>
                                    <asp:TextBox CssClass="signup-txb-layout" runat="server" Placeholder="First Name" Type="text" />
                                </div>
                            </div>

                            <%-- Middle Name --%>
                            <div class="sign-up-form-layout">
                                <div>
                                    <img class="signup-icons-layout" src="resources/images/icons/profile.png" alt="Alternate Text" />
                                </div>
                                <div>
                                    <asp:TextBox CssClass="signup-txb-layout" runat="server" Placeholder="Middle Name" Type="text" />
                                </div>
                            </div>

                            <%-- Middle Name --%>
                            <div class="sign-up-form-layout">
                                <div>
                                    <img class="signup-icons-layout" src="resources/images/icons/profile.png" alt="Alternate Text" />
                                </div>
                                <div>
                                    <asp:TextBox CssClass="signup-txb-layout" runat="server" Placeholder="Last Name" Type="text" />
                                </div>
                            </div>

                            <%-- Username --%>
                            <div class="sign-up-form-layout">
                                <div>
                                    <img class="signup-icons-layout" src="resources/images/icons/user.png" alt="Alternate Text" />
                                </div>
                                <div>
                                    <asp:TextBox CssClass="signup-txb-layout" runat="server" Placeholder="Username" Type="text" />
                                </div>
                            </div>

                            <%-- Password --%>
                            <div class="sign-up-form-layout">
                                <div>
                                    <img class="signup-icons-layout" src="resources/images/icons/lock.png" alt="Alternate Text" />
                                </div>
                                <div>
                                    <asp:TextBox CssClass="signup-txb-layout" runat="server" Placeholder="Password" Type="password" />
                                </div>
                            </div>

                            <%-- Email --%>
                            <div class="sign-up-form-layout">
                                <div>
                                    <img class="signup-icons-layout" src="resources/images/icons/email.png" alt="Alternate Text" />
                                </div>
                                <div>
                                    <asp:TextBox CssClass="signup-txb-layout" runat="server" Placeholder="Email" Type="text" />
                                </div>
                            </div>

                            <%-- By Signing up; you agree to SmartSell Analytics Rules. Terms of Services and Privacy Policy. --%>

                            <%-- Signup Button --%>
                            <div class="signup-form-button-layout">
                                <asp:Button CssClass="signup-button-layout" Text="Sign-up" runat="server" />
                            </div>

                            <div class="terms-agreement-content">
                                <p class="terms-agreement-layout">By Signing up; you agree to SmartSell Analytics Rules. Terms of Services and Privacy Policy.</p>
                            </div>
                        </div>
                    </section>
                </div>
            </div>
        </div>
    </form>

    <script src="js/Script.js"></script>
</body>
</html>
