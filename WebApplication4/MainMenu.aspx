<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainMenu.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>


<html  xmlns="http://www.w3.org/1999/xhtml" runat="server">
<title>Selenium </title>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Raleway">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
  
<style>
html,body,h1,h2,h3,h4,h5 {font-family: "Raleway", sans-serif}
    #menu {
        position: fixed;
        width: 300px;
        height: 100%;
    }
    #menu ul li {
        color:#151719;
        list-style:none;
        padding:15px 10px;
        border-bottom: 1px solid rgba(100,100,100,0.3);
    }
    body {
        
    }
</style>
<body class="w3-light-grey" >
     
    
    <form id="form1" runat="server">
<!-- Top container -->
    <div class="w3-bar w3-top w3-black w3-large" style="z-index:4">
  
        <asp:Button runat="server" CssClass="w3-bar-item w3-button w3-hide-large w3-hover-none w3-hover-text-light-grey"></asp:Button>
        <span class="w3-bar-item w3-left"><strong>NTT Data Selenium</strong></span>
        <span class="w3-right" style="margin: 5px; padding-right: 10px">Logout</span>
        <span class="w3-right" style="margin: 5px"> | </span>
        <span class="w3-right" style="margin: 5px">Settings</span>
    </div>

<!-- Sidebar/menu -->
<nav class="w3-sidebar w3-collapse w3-white w3-animate-left " style="z-index:3;width:300px;" id="mySidebar"><br>
  <div class="w3-container w3-row">
    <div class="w3-col s4">
    </div>
    <div class="w3-col s8 w3-bar">
      <span>Welcome, <strong>Administrator</strong></span><br> 
    </div>
  </div>
  <hr style="margin-bottom: 5px;">
    <div id="menu">
        <ul>
          <a href="MainMenu.html"><li><div class="w3-left"><i class="glyphicon glyphicon-file w3-xxxsmall" style="padding-right: 3px; padding-top: 2px"></i></div>Projects</li></a>
          <a href="createScript.html"><li><div class="w3-left"><i class="glyphicon glyphicon-plus-sign fa w3-xxxsmall" style="padding-right: 3px; padding-top: 2px"></i></div>Create Test Scripts</li></a>
          <a href="#"><li><div class="w3-left"><i class="fa fa-users w3-xxxsmall" style="padding-right: 3px; padding-top: 2px"></i></div>Users</li></a>
        </ul>
    </div>
  </nav>


<!-- Overlay effect when opening sidebar on small screens -->
<div class="w3-overlay w3-hide-large w3-animate-opacity" onclick="w3_close()" style="cursor:pointer" title="close side menu" id="myOverlay"></div>

<!-- !PAGE CONTENT! -->
<div class="w3-main" style="margin-left:300px;margin-right: 100px; margin-top:43px;">

  <!-- Header -->
  <header class="w3-container" style="padding-top:22px">
    <h5><b><i class="fa fa-dashboard"></i> My Dashboard</b></h5>
  </header>

  <div class="w3-row-padding w3-margin-bottom">
    <a href="">
    <div class="w3-quarter">
      <div class="w3-container w3-red w3-padding-16">
        <div class="w3-left"><i class="glyphicon glyphicon-plus-sign fa w3-xxxlarge" ></i></div>
        <div class="w3-right">
          <h3>52</h3>
        </div>
        <div class="w3-clear"></div>
        <h4>Create Script</h4>
      </div>
    </div>
        
    </a><a href="" >
    <div class="w3-quarter">   
      <div class="w3-container w3-blue w3-padding-16">
        <div class="w3-left"><i class="glyphicon glyphicon-plus-sign w3-xxxlarge"></i></div>
        <div class="w3-right">
          <h3>99</h3>
        </div>
        <div class="w3-clear"></div>
        <h4>Create Projects</h4>
      </div>    
    </div>
    
    </a><a href="" >
    <div class="w3-quarter">
      <div class="w3-container w3-teal w3-padding-16">
        <div class="w3-left"><i class="fa fa-eye w3-xxxlarge"></i></div>
        <div class="w3-right">
          <h3>?</h3>
        </div>
        <div class="w3-clear"></div>
        <h4>View Projects</h4>
      </div>
    </div>
    
    </a><a href="" >
    <div class="w3-quarter">
      <div class="w3-container w3-orange w3-text-white w3-padding-16">
        <div class="w3-left"><i class="fa fa-users w3-xxxlarge"></i></div>
        <div class="w3-right">
          <h3>50</h3>
        </div>
        <div class="w3-clear"></div>
        <h4>Users</h4>
      </div>
    </div>
    </a>
  </div>
</form>

<script>
// Get the Sidebar
var mySidebar = document.getElementById("mySidebar");

// Get the DIV with overlay effect
var overlayBg = document.getElementById("myOverlay");

// Toggle between showing and hiding the sidebar, and add overlay effect
function w3_open() {
    if (mySidebar.style.display === 'block') {
        mySidebar.style.display = 'none';
        overlayBg.style.display = "none";
    } else {
        mySidebar.style.display = 'block';
        overlayBg.style.display = "block";
    }
}

// Close the sidebar with the close button
function w3_close() {
    mySidebar.style.display = "none";
    overlayBg.style.display = "none";
}
</script>

</body>
</html>
