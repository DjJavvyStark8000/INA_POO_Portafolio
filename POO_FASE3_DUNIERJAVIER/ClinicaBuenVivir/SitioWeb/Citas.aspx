<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Citas.aspx.cs" Inherits="SitioWeb.Citas" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="css/citas.css" />
</head>
<body>
    <h1 id="mensaje-pantalla-completa">Vista móvil no esta disponible</h1>
    <div id="contenido-normal">
        <h1>Clínica el Buen Vivir | Citas</h1>
        <form id="Citas" runat="server">

            <div class="panel-container-left">
                <asp:Panel ID="panel1" runat="server" GroupingText="Identificación" Height="75px" CssClass="panel-item" BackColor="#99B4D1" Width="100%">
                    <table>
                        <tr>
                            <td class="label">
                                <asp:Label ID="lblNumId" runat="server" Text="Número de Identificación"></asp:Label>
                            </td>
                            <td class="input">
                                <asp:TextBox ID="txtIdPaciente" runat="server" Width="226px" Height="17px" Enabled="False"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>

                <asp:Panel ID="panel2" runat="server" GroupingText="Datos del paciente" Height="325px" CssClass="panel-item" BackColor="#99B4D1" Width="100%">
                    <fieldset>
                        <legend>Datos del paciente</legend>
                        <div>
                            <table>
                                <tr>
                                    <td class="label">
                                        <asp:Label ID="lblNombreCompleto" runat="server" Text="Nombre Completo"></asp:Label>
                                    </td>
                                    <td class="input">
                                        <asp:TextBox ID="txtNombreCompleto" runat="server" Enabled="False" Height="17px" Width="290px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="label">
                                        <asp:Label ID="lblMotivo" runat="server" Text="Motivo"></asp:Label>
                                    </td>
                                    <td class="input">
                                        <asp:TextBox ID="txtMotivo" runat="server" Height="17px" Width="292px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="label">
                                        <asp:Label ID="lblEstado" runat="server" Text="Estado"></asp:Label>
                                    </td>
                                    <td class="input">
                                        <asp:DropDownList ID="selectEstado" runat="server" Enabled="False" Style="margin-left: 0px; margin-top: 8px" Width="300px">
                                            <asp:ListItem Text="Activo" Value="Activo" />
                                            <asp:ListItem Text="Inactivo" Value="Inactivo" />
                                            <asp:ListItem Text="Cancelado" Value="Cancelado" />
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="label">
                                        <asp:Label ID="lblObservaciones" runat="server" Text="Observaciones"></asp:Label>
                                    </td>
                                    <td class="input">
                                        <asp:TextBox ID="txtObservaciones" runat="server" Height="137px" TextMode="MultiLine" Width="295px"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </fieldset>
                </asp:Panel>
            </div>
            <div class="panel-container-right">
                <asp:Panel ID="panel3" runat="server" GroupingText="Seleccione médico, fecha y hora de la cita" Height="400px" CssClass="panel-item-right" BackColor="#99B4D1" Width="100%">
                    <table style="height: 212px">
                        <tr>
                            <td class="label">
                                <asp:Label ID="lblMedico" runat="server" Text="Médicos disponibles" Style="margin-right: 10px; margin-top: 0px; width: 100%"></asp:Label>
                                <asp:DropDownList ID="selectMedico" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownFuncionarios_SelectedIndexChanged" Width="179px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="input">
                                <asp:Label ID="lblFecha" runat="server" Text="Fecha disponibles"></asp:Label>
                                <asp:Calendar ID="Calendario" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
                            </td>
                        </tr>
                        <tr>
                            <td class="label">
                                <asp:Label ID="lblHora" runat="server" Text="Horas disponibles" Style="margin-right: 10px; margin-top: 0px"></asp:Label>
                                <asp:DropDownList ID="selectHora" runat="server" Width="200px" Style="margin-left: 0px; margin-top: 8px" Enabled="False" OnSelectedIndexChanged="selectHora_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </div>
            <div class="panel-container-bottom-left">
                <asp:Panel ID="panel4" runat="server" GroupingText="Monto y método de pago" Height="120px" CssClass="panel-item-right" BackColor="#99B4D1" Width="100%">
                    <table>
                        <tr>
                            <td class="label">
                                <asp:Label ID="Label2" runat="server" Text="Monto a pagar ₡"></asp:Label>
                            </td>
                            <td class="input">
                                <asp:TextBox ID="txtPago" runat="server" Width="292px" Height="17px" Enabled="False">80000</asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="label">
                                <asp:Label ID="Label3" runat="server" Text="Método de pago"></asp:Label>
                            </td>
                            <td class="input">
                                <asp:DropDownList ID="selectMetodoPago" runat="server" Width="300px" Style="margin-left: 0px; margin-top: 8px">
                                    <asp:ListItem Text="Visa" Value="Visa" />
                                    <asp:ListItem Text="Paypal" Value="Paypal" />
                                    <asp:ListItem Text="Efectivo" Value="Efectivo" />
                                    <asp:ListItem Text="Cheque" Value="Cheque" />
                                    <asp:ListItem Text="Apple Pay" Value="Apple Pay" />
                                    <asp:ListItem Text="Google Pay" Value="Google Pay" />
                                    <asp:ListItem Text="MasterCard" Value="MasterCard" />
                                    <asp:ListItem Text="Sinpe Movil" Value="Sinpe Movil" />
                                    <asp:ListItem Text="Transferencia" Value="Transferencia" />
                                    <asp:ListItem Text="Orden de dinero" Value="Orden de dinero" />
                                    <asp:ListItem Text="American Express" Value="American Express" />
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                    <asp:Button ID="guardarCita" runat="server" Text="Guardar" OnClick="guardarCita_Click" />
                </asp:Panel>
            </div>
            <br />
            <div class="panel-container-bottom-left">
                <asp:Panel ID="panel5" runat="server" GroupingText="Lista de Citas" Height="120px" CssClass="panel-item-right" BackColor="#99B4D1" Width="100%">
                    <asp:GridView ID="dgrMisCitas" runat="server" AutoGenerateColumns="False" Height="16px" Style="margin-left: 6px; margin-top: 35px" Width="1177px">
                        <Columns>
                            <asp:BoundField HeaderText="CITA_ID" DataField="CitasId" />
                            <asp:BoundField DataField="Estado" HeaderText="ESTADO" />
                            <asp:BoundField HeaderText="FECHA" DataField="FechaCita" />
                            <asp:BoundField HeaderText="HORA" DataField="HoraCita" />
                            <asp:BoundField HeaderText="MOTIVO" DataField="Motivo" />
                            <asp:BoundField HeaderText="MÉDICO" DataField="Medico" />
                            <asp:BoundField HeaderText="MONTO" DataField="Monto" />
                            <asp:BoundField HeaderText="OBSERVACIONES" DataField="Observaciones" />
                            <asp:TemplateField HeaderText="CANCELAR">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkCancelar" runat="server" OnCommand="lnkCancelar_Command" CommandArgument='<%# Eval("CitasId").ToString() %>'>Cancelar</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </asp:Panel>
            </div>
        </form>
    </div>
</body>
</html>
