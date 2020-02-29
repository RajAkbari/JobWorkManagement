<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JWM_LogIn.aspx.cs" Inherits="LogIn_LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no" />
    <title>Log In</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.3.1/css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
    <link rel="stylesheet" href="../Content/assets/bootstrap/css/styles.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="row mh-100vh">
                <!-- Start: Login block -->
                <div class="col-10 col-sm-8 col-md-6 col-lg-6 offset-1 offset-sm-2 offset-md-3 offset-lg-0 align-self-center d-lg-flex align-items-lg-center align-self-lg-stretch bg-white p-5 rounded rounded-lg-0 my-5 my-lg-0" id="login-block">
                    <!-- Start: Login container -->
                    <div class="m-auto w-lg-60 w-xl-60">
                        <!-- Start: Your company -->
                        <h2 class="text-info font-weight-light mb-5"><i class="fa fa-diamond"></i>&nbsp;Job Work Management</h2>
                        <!-- End: Your company -->
                        <!-- Start: Login form -->
                        <asp:Label runat="server" ID="lblMessage" EnableViewState="false" />
                        <!-- Start: Email -->
                        <div class="form-group">
                            <label class="text-secondary">User Name</label>
                            <%--<input class="form-control" type="text" required="" title="Email" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,15}$" inputmode="email" />--%>
                            <asp:TextBox runat="server" ID="txtUserName" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ID="rfvUserName" ControlToValidate="txtUserName" Display="Dynamic" ErrorMessage="Enter User Name" CssClass="text-danger" ValidationGroup="User" />
                        </div>
                        <!-- End: Email -->
                        <!-- Start: Password -->
                        <div class="form-group">
                            <label class="text-secondary">Password</label>
                            <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ID="rfvPassword" ControlToValidate="txtPassword" Display="Dynamic" ErrorMessage="Enter Password" CssClass="text-danger" ValidationGroup="User" />
                        </div>
                        <!-- End: Password -->
                        <!-- Start: Submit -->

                        <asp:Button runat="server" ID="btnLogin" ValidationGroup="User" Text="Login" CssClass="btn btn-primary pull-right" OnClick="btnLogin_Click"></asp:Button>
                        <!-- End: Submit -->

                        <!-- End: Login form -->
                        <!-- Start: Forgot password -->
                        <div class="col-sm-5"></div>
                        <br />
                        <br />
                        <br />
                        <div class="col-sm-7 pull-right">
                            <i class="small">Don't have an account ?</i>
                            <asp:HyperLink runat="server" ID="hlSignUp" NavigateUrl="~/JWM_SignUp/JWM_SignUp.aspx">
                                <i class="small text-primary">SignUp</i>
                            </asp:HyperLink>
                        </div>
                        <!-- End: Forgot password -->
                    </div>
                    <!-- End: Login container -->
                </div>
                <!-- End: Login block -->
                <!-- Start: Background image -->
                <div class="col-lg-6 d-flex align-items-end" id="bg-block" style="background-image: url(&quot;/Content/assets/img/aldain-austria-316143-unsplash.jpg?h=47cfcc14c63c7ee429179840738cce2c&quot;); background-size: cover; background-position: center center;">
                </div>
                <!-- End: Background image -->
            </div>
        </div>
        <!-- End: ♣ Login form Page BS4 ♣ -->
        <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.3.1/js/bootstrap.bundle.min.js"></script>
    </form>
</body>
</html>