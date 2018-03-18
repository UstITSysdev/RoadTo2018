<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateScript.aspx.cs" Inherits="WebApplication4.CreateScript" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<title>Sample File</title>
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
    body {
        min-height: 93vh;
          
        background-repeat: no-repeat;
        background-position: center;
        background-size: cover;
        /* position: relative; */
        z-index: 1;

        background: #9152f8;
        background: -webkit-linear-gradient(top, #7579ff, #b224ef);
        background: -o-linear-gradient(top, #7579ff, #b224ef);
        background: -moz-linear-gradient(top, #7579ff, #b224ef);
        background: linear-gradient(top, #7579ff, #b224ef);
    }
    
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
    
    #wrapper {
        /*background-color: green; /* for vizualization purposes */
        padding-left: 17%;
    }
    
    #yourdiv {
        /*background-color: red; /* for vizualization purposes */
        display: inline-block;
    }
    
    #fields {
        font-size:20px;
        /*padding-left: 300px;
        padding-right: 100px;
        margin-top: 10px;*/
        padding-left: 200px;
        padding-right: 200px;
    }
    
    .yours {
        border-width: thin;
    }
    
    .container {
        /*padding-bottom: 500px;*/
        position: relative;
        margin: 0;
        padding: 0;
        display: inline-block;
        padding-top: 100px;
        padding-left: 70px;
        padding-right: 100px;
    }
    
    .container input {
        /*margin-left: 9em;*/
        width: 275px;
    }
    
    .container label {
        position: relative;
    }
    
    #cancelBttn{
        width:90px;
    }
    
    #EFbutton{
        display:inline-block;
        position:relative;
        width:300px;
    }
    
</style>
<body>

<!-- Top container -->
<div class="w3-bar w3-top w3-black w3-large" style="z-index:4; min-height: 45px;">
  
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
        <form runat="server">
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
  <div class="col-md-12">
      <header class="w3-container w3-display-topmiddle">
          <div id="head" class="col-md-12 col-md-offset-2">
              <h2><b>Create Script</b></h2>
          </div>
      </header>
  </div> 
    <div class="container">
            Project Name: &nbsp;
            <asp:DropDownList ID="projname" list="projname" name="projname" AutoPostBack="true"  runat="server">
                    <asp:ListItem Value="Internet Explorer"/>
                    <asp:ListItem Value="Firefox" Text=""/>
                    <asp:ListItem Value="Chrome" Text=""/>
                    <asp:ListItem Value="Opera" Text=""/>
                    <asp:ListItem Value="Safari" Text=""/>
            </asp:DropDownList>>
            <br>
            <br>
            Sprint Number: 
            <asp:DropDownList ID="sprintnum" AutoPostBack="true"  runat="server" >
                    <asp:ListItem Value="1" runat="server"/>
                    <asp:ListItem Value="2" runat="server"/>
                    <asp:ListItem Value="3" runat="server"/>
                    <asp:ListItem Value="4" runat="server"/>
                    <asp:ListItem Value="5" runat="server"/>
                    <asp:ListItem Value="6" runat="server"/>
            </asp:DropDownList>
            <br><br>
            Test Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TestName" placeholder="e.g. Admin Module" name="testname" runat="server"></asp:TextBox><br><br>
            Excel file:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:FileUpload runat="server"  id="EFbutton" type="file" name="img"/><br><br>
            Sheet Name:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="SheetName" runat="server" placeholder="e.g. Add Value" type="text" name="sheetname"/><br><br>
            <div id="wrapper">
                <div class="yourdiv">
                      <asp:Button runat="server" type="submit" Value="save" Text="Submit" ></asp:Button>
                    <button type="reset" value="reset">Reset</button>
                    <a class="yours" href="createScript.html"><input id="cancelBttn" type="button" value="Cancel"/></a>
                </div>
            </div>
    </form>  
    </div>
</div> 
  <!-- <div class="w3-row-padding w3-margin-bottom">
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
  </div>-->
    
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

