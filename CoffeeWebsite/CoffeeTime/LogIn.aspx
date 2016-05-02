<%@ Language="C#" AutoEventWireup="true" CodeFile="LogIn.aspx.cs" Inherits="CoffeeWebsite.CoffeeTime.LogIn" %>

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

        .auto-style1 { font-size: 35pt; }

        .auto-style3 { font-size: 55pt; }

        .auto-style5 { font-size: 60pt;
            color: #000000;
        }

        .auto-style10 {
            float: left;
            height: 50px;
            padding: 15px 15px;
            font-size: 18px;
            line-height: 20px;
            color: #000000;
        }
        .auto-style11 {
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
            <a class="auto-style10" href="Home.aspx">Coffee Time</a>
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
            </ul>
        </div><!--/.nav-collapse -->
    </div>
</nav>

<div class="container">

    <div class="starter-template">
        <h1 class="auto-style1">
            <img src="icon/coffee-bean-icon.png" alt=""/><span class="auto-style3"> </span><span class="auto-style5">Coffee Time</span></h1>
        <p class="auto-style1">
            &nbsp;</p>
        <p class="auto-style1">
            <span class="auto-style11">Admin Log In Screen</span></p>
    </div>
    
    </div>
        <div style="margin-left: 480px; width: 769px; height: 236px; text-align: center;">
            <p>
                <br />
                &nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Microsoft Sans Serif" Font-Size="Large" Text="Username" style="color: #000000"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtUsername" runat="server" BorderStyle="Double" Height="33px" Width="263px"></asp:TextBox>
                <br />
                <br />
&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Microsoft Sans Serif" Font-Size="Large" Text="Password" style="color: #000000"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtPassword" runat="server" BorderStyle="Double" Height="31px" Width="263px" TextMode="Password"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
                </p>
            <p>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnLogIn" runat="server" Font-Bold="True" Font-Names="Microsoft Sans Serif" Font-Size="Large" Height="67px" Text="Log In" Width="193px" OnClick="btnLogIn_Click"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
            <p>
                <br/>
            </p>
            <br />
        
            <asp:Label ID="lblMsg" runat="server" style="font-size: large; color: #FF0000;"></asp:Label>
        
        </div>
    </form>


<!-- Bootstrap core JavaScript
================================================== --><!-- Placed at the end of the document so the pages load faster -->
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js">

    
</script><script>window.jQuery || document.write('<script src="../../assets/js/vendor/jquery.min.js"><\/script>')</script>
<script src="javascript/bootstrap.min.js"></script>


</body>
</html>