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
    public partial class ModificarRolesUsuarios : Form
    {

        // INSTANCIA CONTROL -> DATAGRIDVIEW
        BaseDeDatos integracion = new BaseDeDatos();

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


        public ModificarRolesUsuarios()
        {
            InitializeComponent();
            DetallesRolesUsuarios.DataSource = integracion.SelectDataTable("SELECT * FROM vRolesSistema"); // DATAGRIDVIEW ROLES
        }

        // ENVIO DE DATOS A TEXTBOX Y COMBOBOX DE REGISTRO SELECCIONADO EN DATAGRIDVIEW
        private void DetallesRolesUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdRol.Text = DetallesRolesUsuarios.CurrentRow.Cells["ID_Rol"].Value.ToString();
            txtNombreRol.Text = DetallesRolesUsuarios.CurrentRow.Cells["Nombre_Rol"].Value.ToString();
            txtDescripcionCortaRol.Text = DetallesRolesUsuarios.CurrentRow.Cells["Descripcion_Corta_Rol"].Value.ToString();
        }

        /*
            --> BOTON MODIFICAR ROL DE USUARIO 
        */
        private void btnRegistroNuevosRoles_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtIdRol.Text.Length == 0 || txtNombreRol.Text.Length == 0 || txtDescripcionCortaRol.Text.Length == 0)
                {
                    // MOSTRANDO VENTANA EMERGENTE DE ADVERTENCIA
                    Form LlamadaAdvertenciaNoSeleccion = new MensajeNoSeleccion();
                    LlamadaAdvertenciaNoSeleccion.Show();
                    // LLAMADA DE NOTIFICACION PERSONALIZADA DE ADVERTENCIA
                    Llamada.NotificionErrorLimpieza();
                }else
                {
                    using (SqlCommand comando = new SqlCommand("sp_ModificarRolesUsuarios", Controlador.Conexiones()))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Add(new SqlParameter("@ID_Rol", txtIdRol.Text));                                 // ID DE ROLES
                        comando.Parameters.Add(new SqlParameter("@Nombre_Rol", txtNombreRol.Text));                         // NOMBRE GENERAL DE ROL
                        comando.Parameters.Add(new SqlParameter("@Descripcion_Corta_Rol", txtDescripcionCortaRol.Text));    // DESCRIPCION CORTA ESPECIFICA DE ROL
                        comando.ExecuteNonQuery();  // EJECUTANDO RUTINA
                    }
                    // << POR SEGURIDAD ID DE ROL NO PODRA SER MODIFICADO DESDE EL SISTEMA POR SER UTILIZADO AL COMPARAR CADENAS AL MOMENTO DE ACCEDER >>
                    // REFRESCANDO VISTA DATAGRIDVIEW
                    DetallesRolesUsuarios.DataSource = integracion.SelectDataTable("SELECT * FROM vRolesSistema"); // DATAGRIDVIEW ROLES
                    // LIMPIEZA GENERAL LUEGO DE INSERTAR NUEVO REGISTRO
                    LimpiezaRoles(); // LLAMADA METODO LIMPIEZA
                    // MOSTRANDO EN PANTALLA PROCESO FINALIZADO CON EXITO
                    Form TareaFinalizada = new MensajeAprobacion();
                    TareaFinalizada.Show();
                    // LLAMADA DE NOTIFICACION PERSONALIZADA DE ADVERTENCIA
                    Llamada.NotificionConfirmacion();
                }
            }
            catch
            {
                // LLAMADA DE VENTANA EMERGENTE -> ERROR INSERTAR REGISTROS DUPLICADOS
                Form TareaRechazada = new MensajeErrorDuplicados();
                TareaRechazada.Show();
                // LLAMADA DE NOTIFICACION PERSONALIZADA DE ERROR
                Llamada.NotificionErrorDuplicado();
            }
            finally
            {
                Controlador.CierreConexion();   // CIERRE DE CONEXION
            }
        }

        // METODO DE LIMPIEZA FORMULARIO {ROLES}
        public void LimpiezaRoles()
        {
            txtIdRol.Clear(); txtNombreRol.Clear(); txtDescripcionCortaRol.Clear();
        }

        private void ContenedorSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            // HABILITANDO FUNCION DE ARRASTRE DE FORMULARIO
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /*
            --> BOTON MINIMIZAR VENTANA 
        */
        private void IconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*
            --> BOTON CERRAR VENTANA 
        */
        private void IconCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); // CIERRE DIRECTO DE VENTANA EMERGENTE DE TAREAS
        }

        // EVENTO ENTER -> TEXTBOX ID ROL
        private void txtIdRol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroNuevosRoles_Click(this, new EventArgs());
            }
        }

        // EVENTO ENTER -> TEXTBOX NOMBRE ROL
        private void txtNombreRol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroNuevosRoles_Click(this, new EventArgs());
            }
        }

        // EVENTO ENTER -> TEXTBOX DESCRIPCION CORTA ROL
        private void txtDescripcionCortaRol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroNuevosRoles_Click(this, new EventArgs());
            }
        }
    }
}
