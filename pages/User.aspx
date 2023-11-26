<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="SmartSetll_Analytics_V2.pages.User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

    <title> SmartSell | Dashboard</title>

    <link href="../css/User-Style.css" rel="stylesheet" />
    <link rel="icon" href="../resources/images/logos/SmartSell-Analytics-Logo.png" />
</head>
<body>
    <form id="userFormId" runat="server">
        <div class="page">
            <div calss="whole-page">
                <header class="header-content">

                    <section class="section-logo">
                        <img class="logo-layout" src="../resources/images/logos/SmartSell-Analytics-Logo.png" alt="Alternate Text" />
                    </section>

                    <section class="section-user-profile">
                        <div class="user-profile-layout">
                            <div>
                                <img class="icon-layout" src="../resources/images/icons/face-id.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:Label Text="Company ID" runat="server" />
                            </div>
                        </div>

                        <div class="user-profile-layout">
                            <div>
                                <img class="icon-layout" src="../resources/images/icons/corporate.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:Label Text="Company Name" runat="server" />
                            </div>
                        </div>

                        <div class="user-profile-layout">
                            <div>
                                <img class="icon-layout" src="../resources/images/icons/user.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:Label Text="Username" runat="server" />
                            </div>
                        </div>
                    </section>
                </header>

                <main class="main-content">
                    <section class="nav-section">
                        <div class="nav-bar-layout">
                            <div>
                                <img class="nav-icon-layout" src="../resources/images/icons/home.png" alt="Alternate Text" />
                            </div>

                            <div>
                                <img class="nav-icon-layout" src="../resources/images/icons/roi-prediction.png" alt="Alternate Text" />
                            </div>

                            <div>
                                <img class="nav-icon-layout" src="../resources/images/icons/best-customer-experience.png" alt="Alternate Text" />
                            </div>

                            <div>
                                <img class="nav-icon-layout" src="../resources/images/icons/questions.png" alt="Alternate Text" />
                            </div>
                        </div>

                        <div class="nav-bar-layout">
                            <div>
                                <img class="nav-icon-layout" src="../resources/images/icons/setting.png" alt="Alternate Text" />
                            </div>

                            <div>
                                <img class="nav-icon-layout" src="../resources/images/icons/logout.png" alt="Alternate Text" />
                            </div>
                        </div>
                    </section>
                    <section class="main-section">

                    </section>
                </mai>
            </div>
        </div>
    </form>
</body>
</html>
