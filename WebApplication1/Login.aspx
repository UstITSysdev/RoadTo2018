<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

<!DOCTYPE html>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
	<head runat="server">
		<meta charset="UTF-8">
		<meta name="viewport" content="width=device-width, initial-scale=1.0">
		<title>Login Form</title>
		<link rel="stylesheet" type="text/css" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.0/css/bootstrap.min.css">
		<link rel="stylesheet" type="text/css" href="LoginDesign/css/bootstrap.min.css">
		<link rel="stylesheet" type="text/css" href="LoginDesign/css/logfinal.css">
		<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
		<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.0/js/bootstrap.min.js"></script>
		<link rel="stylesheet" type="text/css" href="LoginDesign\fonts\font-awesome-4.7.0\css\font-awesome.css">

		<link rel="icon" type="image/png" href="images/icons/favicon.ico"/>
		<link rel="stylesheet" type="text/css" href="LoginDesign/vendor/bootstrap/css/bootstrap.min.css">
		<link rel="stylesheet" type="text/css" href="LoginDesign/fonts/font-awesome-4.7.0/css/font-awesome.min.css">
		<link rel="stylesheet" type="text/css" href="LoginDesign/fonts/iconic/css/material-design-iconic-font.min.css">
		<link rel="stylesheet" type="text/css" href="LoginDesign/vendor/animate/animate.css">
		<link rel="stylesheet" type="text/css" href="LoginDesign/vendor/css-hamburgers/hamburgers.min.css">
		<link rel="stylesheet" type="text/css" href="LoginDesign/vendor/animsition/css/animsition.min.css">
		<link rel="stylesheet" type="text/css" href="LoginDesign/vendor/select2/select2.min.css">
		<link rel="stylesheet" type="text/css" href="LoginDesign/vendor/daterangepicker/daterangepicker.css">
	</head>
	<style>
		body {
			margin: 0;
			padding: 0;
			background-size: cover;
			font-family: sans-serif; 
		}
	</style>
	<body style="background-image: url('LoginDesign/img/bg-02.jpg');"> 
	<div class="limit">
		<div class="container-login">
			<div class="row">
				<div class="col-md-4 col-xs-12"></div>
  				<div class="col-md-4 col-xs-12">
  					<form id="form1" runat="server" class="form-container">
  						<img src="LoginDesign/img/NTT-Data-Logo.png" style="max-width: 90%;max-height: 100%;"> 						  
  						<div class="form-group">
						    <!--<label for="exampleInputEmail1">Username</label>-->
						    <asp:TextBox  ID="uname" runat="server" name="uname" type="text" CssClass="form-control"  placeholder="Email" required="required"></asp:TextBox>
						  </div>
						  <div class="form-group">
						  	<!--<label for="exampleInputPassword1">Password</label>-->
						    <asp:TextBox ID="pass" runat="server" name="pass" type="password" CssClass="form-control"  placeholder="••••••••" required="required"></asp:TextBox>
						  </div>
                          <div class="checkbox">
                              <label>
                                
                              </label>
                          </div>
                         <asp:Button runat="server" OnClick="Login_Click" CssClass="btn btn-primary btn-block" Text="Login"/>
						 
					</form>
  				</div>
  				<div class="col-md-4 col-xs-12"></div>
			</div>	
		</div>	
	</div>
	</body>
</html>
