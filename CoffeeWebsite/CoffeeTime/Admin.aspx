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
body {
    background-image: url(images/background_beans.jpg);
}
    .auto-style1 {
        font-size: 60pt;
        height: 119px;
    }
    .auto-style2 {
        float: left;
        height: 50px;
        padding: 15px 15px;
        font-size: 18px;
        line-height: 20px;
        color: #000000;
    }
    .auto-style3 {
        font-size: 60pt;
        height: 119px;
        color: #000000;
    }
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
                    <a href="Contact.aspx">Contact Us</a>
                </li>
                <li>
                    <a href="Home.aspx">Log Out</a>
                </li>
            </ul>
        </div><!--/.nav-collapse -->
    </div>
</nav>

<div class="container">
    
    <div class="starter-template">
        <h1 class="auto-style1"> <img src="icon/coffee-bean-icon.png" alt=""/><span class="auto-style3"> Coffee Time</span></h1>
        &nbsp;</div>
    <!-- /.container -->


<!-- Bootstrap core JavaScript
================================================== -->
<!-- Placed at the end of the document so the pages load faster -->
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
<script>window.jQuery || document.write('<script src="../../assets/js/vendor/jquery.min.js"><\/script>')</script>
<script src="javascript/bootstrap.min.js"></script>
</div>
        <div style="margin-left: 40px">
            <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" BackColor="#BF6000" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyNames="CoffeeID" DataSourceID="CoffeeAdminDataSource" ForeColor="Black" GridLines="None" Height="468px" Width="1356px" BorderStyle="Groove" Font-Names="Microsoft Sans Serif">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <Columns>
                    <asp:ImageField NullImageUrl="~/CoffeeTime/images/Antigua.jpg">
                    </asp:ImageField>
                    <asp:BoundField DataField="CoffeeID" HeaderText="CoffeeID" ReadOnly="True" SortExpression="CoffeeID" />
                    <asp:BoundField DataField="CoffeeName" HeaderText="CoffeeName" SortExpression="CoffeeName" />
                    <asp:BoundField DataField="CoffeePrice" HeaderText="CoffeePrice" SortExpression="CoffeePrice" />
                    <asp:BoundField DataField="CoffeeOrigin" HeaderText="CoffeeOrigin" SortExpression="CoffeeOrigin" />
                    <asp:BoundField DataField="CoffeeStrength" HeaderText="CoffeeStrength" SortExpression="CoffeeStrength" />
                    <asp:BoundField DataField="CoffeeGrind" HeaderText="CoffeeGrind" SortExpression="CoffeeGrind" />
                    <asp:BoundField DataField="CoffeeQty" HeaderText="CoffeeQty" SortExpression="CoffeeQty" />
                    <asp:BoundField DataField="CoffeeDescription" HeaderText="CoffeeDescription" SortExpression="CoffeeDescription" />
                    <asp:CommandField ButtonType="Button" EditText="Update" ShowDeleteButton="True" ShowEditButton="True">
                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:CommandField>
                </Columns>
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <SortedAscendingCellStyle BackColor="#FAFAE7" />
                <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                <SortedDescendingCellStyle BackColor="#E1DB9C" />
                <SortedDescendingHeaderStyle BackColor="#C2A47B" />
            </asp:GridView>
            <asp:SqlDataSource ID="CoffeeAdminDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:CoffeeTimeConnectionString %>" SelectCommand="SELECT * FROM [Coffee] ORDER BY [CoffeeID]" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [Coffee] WHERE [CoffeeID] = @original_CoffeeID AND (([CoffeeName] = @original_CoffeeName) OR ([CoffeeName] IS NULL AND @original_CoffeeName IS NULL)) AND (([CoffeePrice] = @original_CoffeePrice) OR ([CoffeePrice] IS NULL AND @original_CoffeePrice IS NULL)) AND (([CoffeeOrigin] = @original_CoffeeOrigin) OR ([CoffeeOrigin] IS NULL AND @original_CoffeeOrigin IS NULL)) AND (([CoffeeStrength] = @original_CoffeeStrength) OR ([CoffeeStrength] IS NULL AND @original_CoffeeStrength IS NULL)) AND (([CoffeeGrind] = @original_CoffeeGrind) OR ([CoffeeGrind] IS NULL AND @original_CoffeeGrind IS NULL)) AND (([CoffeeQty] = @original_CoffeeQty) OR ([CoffeeQty] IS NULL AND @original_CoffeeQty IS NULL)) AND (([CoffeeDescription] = @original_CoffeeDescription) OR ([CoffeeDescription] IS NULL AND @original_CoffeeDescription IS NULL))" InsertCommand="INSERT INTO [Coffee] ([CoffeeID], [CoffeeName], [CoffeePrice], [CoffeeOrigin], [CoffeeStrength], [CoffeeGrind], [CoffeeQty], [CoffeeDescription]) VALUES (@CoffeeID, @CoffeeName, @CoffeePrice, @CoffeeOrigin, @CoffeeStrength, @CoffeeGrind, @CoffeeQty, @CoffeeDescription)" OldValuesParameterFormatString="original_{0}" UpdateCommand="UPDATE [Coffee] SET [CoffeeName] = @CoffeeName, [CoffeePrice] = @CoffeePrice, [CoffeeOrigin] = @CoffeeOrigin, [CoffeeStrength] = @CoffeeStrength, [CoffeeGrind] = @CoffeeGrind, [CoffeeQty] = @CoffeeQty, [CoffeeDescription] = @CoffeeDescription WHERE [CoffeeID] = @original_CoffeeID AND (([CoffeeName] = @original_CoffeeName) OR ([CoffeeName] IS NULL AND @original_CoffeeName IS NULL)) AND (([CoffeePrice] = @original_CoffeePrice) OR ([CoffeePrice] IS NULL AND @original_CoffeePrice IS NULL)) AND (([CoffeeOrigin] = @original_CoffeeOrigin) OR ([CoffeeOrigin] IS NULL AND @original_CoffeeOrigin IS NULL)) AND (([CoffeeStrength] = @original_CoffeeStrength) OR ([CoffeeStrength] IS NULL AND @original_CoffeeStrength IS NULL)) AND (([CoffeeGrind] = @original_CoffeeGrind) OR ([CoffeeGrind] IS NULL AND @original_CoffeeGrind IS NULL)) AND (([CoffeeQty] = @original_CoffeeQty) OR ([CoffeeQty] IS NULL AND @original_CoffeeQty IS NULL)) AND (([CoffeeDescription] = @original_CoffeeDescription) OR ([CoffeeDescription] IS NULL AND @original_CoffeeDescription IS NULL))">
                <DeleteParameters>
                    <asp:Parameter Name="original_CoffeeID" Type="Int64" />
                    <asp:Parameter Name="original_CoffeeName" Type="String" />
                    <asp:Parameter Name="original_CoffeePrice" Type="Double" />
                    <asp:Parameter Name="original_CoffeeOrigin" Type="String" />
                    <asp:Parameter Name="original_CoffeeStrength" Type="Int32" />
                    <asp:Parameter Name="original_CoffeeGrind" Type="String" />
                    <asp:Parameter Name="original_CoffeeQty" Type="Int32" />
                    <asp:Parameter Name="original_CoffeeDescription" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="CoffeeID" Type="Int64" />
                    <asp:Parameter Name="CoffeeName" Type="String" />
                    <asp:Parameter Name="CoffeePrice" Type="Double" />
                    <asp:Parameter Name="CoffeeOrigin" Type="String" />
                    <asp:Parameter Name="CoffeeStrength" Type="Int32" />
                    <asp:Parameter Name="CoffeeGrind" Type="String" />
                    <asp:Parameter Name="CoffeeQty" Type="Int32" />
                    <asp:Parameter Name="CoffeeDescription" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="CoffeeName" Type="String" />
                    <asp:Parameter Name="CoffeePrice" Type="Double" />
                    <asp:Parameter Name="CoffeeOrigin" Type="String" />
                    <asp:Parameter Name="CoffeeStrength" Type="Int32" />
                    <asp:Parameter Name="CoffeeGrind" Type="String" />
                    <asp:Parameter Name="CoffeeQty" Type="Int32" />
                    <asp:Parameter Name="CoffeeDescription" Type="String" />
                    <asp:Parameter Name="original_CoffeeID" Type="Int64" />
                    <asp:Parameter Name="original_CoffeeName" Type="String" />
                    <asp:Parameter Name="original_CoffeePrice" Type="Double" />
                    <asp:Parameter Name="original_CoffeeOrigin" Type="String" />
                    <asp:Parameter Name="original_CoffeeStrength" Type="Int32" />
                    <asp:Parameter Name="original_CoffeeGrind" Type="String" />
                    <asp:Parameter Name="original_CoffeeQty" Type="Int32" />
                    <asp:Parameter Name="original_CoffeeDescription" Type="String" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
    </html>