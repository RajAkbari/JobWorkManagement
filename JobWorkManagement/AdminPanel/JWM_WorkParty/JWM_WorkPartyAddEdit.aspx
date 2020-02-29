<%@ Page Title="" Language="C#" MasterPageFile="~/Content/AdminPanel.master" AutoEventWireup="true" CodeFile="JWM_WorkPartyAddEdit.aspx.cs" Inherits="AdminPanel_JWM_WorkParty_WorkPartyAddEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="stylesheet" href="../../Content/assets/bootstrap/css/glyphicon.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="Server">

    <div class="container-fluid">
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
        <div class="col-lg-12">
            <div class="card shadow mb-4">
                <div class="card-header d-flex justify-content-between align-items-center">
                    <h5 class="text-primary font-weight-bold m-0"><i class="fas fa-plus-circle"></i>
                        <asp:Label ID="lblPageHeader" runat="server"></asp:Label></h5>
                    <asp:HyperLink ID="hyAddWorkParty" NavigateUrl="~/AdminPanel/JWM_WorkParty/JWM_WorkPartyList.aspx" runat="server" CssClass="btn btn-success btn-sm d-sm-inline-block">
                            <i class="fas fa-list-ul"></i>&nbsp;&nbsp;Work Party List
                    </asp:HyperLink>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label>Party Name:</label>
                        <div class="input-group">
                            <div class="input-group-text"><i class="glyphicon glyphicon-briefcase"></i></div>
                            <asp:TextBox type="text" ID="txtWorkPartyName" runat="server" class="form-control" placeholder="Enter Party Name"></asp:TextBox>
                        </div>
                        <asp:RequiredFieldValidator ID="rfvWorkPartyName" runat="server" ControlToValidate="txtWorkPartyName" ErrorMessage="Enter Party Name" ForeColor="Red" SetFocusOnError="True" Display="None"></asp:RequiredFieldValidator>
                    </div>
                    <div class="row">
                        <div class="col-lg-6">
                            <div class="form-group">
                                <label>Phone number:</label>
                                <div class="input-group">
                                    <div class="input-group-text"><i class="glyphicon glyphicon-phone"></i></div>
                                    <asp:TextBox type="text" ID="txtMobileNo" runat="server" MaxLength="10" class="form-control" placeholder="Enter Mobile number"></asp:TextBox>
                                </div>
                                <asp:RequiredFieldValidator ID="rfvMobileNo" runat="server" ControlToValidate="txtMobileNo" ErrorMessage="Enter Mobile Number" pattern="[0-9]{10}" ForeColor="Red" SetFocusOnError="True" Display="None"></asp:RequiredFieldValidator>

                                <asp:RegularExpressionValidator ID="rgvMobileNo" runat="server" ControlToValidate="txtMobileNo" ErrorMessage="Enter Valid Mobile Number" ValidationExpression="[0-9]{10}" ForeColor="Red" Display="None"></asp:RegularExpressionValidator>
                            </div>
                        </div>
                        <div class="col-lg-6">
                            <div class="form-group">
                                <label>Email:</label>

                                <div class="input-group">
                                    <div class="input-group-text"><i class="glyphicon glyphicon-envelope"></i></div>
                                    <asp:TextBox type="text" ID="txtEmail" runat="server" class="form-control" placeholder="Enter Email"></asp:TextBox>
                                </div>
                                <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Enter Email" ForeColor="Red" SetFocusOnError="True" Display="None"></asp:RequiredFieldValidator>

                                <asp:RegularExpressionValidator ID="rgvEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Enter Valid Email" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" ForeColor="Red" Display="None"></asp:RegularExpressionValidator>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-6">
                            <div class="form-group">
                                <label>Address :</label>
                                <asp:TextBox type="text" ID="txtAddress" TextMode="MultiLine" Rows="3" runat="server" class="form-control" placeholder="Enter Address"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvAddress" runat="server" ControlToValidate="txtAddress" ErrorMessage="Enter Address" ForeColor="Red" SetFocusOnError="True" Display="None"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="col-lg-6">
                            <div class="form-group">
                                <label>Remarks :</label>
                                <asp:TextBox type="text" ID="txtRemarks" TextMode="MultiLine" Rows="3" runat="server" class="form-control" placeholder="Enter Remarks"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="btn fa-pull-right">
                        <asp:Button runat="server" ID="btnSave" type="Submit" class="btn btn-primary btn-sm d-sm-inline-block" Text="Save" OnClick="btnSave_Click" />
                        <asp:HyperLink ID="hlCancel" runat="server" NavigateUrl="~/AdminPanel/JWM_WorkParty/JWM_WorkPartyList.aspx" type="reset" class="btn btn-secondary btn-sm d-sm-inline-block">Cancel</asp:HyperLink>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphScripts" runat="Server">
</asp:Content>