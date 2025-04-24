<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ejercicio2.aspx.cs" Inherits="TP4_Grupo_8.ejercicio2" %>

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
            width: 125px;
        }
        .auto-style3 {
            width: 125px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            width: 103px;
        }
        .auto-style6 {
            width: 102px;
        }
        .auto-style7 {
            width: 104px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style5">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style6">
                                    <asp:DropDownList ID="DdlProducto" runat="server">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:TextBox ID="TxtProducto" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style4">
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style6">
                                    <asp:DropDownList ID="DdlCategoria" runat="server">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:TextBox ID="TxtCategoria" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style7">&nbsp;</td>
                                <td>
                                    <asp:Button ID="BtnFiltrar" runat="server" OnClick="BtnFiltrar_Click" Text="Filtrar" />
                                    <asp:Button ID="BtnQuitar" runat="server" OnClick="BtnQuitar_Click" Text="Quitar filtro" />
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:GridView ID="gvTablaProductos" runat="server">
                        </asp:GridView>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
