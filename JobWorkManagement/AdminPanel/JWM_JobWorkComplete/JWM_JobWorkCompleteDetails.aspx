<%@ Page Title="" Language="C#" MasterPageFile="~/Content/AdminPanel.master" AutoEventWireup="true" CodeFile="JWM_JobWorkCompleteDetails.aspx.cs" Inherits="AdminPanel_JWM_JobWorkComplete_JWM_JobWorkCompleteDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="Server">
    <div class="container-fluid">
        <%--Collepse Effect for View page Start--%>
        <div class="block">

            <asp:Label ID="lblPageHeader" runat="server" />

            <div class="card shadow">
                <div class="card-header py-3">
                    <p class="text-primary m-0 text-xl-center font-weight-bold"><i class="fas fa-exclamation-circle sidebar-brand-text mx-1"></i><span>Job Work Complete Info</span></p>
                </div>
            </div>
            <div class="card shadow">
                <div class="card-body">
                    <div class="form-horizontal table-responsive" role="form">
                        <table class="table table-bordered table-hover">
                            <tr>
                                <td>
                                    <asp:Label ID="lblWorkPartyName_XXXXX" Text="Party" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblWorkPartyName" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblJobTypeName_XXXXX" Text="Job Type" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblJobTypeName" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblWorkCompleteDate_XXXXX" Text="Work Complete Date" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblWorkCompleteDate" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblQuantityActual_XXXXX" Text="Qty. Actual" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblQuantityActual" runat="server" CssClass="alert alert-primary"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblQuantityPanding_XXXXX" Text="Qty. Panding" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblQuantityPanding" runat="server" CssClass="alert alert-danger"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblQuantityComplete_XXXXX" Text="Qty. Complete" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblQuantityComplete" runat="server" CssClass="alert alert-success"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphScripts" runat="Server">
</asp:Content>