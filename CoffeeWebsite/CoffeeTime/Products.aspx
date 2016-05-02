<%@ Language="C#" AutoEventWireup="true" CodeFile="Products.aspx.cs" Inherits="CoffeeWebsite.CoffeeTime.Products" %>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <meta name="description" content="">
    <meta name="author" content="">
    <link rel="icon" href="icon/coffee-bean-icon.png">

    <style>
        body { background-image: url(images/background_beans.jpg); }

        .auto-style1 {
            font-size: 60pt;
            height: 119px;
        }

        .auto-style2 {
            color: #000000;
            float: left;
            font-size: 18px;
            height: 50px;
            line-height: 20px;
            padding: 15px 15px;
        }

        .auto-style3 {
            color: #000000;
            font-size: 60pt;
            height: 119px;
        }

        .auto-style4 { color: #000000; }
        </style>

    <title>Coffee Time</title>

    <!-- Bootstrap core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom styles for this template -->
    <link href="css/starter-template.css" rel="stylesheet">

</head>

<body>

<form id="form1" runat="server">

    <nav class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="auto-style2" href="Home.aspx">Coffee Time</a>
            </div>
            <div id="navbar" class="collapse navbar-collapse">
                <ul class="nav navbar-nav">
                    <li class="active">
                        <a href="Home.aspx">Home</a>
                    </li>
                    <li>
                        <a href="Products.aspx">Products</a>
                    </li>
                    <li>
                        <a href="LogIn.aspx">Log In</a>
                    </li>
                    <li>
                        <a href="Contact.aspx">Contact Us</a>
                    </li>
                </ul>
            </div><!--/.nav-collapse -->
        </div>
    </nav>

    <div class="container">

        <div class="starter-template">
            <h1 class="auto-style1">
                <img src="icon/coffee-bean-icon.png" alt=""/><span class="auto-style3"> Coffee Time</span></h1>
            &nbsp;
        </div>
        <!-- /.container -->


        <!-- Bootstrap core JavaScript
        ================================================== -->
        <!-- Placed at the end of the document so the pages load faster -->
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
        <script>window.jQuery || document.write('<script src="../../assets/js/vendor/jquery.min.js"><\/script>')</script>
        <script src="javascript/bootstrap.min.js"></script>
    </div>

    <h1 class="auto-style4">List of all Available Coffee Bean Products</h1>
    <p class="auto-style4">&nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Antigua&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Breve&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Columbian&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Harar&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Java&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Kenyan&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Monsoon
    </p>
    <div style="margin-left: 40px">
        <asp:Image ID="Image1" runat="server" ImageUrl="images/Antigua.jpg"/>
        &nbsp;&nbsp;
        <asp:Image ID="Image2" runat="server" ImageUrl="images/Breve.JPG"/>
        &nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image3" runat="server" ImageUrl="images/Columbian.jpg"/>
        &nbsp;&nbsp;
        <asp:Image ID="Image6" runat="server" ImageUrl="images/Harar.jpg"/>
        &nbsp;&nbsp;
        <asp:Image ID="Image7" runat="server" ImageUrl="images/Java.png"/>
        &nbsp;&nbsp;
        <asp:Image ID="Image8" runat="server" ImageUrl="images/Kenyan.JPG"/>
        &nbsp;&nbsp;
        <asp:Image ID="Image9" runat="server" ImageUrl="images/Monsoon.jpg"/>
        <br/>
        <br/>
        <br/>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br/>
        <br/>
        <asp:GridView ID="dgCoffee" runat="server" AllowSorting="True" AutoGenerateColumns="False" BackColor="#C78F58" BorderColor="#663300" BorderWidth="1px" CellPadding="2" DataSourceID="CoffeeDataSource" ForeColor="Black" GridLines="None" Height="533px" Width="1392px" BorderStyle="Outset" Font-Names="MS Reference Sans Serif" HorizontalAlign="Center">
            <AlternatingRowStyle BackColor="PaleGoldenrod"/>
            <Columns>
                <asp:BoundField DataField="CoffeeName" HeaderText="CoffeeName" SortExpression="CoffeeName">
                    <ControlStyle BorderStyle="Groove"/>
                </asp:BoundField>
                <asp:BoundField DataField="CoffeePrice" HeaderText="CoffeePrice" SortExpression="CoffeePrice"></asp:BoundField>
                <asp:BoundField DataField="CoffeeOrigin" HeaderText="CoffeeOrigin" SortExpression="CoffeeOrigin"></asp:BoundField>
                <asp:BoundField DataField="CoffeeStrength" HeaderText="CoffeeStrength" SortExpression="CoffeeStrength"></asp:BoundField>
                <asp:BoundField DataField="CoffeeGrind" HeaderText="CoffeeGrind" SortExpression="CoffeeGrind"></asp:BoundField>
                <asp:BoundField DataField="CoffeeDescription" HeaderText="CoffeeDescription" SortExpression="CoffeeDescription">
                    <HeaderStyle HorizontalAlign="Center"/>
                </asp:BoundField>
                <asp:CommandField ButtonType="Button" ShowSelectButton="True" SelectText="Buy Now"></asp:CommandField>
            </Columns>
            <FooterStyle BackColor="Tan"/>
            <HeaderStyle BackColor="Tan" Font-Bold="True"/>
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center"/>
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite"/>
            <SortedAscendingCellStyle BackColor="#FAFAE7"/>
            <SortedAscendingHeaderStyle BackColor="#DAC09E" HorizontalAlign="Center"/>
            <SortedDescendingCellStyle BackColor="#E1DB9C"/>
            <SortedDescendingHeaderStyle BackColor="#C2A47B"/>
        </asp:GridView>
    </div>
    <asp:SqlDataSource ID="CoffeeDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:CoffeeTimeConnectionString %>" SelectCommand="SELECT [CoffeeName], [CoffeePrice], [CoffeeOrigin], [CoffeeStrength], [CoffeeGrind], [CoffeeDescription] FROM [Coffee] ORDER BY [CoffeePrice]"></asp:SqlDataSource>
</form>

</body>
</html>