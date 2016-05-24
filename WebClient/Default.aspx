<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebClient.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>eBanking</title>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <link href="/css/bootstrap.min.css" rel="stylesheet" />
    <link href="/css/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="/css/font-awesome.min.css" rel="stylesheet" />
    <link href="/css/styles.css" rel="stylesheet" />
</head>
<body>
    <nav class="navbar navbar-default">
        <div class="container">
            <!-- Brand and toggle get grouped for better mobile display -->
            <div class="navbar-header">
                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="#">eBanking</a>
            </div>

            <!-- Collect the nav links, forms, and other content for toggling -->
            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                <ul class="nav navbar-nav">
                </ul>
                <ul class="nav navbar-nav navbar-right">
                    <li><a href="#">Link</a></li>
                </ul>
            </div>
            <!-- /.navbar-collapse -->
        </div>
        <!-- /.container-fluid -->
    </nav>


    <div class="jumbotron">
        <div class="container">
            <form class="form-horizontal col-lg-4 col-lg-offset-4 col-sm-10 col-sm-offset-1 col-xs-12" id="stocks_form">
                <h1 class="text-center"><i class="fa fa-line-chart"></i></h1>
                <div class="form-group">
                    <label for="client_name" class="col-sm-2 control-label">Name</label>
                    <div class="col-sm-10">
                        <input type="text" class="form-control" name="client_name" id="client_name" placeholder="Your Name" />
                    </div>
                </div>
                <div class="form-group">
                    <label for="client_email" class="col-sm-2 control-label">Email</label>
                    <div class="col-sm-10">
                        <input type="email" class="form-control" name="client_email" id="client_email" placeholder="Your Email" />
                    </div>
                </div>
                <div class="form-group">
                    <label for="order_type" class="col-sm-2 control-label">Order Type</label>
                    <div class="col-sm-10">
                        <select name="order_type" id="order_type" class="form-control">
                            <option value="purchase">Purchase</option>
                            <option value="sell">Sell</option>
                        </select>
                    </div>
                </div>
                <div class="form-group">
                    <label for="company" class="col-sm-2 control-label">Company</label>
                    <div class="col-sm-10">
                        <select name="company" id="company" class="form-control"  runat="server">
                            <option>Choose a company</option>
                        </select>
                    </div>
                </div>
                <div class="form-group">
                    <label for="quantity" class="col-sm-2 control-label">Quantity</label>
                    <div class="col-sm-10">
                        <input type="number" class="form-control" name="quantity" id="quantity" min="1" value="1" />
                    </div>
                </div>
                <div class="form-group text-right">
                    <div class="col-sm-12">
                        <button type="submit" class="btn btn-default">Submit</button>
                    </div>
                </div>
            </form>
        </div>
    </div>

    <div class="container">
    </div>

    <script src="/scripts/jquery-2.2.4.min.js"></script>
    <script src="/scripts/bootstrap.min.js"></script>
</body>
</html>
