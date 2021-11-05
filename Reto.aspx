<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reto.aspx.cs" Inherits="RETO.Reto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">



        <div>
            <table>
                <tr>
                    <td>
                        <INPUT type="text"     runat="server"  size="6000"  name="txtDatos" id="txtDatos" style="font-family: Arial, Helvetica, sans-serif; color: #000000; font-weight: bold" >
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox>
                    </td>

                </tr>


            </table>

        </div>
    </form>
</body>
</html>
