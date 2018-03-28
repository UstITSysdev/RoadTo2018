<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addProject.aspx.cs" Inherits="WebApplication1.addProject" %>

<!DOCTYPE html>

<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Admin Area | Add Project</title>
    <!-- Bootstrap core CSS -->
    <link href="LoginDesign/font-awesome-4.7.0/css/font-awesome.min.css" rel="stylesheet">
    <link href="LoginDesign/oldcss/bootstrap.min.css" rel="stylesheet">
    <link href="LoginDesign/css/style.css" rel="stylesheet">
</head>
<body style="background-image: url('LoginDesign/img/NTT_bg-flipped.png');">
    <div class="limit">
        <nav class="navbar navbar-inverse">
          <div class="container">
            <div class="navbar-header" style="length: 100%;">
              <button type="button" class="navbar-toggle collapsed" style="margin-left: 15px; margin-top: 15px; margin-bottom: 15px;" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
              </button>
              <a class="navbar-brand" href="Main2.html"><img src="LoginDesign/img/logonttdatacopy2x.png" style="width: 34%;"></a>
            </div>
            <div id="navbar" class="collapse navbar-collapse">
              <ul class="nav navbar-nav navbar-right">
                <li class="active"><a href="#">Welcome, User</a></li>
                <li><asp:HyperLink runat="server" NavigateUrl="Login.aspx">Logout</asp:HyperLink></li>
              </ul>
            </div><!--/.nav-collapse -->
          </div>
        </nav>

        <header id="header">
          <div class="container">
            <div class="row">
              <div class="col-md-10">
                <h3><!--<img src="img/logonttdatacopy2x.png" style="max-width: 25%;max-height: 25%;">--></h3>
              </div>
              <div class="col-md-2">
                <!--<div class="dropdown create">
                  <button class="btn btn-default dropdown-toggle" type="button" id="dropdownMenu1" data-toggle="dropdown" aria-haspopup="true" aria-expanded="true">
                    Create Content
                    <span class="caret"></span>
                  </button>
                  <ul class="dropdown-menu" aria-labelledby="dropdownMenu1">
                    <li><a type="button" data-toggle="modal" data-target="#addProject">Add Project</a></li>
                    <li><a type="button" data-toggle="modal" data-target="#createScript">Create Test Script</a></li>
                  </ul>
                </div>-->
            </div>
          </div>
        </header>

        <!--
        <section id="breadcrumb">
          <div class="container">
            <ol class="breadcrumb">
              <li class="active">Dashboard</li>
            </ol>
          </div>
        </section>
        -->
        <section id="main">
          <div class="container">
            <div class="row">
              <div class="col-md-3">
                <div class="list-group">
                  <asp:HyperLink runat="server" NavigateUrl="Main2.aspx" CssClass="list-group-item"><i class="fa fa-home" aria-hidden="true"></i> Home</asp:HyperLink>
                  <!--<a href="projects.html" class="list-group-item"> <i class="fa fa-cube" aria-hidden="true"></i> Projects</a>-->
                  <asp:HyperLink runat="server" NavigateUrl="#demo3" CssClass="list-group-item active main-color-bg" data-toggle="collapse" data-parent="#MainMenu"><i class="fa fa-cube" aria-hidden="true"></i> Projects</asp:HyperLink>
                    <div class="collapse" id="demo3">
                        <asp:HyperLink runat="server" NavigateUrl="viewProject.aspx" CssClass="list-group-item" style="padding-left: 40px;">View Project</asp:HyperLink>
                        <asp:HyperLink runat="server" NavigateUrl="addProject.aspx" CssClass="list-group-item" style="padding-left: 40px;">Add Project</asp:HyperLink>
                    </div>
                  <asp:HyperLink runat="server" NavigateUrl="createScript.html" CssClass="list-group-item"><i class="fa fa-pencil-square-o" aria-hidden="true"></i> Create Test Script</asp:HyperLink>
                  <asp:HyperLink runat="server" NavigateUrl="account.html" CssClass="list-group-item"><i class="fa fa-user" aria-hidden="true"></i> Account Settings</asp:HyperLink>

                </div>

                <div class="well">
                  <h4>Disk Space Used</h4>
                  <div class="progress">
                    <div class="progress-bar" role="progressbar" aria-valuenow="60" aria-valuemin="0" aria-valuemax="100" style="width: 60%;">
                      60%
                    </div>
                  </div>
                  <h4>Bandwidth Used</h4>
                  <div class="progress">
                    <div class="progress-bar" role="progressbar" aria-valuenow="40" aria-valuemin="0" aria-valuemax="100" style="width: 40%;">
                      40%
                    </div>
                  </div>
                </div>

              </div>
              <div class="col-md-9">
                <!--Website Overview -->
                <div class="panel panel-primary">
                  <div class="panel-heading main-color-bg">
                    <h3 class="panel-title">Projects > Add Project</h3>
                  </div>
                  <div class="panel-body">
                    <div class="row">
                      <div class="col-md-12">
                        <form runat="server">
                          <div class="modal-body">
                          <div class="form-group">
                            <label>Project Title</label>
                              <asp:TextBox ID="projNameCreate" runat="server" type="text" CssClass="form-control" placeholder="Death Star"></asp:TextBox>
                          </div>
                          <div class="form-group">
                            <label>URL</label>
                              <asp:TextBox ID="URL" runat="server" type="url" CssClass="form-control" placeholder="https://javatpoint.com"></asp:TextBox>
                          </div>
                        </div>
                        <div class="modal-footer">
                          <button type="reset" class="btn btn-default" data-dismiss="modal">Reset</button>
                          <asp:Button ID="createButton" runat="server" CssClass="btn btn-primary" Text="Save changes" OnClick="createProject"></asp:Button>
                        </div>
                        </form>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </section>

        <!--
        <footer id="footer">
          <p>Developed by SYSDEV, &copy; 2018</p>
        </footer>
        -->
    </div>

    <!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>

    <script src="LoginDesign/js/bootstrap.min.js"></script>
</body>
</html>
