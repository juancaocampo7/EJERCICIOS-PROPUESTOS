<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EJERCICIO4.aspx.cs" Inherits="EJERCICIOS_PROPUESTOS.EJERCICIO4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Edad:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtedad" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Número de pulsaciones:"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblnumpulsa" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btncalcular" runat="server" OnClick="btncalcular_Click" Text="Calcular" />
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
