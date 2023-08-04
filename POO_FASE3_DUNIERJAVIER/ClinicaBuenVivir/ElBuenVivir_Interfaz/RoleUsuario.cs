using ElBuenVivir_Entidades;
using ElBuenVivir_Logica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ElBuenVivir_Interfaz
{
    public partial class RoleUsuario : Form
    {
        public RoleUsuario()
        {
            InitializeComponent();
        }

        //cargar lista funcionarios
        private void RollUsuario_Load(object sender, EventArgs e)
        {
            CargarListaFuncionarios();
        }

        private void CargarListaFuncionarios(string condicion = "")
        {
            BLFuncionarios logicaFuncionario = new BLFuncionarios(Configuracion.getCadenaConeccion);
            List<EntidadFuncionario> funcionarios;

            try
            {
                funcionarios = logicaFuncionario.llamarListarFuncionarios(condicion);

                if (funcionarios.Count > 0)
                {
                    comboFuncionario.DataSource = funcionarios;
                    comboFuncionario.DisplayMember = "Nombre"; // Assuming "Nombre" is the property in the EntidadFuncionario class that holds the name
                    comboFuncionario.ValueMember = "Identificacion"; // Assuming "ID" is the property in the EntidadFuncionario class that holds the ID

                    comboFuncionario.SelectedIndex = 0; // Select the first item by default
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (comboRoles.SelectedItem != null && txtClave.Text == "1234")
            {
                if (comboRoles.SelectedItem.ToString() == "Admin")
                {
                    // modify the user
                    Properties.Settings.Default.role_Usuario = "Admin";
                    // save the user
                    Properties.Settings.Default.Save();
                    this.Close();
                }
                else if (comboRoles.SelectedItem.ToString() == "Médico")
                {
                    // modify the user
                    Properties.Settings.Default.role_Usuario = "Médico";
                    // save the user
                    Properties.Settings.Default.Save();
                    this.Close();
                }
                else if (comboRoles.SelectedItem.ToString() == "Funcionario")
                {
                    // modify the user
                    Properties.Settings.Default.role_Usuario = "Funcionario";
                    // save the user
                    Properties.Settings.Default.Save();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Todos los campos deben de estar llenos", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboFuncionario_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //pasar datos del funcionario usando el sistema      
            EntidadFuncionario selectedFuncionario = (EntidadFuncionario)comboFuncionario.SelectedItem;
            VariableGlobal.userName = selectedFuncionario.Nombre;
            VariableGlobal.funcionarioId = selectedFuncionario.Identificacion;
        }
    }
}
