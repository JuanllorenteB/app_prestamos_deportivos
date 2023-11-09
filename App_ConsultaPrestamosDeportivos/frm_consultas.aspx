<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_consultas.aspx.cs" Inherits="App_ConsultaPrestamosDeportivos.frm_consultas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Consulta de Prestamos</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txt_id" placeholder="Ingrese su documento de identidad" runat="server"></asp:TextBox>
            <asp:Button ID="btn_consultar" runat="server" Text="Consultar" />
            <asp:Button ID="btn_nuevo" runat="server" Text="Nuevo" />
        </div>
        <br>
        <br>
        <div>
            <asp:GridView ID="dtg_prestamos" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
