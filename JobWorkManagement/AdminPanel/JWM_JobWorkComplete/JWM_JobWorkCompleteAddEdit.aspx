<%@ Page Title="" Language="C#" MasterPageFile="~/Content/AdminPanel.master" AutoEventWireup="true" CodeFile="JWM_JobWorkCompleteAddEdit.aspx.cs" Inherits="AdminPanel_JWM_WorkComplete_WorkCompleteAddEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="Server">

    <div class="container-fluid">
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
        <div class="col-lg-12">
            <div class="card shadow mb-4">
                <div class="card-header d-flex justify-content-between align-items-center">
                    <h5 class="text-primary font-weight-bold m-0"><i class="fas fa-plus-circle"></i>
                        <asp:Label ID="lblPageHeader" runat="server"></asp:Label></h5>
                    <asp:HyperLink ID="hyAddWorkComplete" NavigateUrl="~/AdminPanel/JWM_JobWorkComplete/JWM_JobWorkCompleteList.aspx" runat="server" Text="Work Complete List" CssClass="btn btn-success btn-sm d-sm-inline-block"> </asp:HyperLink>
                </div>
                <div class="card-body">
                    <div class="row">
                        <div class="col-lg-6">
                            <div class="form-group">
                                <label>Party :</label>
                                <asp:DropDownList ID="ddlWorkParty" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlWorkParty_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                                <asp:RequiredFieldValidator runat="server" ID="rfvddlWorkParty" ControlToValidate="ddlWorkParty" InitialValue="-1" ErrorMessage="Select Job Type" ForeColor="Red" SetFocusOnError="True" Display="Dynamic" />
                            </div>
                        </div>
                        <div class="col-lg-6">
                            <div class="form-group">
                                <label>Work Receive :</label>
                                <asp:DropDownList ID="ddlWorkReceive" runat="server" CssClass="form-control" AutoPostBack="true"></asp:DropDownList>
                                <asp:RequiredFieldValidator runat="server" ID="rfvddlWorkReceive" ControlToValidate="ddlWorkReceive" InitialValue="-1" ErrorMessage="Select Work Party" ForeColor="Red" SetFocusOnError="True" Display="Dynamic" />
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-6">
                            <div class="form-group">
                                <label>Complete Date:</label>
                                <asp:TextBox type="text" ID="txtWorkCompletedDate" runat="server" class="form-control" TextMode="Date" placeholder="Enter Work Complete Date"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvWorkCompleteDate" runat="server" ControlToValidate="txtWorkCompletedDate" ErrorMessage="Enter Work Complete Date" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="col-lg-6">
                            <div class="form-group">
                                <label>Quantity Complete:</label>
                                <asp:TextBox type="text" ID="txtQuantityComplete" runat="server" class="form-control" placeholder="Enter Quantity Done"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvQuantityComplete" runat="server" ControlToValidate="txtQuantityComplete" ErrorMessage="Enter Quantity Complete" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <label>Remarks :</label>
                        <asp:TextBox type="text" ID="txtRemarks" TextMode="MultiLine" Rows="3" runat="server" class="form-control" placeholder="Enter Remarks"></asp:TextBox>
                    </div>
                    <div class="btn fa-pull-right">
                        <asp:Button runat="server" ID="btnSave" type="Submit" class="btn btn-primary btn-sm d-sm-inline-block" Text="Save" OnClick="btnSave_Click" />
                        <asp:HyperLink ID="hlCancel" runat="server" NavigateUrl="~/AdminPanel/JWM_JobWorkComplete/JWM_JobWorkCompleteList.aspx" type="reset" class="btn btn-secondary btn-sm d-sm-inline-block">Cancel</asp:HyperLink>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphScripts" runat="Server">
</asp:Content>