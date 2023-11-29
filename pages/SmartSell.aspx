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
                                <a class="navbar-layout" href="../Index.aspx">Home</a>
                            </div>

                            <div>
                                <a class="navbar-layout" href="#" onclick="showSideContent('help-form-id')">Help</a>
                            </div>

                            <div>
                                <a class="navbar-layout" href="../Index.aspx">Rate</a>
                            </div>

                            <div>
                                <a class="navbar-layout" href="#" onclick="showSideContent('login-form-id')">Login</a>
                            </div>
                        </nav>
                    </div>
                </div>
            </header>

            <%-- Main Content --%>
            <main class="main-content">

                <%-- Section Content --%>
                <section class="section-contents">

                    <%-- Capital Days Price Content --%>
                    <div class="section-container capital-days-price-content specific-margin-layout">

                        <%-- Capital --%>
                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/capital.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox ID="Txb_Capital" CssClass="txb-input-layout" runat="server" Placeholder="Capital" />
                            </div>
                        </div>

                        <%-- Number of Days --%>
                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/days.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox ID="Txb_Num_Days" CssClass="txb-input-layout" runat="server" Placeholder="Number of Days" />
                            </div>
                        </div>

                        <%-- Average Price --%>
                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/average-price.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox ID="Txb_Average_Price" CssClass="txb-input-layout" runat="server" Placeholder="Average Price" />
                            </div>
                        </div>
                    </div>

                    <%-- Target Market Daily Target Monthly Sales Content --%>
                    <div class="section-container population-percent-target-daily-content">

                        <%-- Population --%>
                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/population.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox ID="Txb_Population" CssClass="txb-input-layout" runat="server" Placeholder="Population" />
                            </div>
                        </div>

                        <%-- Percent Population --%>
                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/percent-population.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox ID="Txb_Percent_Population" CssClass="txb-input-layout" runat="server" Placeholder="Percent Population" />
                            </div>
                        </div>

                        <%-- Calculate Button --%>
                        <div class="input-contents calculate-button-content">
                            <div class="calcu-content">
                                <div>
                                    <img class="calcu-icons-layout" src="../resources/images/icons/calculator.png" alt="Alternate Text" />
                                </div>

                                <div>
                                    <asp:Button ID="Btn_One_Calculate" CssClass="calcu-layout" Text="Calculate" runat="server" OnClick="Btn_One_Calculate_Click" />
                                </div>
                            </div>
                        </div>
                    </div>

                    <%-- Target Market Daily Section Container --%>
                    <div class="section-container">
                        <%-- Target Market --%>
                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/target-market.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox ID="Txb_Target_Market" CssClass="txb-input-layout" runat="server" Placeholder="Target Market" ReadOnly="True" />
                            </div>
                        </div>

                        <%-- Daily Target --%>
                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/daily-target.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox ID="Txb_Daily_Target" CssClass="txb-input-layout" runat="server" Placeholder="Daily Target" ReadOnly="True" />
                            </div>
                        </div>
                    </div>
                </section>

                <%-- Section Content --%>
                <section class="section-contents">

                    <%-- Sales Per Day Monthly Sales Monthly Salary Content --%>
                    <div class="section-container specific-margin-layout">

                        <%-- Sales Per Day --%>
                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/sales-per-day.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox ID="Txb_Sales_Per_Day" CssClass="txb-input-layout" runat="server" Placeholder="Sales Per Day" ReadOnly="True" />
                            </div>
                        </div>

                        <%-- Monthly Sales --%>
                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/monthly-sales.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox ID="Txb_Monthly_Sales" CssClass="txb-input-layout" runat="server" Placeholder="Monthly Sales" ReadOnly="True" />
                            </div>
                        </div>
                    </div>

                    <%-- Salary Per Day Monthly Salary Monthly Expenses --%>
                    <div class="section-container">

                        <%-- Salary Per Day --%>
                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/salary-per-day.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox ID="Txb_Salary_Per_Day" CssClass="txb-input-layout" runat="server" Placeholder="Salary Per Day" />
                            </div>
                        </div>

                        <%-- Calculate Button --%>
                        <div class="input-contents calculate-button-content">
                            <div class="calcu-content">
                                <div>
                                    <img class="calcu-icons-layout" src="../resources/images/icons/calculator.png" alt="Alternate Text" />
                                </div>

                                <div>
                                    <asp:Button ID="Btn_Two_Calculate" CssClass="calcu-layout" Text="Calculate" runat="server" OnClick="Btn_Two_Calculate_Click" />
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class="section-container">
                        <%-- Monthly Salary --%>
                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/monthly-salary.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox ID="Txb_Monthly_Salary" CssClass="txb-input-layout" runat="server" Placeholder="Monthly Salary" ReadOnly="True" />
                            </div>
                        </div>
                    </div>

                    <div class="section-container">
                        <%-- Monthly Expenses --%>
                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/monthly-expenses.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox ID="Txb_Monthly_Expenses" CssClass="txb-input-layout" runat="server" Placeholder="Monthly Expenses" />
                            </div>
                        </div>

                        <%-- Calculate Button --%>
                        <div class="input-contents calculate-button-content">
                            <div class="calcu-content">
                                <div>
                                    <img class="calcu-icons-layout" src="../resources/images/icons/calculator.png" alt="Alternate Text" />
                                </div>

                                <div>
                                    <asp:Button ID="Btn_Three_Calculate" CssClass="calcu-layout" Text="Calculate" runat="server" OnClick="Btn_Three_Calculate_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </section>

                <%-- Section Content --%>
                <section class="section-contents">
                    <div class="section-container common-content">

                        <%-- Total Expenses --%>
                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/total-expenses.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox ID="Txb_Total_Expenses" CssClass="txb-input-layout" runat="server" Placeholder="Total Expenses" ReadOnly="True" />
                            </div>
                        </div>
                    </div>

                    <div class="section-container common-content specific-margin-layout">

                        <%-- Net Profit --%>
                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/net-profit.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox ID="Txb_Net_Profit" CssClass="txb-input-layout" runat="server" Placeholder="Net Profit" ReadOnly="True" />
                            </div>
                        </div>
                    </div>

                    <div class="section-container common-content">

                        <%-- Return of Investment --%>
                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/return-of-investment.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox ID="Txb_Return_Investment" CssClass="txb-input-layout" runat="server" Placeholder="Return of Investment (ROI)" ReadOnly="True" />
                            </div>
                        </div>
                    </div>

                    <div class="section-container common-content">

                        <%-- ROI Return Prediction --%>
                        <div class="input-contents">
                            <div>
                                <img class="input-icons-layout" src="../resources/images/icons/roi-prediction.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox ID="Txb_Roi_Prediction" CssClass="txb-input-layout" runat="server" Placeholder="ROI Return Prediction" ReadOnly="True" />
                            </div>
                        </div>
                    </div>

                    <%-- Clear And Save Button --%>
                    <div class="clear-n-save-content">
                        <div>
                            <asp:Button ID="Btn_Clear" CssClass="clr-save-layout clear-layout" Text="Clear" runat="server" OnClick="Btn_Clear_Click" />
                        </div>
                        <div>
                            <asp:Button ID="Btn_Save" CssClass="clr-save-layout save-layout" Text="Save" runat="server" OnClick="Btn_Save_Click" />
                        </div>
                    </div>
                </section>

                <%-- Side Form Content --%>
                <section class="section-contents">
                    <div id="help-form-id" class="section-container side-form-content w3-animate-right" style="display: none;">
                        <div>
                            <h3 class="close-button-layout" onclick="closeSideContent('help-form-id')">X</h3>
                        </div>
                        <div class="help-form-content">
                            <h2 class="section-contents-header">HELP</h2>
                        </div>
                    </div>

                    <div id="login-form-id" class="section-container side-form-content login-form-layout w3-animate-bottom" style="display: none;">
                        <div>
                            <h3 class="close-button-layout" onclick="closeSideContent('login-form-id')">X</h3>
                        </div>

                        <div>
                            <h2 class="section-contents-header">LOGIN HERE</h2>
                        </div>
                        <div class="login-form-content">
                            <div>
                                <img class="login-icon-layout" src="../resources/images/icons/user.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox ID="Txb_Login_Username" CssClass="txb-input-layout" runat="server" Placeholder="Username" />
                            </div>
                        </div>

                        <div class="login-form-content">
                            <div>
                                <img class="login-icon-layout" src="../resources/images/icons/lock.png" alt="Alternate Text" />
                            </div>
                            <div>
                                <asp:TextBox ID="Txb_Login_Password" CssClass="txb-input-layout" runat="server" Placeholder="Password" TextMode="password" />
                            </div>
                        </div>

                        <div class="login-form-content">
                            <div class="login-button-layout">
                                <asp:Button ID="Btn_Login" CssClass="signin-button-layout" Text="Login" runat="server" OnClick="Btn_Login_Click" />
                            </div>
                        </div>

                    </div>
                </section>
            </main>
        </div>
    </form>

    <script src="../js/Script.js"></script>
</body>
</html>
