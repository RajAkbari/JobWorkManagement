<%@ Page Title="" Language="C#" MasterPageFile="~/Content/AdminPanel.master" AutoEventWireup="true" CodeFile="JWM_WorkPartyLedges.aspx.cs" Inherits="AdminPanel_JWM_PartyLedges_JWM_WorkPartyLedges" %>

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
    <div class="container-fluid">
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
                        <asp:Button runat="server" ID="btnShow" Text="Search" CssClass="btn btn-success btn-sm d-sm-inline-block" ValidationGroup="show" />
                        <asp:Button runat="server" ID="btnClear" Text="Clear" CssClass="btn btn-danger btn-sm d-sm-inline-block" ValidationGroup="show" />
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
                <div class="form-group row">
                    <div class="col-sm-3">
                        <asp:Label ID="lblOpeningBalance_XXXXX" runat="server" Text="<b>Opening Balance</b>"></asp:Label>
                        <asp:TextBox type="text" ID="txtOpeningBalance" runat="server" class="form-control form-control-sm" ReadOnly="true"></asp:TextBox>
                    </div>
                </div>
                <hr />
                <div class="table-hover table-responsive-sm table " id="dataTable" role="grid" aria-describedby="dataTable_info">
                    <table class="table dataTable my-0">
                    </table>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphScripts" runat="Server">
</asp:Content>