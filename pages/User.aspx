<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="SmartSetll_Analytics_V2.pages.User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

    <title>SmartSell | Dashboard</title>

    <link href="../css/User-Style.css" rel="stylesheet" />
    <link rel="icon" href="../resources/images/logos/SmartSell-Analytics-Logo.png" />
</head>
<body>
    <form id="userFormId" runat="server">

        <%-- Whole Page --%>
        <div class="page">
            <section class="nav-bar-section">
                <div class="logo-content">
                    <img class="logo-layout" src="../resources/images/logos/SmartSell-Analytics-Logo.png" alt="Alternate Text" />
                </div>

                <div class="separated-nav-bar">
                    <section class="nav-section">
                        <div>
                            <asp:ImageButton ID="Img_Btn_Home" CssClass="nav-icon-layout" ImageUrl="~/resources/images/icons/home.png" runat="server" OnClick="Btn_Home_Click" />
                        </div>

                        <div>
                            <asp:ImageButton ID="Img_Btn_Capital" CssClass="nav-icon-layout" ImageUrl="~/resources/images/icons/capital.png" runat="server" OnClick="Btn_Capital_Click" />
                        </div>

                        <div>
                            <asp:ImageButton ID="Img_Btn_Monthly" CssClass="nav-icon-layout" ImageUrl="~/resources/images/icons/roi-prediction.png" runat="server" OnClick="Btn_Monthly_Click" />
                        </div>

                        <div>
                            <asp:ImageButton ID="Img_Btn_Feedback" CssClass="nav-icon-layout" ImageUrl="~/resources/images/icons/best-customer-experience.png" runat="server" OnClick="Btn_Feedback_Click" />
                        </div>

                        <div>
                            <asp:ImageButton ID="Img_Btn_Manual" CssClass="nav-icon-layout" ImageUrl="~/resources/images/icons/questions.png" runat="server" OnClick="Btn_Manual_Click" />
                        </div>
                    </section>

                    <section class="nav-section">
                        <div>
                            <asp:ImageButton ID="Img_Btn_Profile" CssClass="nav-icon-layout" ImageUrl="~/resources/images/icons/profile.png" runat="server" OnClick="Btn_Profile_Click" />
                        </div>

                        <div>
                            <asp:ImageButton ID="Img_Btn_Logout" CssClass="nav-icon-layout" ImageUrl="~/resources/images/icons/logout.png" runat="server" OnClick="Btn_Logout_Click" />
                        </div>
                    </section>
                </div>
            </section>

            <section class="main-section" runat="server">

                <div id="homeContentID" class="home-content main-content" runat="server" visible="false">
                    <header class="header-section">
                        <div class="left-section">
                            <div>
                                <img class="header-icon-layout" src="../resources/images/icons/home.png" alt="Alternate Text" />
                            </div>

                            <div>
                                <h1>Home</h1>
                            </div>
                        </div>

                        <div class="right-section">
                            <div>
                                <img class="header-icon-layout" src="../resources/images/icons/corporate.png" alt="Alternate Text" />
                            </div>
                            <div class="company-n-id-section">
                                <div>
                                    <asp:Label CssClass="company-name-layout" Text="Company Name" runat="server" />
                                </div>
                                <div>
                                    <asp:Label CssClass="company-id-layout" Text="Company ID" runat="server" />
                                </div>

                            </div>
                        </div>
                    </header>
                </div>
                <div id="capitalContentID" class="capital-content main-content" runat="server" visible="false">
                    <h2>Capital</h2>
                </div>

                <div id="monthlyContentID" class="monthly-content main-content" runat="server" visible="false">
                    <h2>Monthly</h2>
                </div>

                <div id="feedbackContentID" class="feedback-content main-content" runat="server" visible="false">
                    <h2>Feedback</h2>
                </div>

                <div id="manualContentID" class="manual-content main-content" runat="server" visible="false">
                    <h2>Manual</h2>
                </div>

                <div id="profileContentID" class="profile-content main-content" runat="server" visible="false">
                    <h2>Profile</h2>
                </div>
            </section>
        </div>
    </form>

    <script src="../js/UserScript.js"></script>
</body>
</html>
