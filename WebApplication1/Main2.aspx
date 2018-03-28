<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main2.aspx.cs" Inherits="WebApplication1.Main2" %>
<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <title>Admin Area | Dashboard</title>
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
                <li><asp:LinkButton runat="server" OnClick="Unnamed_Click" >Logout</asp:LinkButton></li>
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
                  <asp:HyperLink ID="main2" NavigateUrl="Main2.html" runat="server" CssClass="list-group-item active main-color-bg"><i class="fa fa-home" aria-hidden="true"></i> Home</asp:HyperLink>
                  <!--<a href="projects.html" class="list-group-item"> <i class="fa fa-cube" aria-hidden="true"></i> Projects</a>-->
                  <a href="#demo3" class="list-group-item" data-toggle="collapse" data-parent="#MainMenu"><i class="fa fa-cube" aria-hidden="true"></i> Projects</a>
                    <div class="collapse" id="demo3">
                        <a href="viewProject.html" class="list-group-item" style="padding-left: 40px;">View Project</a>
                        <a href="addProject.html" class="list-group-item" style="padding-left: 40px;">Add Project</a>
                    </div>
                  <a href="createScript.html" class="list-group-item"><i class="fa fa-pencil-square-o" aria-hidden="true"></i> Create Test Script</a>
                  <a href="account.html" class="list-group-item"><i class="fa fa-user" aria-hidden="true"></i> Account Settings</a>

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
                    <h3 class="panel-title">Website Overview</h3>
                  </div>
                  <div class="panel-body">
                    <div class="col-md-3">
                      <div class="well dash-box">
                        <h2><span class="fa fa-cube" aria-hidden="true"></span> 25</h2>
                        <h4>Projects</h4>
                      </div>
                    </div>
                    <div class="col-md-3">
                      <div class="well dash-box">
                        <h2><span class="fa fa-camera-retro" aria-hidden="true"></span> 203</h2>
                        <h4>Screenshots</h4>
                      </div>
                    </div>
                    <div class="col-md-3">
                      <div class="well dash-box">
                        <h2><span class="fa fa-archive" aria-hidden="true"></span> 75</h2>
                        <h4>Archive</h4>
                      </div>
                    </div>
                    <div class="col-md-3">
                      <div class="well dash-box">
                        <h2><span class="fa fa-pie-chart" aria-hidden="true"></span> 5</h2>
                        <h4>Charts</h4>
                      </div>
                    </div>
                  </div>
                </div>

                <!-- Latest Projects -->
                <div class="panel panel-default">
                  <div class="panel-heading">
                    <h3 class="panel-title">Latest Projects</h3>
                  </div>
                  <div class="panel-body">
                    <table class="table table-striped table-hover">
                      <tr>
                        <th>Name</th>
                        <th>Company</th>
                        <th>Date Created</th>
                        <th>Pass/Fail</th>
                        <th>Remarks</th>
                      </tr>
                      <tr>
                        <td>Wayne Distribution Management System</td>
                        <td>Wayne Enterprise</td>
                        <td>January 24, 2016</td>
                        <td>Passed</td>
                        <td>Completed</td>
                      </tr>
                      <tr>
                        <td>Merger Tech</td>
                        <td>Queen Consolidated</td>
                        <td>April 15, 2014</td>
                        <td>Failed</td>
                        <td>For Retesting</td>
                      </tr>
                      <tr>
                        <td>Stark Engine Effiency Charter</td>
                        <td>Stark Industries</td>
                        <td>November 12, 2017</td>
                        <td>Pending</td>
                        <td></td>
                      </tr>
                      <tr>
                        <td>Dust Mine Website</td>
                        <td>Schnee Dust Company</td>
                        <td>September 12, 2002</td>
                        <td>Pending</td>
                        <td></td>
                      </tr>
                      <tr>
                        <td>Freddy Fazbear's Pizzaria Website</td>
                        <td>Fazbear Entertainment</td>
                        <td>Decmebr 25, 1998</td>
                        <td>Pending</td>
                        <td></td>
                      </tr>
                    </table>
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

        <!-- Modals -->

        <!-- Add project -->
        <div class="modal fade" id="addProject" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
          <div class="modal-dialog" role="document">
            <div class="modal-content">
              <form runat="server">
              <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                <h4 class="modal-title" id="myModalLabel">Add Project</h4>
              </div>
              <div class="modal-body">
                <div class="form-group">
                  <label>Project Title</label>
                    <asp:TextBox ID="projectName" runat="server" CssClass="form-control" placeholder="Death Star"/>
                </div>
                <div class="form-group">
                  <label for="exampleSelect1">Sprint Number</label>
                  <asp:TextBox ID="sprintnum" runat="server" type="number" CssClass="form-control">
                    </asp:TextBox>
                      </div>
                <div class="form-group">
                  <label>URL</label>
                    <asp:TextBox ID="url" runat="server" CssClass="form-control" placeholder="https://javatpoint.com">
                    </asp:TextBox>
                        </div>
              </div>
              <div class="modal-footer">
                <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                <button type="submit" class="btn btn-primary">Save changes</button>
              </div>
            </form>
            </div>
          </div>
        </div>

        <!-- Create test scripts -->
        <div class="modal fade" id="createScript" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
          <div class="modal-dialog" role="document">
            <div class="modal-content">
              <form>
              <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                <h4 class="modal-title" id="myModalLabel">Add Project</h4>
              </div>
              <div class="modal-body">
                <div class="form-group">
                  <label>Project Title</label>
                    <input type="text" class="form-control" placeholder="Death Star">
                </div>
                <div class="form-group">
                  <label>Sprint Number</label>
                    <input type="number" class="form-control" placeholder="42">
                </div>
                <div class="form-group">
                  <label>Test Name</label>
                    <input type="text" class="form-control" placeholder="Test 1">
                </div>
                <div class="form-group">
                  <label>Excel file </label>
                  <input type="file" class="form-control-file" aria-describedby="fileHelp">
                </div>
                <div class="form-group">
                  <label>Driver type</label>
                  <div class="form-check">
                    <label class="form-check-label bold">
                      <input type="radio" class="form-check-input" name="optionsRadios" id="optionsRadios1" value="option1">
                      Google Chrome <i class="fa fa-chrome" aria-hidden="true"></i>
                    </label>
                  </div>
                  <div class="form-check">
                  <label class="form-check-label bold">
                      <input type="radio" class="form-check-input" name="optionsRadios" id="optionsRadios2" value="option2">
                      Mozilla Firefox <i class="fa fa-firefox" aria-hidden="true"></i>
                    </label>
                  </div>
                </div>
                <div class="form-group">
                  <label>Sheet Name</label>
                    <input type="text" class="form-control" placeholder="Sheet">
                </div>
              </div>
              <div class="modal-footer">
                <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                <button type="submit" class="btn btn-primary">Save changes</button>
              </div>
            </form>
            </div>
          </div>
        </div>
    </div>

    <!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>

    <script src="LoginDesign/js/bootstrap.min.js"></script>
</body>
</html>
