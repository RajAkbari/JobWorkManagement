<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JWM_SignUp.aspx.cs" Inherits="SignUp_SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign Up</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no" />
    <link rel="stylesheet" href="../Content/assets/bootstrap/css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i" />
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.1/css/all.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card shadow-lg o-hidden border-0 my-5">
                <div class="card-body p-0">
                    <div class="row">
                        <div class="col-lg-5 d-none d-lg-flex">
                            <div class="flex-grow-1 bg-register-image" style="background-image: url(&quot;/Content/assets/img/aldain-austria-316143-unsplash.jpg?h=47cfcc14c63c7ee429179840738cce2c&quot;);"></div>
                        </div>
                        <div class="col-lg-7">
                            <div class="p-5">
                                <div class="text-center">
                                    <h4 class="text-dark mb-4">Create an Account!</h4>

                                    <asp:Label runat="server" ID="lblMessage" EnableViewState="false" />
                                </div>
                                <div class="form-group row">
                                    <div class="col-sm-6 mb-3 mb-sm-0">
                                        <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control form-control-user" Type="text" placeholder="User Name"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfvUserName" runat="server" ControlToValidate="txtUserName" ErrorMessage="Enter User Name" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </div>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="txtDisplayName" runat="server" CssClass="form-control form-control-user" Type="text" placeholder="Display Name"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfvDisplayName" runat="server" ControlToValidate="txtDisplayName" ErrorMessage="Enter Display Name" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control form-control-user" Type="Password" placeholder="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Enter Password" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control form-control-user" Type="email" aria-describedby="emailHelp" placeholder="Email Address"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Enter Email" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox ID="txtMobileno" runat="server" CssClass="form-control form-control-user" Type="text" MaxLength="10" placeholder="Mobile Number" pattern="[7-9]{1}[0-9]{9}"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvMobileno" runat="server" ControlToValidate="txtMobileno" ErrorMessage="Enter Mobile number" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox ID="txtRemarks" runat="server" CssClass="form-control form-control-user" Type="remarks" TextMode="MultiLine" placeholder="remarks"></asp:TextBox>
                                </div>
                                <asp:Button runat="server" ID="btnRegister" Text="Register Account" CssClass="btn btn-primary btn-block text-white btn-user" OnClick="btnRegister_Click"></asp:Button>

                                <hr />

                                <%--<div class="text-center"><a class="small" href="forgot-password.html">Forgot Password?</a></div>--%>
                                <div class="text-center"><a class="small" href="../JWM_LogIn/JWM_LogIn.aspx">Already have an account? Login!</a></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.3.1/js/bootstrap.bundle.min.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.8.0/Chart.bundle.min.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.4.1/jquery.easing.js"></script>
        <script src="../Content/assets/js/script.min.js"></script>
    </form>
</body>
</html>