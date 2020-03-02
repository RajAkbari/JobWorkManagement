<%@ Page Title="" Language="C#" MasterPageFile="~/Content/AdminPanel.master" AutoEventWireup="true" CodeFile="JWM_PaymentReceiveDetails.aspx.cs" Inherits="AdminPanel_JWM_PaymentReceive_JWM_PaymentReceiveDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="Server">
    <div class="container-fluid">
        <%--Collepse Effect for View page Start--%>
        <div class="block">

            <asp:Label ID="lblPageHeader" runat="server" />

            <div class="card shadow">
                <div class="card-header py-3">
                    <p class="text-primary m-0 text-xl-center font-weight-bold"><i class="fas fa-exclamation-circle sidebar-brand-text mx-1"></i><span>Payment Receive Info</span></p>
                </div>
            </div>
            <div class="card shadow">
                <div class="card-body">
                    <div class="form-horizontal table-responsive" role="form">
                        <table class="table table-bordered table-hover">
                            <tr>
                                <td style="width: 300px">
                                    <asp:Label ID="lblWorkPartyName_XXXXX" Text="Party" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblWorkPartyName" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblPaymentReceiveDate_XXXXX" Text="Payment Receive Date" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblPaymentReceiveDate" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblAmount_XXXXX" Text="Amount" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblAmount" runat="server"></asp:Label>
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