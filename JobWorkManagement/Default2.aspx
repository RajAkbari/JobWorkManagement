<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.4/jquery.min.js"></script>
    <script type="text/javascript">
        $(function () {
            var textBox1 = $('input:text[id$=TextBox1]').keyup(foo);
            var textBox2 = $('input:text[id$=TextBox2]').keyup(foo);

            function foo() {
                var value1 = textBox1.val();
                var value2 = textBox2.val();
                var sum = add(value1, value2);
                $('input:text[id$=TextBox3]').val(sum);
            }

            function add() {
                var sum = 0;
                for (var i = 0, j = arguments.length; i < j; i++) {

                    if (IsNumeric(arguments[i])) {

                        sum += parseFloat(arguments[i]);

                    }

                }

                return sum;

            }

            function IsNumeric(input) {

                return (input - 0) == input && input.length > 0;
            }
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table width="300px" border="1" style="border-collapse: collapse; background-color: #E8DCFF">
                <tr>
                    <td>Butter</td>
                    <td>
                        <asp:TextBox runat="server" ID="TextBox1"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Cheese</td>
                    <td>
                        <asp:TextBox runat="server" ID="TextBox2"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Total</td>
                    <td>
                        <asp:TextBox runat="server" ID="TextBox3"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>