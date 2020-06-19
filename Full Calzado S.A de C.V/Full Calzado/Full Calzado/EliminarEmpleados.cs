/*      
 *  ´´  ´´          ´´      ´´          ´´      ´´      ´´          ´´      ´´          ´´      ´´      ´´
 *   ´´   ´´    ´´         ´´      ´´       ´´      ´´      ´´   ´´      ´´          ´´      ´´      ´´
 *   ´´   ´´    ´´         ´´      ´´       ´´      ´´      ´´              ´´              ´´
 *   ´´   ´´    ´´         ´´      ´´       ´´      ´´      ´´      ´´      ´´        ´´              ´´
 *  
 *     @@@@@@   @@    @@   @@        @@         @@@@@@@  @@@@@@@@  @@       @@@@@@@  @@@@@@@@  @@@@@@       @@@@@@@
 *     @@       @@    @@   @@        @@         @@       @@    @@  @@           @@   @@    @@  @@   @@     @@     @@
 *     @@       @@    @@   @@        @@         @@       @@    @@  @@          @@    @@    @@  @@    @@   @@       @@
 *     @@@@@@   @@    @@   @@        @@         @@       @@@@@@@@  @@         @@     @@@@@@@@  @@     @@  @@       @@
 *     @@       @@    @@   @@        @@         @@       @@    @@  @@        @@      @@    @@  @@     @@   @@     @@
 *     @@       @@    @@   @@        @@         @@       @@    @@  @@       @@       @@    @@  @@    @@     @@   @@
 *     @@       @@@@@@@@   @@@@@@@   @@@@@@     @@@@@@@  @@    @@  @@@@@@  @@@@@@    @@    @@  @@@@@@@       @@@@@
 *     
 *     ´´  ´´          ´´      ´´          ´´      ´´      ´´          ´´      ´´          ´´      ´´      ´´
 *   ´´   ´´    ´´         ´´      ´´       ´´      ´´      ´´   ´´      ´´          ´´      ´´      ´´
 *   ´´   ´´    ´´         ´´      ´´       ´´      ´´      ´´              ´´              ´´
 *   ´´   ´´    ´´         ´´      ´´       ´´      ´´      ´´      ´´              ´´            ´´      ´´ 
 *   ------------------------------------------------------------------------
 *   PROYECTO COMPARTIDO Y LIBERADO CON FINES EDUCATIVOS
 *   https://github.com/DanielRivera03
 *   ------------------------------------------------------------------------
 *  ----> VERSION 1.0 FINAL ESTABLE <----  
 *  --------------------------------------------------------------------------
 *  |                       FULL CALZADO S.A DE C.V                          |
 *  --------------------------------------------------------------------------
 *  |  DESARROLLADORES DEL SISTEMA {4}                                       |
 *  --------------------------------------------------------------------------
 *  | -> DANIEL RIVERA           || ENCARGADO DISEÑO BASE SISTEMA, ESTANDARES|
 *  |                            || INICIALES DE APLICACION, CREACION LOGIN, |
 *  |                            || MANTENIMIENTO COMPLETO DE USUARIOS, ROLES|
 *  |                            || DE USUARIOS, TODAS LAS INTERFACES {BASE} | 
 *  --------------------------------------------------------------------------                                  
 *  | -> FERNANDO SANCHEZ        || ENCARGADO GESTION PRODUCTOS SISTEMA,TODOS|
 *  |                            || LOS ROLES, CONFIGURACIONES DE TODOS LOS  |
 *  |                            || REPORTES DEL SISTEMA                     |
 *  --------------------------------------------------------------------------                                        
 *  | -> CHRISTIAN MONGE         || ENCARGADO DE FACTURACION DE PRODUCTOS,   |
 *  |                            || TODOS LOS ROLES DEL SISTEMA, Y REPORTES  |
 *  |                            || EN RELACION A ESTA OPCION DE MENU        |
 *  --------------------------------------------------------------------------                                      
 *  | -> KARLA NAVAS             || ENCARGADA DE GESTION DE EMPLEADOS DEL    |
 *  |                            || SISTEMA, Y REPORTES EN RELACION A ESTA   |
 *  |                            || OPCION DE MENU                           |            
 *  --------------------------------------------------------------------------
 *  |                        FULL CALZADO S.A DE C.V                         |
 *  --------------------------------------------------------------------------
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// IMPORTANDO LIBRERIA QUE HABILITA EL EVENTO DE ARRASTRES DE FORMULARIOS POR PARTE DE LOS USUARIOS
using System.Runtime.InteropServices;
// IMPORTANDO LIBRERIA SERVICIO CLIENTE C# -> SQL SERVER
using System.Data.SqlClient;

namespace Full_Calzado
{
    public partial class EliminarEmpleados : Form
    {
        // INSTANCIA CONTROL -> DATAGRIDVIEW
        BaseDeDatos integracion = new BaseDeDatos();

        // INSTANCIA CONTROL GENERAL COMBOBOX
        ControlComboboxGeneral DatosCargo = new ControlComboboxGeneral();   // SEXO DE EMPLEADOS
        ControlComboboxGeneral DatosGenero = new ControlComboboxGeneral();      // GENERO DE EMPLEADOS
        ControlComboboxGeneral DatosEstadoCivil = new ControlComboboxGeneral(); // ESTADO CIVIL DE EMPLEADOS
        
        // INSTANCIA LLAMADA NOTIFICACIONES PESONALIZADAS
        NotificacionesPersonalizadas Llamada = new NotificacionesPersonalizadas();

        // INSTANCIA CONTROLADOR GENERAL DE CONEXION {TODOS LOS MANTENIMIENTOS DEL SISTEMA}
        ControlConexion Controlador = new ControlConexion();
        /*********************************************************************************************
        * HABILITANDO EL ARRASTRE DEL FORMULARIO A X POSICION EN PANTALLA POR PARTE DEL USUARIO
        * --> CODIGO DE INICIALIZACION DEL EVENTO
        *********************************************************************************************/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        // FIN INICIALIZACION DE EVENTO ARRASTRE DE FORMULARIOS
        public EliminarEmpleados()
        {
            InitializeComponent();
            DetallesSimplesEmpleado.DataSource = integracion.SelectDataTable("SELECT * FROM vEmpleadoSistema"); // DATAGRIDVIEW PRODUCTOS
            DatosCargo.SeleccionarDatosCE(cbxCargo);  // COMBOBOX -> CATEGORIA DE PRODUCTOS
            DatosGenero.SeleccionarDatosGE(cbxGenero);             // COMBOBOX -> GENERO DE EMPLEADOS
            DatosEstadoCivil.SeleccionarDatosECE(cbxEstadoCivil); // COMBOBOX -> ESTADO CIVIL DE EMPLEADOS
        }
        /*
          --> BOTON REGISTRAR EMPLEADOS
        */
        private void IconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /*
            --> BOTON ELIMINAR USUARIOS 
        */
        private void IconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistroEmpleadoNuevos_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdEmpleado.Text.Length == 0 || txtP1Nombre.Text.Length == 0 || txtA1Apellido.Text.Length == 0 || txtSueldoBase.Text.Length == 0
                || txtFechaNacimiento.Text.Length == 0 || txtDireccion.Text.Length == 0 || txtTelefono.Text.Length == 0 || txtDui.Text.Length == 0
                || cbxCargo.Text == "- Seleccione Cargo..." || cbxEstadoCivil.Text == "-Seleccione Estado Civil..." || cbxGenero.Text == "- Seleccione Genero...")
                {
                    // MOSTRANDO VENTANA EMERGENTE DE ADVERTENCIA
                    Form LlamadaAdvertenciaNoSeleccion = new MensajeNoSeleccion();
                    LlamadaAdvertenciaNoSeleccion.Show();
                    // LLAMADA DE NOTIFICACION PERSONALIZADA DE ADVERTENCIA
                    Llamada.NotificionErrorLimpieza();
                }
                else
                {
                    DialogResult resultado = new DialogResult();
                    // MOSTRANDO VENTANA EMERGENTE DE ADVERTENCIA
                    Form mensaje = new MensajePreguntaAccionesWF();
                    resultado = mensaje.ShowDialog();
                    // LLAMADA DE NOTIFICACION PERSONALIZADA DE PREGUNTA
                    Llamada.NotificionIncognita();
                    MensajePreguntaAccionesWF Consulta = new MensajePreguntaAccionesWF();
                    /*
                        --> COMPROBACION DE DEPURACION DE REGISTRO...
                                DISPONIBILIDAD DE CANCELAR EVENTO 
                    */
                    if (resultado == DialogResult.OK)
                    {
                        using (SqlCommand comando = new SqlCommand("sp_EliminarEmpleados", Controlador.Conexiones()))
                        {
                            comando.CommandType = CommandType.StoredProcedure;
                            comando.Parameters.Add(new SqlParameter("@Id_empleado", txtIdEmpleado.Text));    // ID DE USUARIO
                            comando.ExecuteNonQuery();  // EJECUTANDO RUTINA
                        }
                        // REFRESCANDO VISTA DATAGRIDVIEW
                        DetallesSimplesEmpleado.DataSource = integracion.SelectDataTable("SELECT * FROM vEmpleadoSistema"); // DATAGRIDVIEW USUARIOS                                                                                                                                                                    // LIMPIEZA GENERAL LUEGO DE INSERTAR NUEVO REGISTRO
                        LimpiezaEmpleado(); // LLAMADA METODO LIMPIEZA
                        // MOSTRANDO EN PANTALLA PROCESO FINALIZADO CON EXITO
                        Form TareaFinalizada = new MensajeAprobacion();
                        TareaFinalizada.Show();
                        // LLAMADA DE NOTIFICACION PERSONALIZADA DE ADVERTENCIA
                        Llamada.NotificionConfirmacion();
                    }
                    // SI USUARIO CANCELA EVENTO...
                    if (resultado == DialogResult.Cancel)
                    {
                        this.Close();   // -> CIERRE DIRECTO DE VENTANA EMERGENTE CON TODOS SUS PARAMETROS RESETEADOS
                    }
                }
            }
            catch
            {
                // LLAMADA DE VENTANA EMERGENTE -> ERROR ELIMINAR REGISTRO
                Form TareaRechazada = new MensajeErrorEliminarDatos();
                TareaRechazada.Show();
                // LLAMADA DE NOTIFICACION PERSONALIZADA DE ERROR
                Llamada.NotificionErrorDepurarRegistros();
            }
            finally
            {
                Controlador.CierreConexion();   // CIERRE DE CONEXION
            }
        }
        /*
          -->LIMPIEZA TEXTBOX Y COMBOBOX
        */
        public void LimpiezaEmpleado()
        {
            txtIdEmpleado.Clear(); txtP1Nombre.Clear(); txtA1Apellido.Clear(); txtSueldoBase.Clear(); txtFechaNacimiento.Clear();
            txtDireccion.Clear(); txtTelefono.Clear(); txtDui.Clear(); cbxCargo.Text = "- Seleccione Cargo...";
            cbxEstadoCivil.Text = "-Seleccione Estado Civil..."; cbxGenero.Text = "- Seleccione Genero...";
        }
        // ENVIO DE DATOS A TEXTBOX Y COMBOBOX DE REGISTRO SELECCIONADO EN DATAGRIDVIEW
        private void DetallesSimplesEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdEmpleado.Text = DetallesSimplesEmpleado.CurrentRow.Cells["Id_empleado"].Value.ToString();
            txtP1Nombre.Text = DetallesSimplesEmpleado.CurrentRow.Cells["Nombre"].Value.ToString();
            txtA1Apellido.Text = DetallesSimplesEmpleado.CurrentRow.Cells["Apellido"].Value.ToString();
            txtSueldoBase.Text = DetallesSimplesEmpleado.CurrentRow.Cells["Sueldo_Base"].Value.ToString();
            txtFechaNacimiento.Text = DetallesSimplesEmpleado.CurrentRow.Cells["Fecha_Nacimiento"].Value.ToString();
            txtDireccion.Text = DetallesSimplesEmpleado.CurrentRow.Cells["Direccion"].Value.ToString();
            txtTelefono.Text = DetallesSimplesEmpleado.CurrentRow.Cells["Telefono"].Value.ToString();
            txtDui.Text = DetallesSimplesEmpleado.CurrentRow.Cells["Dui"].Value.ToString();
            cbxCargo.Text = DetallesSimplesEmpleado.CurrentRow.Cells["Nombre_cargo"].Value.ToString();
            cbxEstadoCivil.Text = DetallesSimplesEmpleado.CurrentRow.Cells["Estado_Civil"].Value.ToString();
            cbxGenero.Text = DetallesSimplesEmpleado.CurrentRow.Cells["Sexo"].Value.ToString();
        }
        // MOVIMIENTO AL FORMULARIO
        private void ContenedorSuperiorEUs_MouseDown(object sender, MouseEventArgs e)
        {
            // HABILITANDO FUNCION DE ARRASTRE DE FORMULARIO
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        // EVENTO ENTER -> TEXTBOX ID EMPLEADOS
        private void txtIdEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroEmpleadoNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX NOMBRE EMPLEADO
        private void txtP1Nombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroEmpleadoNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX SUELDO BASE EMPLEADO
        private void txtSueldoBase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroEmpleadoNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX FECHA DE NACIMINIENTO EMPLEADO
        private void txtFechaNacimiento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroEmpleadoNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX DIRECCION EMPLEADO
        private void txtDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroEmpleadoNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX TELEFONO EMPLEADO
        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroEmpleadoNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX DUI EMPLEADO
        private void txtDui_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroEmpleadoNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> COMBOBOX ESTADO CIVIL EMPLEADO
        private void cbxEstadoCivil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroEmpleadoNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> COMBOBOX GENERO EMPLEADO
        private void cbxGenero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroEmpleadoNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> COMBOBOX CARGO EMPLEADO
        private void cbxCargo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroEmpleadoNuevos_Click(this, new EventArgs());
            }
        }
    }
}
