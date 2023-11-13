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
            <section class="home-content">
                <header class="header-content">
                    <div class="logo-content">
                        <div class="logo-image-content">
                            <img class="logo-layout" src="resources/images/logos/SmartSell-Analytics-Logo.png" alt="Alternate Text" />
                        </div>

                        <div class="logo-name-content">
                            <h1 class="logo-text-layout">SmartSell Analytics</h1>
                            <h5 class="logo-subtext-layout">Simplified Financial Model System</h5>
                        </div>
                    </div>

                    <div class="login-signup-content">
                        <div><p class="p-login-button-layout">Sign-in</p></div>
                        <div><p>|</p></div>
                        <div><p class="p-login-button-layout">Sign-up</p></div>
                    </div>
                </header>

                <main class="main-content">
                    <main class="main-section-content">
                        <div class="home-details-content">
                            <p class="details-layout">SmartSell Analytics is a groundbreaking digital platform poised to reshape how businesses approach financial analysis and decision-making. At its core, this undertaking revolves around the development and implementation of an advanced financial model. This model harnesses market intelligence and user inputs to precisely estimate ROI, compute monthly sales, and evaluate net profit.</p>
                            <div class="launch-button-content">
                                <asp:Button CssClass="launch-button-layout" Text="Launch" runat="server" />
                            </div>
                        </div>

                        <div class="illustration-content">
                            <img class="illustration-layout" src="resources/images/illustrations/Shared-workspace-amico.png"" alt="Alternate Text" />
                        </div>
                    </main>
                </main>
            </section>
        </div>

        <script src="js/Script.js"></script>
    </form>
</body>
</html>
