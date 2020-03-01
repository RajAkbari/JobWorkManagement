<%@ Page Title="" Language="C#" MasterPageFile="~/Content/AdminPanel.master" AutoEventWireup="true" CodeFile="JWM_WorkPartyLedges.aspx.cs" Inherits="AdminPanel_JWM_PartyLedges_JWM_WorkPartyLedges" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="Server">
    <div class="container-fluid">
        <div class="card shadow">
            <div class="card-header py-3">
                <p class="text-primary m-0 font-weight-bold"><i class="fas fa-exclamation-circle sidebar-brand-text mx-1"></i><span>Party Ledge</span></p>
            </div>
        </div>
        <div class="card-body">
            <div class="table-hover table-responsive-sm table " id="dataTable" role="grid" aria-describedby="dataTable_info">
                <table class="table dataTable my-0">
                    <%--<asp:GridView ID="gvJobTypeList" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-hover mt-3" OnRowCommand="GvJobType_RowCommand">
                        <Columns>
                            <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" HeaderStyle-CssClass="text-center">
                                <ItemTemplate>
                                    <asp:HyperLink ID="hlEdit" runat="server" Text="Edit" CssClass="btn btn-warning btn-sm d-sm-inline-block" NavigateUrl='<%# "~/AdminPanel/JWM_JobType/JWM_JobTypeAddEdit.aspx?JobTypeID=" + Eval("JobTypeID").ToString().Trim() %>'><i class="far fa-edit"></i></asp:HyperLink>
                                    <asp:LinkButton ID="btnDelete" runat="server" Text="Delete" CssClass="btn btn-danger btn-sm d-sm-inline-block" CommandName="DeleteRecord" CommandArgument='<%# Eval("JobTypeID") %>'><i class="far fa-trash-alt"></i></asp:LinkButton>
                                    <asp:HyperLink ID="hlView" runat="server" Text="Details" CssClass="btn btn-secondary btn-sm d-sm-inline-block" NavigateUrl='<%# String.Concat("JWM_JobViewDetails.aspx?","JobTypeID=",Eval("JobTypeID")) %>'><i class="far fa-eye"></i></asp:HyperLink>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="SrNo" HeaderText="Sr." />
                            <asp:BoundField DataField="JobTypeName" HeaderText="Job Type" />
                            <asp:BoundField DataField="CreationDate" HeaderText="Creation Date" DataFormatString="{0:dd/MM/yyyy}" />
                            <asp:BoundField DataField="ModifiedDate" HeaderText="Modified Date" DataFormatString="{0:dd/MM/yyyy}" />
                        </Columns>
                    </asp:GridView>--%>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphScripts" runat="Server">
</asp:Content>