<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SitioWeb.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="css/styles.css" />
</head>
<body>
    <form id="form" runat="server">
        <div>
            <h2>Formulario de acceso</h2>
            <label for="Select1">Roll de Usuario:</label>
            <asp:DropDownList ID="SelectRoll" runat="server" Width="300px" Style="margin-left: 0px; margin-top: 8px">
                <asp:ListItem Text="Admin" Value="Admin" />
                <asp:ListItem Text="Médico" Value="Médico" />
                <asp:ListItem Text="Funcionario" Value="Funcionario" />
                <asp:ListItem Text="Paciente" Value="Paciente" Selected="True" />
            </asp:DropDownList>
            <label for="username">Número de Usuario:</label>
            <input type="text" id="idUsuario" runat="server" />
            <label for="password">Clave de Usuario:</label>
            <input type="password" id="password" runat="server" disabled="disabled" value="1234" />
            <label for="message" style="font-weight: normal; font-size: x-small;">Clave temporal 1234</label>
            <asp:Button ID="btnLogin" runat="server" Text="Entrar" OnClick="btnLogin_Click" />
            <asp:Button ID="Registro" runat="server" Text="Registrarse" OnClick="Registro_Click" />
        </div>
    </form>

</body>
</html>
