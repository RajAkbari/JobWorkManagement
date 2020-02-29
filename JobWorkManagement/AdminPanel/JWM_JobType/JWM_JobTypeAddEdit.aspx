<%@ Page Title="" Language="C#" MasterPageFile="~/Content/AdminPanel.master" AutoEventWireup="true" CodeFile="JWM_JobTypeAddEdit.aspx.cs" Inherits="AdminPanel_JWM_JobType_JobTypeAddEdit" %>

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
                        <asp:Label ID="lblPageHeader" runat="server"></asp:Label>
                    </h5>
                    <asp:HyperLink ID="hlAddJobType" runat="server" NavigateUrl="~/AdminPanel/JWM_JobType/JWM_JobTypeList.aspx" class="btn btn-success btn-sm d-sm-inline-block"><i class="fas fa-list-ul"></i>&nbsp;&nbsp;&nbsp;Job Type List</asp:HyperLink>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label>Job Type Name:</label>
                        <div class="input-group">
                            <div class="input-group-text"><i class="glyphicon glyphicon-user"></i></div>
                            <asp:TextBox type="text" ID="txtJobTypeName" runat="server" CssClass="form-control" placeholder="Enter Job Type Name"></asp:TextBox>
                        </div>
                        <asp:RequiredFieldValidator ID="rfvJobTypeName" runat="server" ControlToValidate="txtJobTypeName" ErrorMessage="Enter Job Name" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label>Remarks :</label>
                        <asp:TextBox type="text" ID="txtRemarks" TextMode="MultiLine" Rows="3" runat="server" class="form-control" placeholder="Enter Remarks"></asp:TextBox>
                    </div>
                    <div class="btn fa-pull-right">
                        <asp:Button runat="server" ID="btnSave" type="Submit" class="btn btn-primary btn-sm d-sm-inline-block" Text="Save" OnClick="btnSave_Click" />
                        <asp:HyperLink ID="hlCancel" runat="server" NavigateUrl="~/AdminPanel/JWM_JobType/JWM_JobTypeList.aspx" type="reset" class="btn btn-secondary btn-sm d-sm-inline-block">Cancel</asp:HyperLink>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphScripts" runat="Server">
</asp:Content>