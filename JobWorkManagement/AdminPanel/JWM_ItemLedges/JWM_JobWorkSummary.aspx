<%@ Page Title="" Language="C#" MasterPageFile="~/Content/AdminPanel.master" AutoEventWireup="true" CodeFile="JWM_JobWorkSummary.aspx.cs" Inherits="AdminPanel_JWM_ItemLeadges_Default" %>

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
        <div class="d-sm-flex justify-content-between align-items-center mb-4">
            <h4 class="text-dark mb-0">
                <asp:Label ID="lblHeader" runat="server" Text="Job Work Summary"></asp:Label>
                (<asp:Label ID="lblCount" runat="server" Text="Total Record"></asp:Label>)
            </h4>
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </div>

        <div class="card shadow">
            <div class="card-header py-3">
                <p class="text-primary m-0 font-weight-bold"><i class="fas fa-cogs sidebar-brand-text mx-1"></i><span>Search</span></p>
            </div>
            <div class="card-body">
                <div class="form-group row">
                    <div class="col-sm-3">
                        <asp:DropDownList ID="ddlJobType" runat="server" CssClass=" form-control form-control-sm "></asp:DropDownList>
                    </div>
                    <div class="col-sm-3">
                        <asp:DropDownList ID="ddlWorkParty" runat="server" CssClass=" form-control form-control-sm "></asp:DropDownList>
                    </div>
                    
                    <div class="col-sm-6">
                        <div class="form-group input-group input-daterange">
                            <asp:TextBox type="text" ID="txtfromdate" runat="server" class="form-control form-control-sm" TextMode="Date"></asp:TextBox>
                            <div class="input-group-addon">to</div>
                            <asp:TextBox type="text" ID="txttodate" runat="server" class="form-control form-control-sm" TextMode="Date"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="col-sm-2 float-right">
                      <asp:Button runat="server" ID="btnShow" Text="Search" CssClass="btn btn-success btn-sm d-sm-inline-block" ValidationGroup="show" OnClick="btnShow_Click" />
                      <asp:Button runat="server" ID="btnClear" Text="Clear" CssClass="btn btn-danger btn-sm d-sm-inline-block" ValidationGroup="show" OnClick="btnClear_Click" />
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
                <div class="table-responsive" id="dataTable" role="grid" aria-describedby="dataTable_info">
                    <table class="table dataTable my-0">
                        <asp:GridView ID="gvJobWorkSummary" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered text-nowrap">
                            <Columns>
                                <asp:BoundField DataField="SrNo" HeaderText="Sr." />
                                <asp:BoundField DataField="JobTypeName" HeaderText="Job Type" />
                                <asp:BoundField DataField="WorkPartyName" HeaderText="Party" ItemStyle-Width="15%" />
                                <asp:BoundField DataField="QuantityReceived" HeaderText="Qty Received" />
                                <asp:TemplateField HeaderText="Status" ItemStyle-Font-Bold="true" HeaderStyle-CssClass="text-nowrap text-center" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <asp:Label ID="lblIsActive" CssClass='<%# JobWorkManagement.CommonFunction.GetStatusLabelCss(Convert.ToBoolean(Eval("IsActive")))%>' Text='<%# JobWorkManagement.CommonFunction.GetStatusLabelCompletePanding(Convert.ToBoolean(Eval("IsActive")))%>' runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="TotalAmount" HeaderText="Total Amount"  />
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