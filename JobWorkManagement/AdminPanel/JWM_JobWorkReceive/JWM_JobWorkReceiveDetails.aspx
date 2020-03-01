<%@ Page Title="" Language="C#" MasterPageFile="~/Content/AdminPanel.master" AutoEventWireup="true" CodeFile="JWM_JobWorkReceiveDetails.aspx.cs" Inherits="AdminPanel_JWM_JobWorkReceive_JWM_WorkReceiveDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="Server">
    <div class="container-fluid">
        <%--Collepse Effect for View page Start--%>
        <div class="block">

            <asp:Label ID="lblPageHeader" runat="server" />

            <div class="card shadow">
                <div class="card-header py-3">
                    <p class="text-primary m-0 text-xl-center font-weight-bold"><i class="fas fa-exclamation-circle sidebar-brand-text mx-1"></i><span>Work Party Info</span></p>
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
                                    <asp:Label ID="lblQuantityReceive_XXXXX" Text="Qty. Received" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblQuantityReceive" runat="server" CssClass="alert alert-primary"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblQuantityDamaged_XXXXX" Text="Qty. Damage" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblQuantityDamaged" runat="server" CssClass="alert alert-danger"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblQuantityActual_XXXXX" Text="Qty. Actual" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblQuantityActual" runat="server" CssClass="alert alert-success"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblEstimatedDeliveryDate_XXXXX" Text="Estimated Delivery Date" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblEstimatedDeliveryDate" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblRate_XXXXX" Text="Rate<small>(per Quantity)<small>" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblRate" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblTotalAmount_XXXXX" Text="Total Amount" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblTotalAmount" runat="server"></asp:Label>
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