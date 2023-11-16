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
                                <asp:LinkButton CssClass="navbar-layout" Text="Home" runat="server" Width="70" />
                            </div>

                            <div>
                                <asp:LinkButton CssClass="navbar-layout" Text="About" runat="server" Width="70" />
                            </div>

                            <div>
                                <asp:LinkButton CssClass="navbar-layout" Text="Login" runat="server" Width="70" />
                            </div>
                        </nav>
                    </div>
                </div>
            </header>

            <main class="main-content">
                <section class="section-contents">
                    <div class="section-container capital-days-price-content">
                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/user.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox CssClass="txb-input-layout" runat="server" Placeholder="Capital" />
                            </div>
                        </div>

                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/user.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox CssClass="txb-input-layout" runat="server" Placeholder="Number of Days" />
                            </div>
                        </div>

                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/user.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox CssClass="txb-input-layout" runat="server" Placeholder="Average Price" />
                            </div>
                        </div>
                    </div>

                    <div class="section-container population-percent-target-daily-content">
                        <div class="input-contents help-content">
                            <p class="help-layout">Help</p>
                        </div>

                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/user.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox CssClass="txb-input-layout" runat="server" Placeholder="Population" />
                            </div>
                        </div>

                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/user.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox CssClass="txb-input-layout" runat="server" Placeholder="Percent Population" />
                            </div>
                        </div>

                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/user.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox CssClass="txb-input-layout" runat="server" Placeholder="Target Market" />
                            </div>
                        </div>

                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/user.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox CssClass="txb-input-layout" runat="server" Placeholder="Daily Target" />
                            </div>
                        </div>
                    </div>
                </section>

                <section class="section-contents">
                    <div class="section-container sales-monthly-content">
                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/user.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox CssClass="txb-input-layout" runat="server" Placeholder="Sales Per Day" />
                            </div>
                        </div>

                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/user.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox CssClass="txb-input-layout" runat="server" Placeholder="Monthly Sales" />
                            </div>
                        </div>
                    </div>

                    <div class="section-container monthly-salary-expenses-content">
                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/user.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox CssClass="txb-input-layout" runat="server" Placeholder="Salary Per Day" />
                            </div>
                        </div>

                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/user.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox CssClass="txb-input-layout" runat="server" Placeholder="Monthly Salary" />
                            </div>
                        </div>

                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/user.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox CssClass="txb-input-layout" runat="server" Placeholder="Monthly Expenses" />
                            </div>
                        </div>
                    </div>
                </section>

                <section class="section-contents">
                    <div class="section-container common-content">
                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/user.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox CssClass="txb-input-layout" runat="server" Placeholder="Total Expenses" />
                            </div>
                        </div>
                    </div>

                    <div class="section-container common-content">
                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/user.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox CssClass="txb-input-layout" runat="server" Placeholder="Net Profit" />
                            </div>
                        </div>
                    </div>

                    <div class="section-container common-content">
                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/user.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox CssClass="txb-input-layout" runat="server" Placeholder="Return of Investment (ROI)" />
                            </div>
                        </div>
                    </div>

                    <div class="section-container common-content">
                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/user.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox CssClass="txb-input-layout" runat="server" Placeholder="ROI Return Prediction" />
                            </div>
                        </div>
                    </div>
                </section>
            </main>
        </div>
    </form>
</body>
</html>
