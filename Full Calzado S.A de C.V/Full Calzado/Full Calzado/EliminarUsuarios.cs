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
    public partial class EliminarUsuarios : Form
    {

        // INSTANCIA CONTROL -> DATAGRIDVIEW
        BaseDeDatos integracion = new BaseDeDatos();

        // INSTANCIA CONTROL GENERAL COMBOBOX
        ControlComboboxGeneral DatosRolesUsuarios = new ControlComboboxGeneral();   // ROLES DE USUARIOS

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

        public EliminarUsuarios()
        {
            InitializeComponent();
            DetallesSimplesUsuarios.DataSource = integracion.SelectDataTable("SELECT * FROM vUsuariosRegistrados"); // DATAGRIDVIEW ROLES
            DatosRolesUsuarios.SeleccionarDatos(cbxRolesUsuarios);  // COMBOBOX -> ROLES DE USUARIOS
        }
        /*
            --> BOTON MINIMIZAR VENTANA 
        */
        private void IconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*
            --> BOTON  CERRAR  VENTANA 
        */
        private void IconCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); // CIERRE DIRECTO DE VENTANA EMERGENTE DE TAREAS
        }

        /*
            --> BOTON ELIMINAR USUARIOS 
        */
        private void btnRegistroUsuariosNuevos_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdUsuarios.Text.Length == 0 || txtP1Nombre.Text.Length == 0 || txtA1Apellido.Text.Length == 0
               || txtNombreUsuario.Text.Length == 0 || txtPassword.Text.Length == 0 || cbxRolesUsuarios.Text == "- Seleccione un rol...")
                {
                    // MOSTRANDO VENTANA EMERGENTE DE ADVERTENCIA
                    Form LlamadaAdvertenciaNoSeleccion = new MensajeNoSeleccion();
                    LlamadaAdvertenciaNoSeleccion.Show();
                    // LLAMADA DE NOTIFICACION PERSONALIZADA DE ADVERTENCIA
                    Llamada.NotificionErrorLimpieza();
                }else
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
                        try
                        {
                            using (SqlCommand comando = new SqlCommand("sp_EliminarUsuarios", Controlador.Conexiones()))
                            {
                                comando.CommandType = CommandType.StoredProcedure;
                                comando.Parameters.Add(new SqlParameter("@ID_Usuario", txtIdUsuarios.Text)); // ID DE USUARIO
                                comando.ExecuteNonQuery();  // EJECUTANDO RUTINA
                            }
                            // REFRESCANDO VISTA DATAGRIDVIEW
                            DetallesSimplesUsuarios.DataSource = integracion.SelectDataTable("SELECT * FROM vUsuariosRegistrados"); // DATAGRIDVIEW USUARIOS                                                                                                                                                                    // LIMPIEZA GENERAL LUEGO DE INSERTAR NUEVO REGISTRO
                            LimpiezaUsuarios(); // LLAMADA METODO LIMPIEZA
                            // MOSTRANDO EN PANTALLA PROCESO FINALIZADO CON EXITO
                            Form TareaFinalizada = new MensajeAprobacion();
                            TareaFinalizada.Show();
                            // LLAMADA DE NOTIFICACION PERSONALIZADA DE ADVERTENCIA
                            Llamada.NotificionConfirmacion();
                        }
                        catch
                        {
                            // LLAMADA DE VENTANA EMERGENTE -> ERROR INSERTAR BASE DE DATOS
                            Form TareaRechazadaDB = new MensajeErrorDB();
                            TareaRechazadaDB.Show();
                            // LLAMADA DE NOTIFICACION PERSONALIZADA DE ERROR
                            Llamada.NotificionError();
                        }
                    }
                    // SI USUARIO CANCELA EVENTO...
                    if(resultado == DialogResult.Cancel)
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

        public DialogResult ActivarEstado(DialogResult Estado)
        {
            DialogResult Resultado = new DialogResult();
            Resultado = DialogResult.OK;
            return Resultado;
        }

        // METODO DE LIMPIEZA FORMULARIO {USUARIOS}
        public void LimpiezaUsuarios()
        {
            txtP1Nombre.Clear(); txtA1Apellido.Clear(); txtIdUsuarios.Clear(); txtNombreUsuario.Clear();
            txtPassword.Clear(); cbxRolesUsuarios.Text = "- Seleccione un rol...";
        }

        // ENVIO DE DATOS A TEXTBOX Y COMBOBOX DE REGISTRO SELECCIONADO EN DATAGRIDVIEW
        private void DetallesSimplesUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdUsuarios.Text = DetallesSimplesUsuarios.CurrentRow.Cells["ID_Usuario"].Value.ToString();
            txtP1Nombre.Text = DetallesSimplesUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
            txtA1Apellido.Text = DetallesSimplesUsuarios.CurrentRow.Cells["Apellido"].Value.ToString();
            txtNombreUsuario.Text = DetallesSimplesUsuarios.CurrentRow.Cells["Nombre_Usuario"].Value.ToString();
            txtPassword.Text = DetallesSimplesUsuarios.CurrentRow.Cells["Contrasenia"].Value.ToString();
            cbxRolesUsuarios.Text = DetallesSimplesUsuarios.CurrentRow.Cells["ID_Rol"].Value.ToString();
        }

        private void ContenedorSuperiorEUs_MouseDown(object sender, MouseEventArgs e)
        {
            // HABILITANDO FUNCION DE ARRASTRE DE FORMULARIO
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // EVENTO ENTER -> TEXTBOX ID USUARIOS
        private void txtIdUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroUsuariosNuevos_Click(this, new EventArgs());
            }
        }

        // EVENTO ENTER -> TEXTBOX PRIMER NOMBRE USUARIOS
        private void txtP1Nombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroUsuariosNuevos_Click(this, new EventArgs());
            }
        }

        // EVENTO ENTER -> TEXTBOX PRIMER APELLIDO USUARIOS
        private void txtA1Apellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroUsuariosNuevos_Click(this, new EventArgs());
            }
        }

        // EVENTO ENTER -> TEXTBOX NOMBRE DE USUARIO / USUARIOS
        private void txtNombreUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroUsuariosNuevos_Click(this, new EventArgs());
            }
        }

        // EVENTO ENTER -> TEXTBOX CONTRASEÑA DE USUARIO / USUARIOS
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroUsuariosNuevos_Click(this, new EventArgs());
            }
        }

        // EVENTO ENTER -> COMBOBOX ROLES DE USUARIOS
        private void cbxRolesUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroUsuariosNuevos_Click(this, new EventArgs());
            }
        }
    }
}
