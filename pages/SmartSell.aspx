<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SmartSell.aspx.cs" Inherits="SmartSetll_Analytics_V2.pages.SmartSell" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>SmartSell | Launch</title>

    <link href="../css/SmartSell-Style.css" rel="stylesheet" />
    <link rel="icon" href="../resources/images/logos/SmartSell-Analytics-Logo.png" />
</head>
<body>
    <form id="smartsellFormId" runat="server">
        <div class="smartsell-page">
            <header class="header-content">
                <div class="logo-content">
                    <div>
                        <img class="logo-layout" src="../resources/images/logos/SmartSell-Analytics-Logo.png" alt="Alternate Text" />
                    </div>
                    <div class="logo-text-navbar-content">
                        <div>
                            <h3 class="header-text-layout">SmartSell-Analytics</h3>
                            <h5 class="sub-header-text-layout">Simplified Financial Model System</h5>
                        </div>

                        <nav class="navigation-bar-content">
                            <div>
                                <asp:LinkButton CssClass="navbar-layout" Text="Home" runat="server" Width="50" />
                            </div>

                            <div>
                                <asp:LinkButton CssClass="navbar-layout" Text="About" runat="server" Width="50" />
                            </div>

                            <div>
                                <asp:LinkButton CssClass="navbar-layout" Text="Login" runat="server" Width="50" />
                            </div>
                        </nav>
                    </div>
                </div>
            </header>

            <main class="main-content">
            </main>
        </div>
    </form>
</body>
</html>
