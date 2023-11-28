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

        <% /* N: Whole Container */ %>
        <div class="page">
            <section class="nav-bar-section">
                <div class="logo-content">
                    <img class="logo-layout" src="../resources/images/logos/SmartSell-Analytics-Logo.png" alt="Alternate Text" />
                </div>

                <% /* N: Navigation Bar */ %>
                <div class="separated-nav-bar">

                    <% /* N: Navigation Bar on Top */ %>
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

                    <% /* N: Navigation Bar on Bottom */ %>
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

            <% /* N: Main Section */ %>
            <section class="main-section" runat="server">

                <% /* N: Home Content */ %>
                <div id="homeContentID" class="home-content main-content" runat="server" visible="false">

                    <% /* N: Header that contain Home Label, Company Name and Company ID */ %>
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

                            <% /* ! This is where you can manipulate the company name and id through its label ID */ %>
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

                    <% /* N: Home Main Section */ %>
                    <main class="home-main-section">

                        <% /* N: Section One: Capital, Days, Average PRice, Population, Percent Population, Daily Target, Monthyly Target */ %>
                        <section class="section-one">

                            <% /* N: Capital Section */ %>
                            <div class="simplified-layout">
                                <div class="simplified-icon-n-label">
                                    <div>
                                        <img class="colored-icons-layout" src="../resources/images/colored-icons/capital-icon.png" alt="Alternate Text" />
                                    </div>

                                    <div>

                                        <% /* ! Capital: Manipulate the Text via ID */ %>
                                        <div>
                                            <asp:Label CssClass="label-layout" Text="0000.00" runat="server" />
                                        </div>
                                        <div>
                                            <p style="font-size: 14px;">Capital</p>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <% /* N: Days Open Section */ %>
                            <div class="simplified-layout">
                                <div class="simplified-icon-n-label">
                                    <div>
                                        <img class="colored-icons-layout" src="../resources/images/colored-icons/days-icon.png" alt="Alternate Text" />
                                    </div>

                                    <div>
                                        <% /* ! Days: Manipulate the Text via ID */ %>
                                        <div>
                                            <asp:Label CssClass="label-layout" Text="0000.00" runat="server" />
                                        </div>
                                        <div>
                                            <p style="font-size: 14px;">Days Open</p>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <% /* N: Average Price Section */ %>
                            <div class="simplified-layout">
                                <div class="simplified-icon-n-label">
                                    <div>
                                        <img class="colored-icons-layout" src="../resources/images/colored-icons/average-price-icon.png" alt="Alternate Text" />
                                    </div>

                                    <div>

                                        <% /* ! Average Price: Manipulate the Text via ID */ %>
                                        <div>
                                            <asp:Label CssClass="label-layout" Text="0000.00" runat="server" />
                                        </div>
                                        <div>
                                            <p style="font-size: 14px;">Average Price</p>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <% /* N: Population Section */ %>
                            <div class="simplified-layout">
                                <div class="simplified-icon-n-label">
                                    <div>
                                        <img class="colored-icons-layout" src="../resources/images/colored-icons/population-icon.png" alt="Alternate Text" />
                                    </div>

                                    <div>

                                        <% /* ! Population:: Manipulate the Text via ID  */ %>
                                        <div>
                                            <asp:Label CssClass="label-layout" Text="0000.00" runat="server" />
                                        </div>
                                        <div>
                                            <p style="font-size: 14px;">Population</p>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <% /* N: Percent Population Section */ %>
                            <div class="simplified-layout">
                                <div class="simplified-icon-n-label">
                                    <div>
                                        <img class="colored-icons-layout" src="../resources/images/colored-icons/percent-population-icon.png" alt="Alternate Text" />
                                    </div>

                                    <div>

                                        <% /* ! Percent Population: Manipulate the Text via ID  */ %>
                                        <div>
                                            <asp:Label CssClass="label-layout" Text="0000.00" runat="server" />
                                        </div>
                                        <div>
                                            <p style="font-size: 14px;">Percent Population</p>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <% /* N: Daily Target Section */ %>
                            <div class="simplified-layout">
                                <div class="simplified-icon-n-label">
                                    <div>
                                        <img class="colored-icons-layout" src="../resources/images/colored-icons/daily-target-icon.png" alt="Alternate Text" />
                                    </div>

                                    <div>

                                        <% /* ! Daily Target: Manipulate the Text via ID */ %>
                                        <div>
                                            <asp:Label CssClass="label-layout" Text="0000.00" runat="server" />
                                        </div>
                                        <div>
                                            <p style="font-size: 14px;">Daily Target</p>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <% /* N: Monthly Target Section */ %>
                            <div class="simplified-layout">
                                <div class="simplified-icon-n-label">
                                    <div>
                                        <img class="colored-icons-layout" src="../resources/images/colored-icons/target-market-icon.png" alt="Alternate Text" />
                                    </div>

                                    <div>

                                        <% /* ! Monthly Target: Manipulate the Text via ID */ %>
                                        <div>
                                            <asp:Label CssClass="label-layout" Text="0000.00" runat="server" />
                                        </div>
                                        <div>
                                            <p style="font-size: 14px;">Monthly Target</p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </section> <% /* N: End of Section One */ %>

                        <% /* N: Section Two: Sales Per Day, Monthly Sales, Salary Per Day, Monthly Salary, MOnthly Expenses */ %>
                        <section class="section-two">

                            <% /* N: Sales Per Day Section */ %>
                            <div class="simplified-layout">
                                <div class="simplified-icon-n-label">
                                    <div>
                                        <img class="colored-icons-layout" src="../resources/images/colored-icons/sales-per-day-icon.png" alt="Alternate Text" />
                                    </div>

                                    <div>
                                        <% /* ! Sales Per Day: Manipulate the Text via ID */ %>
                                        <div>
                                            <asp:Label CssClass="label-layout" Text="0000.00" runat="server" />
                                        </div>
                                        <div>
                                            <p style="font-size: 14px;">Sales Per Day</p>
                                        </div>
                                    </div>
                                </div>
                            </div>


                            <% /* N: Monthly Sales Section */ %>
                            <div class="simplified-layout">
                                <div class="simplified-icon-n-label">
                                    <div>
                                        <img class="colored-icons-layout" src="../resources/images/colored-icons/gross-income-icon.png" alt="Alternate Text" />
                                    </div>

                                    <div>

                                        <% /* ! Monthly Sales: Manipulate the Text via ID  */ %>
                                        <div>
                                            <asp:Label CssClass="label-layout" Text="0000.00" runat="server" />
                                        </div>
                                        <div>
                                            <p style="font-size: 14px;">Monthly Sales</p>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="simplified-layout">
                                <div class="simplified-icon-n-label">
                                    <div>
                                        <img class="colored-icons-layout" src="../resources/images/colored-icons/salary-icon.png" alt="Alternate Text" />
                                    </div>

                                    <div>
                                        <div>
                                            <asp:Label CssClass="label-layout" Text="0000.00" runat="server" />
                                        </div>
                                        <div>
                                            <p style="font-size: 14px;">Salary Per Day</p>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <% /* N: Monthly Salary Section */ %>
                            <div class="simplified-layout">
                                <div class="simplified-icon-n-label">
                                    <div>
                                        <img class="colored-icons-layout" src="../resources/images/colored-icons/monthly-salary-icon.png" alt="Alternate Text" />
                                    </div>

                                    <div>

                                        <% /* ! Monthly Salary: Manipulate the Text via ID */ %>
                                        <div>
                                            <asp:Label CssClass="label-layout" Text="0000.00" runat="server" />
                                        </div>
                                        <div>
                                            <p style="font-size: 14px;">Monthly Salary</p>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <% /* N: Monthly Expenses Section */ %>
                            <div class="simplified-layout">
                                <div class="simplified-icon-n-label">
                                    <div>
                                        <img class="colored-icons-layout" src="../resources/images/colored-icons/fixed-expenses-icon.png" alt="Alternate Text" />
                                    </div>

                                    <div>

                                        <% /* ! Monthly Expenses: Manipulate the Text via ID */ %>
                                        <div>
                                            <asp:Label CssClass="label-layout" Text="0000.00" runat="server" />
                                        </div>
                                        <div>
                                            <p style="font-size: 14px;">Monthly Expenses</p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </section> <% /* N: End of Section Two */ %>

                        <% /* N: Section Three: Total Expenses, Net Profit */ %>
                        <section class="section-three">

                            <% /* N: Total Expenses Section */ %>
                            <div class="simplified-layout" style="margin-top: 20%;">
                                <div class="simplified-icon-n-label">
                                    <div>
                                        <img class="colored-icons-layout" src="../resources/images/colored-icons/total-expenses-icon.png" alt="Alternate Text" />
                                    </div>

                                    <div>

                                        <% /* ! Total Expenses: Manipulate the Text via ID */ %>
                                        <div>
                                            <asp:Label CssClass="label-layout" Text="0000.00" runat="server" />
                                        </div>
                                        <div>
                                            <p style="font-size: 14px;">Total Expenses</p>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <% /* N: Net Profit Section */ %>
                            <div class="simplified-layout">
                                <div class="simplified-icon-n-label">
                                    <div>
                                        <img class="colored-icons-layout" src="../resources/images/colored-icons/gross-profit-icon.png" alt="Alternate Text" />
                                    </div>

                                    <div>

                                        <% /* ! Net Profit: Manipulate the Text via ID */ %>
                                        <div>
                                            <asp:Label CssClass="label-layout" Text="0000.00" runat="server" />
                                        </div>
                                        <div>
                                            <p style="font-size: 14px;">Net Profit</p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </section> <% /* N: End of Section Three */ %>


                        <% /* N: Section Four: Return of Investmen, ROI Prediction Year */ %>
                        <section class="section-four">

                            <% /* N: Return of Investment Section */ %>
                            <div class="simplified-layout" style="margin-top: 20%;">
                                <div class="simplified-icon-n-label">
                                    <div>
                                        <img class="colored-icons-layout" src="../resources/images/colored-icons/roi-percentage-icon.png" alt="Alternate Text" />
                                    </div>

                                    <div>

                                        <% /* ! Return of Investment: Manipulate the Text via ID */ %>
                                        <div>
                                            <asp:Label CssClass="label-layout" Text="0000.00" runat="server" />
                                        </div>
                                        <div>
                                            <p style="font-size: 14px;">Return of Investment (ROI)</p>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <% /* N: ROI Prediction Year Section */ %>
                            <div class="simplified-layout">
                                <div class="simplified-icon-n-label">
                                    <div>
                                        <img class="colored-icons-layout" src="../resources/images/colored-icons/return-of-investment-icon.png" alt="Alternate Text" />
                                    </div>

                                    <div>

                                        <% /* ! ROI Prediction Year: Manipulate the Text via ID */ %>
                                        <div>
                                            <asp:Label CssClass="label-layout" Text="0000.00" runat="server" />
                                        </div>
                                        <div>
                                            <p style="font-size: 14px;">ROI Prediction Year</p>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <% /* N: SmartSell Button to prceed to SmartSell.aspx */ %>
                            <div class="simplified-layout">
                                <asp:Button ID="Btn_Go_SmartSell" CssClass="smartsell-button-layout" Text="Go to SmartSell" runat="server" OnClick="Btn_Go_SmartSell_Click" />
                            </div>
                        </section> <% /* N: End of Section Four */ %>
                    </main> <% /* N: End of Home Main Section */ %>
                </div>

                <% /* N: Capital Content */ %>
                <div id="capitalContentID" class="capital-content main-content" runat="server" visible="false">
                    <h2>Capital</h2>
                </div>

                <% /* N: Monthly Content */ %>
                <div id="monthlyContentID" class="monthly-content main-content" runat="server" visible="false">
                    <h2>Monthly</h2>
                </div>

                <% /* N: Feedback Content */ %>
                <div id="feedbackContentID" class="feedback-content main-content" runat="server" visible="false">
                    <h2>Feedback</h2>
                </div>

                <% /* N: Manual Content */ %>
                <div id="manualContentID" class="manual-content main-content" runat="server" visible="false">
                    <h2>Manual</h2>
                </div>

                <% /* N: Profile Content */ %>
                <div id="profileContentID" class="profile-content main-content" runat="server" visible="false">
                    <h2>Profile</h2>
                </div>
            </section> <% /* N: End of MAin Section */ %>
        </div>
    </form>

    <script src="../js/UserScript.js"></script>
</body>
</html>
