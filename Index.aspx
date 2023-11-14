<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SmartSetll_Analytics_V2.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>SmartSell | Home</title>

    <link href="css/Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="page">
            <div class="home-page-content">
                <header class="header-content">
                    <section class="navbar-section">
                        <div>
                            <p class="navbar-layout">Home</p>
                        </div>
                        <div>
                            <p class="navbar-layout">About</p>
                        </div>
                        <div>
                            <p class="navbar-layout">Contact</p>
                        </div>
                        <div>
                            <p class="navbar-layout">Feedback</p>
                        </div>
                    </section>

                    <section class="navbar-section">
                        <div>
                            <p class="navbar-layout">Sign-in</p>
                        </div>
                        <div>
                            <p>|</p>
                        </div>
                        <div>
                            <p class="navbar-layout">Sign-up</p>
                        </div>
                    </section>
                </header>

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

                        <div class="launch-button-content">
                            <asp:Button CssClass="launch-button-layout" Text="Launch" runat="server" />
                        </div>
                    </section>

                    <section class="main-right-content">
                        <img class="illustration-layout floating-animation-v2" src="resources/images/illustrations/At the office-amico.png" alt="Alternate Text" />
                    </section>
                </main>
            </div>
        </div>
    </form>

    <script src="js/Script.js"></script>
</body>
</html>
