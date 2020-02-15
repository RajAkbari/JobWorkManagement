<%@ Page Title="" Language="C#" MasterPageFile="~/Content/AdminPanel.master" AutoEventWireup="true" CodeFile="JWM_JobWorkReceiveAddEdit.aspx.cs" Inherits="AdminPanel_JWM_WorkReceive_WorkReceiveAddEdit" %>

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
                    <asp:HyperLink ID="hyAddWorkReceive" NavigateUrl="~/AdminPanel/JWM_JobWorkReceive/JWM_JobWorkReceiveList.aspx" runat="server" Text="Work Receive List" CssClass="btn btn-success btn-sm d-sm-inline-block"></asp:HyperLink>
                </div>
                <div class="card-body">
                    <div class="row">
                        <div class="col-lg-4">
                            <div class="form-group">
                                <label>Job Type</label>
                                <asp:DropDownList ID="ddlJobType" runat="server" CssClass="form-control"></asp:DropDownList>
                                <asp:RequiredFieldValidator runat="server" ID="rfvddlJobType" ControlToValidate="ddlJobType" InitialValue="-1" ErrorMessage="Select Job Type" ForeColor="Red" SetFocusOnError="True" Display="Dynamic" />
                            </div>
                        </div>
                        <div class="col-lg-8">
                            <div class="form-group">
                                <label>Party</label>
                                <asp:DropDownList ID="ddlWorkParty" runat="server" CssClass="form-control"></asp:DropDownList>
                                <asp:RequiredFieldValidator runat="server" ID="rfvddlWorkParty" ControlToValidate="ddlWorkParty" InitialValue="-1" ErrorMessage="Select Work Party" ForeColor="Red" SetFocusOnError="True" Display="Dynamic" />
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-4">
                            <div class="form-group">
                                <label>Received Quantity</label>
                                <asp:TextBox type="text" ID="txtReceiveQuantity" runat="server" class="form-control" placeholder="Enter Total Quantity"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvQuantityReceive" runat="server" ControlToValidate="txtReceiveQuantity" ErrorMessage="Enter Received Quantity" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>

                            </div>
                        </div>
                        <div class="col-lg-4">
                            <div class="form-group">
                                <label>Damage Quantity</label>
                                <asp:TextBox type="text" ID="txtDamageQuantity" runat="server" class="form-control" placeholder="Enter Damage Quantity"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvDamageQuantity" runat="server" ControlToValidate="txtDamageQuantity" ErrorMessage="Enter Damaged Quantity" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>

                            </div>
                        </div>
                        <div class="col-lg-4">
                            <div class="form-group">
                                <label>Actual Quanity</label>
                                <asp:TextBox type="text" ID="txtActualQuantity" runat="server" class="form-control" placeholder="Enter Actual Quantity"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvActualQuantity" runat="server" ControlToValidate="txtActualQuantity" ErrorMessage="Enter Actual Quantity" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>

                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-8">
                            <div class="row">
                                <div class="col-lg-6">
                                    <label>Receive Date</label>
                                    <asp:TextBox type="text" ID="txtWorkReceiveDate" runat="server" class="form-control" TextMode="Date" placeholder="Enter Work Receive Date"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvWorkReceiveDate" runat="server" ControlToValidate="txtWorkReceiveDate" ErrorMessage="Enter Work Receive Date" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-6">
                                    <label>Estimate Delivery Date</label>
                                    <asp:TextBox type="text" ID="txtEstimatedDate" runat="server" class="form-control" TextMode="Date" placeholder="Enter Estimated Date"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvEstimatedDate" runat="server" ControlToValidate="txtEstimatedDate" ErrorMessage="Enter Estimated Delivery Date" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-lg-6">
                                    <label>Rate(Per Quantity)</label>
                                    <asp:TextBox type="text" ID="txtRate" runat="server" class="form-control" placeholder="Enter Rate"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvRate" runat="server" ControlToValidate="txtRate" ErrorMessage="Enter Rate" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>

                                </div>
                                <div class="col-lg-6">
                                    <label>Amount</label>
                                    <asp:TextBox type="text" ID="txtTotalAmount" runat="server" class="form-control" placeholder="Enter Total Amount "></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvTotalAmount" runat="server" ControlToValidate="txtTotalAmount" ErrorMessage="Enter Total Amount" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>

                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4">
                            <label>Remarks</label>
                            <asp:TextBox type="text" ID="txtRemarks" TextMode="MultiLine" Rows="5" runat="server" class="form-control" placeholder="Enter Remarks"></asp:TextBox>
                        </div>
                    </div>
                    <br />
                            <div class="form-check">
                                <asp:CheckBox ID="ckbIsActive" runat="server"  />
                                <label class="form-check-label" for="ckbIsActive">Is Complete</label>
                         </div>
                            <div class="btn fa-pull-right">
                                <asp:Button runat="server" ID="btnSave" type="Submit" class="btn btn-primary btn-sm d-sm-inline-block" Text="Save" OnClick="btnSave_Click" />
                                <asp:HyperLink ID="hlCancel" runat="server" NavigateUrl="~/AdminPanel/JWM_JobWorkReceive/JWM_JobWorkReceiveList.aspx" type="reset" class="btn btn-secondary btn-sm d-sm-inline-block">Cancel</asp:HyperLink>
                            </div>
                        
                 </div>
                </div>
            </div>
        </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphScripts" runat="Server">

    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.4/jquery.min.js"></script>
    <script type="text/javascript">
        function functionx(evt) {
            if (evt.charCode > 31 && (evt.charCode < 48 || evt.charCode > 57)) {
                alert("Allow Only Numbers");
                return false;
            }
        }
    </script>

    <script type="text/javascript">
        $(function () {
            var ReceiveQuantity = $('input:text[id$=txtReceiveQuantity]').keyup(foo);
            var DamageQuantity = $('input:text[id$=txtDamageQuantity]').keyup(foo);
            var ActualQuantity = $('input:text[id$=txtActualQuantity]').keyup(foo);
            function foo() {
                var value1 = ReceiveQuantity.val();
                var value2 = DamageQuantity.val();
                if (IsNumeric(value2)) {
                    if (IsNumeric(value1)) {
                        var value3 = parseFloat(value1) - parseFloat(value2);
                        $('input:text[id$=txtActualQuantity]').val(value3);
                    }
                }
                value3 = ActualQuantity.val();
            }
            function IsNumeric(input) {
                return (input - 0) == input && input.length > 0;
            }
        });
    </script>

    <script type="text/javascript">
        $(function () {
            var ActualQuantity = $('input:text[id$=txtActualQuantity]').keyup(foo);
            var Rate = $('input:text[id$=txtRate]').keyup(foo);
            var TotalAmount = $('input:text[id$=txtTotalAmount]').keyup(foo);
            function foo() {
                var value1 = ActualQuantity.val();
                var value2 = Rate.val();
                if (IsNumeric(value2)) {
                    if (IsNumeric(value1)) {
                        var value3 = parseFloat(value1) * parseFloat(value2);
                        $('input:text[id$=txtTotalAmount]').val(value3);
                    }
                }
                value3 = TotalAmount.val();
            }
            function IsNumeric(input) {
                return (input - 0) == input && input.length > 0;
            }
        });
    </script>
</asp:Content>

