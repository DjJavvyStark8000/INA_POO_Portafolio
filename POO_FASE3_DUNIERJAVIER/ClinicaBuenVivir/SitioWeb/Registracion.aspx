<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registracion.aspx.cs" Inherits="SitioWeb.Registracion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="css/registracion.css" />
    <style type="text/css">
        .auto-style1 {
            height: 45px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="panel-container-left">

                <asp:Panel ID="panelID" runat="server" BackColor="#99B4D1" GroupingText="Indentificar Paciente" Height="100px" Width="100%">
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="Número de Identificación"></asp:Label><br />
                                <asp:TextBox ID="txtNumeroId" runat="server" Width="321px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="Tipo de Identificación"></asp:Label><br />
                                <asp:DropDownList ID="selectTipoId" runat="server" Width="334px" Style="margin-left: 0px">
                                    <asp:ListItem>Cédula</asp:ListItem>
                                    <asp:ListItem>Dimex</asp:ListItem>
                                    <asp:ListItem>Pasaporte</asp:ListItem>
                                    <asp:ListItem>Permiso</asp:ListItem>
                                    <asp:ListItem>Otro</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
                <asp:Panel ID="panelDatos" runat="server" BackColor="#99B4D1" GroupingText="Datos del Paciente" Height="450px" Width="100%">
                    <table style="width: 680px">
                        <tr>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="Nombre Completo"></asp:Label><br />
                                <asp:TextBox ID="txtNombrePaciente" runat="server" Width="660px"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                    <br />
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="Número de Identificación"></asp:Label><br />
                                <asp:Calendar ID="Calendario" runat="server" Width="673px"></asp:Calendar>
                            </td>
                        </tr>
                    </table>
                    <br />
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="Label5" runat="server" Text="Género"></asp:Label><br />
                                <asp:DropDownList ID="selectGenero" runat="server" Width="215px">
                                    <asp:ListItem>Masculino</asp:ListItem>
                                    <asp:ListItem>Femenino</asp:ListItem>
                                    <asp:ListItem>Otro</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="Label7" runat="server" Text="Nacionalidad"></asp:Label><br />
                                <asp:TextBox ID="txtNacionalidad" runat="server" Width="215px" Style="margin-left: 0px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label ID="Label8" runat="server" Text="Estado Civil"></asp:Label><br />
                                <asp:DropDownList ID="selectEstadoCivil" runat="server" Width="215px">
                                    <asp:ListItem>Masculino</asp:ListItem>
                                    <asp:ListItem>Femenino</asp:ListItem>
                                    <asp:ListItem>Otro</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label6" runat="server" Text="Laborando"></asp:Label><br />
                                <asp:DropDownList ID="selectLaborando" runat="server" Width="215px">
                                    <asp:ListItem>Si</asp:ListItem>
                                    <asp:ListItem>No</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="Label9" runat="server" Text="Asegurado"></asp:Label><br />
                                <asp:DropDownList ID="selectAsegurado" runat="server" Width="215px">
                                    <asp:ListItem>Si</asp:ListItem>
                                    <asp:ListItem>No</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="Label11" runat="server" Text="Nacionalidad"></asp:Label><br />
                                <asp:TextBox ID="txtGuardian" runat="server" Width="215px" Style="margin-left: 0px"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </div>
            <div class="panel-container-right">
                <asp:Panel ID="panelContacto" runat="server" BackColor="#99B4D1" GroupingText="Datos de Contacto" Height="505px" Width="100%">
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="Label10" runat="server" Text="Telefono"></asp:Label><br />
                                <asp:TextBox ID="txtTelefono" runat="server" Width="214px" Style="margin-left: 0px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label ID="Label13" runat="server" Text="Emergencia"></asp:Label><br />
                                <asp:TextBox ID="txtEmergencia" runat="server" Width="198px" Style="margin-left: 0px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:Label ID="Label15" runat="server" Text="Ciudad"></asp:Label><br />
                                <asp:DropDownList ID="selectCiudad" runat="server" Width="222px">
                                    <asp:ListItem>CiudadA</asp:ListItem>
                                    <asp:ListItem>CiudadB</asp:ListItem>
                                    <asp:ListItem>CiudadC</asp:ListItem>
                                    <asp:ListItem>CiudadD</asp:ListItem>
                                    <asp:ListItem>CiudadE</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="auto-style1">
                                <asp:Label ID="Label16" runat="server" Text="Provincia"></asp:Label><br />
                                <asp:DropDownList ID="selectProvincia" runat="server" Width="209px">
                                    <asp:ListItem>Alajuela</asp:ListItem>
                                    <asp:ListItem>San José</asp:ListItem>
                                    <asp:ListItem>Puntarenas</asp:ListItem>
                                    <asp:ListItem>Cartago</asp:ListItem>
                                    <asp:ListItem>Limón</asp:ListItem>
                                    <asp:ListItem>Heredia</asp:ListItem>
                                    <asp:ListItem>Guanacaste</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                    <br />
                    <asp:Label ID="lblCorreo" runat="server" Text="Correo"></asp:Label><br />
                    <asp:TextBox ID="txtCorreo" runat="server" Width="430px" Height="16px"></asp:TextBox><br />
                    <br />
                    <asp:Label ID="lblDetallesDireccion" runat="server" Text="Detalles de Dirección"></asp:Label><br />
                    <br />
                    <asp:TextBox ID="txtDetallesDireccion" runat="server" Width="430px" Height="204px" TextMode="MultiLine"></asp:TextBox>
                </asp:Panel>
            </div>
        </div>
        <asp:Button ID="btnRegistrarPaciente" runat="server" Text="Registrar" Height="62px" Width="75px" OnClick="btnRegistrarPaciente_Click" />
    </form>

</body>
</html>
