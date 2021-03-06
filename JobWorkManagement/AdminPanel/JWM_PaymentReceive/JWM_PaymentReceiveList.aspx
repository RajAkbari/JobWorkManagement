﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Content/AdminPanel.master" AutoEventWireup="true" CodeFile="JWM_PaymentReceiveList.aspx.cs" Inherits="AdminPanel_JWM_PaymentReceive_PaymentReceiveList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        .input-group-addon {
            padding: .5rem .75rem;
            margin-bottom: 0;
            font-size: 1rem;
            font-weight: 400;
            line-height: 0.75;
            color: #464a4c;
            text-align: center;
            background-color: #eceeef;
            border: 1px solid rgba(0,0,0,.15);
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="Server">

    <div class="container">
        <div class="d-sm-flex justify-content-between align-items-center mb-4">
            <h4 class="text-dark mb-0">
                <asp:Label ID="lblHeader" runat="server" Text="Payment Receive List"></asp:Label>
                (<asp:Label ID="lblCount" runat="server" Text="Payment Receive Count"></asp:Label>)
            </h4>
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
            <div>
                <asp:HyperLink ID="hlAddWorkReceive" runat="server" NavigateUrl="~/AdminPanel/JWM_PaymentReceive/JWM_PaymentReceiveAddEdit.aspx" Text="Add Payment Receive" CssClass="btn btn-primary btn-sm d-sm-inline-block "></asp:HyperLink>
            </div>
        </div>

        <div class="card shadow">
            <div class="card-header py-3">
                <p class="text-primary m-0 font-weight-bold"><i class="fas fa-cogs sidebar-brand-text mx-1"></i><span>Search</span></p>
            </div>
            <div class="card-body">
                <div class="form-group row">
                    <div class="col-sm-3">
                        <asp:DropDownList ID="ddlWorkParty" runat="server" CssClass=" form-control form-control-sm "></asp:DropDownList>
                    </div>
                    <div class="col-sm-7">
                        <div class="form-group input-group input-daterange">
                            <asp:TextBox type="text" ID="txtfromdate" runat="server" class="form-control form-control-sm" TextMode="Date"></asp:TextBox>
                            <div class="input-group-addon">to</div>
                            <asp:TextBox type="text" ID="txttodate" runat="server" class="form-control form-control-sm" TextMode="Date"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-2">
                        <asp:Button runat="server" ID="btnShow" Text="Search" CssClass="btn btn-success btn-sm d-sm-inline-block" ValidationGroup="show" OnClick="btnShow_Click" />
                        <asp:Button runat="server" ID="btnClear" Text="Clear" CssClass="btn btn-danger btn-sm d-sm-inline-block" ValidationGroup="show" OnClick="btnClear_Click" />
                    </div>
                </div>
            </div>
        </div>

        &nbsp;

        <div class="card shadow">
            <div class="card-header py-3">
                <p class="text-primary m-0 font-weight-bold">
                    <i class="fas fa-search sidebar-brand-text mx-1"></i><span>Search Result</span>&nbsp;
                    <asp:Label ID="lblRecord" runat="server" CssClass="text-dark mb-0"></asp:Label>
                </p>
            </div>
            <div class="card-body">
                <div class="table-hover table-responsive-sm table " id="dataTable" role="grid" aria-describedby="dataTable_info">
                    <table class="table dataTable my-0">
                        <asp:GridView ID="gvPaymentReceiveList" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-hover mt-3 " OnRowCommand="GvPaymentReceive_RowCommand">
                            <Columns>
                                <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" HeaderStyle-CssClass="text-center">
                                    <ItemTemplate>
                                        <asp:HyperLink ID="hlEdit" runat="server" Text="Edit" CssClass="btn btn-warning btn-sm d-sm-inline-block" NavigateUrl='<%# "~/AdminPanel/JWM_PaymentReceive/JWM_PaymentReceiveAddEdit.aspx?PaymentReceiveID=" + Eval("PaymentReceiveID").ToString().Trim() %>'><i class="far fa-edit"></i></asp:HyperLink>
                                        <asp:LinkButton ID="btnDelete" runat="server" Text="Delete" CssClass="btn btn-danger btn-sm d-sm-inline-block" CommandName="DeleteRecord" CommandArgument='<%# Eval("PaymentReceiveID") %>'><i class="far fa-trash-alt"></i></asp:LinkButton>
                                        <asp:HyperLink ID="hlView" runat="server" Text="Details" CssClass="btn btn-secondary btn-sm d-sm-inline-block" NavigateUrl='<%# String.Concat("JWM_PaymentReceiveDetails.aspx?","PaymentReceiveID=",Eval("PaymentReceiveID")) %>'><i class="far fa-eye"></i></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="SrNo" HeaderText="Sr." />
                                <asp:BoundField DataField="WorkPartyName" HeaderText="Party" />
                                <asp:BoundField DataField="PaymentReceiveDate" HeaderText="Payment Date" DataFormatString="{0:dd/MM/yyyy}" />
                                <asp:BoundField DataField="Amount" HeaderText="Amount" />
                            </Columns>
                        </asp:GridView>
                    </table>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphScripts" runat="Server">
</asp:Content>