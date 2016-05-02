<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="CoffeeWebsite.CoffeeTime.Contact" %>

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

        .auto-style1 { font-size: 50pt; }

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
            font-size: 30pt;
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
            <img src="icon/coffee-bean-icon.png" alt=""/><span class="auto-style3"> </span><span class="auto-style5">Coffee Time</span></h1>
        <p class="auto-style1">
            &nbsp;</p>
        <p class="auto-style11">
            Contact Us</p>
    </div>

</div><!-- /.container -->
    
<script
src="http://maps.googleapis.com/maps/api/js">
</script>

<script>
var myCenter=new google.maps.LatLng(45.434046,12.340284);

function initialize()
{
var mapProp = {
  center:myCenter,
  zoom:18,
  mapTypeId:window.google.maps.MapTypeId.HYBRID
  };

var map=new window.google.maps.Map(document.getElementById("googleMap"),mapProp);
}

google.maps.event.addDomListener(window, 'load', initialize);
</script>

<div id="googleMap" style="width:500px;height:380px; margin-left: 520px;"></div>

</body>
</html>

