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
                <div class="division-header">
                    <div class="left-section">
                        <div>
                            <asp:Label ID="Lbl_Navigation" CssClass="header-lbl-layout" Text="HOME | SMARTSELL" runat="server" />
                        </div>
                    </div>

                    <div class="right-section">
                        <div>
                            <img class="header-icon-layout" src="../resources/images/icons/corporate.png" alt="Alternate Text" />
                        </div>

                        <% /* ! This is where you can manipulate the company name and id through its label ID */ %>
                        <div class="company-n-id-section">
                            <div>
                                <asp:Label ID="Lbl_Company_Name" CssClass="company-name-layout" Text="Company Name" runat="server" />
                            </div>
                            <div>
                                <asp:Label Text="ID: " CssClass="company-id-layout" runat="server" />
                                <asp:Label ID="Lbl_Company_ID" CssClass="company-id-layout" Text="Company ID" runat="server" />
                            </div>
                        </div>

                    </div>
                </div>

                <div class="division-main">
                    <% /* N: Home Content */ %>
                    <div id="homeContentID" class="home-content main-content" runat="server" visible="false">

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
                                                <asp:Label ID="Lbl_Capital" CssClass="label-layout" Text="0000.00" runat="server" />
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
                                                <asp:Label ID="Lbl_Num_Days" CssClass="label-layout" Text="00" runat="server" />
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
                                                <asp:Label ID="Lbl_Average_Price" CssClass="label-layout" Text="0000.00" runat="server" />
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
                                                <asp:Label ID="Lbl_Population" CssClass="label-layout" Text="00" runat="server" />
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
                                                <asp:Label ID="Lbl_Percent_Population" CssClass="label-layout" Text="00" runat="server" />
                                            </div>
                                            <div>
                                                <p style="font-size: 14px;">Percent Population</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <% /* N: Target Market Section */ %>
                                <div class="simplified-layout">
                                    <div class="simplified-icon-n-label">
                                        <div>
                                            <img class="colored-icons-layout" src="../resources/images/colored-icons/daily-target-icon.png" alt="Alternate Text" />
                                        </div>

                                        <div>

                                            <% /* ! Target Market: Manipulate the Text via ID */ %>
                                            <div>
                                                <asp:Label ID="Lbl_Target_Market" CssClass="label-layout" Text="00" runat="server" />
                                            </div>
                                            <div>
                                                <p style="font-size: 14px;">Daily Target</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <% /* N: Daily Target Section */ %>
                                <div class="simplified-layout">
                                    <div class="simplified-icon-n-label">
                                        <div>
                                            <img class="colored-icons-layout" src="../resources/images/colored-icons/target-market-icon.png" alt="Alternate Text" />
                                        </div>

                                        <div>

                                            <% /* ! Daily Target: Manipulate the Text via ID */ %>
                                            <div>
                                                <asp:Label ID="Lbl_Daily_Target" CssClass="label-layout" Text="00" runat="server" />
                                            </div>
                                            <div>
                                                <p style="font-size: 14px;">Daily Target</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </section>
                            <% /* N: End of Section One */ %>

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
                                                <asp:Label ID="Lbl_Sales_Per_Day" CssClass="label-layout" Text="0000.00" runat="server" />
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
                                                <asp:Label ID="Lbl_Monthly_Sales" CssClass="label-layout" Text="0000.00" runat="server" />
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
                                                <asp:Label ID="Lbl_Salary_Per_Day" CssClass="label-layout" Text="0000.00" runat="server" />
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
                                                <asp:Label ID="Lbl_Monthly_Salary" CssClass="label-layout" Text="0000.00" runat="server" />
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
                                                <asp:Label ID="Lbl_Monthly_Expenses" CssClass="label-layout" Text="0000.00" runat="server" />
                                            </div>
                                            <div>
                                                <p style="font-size: 14px;">Monthly Expenses</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </section>
                            <% /* N: End of Section Two */ %>

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
                                                <asp:Label ID="Lbl_Total_Expenses" CssClass="label-layout" Text="0000.00" runat="server" />
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
                                                <asp:Label ID="Lbl_Net_Profit" CssClass="label-layout" Text="0000.00" runat="server" />
                                            </div>
                                            <div>
                                                <p style="font-size: 14px;">Net Profit</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </section>
                            <% /* N: End of Section Three */ %>


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
                                                <asp:Label ID="Lbl_Return_Investment" CssClass="label-layout" Text="0000.00" runat="server" />
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
                                                <asp:Label ID="Lbl_Roi_Prediction" CssClass="label-layout" Text="0000.00" runat="server" />
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
                            </section>
                            <% /* N: End of Section Four */ %>
                        </main>
                        <% /* N: End of Home Main Section */ %>
                    </div>

                    <% /* N: Capital Content */ %>
                    <div id="capitalContentID" class="capital-content main-content" runat="server" visible="false">
                        <main class="capital-main-section">
                            <section class="capital-section-input">
                                <div class="capital-input-fields">
                                    <div>
                                        <img class="small-icons-layouts" src="../resources/images/icons/user.png" alt="Alternate Text" />
                                    </div>

                                    <div>
                                        <asp:TextBox ID="Txb_Item_Qty" CssClass="capital-input-field-layout" runat="server" Placeholder="Quantity" />
                                    </div>
                                </div>

                                <div class="capital-input-fields">
                                    <div>
                                        <img class="small-icons-layouts" src="../resources/images/icons/user.png" alt="Alternate Text" />
                                    </div>

                                    <div>
                                        <asp:TextBox ID="Txb_Item_Name" CssClass="capital-input-field-layout" runat="server" Placeholder="Item Name" Width="300" />
                                    </div>
                                </div>

                                <div class="capital-input-fields">
                                    <div>
                                        <img class="small-icons-layouts" src="../resources/images/icons/user.png" alt="Alternate Text" />
                                    </div>

                                    <div>
                                        <asp:TextBox ID="Txb_Item_Price" CssClass="capital-input-field-layout" runat="server" Placeholder="Price" />
                                    </div>
                                </div>

                                <div class="capital-input-fields">
                                    <div>
                                        <asp:Button ID="Btn_Capital_Add_Item" CssClass="capital-button-layout" Text="Add Item" runat="server" OnClick="Btn_Capital_Add_Item_Click" />
                                    </div>
                                </div>
                            </section>

                            <section class="capital-section-table">
                                <div class="datagrid-content-layout">
                                    <asp:GridView ID="Gridvw_Capital" CssClass="gridview-capital-layout" runat="server" AutoGenerateColumns="false">
                                        <HeaderStyle CssClass="gridview-header" />
                                        <AlternatingRowStyle CssClass="gridview-alternating-row" />

                                        <RowStyle CssClass="gridview-row" />
                                        <Columns>
                                            <asp:BoundField DataField="Item_Qty" HeaderText="Quantity" SortExpression="Quantity" ItemStyle-CssClass="gridview-cell" />
                                            <asp:BoundField DataField="Item_Name" HeaderText="Equipment Name" SortExpression="EquipmentName" ItemStyle-CssClass="gridview-cell" />
                                            <asp:BoundField DataField="Item_Price" HeaderText="Equipment Price" SortExpression="EquipmentPrice" ItemStyle-CssClass="gridview-cell" />
                                        </Columns>
                                    </asp:GridView>
                                </div>
                            </section>
                        </main>
                    </div>

                    <% /* N: Monthly Content */ %>
                    <div id="monthlyContentID" class="monthly-content main-content" runat="server" visible="false">
                        <section class="monthly-section">
                            <div class="datagrid-content-layout">
                                <asp:GridView ID="GridView1" CssClass="gridview-capital-layout" runat="server" AutoGenerateColumns="false">
                                    <HeaderStyle CssClass="gridview-header" />
                                    <AlternatingRowStyle CssClass="gridview-alternating-row" />

                                    <RowStyle CssClass="gridview-row" />
                                    <Columns>
                                        <asp:BoundField DataField="Month_SmartSell" HeaderText="Month" SortExpression="Month" ItemStyle-CssClass="gridview-cell" />
                                        <asp:BoundField DataField="Monthly_Sales" HeaderText="Monthly Sales" SortExpression="MonthlySales" ItemStyle-CssClass="gridview-cell" />
                                        <asp:BoundField DataField="Monthly_Salary" HeaderText="Monthly Salary" SortExpression="MonthlySalary" ItemStyle-CssClass="gridview-cell" />
                                        <asp:BoundField DataField="Monthly_Expenses" HeaderText="Monthly Expenses" SortExpression="MonthlyExpenses" ItemStyle-CssClass="gridview-cell" />
                                        <asp:BoundField DataField="Total_Expenses" HeaderText="Total Expenses" SortExpression="TotalExpenses" ItemStyle-CssClass="gridview-cell" />
                                        <asp:BoundField DataField="Net_Profit" HeaderText="Net Profit" SortExpression="NetProfit" ItemStyle-CssClass="gridview-cell" />
                                        <asp:BoundField DataField="Return_Investment" HeaderText="Return Investment" SortExpression="ReturnInvestment" ItemStyle-CssClass="gridview-cell" />
                                        <asp:BoundField DataField="Roi_Prediction" HeaderText="ROI Prediction" SortExpression="RoiPrediction" ItemStyle-CssClass="gridview-cell" />
                                    </Columns>
                                </asp:GridView>
                            </div>

                        </section>

                        <section class="monthly-input">
                            <main class="monthly-input-main">
                                <div>
                                    <h1>REAL TIME MONTHLY FIELDS</h1>
                                </div>

                                <div class="monthly-input-fields">
                                    <div>
                                        <img class="monthly-input-icon" src="../resources/images/icons/user.png" alt="Alternate Text" />
                                    </div>

                                    <div class="monthly-input-div">
                                        <div>
                                            <h4 style="color: #ffffff">Month</h4>
                                        </div>
                                        <div>
                                            <asp:TextBox ID="Txb_Month" CssClass="txb-monthly-input-layout" runat="server" Width="200" />
                                        </div>
                                    </div>
                                </div>

                                <div class="monthly-input-fields">
                                    <div>
                                        <img class="monthly-input-icon" src="../resources/images/icons/monthly-sales.png" alt="Alternate Text" />
                                    </div>

                                    <div class="monthly-input-div">
                                        <div>
                                            <h4 style="color: #ffffff">Monthly Sales</h4>
                                        </div>
                                        <div>
                                            <asp:TextBox ID="Txb_Rl_MonthlySales" CssClass="txb-monthly-input-layout" runat="server" Width="200" />
                                        </div>
                                    </div>
                                </div>

                                <div class="monthly-input-fields">
                                    <div>
                                        <img class="monthly-input-icon" src="../resources/images/icons/monthly-salary.png" alt="Alternate Text" />
                                    </div>

                                    <div class="monthly-input-div">
                                        <div>
                                            <h4 style="color: #ffffff">Monthly Salary</h4>
                                        </div>
                                        <div>
                                            <asp:TextBox ID="Txb_Rl_MonthlySalary" CssClass="txb-monthly-input-layout" runat="server" Width="200" />
                                        </div>
                                    </div>
                                </div>

                                <div class="monthly-input-fields">
                                    <div>
                                        <img class="monthly-input-icon" src="../resources/images/icons/monthly-expenses.png" alt="Alternate Text" />
                                    </div>

                                    <div class="monthly-input-div">
                                        <div>
                                            <h4 style="color: #ffffff">Monthly Expenses</h4>
                                        </div>
                                        <div>
                                            <asp:TextBox ID="Txb_Rl_MonthlyExpenses" CssClass="txb-monthly-input-layout" runat="server" Width="200" />
                                        </div>
                                    </div>
                                </div>

                                <div>
                                    <asp:Button ID="Btn_Real_Monthly" CssClass="smartsell-button-layout" Text="Save" runat="server" Width="130" OnClick="Btn_Real_Monthly_Click" />
                                </div>
                            </main>
                        </section>
                    </div>

                    <% /* N: Feedback Content */ %>
                    <div id="feedbackContentID" class="feedback-content main-content" runat="server" visible="false">
                    </div>

                    <% /* N: Manual Content */ %>
                    <div id="manualContentID" class="manual-content main-content" runat="server" visible="false">
                    </div>

                    <% /* N: Profile Content */ %>
                    <div id="profileContentID" class="profile-content main-content" runat="server" visible="false">
                    </div>
                </div>


            </section>
            <% /* N: End of MAin Section */ %>
        </div>
    </form>

    <script src="../js/UserScript.js"></script>
</body>
</html>
