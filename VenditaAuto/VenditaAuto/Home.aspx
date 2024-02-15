<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="VenditaAuto.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Scegli la tua auto</h2>
            <asp:DropDownList ID="ListaAuto" runat="server"></asp:DropDownList>
            <h2>Scegli i tuoi Optional</h2>
            <asp:CheckBoxList ID="ListaOptional" runat="server"></asp:CheckBoxList>
        </div>
    </form>
</body>
</html>
