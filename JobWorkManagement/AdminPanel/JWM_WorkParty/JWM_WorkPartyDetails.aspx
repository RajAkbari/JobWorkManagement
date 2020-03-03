<%@ Page Title="" Language="C#" MasterPageFile="~/Content/AdminPanel.master" AutoEventWireup="true" CodeFile="JWM_WorkPartyDetails.aspx.cs" Inherits="AdminPanel_JWM_WorkParty_JWM_WorkPartyDetails" %>

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
                                <td style="width: 300px">
                                    <asp:Label ID="lblWorkPartyName_XXXXX" Text="Party" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblWorkPartyName" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblEmail_XXXXX" Text="Email Id" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblEmail" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblMobile_XXXXX" Text="Mobile No." runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblMobile" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblAddress_XXXXX" Text="Address" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblAddress" runat="server"></asp:Label>
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