﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Content/AdminPanel.master" AutoEventWireup="true" CodeFile="JWM_WorkPartyDetails.aspx.cs" Inherits="AdminPanel_JWM_WorkParty_JWM_WorkPartyDetails" %>

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
            <div class="shadow-lg card">
                <div class="card bg-light">
                    <div class="card-body text-left text-dark">
                        <div class="row">
                            <div class="col-md-12">
                                <asp:Label ID="lblMessage" runat="server" CssClass="badge badge-success"></asp:Label>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group row">
                                    <label class="col-md-6">
                                        <i class="sidebar-brand-text mx-1" style="font-size: medium" ></i>Work Party ID &nbsp; : &nbsp;
                                        <asp:Label ID="lblWorkPartyID" runat="server" Text='<%# string.Concat(" : ",Eval("WorkPartyID")) %>'></asp:Label>
                                    </label>
                                </div>
                                <div class="form-group row">
                                    <label class="col-md-6">
                                        <i class="sidebar-brand-text mx-1" style="font-size: medium"></i>Work Party Name &nbsp; : &nbsp;
                                        <asp:Label ID="lblWorkPartyName" runat="server" Text='<%# string.Concat(" : ",Eval("WorkPartyName")) %>'></asp:Label>
                                    </label>
                                </div>
                                <div class="form-group row">
                                    <label class="col-md-6">
                                        <i class="sidebar-brand-text mx-1" style="font-size: medium"></i>Address &nbsp; : &nbsp;
                                <asp:Label ID="lblAddress" runat="server" Text='<%# string.Concat(" : ",Eval("Address")) %>'></asp:Label>
                                    </label>
                                </div>
                                <div class="form-group row">
                                    <label class="col-md-6">
                                        <i class="sidebar-brand-text mx-1" style="font-size: medium"></i>Mobile No. &nbsp; : &nbsp;
                                <asp:Label ID="lblMobile" runat="server" Text='<%# string.Concat(" : ",Eval("MobileNo")) %>' ></asp:Label>
                                    </label>
                                </div>
                                <div class="form-group row">
                                    <label class="col-md-6">
                                        <i class="sidebar-brand-text mx-1" style="font-size: medium"></i>Email &nbsp; : &nbsp;
                                <asp:Label ID="lblEmail" runat="server" Text='<%# string.Concat(" : ",Eval("Email")) %>' ></asp:Label>
                                    </label>
                                </div>
                                <div class="form-group row">
                                    <label class="col-md-6">
                                        <i class="sidebar-brand-text mx-1" style="font-size: medium"></i>Creation Date &nbsp; : &nbsp;
                                <asp:Label ID="lblCreationDate" runat="server" Text='<%# string.Concat(" : ",Eval("CreationDate")) %>'></asp:Label>
                                    </label>
                                </div>
                                <div class="form-group row">
                                    <label class="col-md-6">
                                        <i class="sidebar-brand-text mx-1" style="font-size: medium"></i>Modified Date &nbsp; : &nbsp;
                                <asp:Label ID="lblModifiedDate" runat="server" Text='<%# string.Concat(" : ",Eval("ModifiedDate")) %>'></asp:Label>
                                    </label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphScripts" runat="Server">
</asp:Content>
