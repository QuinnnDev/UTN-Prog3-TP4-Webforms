﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ejercicio1.aspx.cs" Inherits="TP4_Grupo_8.ejercicio1" %>

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
            height: 23px;
        }
        .auto-style3 {
            width: 149px;
        }
        .auto-style4 {
            height: 23px;
            width: 149px;
        }
        .auto-style5 {
            height: 54px;
        }
        .auto-style6 {
            width: 149px;
            height: 54px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
            <table class="auto-style1">
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="lblDestInicio" runat="server" Text="DESTINO INICIO" Font-Overline="False" Font-Underline="True"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
                    <td class="auto-style4">
                        <asp:Label ID="lblProvinciaInicio" runat="server" Font-Bold="True" Text="PROVINCIA:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="ddlProvinciaInicio" runat="server" AutoPostBack="True" Height="22px" OnSelectedIndexChanged="ddlProvinciaInicio_SelectedIndexChanged" Width="209px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="lblLocalidadInicio" runat="server" Font-Bold="True" Text="LOCALIDAD:"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlLocalidadInicio" runat="server" Height="17px" Width="207px" Enabled="False">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="lblDestFinal" runat="server" Text="DESTINO FINAL" Font-Overline="False" Font-Underline="True"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="lblProvinciaFinal" runat="server" Font-Bold="True" Text="PROVINCIA:"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlProvinciaFinal" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="ddlProvinciaFinal_SelectedIndexChanged" Width="214px">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvProvinciaFinal" runat="server" ControlToValidate="ddlProvinciaFinal" ErrorMessage="seleccione una provincia final " ForeColor="Red" InitialValue="0" ValidateRequestMode="Disabled" ValidationGroup="vsDestino">* </asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="lblLocalidadFinal" runat="server" Font-Bold="True" Text="LOCALIDAD:"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlLocalidadFinal" runat="server" Height="16px" Width="211px" Enabled="False">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style5"></td>
                    <td class="auto-style5"></td>
                    <td class="auto-style5"></td>
                    <td class="auto-style5"></td>
                    <td class="auto-style5"></td>
                    <td class="auto-style5"></td>
                    <td class="auto-style5"></td>
                </tr>
            </table>
    </form>
</body>
</html>
