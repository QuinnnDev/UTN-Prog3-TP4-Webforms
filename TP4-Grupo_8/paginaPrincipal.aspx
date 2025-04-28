<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="paginaPrincipal.aspx.cs" Inherits="TP4_Grupo_8.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 180px;
        }
        .auto-style3 {
            width: 150px;
        }
        .auto-style4 {
            width: 193px;
        }
        .auto-style5 {
            width: 168px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Button ID="btnEjercicio1" runat="server" OnClick="btnEjercicio1_Click" Text="Ejercicio 1" Width="120px" />
                    </td>
                    <td>&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Button ID="btnEjercicio2" runat="server" OnClick="btnEjercicio2_Click" Text="Ejercicio 2" Width="120px" />
                    </td>
                    <td>&nbsp;</td>
                    <td class="auto-style4">
                        <asp:Button ID="btnEjercicio3" runat="server" OnClick="btnEjercicio3_Click" Text="Ejercicio 3" Width="120px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="lblEjercicio1" runat="server" Text="BDD Viajes"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Label ID="lblEjercicio2" runat="server" Text="BDD Neptuno"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td class="auto-style4">
                        <asp:Label ID="lblEjercicio3" runat="server" Text="BDD Libreria"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
