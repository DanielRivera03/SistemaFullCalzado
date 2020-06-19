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
    // --> MEDIDAS ESTANDAR (1000 x 650)
    public partial class NuevoVistaRoles : Form
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


        public NuevoVistaRoles()
        {
            InitializeComponent();
            DetallesRolesUsuarios.DataSource = integracion.SelectDataTable("SELECT * FROM Roles"); // DATAGRIDVIEW ROLES
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

        /*
            --> BOTON REGISTRAR NUEVOS ROLES DE USUARIOS 
        */

        private void btnRegistroNuevosRoles_Click(object sender, EventArgs e)
        {
            if (txtIdRol.Text.Length == 0 || txtNombreRol.Text.Length == 0 || txtDescripcionCortaRol.Text.Length == 0)
            {
                // MOSTRANDO VENTANA EMERGENTE DE ADVERTENCIA
                Form LlamadaAdvertencia = new MensajeErrorCamposVacios();
                LlamadaAdvertencia.Show();
                // LLAMADA DE NOTIFICACION PERSONALIZADA DE ADVERTENCIA
                Llamada.NotificionAdvertencia();
            }
            else
            {
                // SI CUMPLE CONDICION ANTERIOR, E INSERCION ES EXITOSA... ENTONCES
                try
                {
                    // BUSQUEDA DE REGISTROS DUPLICADOS PREVIO A INSERCION DE NUEVOS REGISTROS
                    SqlCommand Comunicacion = new SqlCommand("SELECT ID_Rol FROM Roles WHERE ID_Rol = @ID_Rol", Controlador.Conexiones());
                    Comunicacion.Parameters.AddWithValue("ID_Rol", txtIdRol.Text);  // NOMBRE ROL DE USUARIO
                    SqlDataAdapter AdaptadorSQL = new SqlDataAdapter(Comunicacion);
                    DataTable DatosDB = new DataTable();
                    AdaptadorSQL.Fill(DatosDB);
                    // SI EXISTE AL MENOS UN REGISTRO EN LA BUSQUEDA, ENTONCES...
                    if (DatosDB.Rows.Count == 1)
                    {
                        // LLAMADA DE VENTANA EMERGENTE -> ERROR INSERTAR REGISTROS DUPLICADOS
                        Form TareaRechazada = new MensajeErrorDuplicados();
                        TareaRechazada.Show();
                        // LLAMADA DE NOTIFICACION PERSONALIZADA DE ERROR
                        Llamada.NotificionErrorDuplicado();

                    }
                    else if (DatosDB.Rows.Count == 0)
                    {
                        try
                        {
                            // SI NO EXISTEN DUPLICADOS, ENTONCES...
                            using (SqlCommand comando = new SqlCommand("sp_InsertarRolesUsuarios", Controlador.Conexiones()))
                            {
                                comando.CommandType = CommandType.StoredProcedure;
                                comando.Parameters.Add(new SqlParameter("@ID_Rol", txtIdRol.Text));                                 // ID DE ROLES
                                comando.Parameters.Add(new SqlParameter("@Nombre_Rol", txtNombreRol.Text));                         // NOMBRE GENERAL DE ROL
                                comando.Parameters.Add(new SqlParameter("@Descripcion_Corta_Rol", txtDescripcionCortaRol.Text));    // DESCRIPCION CORTA ESPECIFICA DE ROL
                                comando.ExecuteNonQuery();  // EJECUTANDO RUTINA
                            }
                            // REFRESCANDO VISTA DATAGRIDVIEW
                            DetallesRolesUsuarios.DataSource = integracion.SelectDataTable("SELECT * FROM Roles"); // DATAGRIDVIEW ROLES
                                                                                                                   // LIMPIEZA GENERAL LUEGO DE INSERTAR NUEVO REGISTRO
                            LimpiezaRoles(); // LLAMADA METODO LIMPIEZA
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
                }
                // SI OCURRE UN ERROR, ENTONCES...
                catch
                {
                    // LLAMADA DE VENTANA EMERGENTE -> ERROR ALGO SALIO MAL
                    Form TareaRechazada = new MensajeAlgoSalioMal();
                    TareaRechazada.Show();
                    // LLAMADA DE NOTIFICACION PERSONALIZADA DE ERROR
                    Llamada.NotificionErrorDuplicado();
                }
                finally
                {
                    Controlador.CierreConexion();   // CIERRE DE CONEXION
                }
            }
        }

        // METODO DE LIMPIEZA FORMULARIO {ROLES}
        public void LimpiezaRoles()
        {
            txtIdRol.Clear(); txtNombreRol.Clear(); txtDescripcionCortaRol.Clear();
        }

        // EVENTO ENTER -> TEXTBOX ID ROL DE USUARIOS
        private void txtIdRol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroNuevosRoles_Click(this, new EventArgs());
            }
        }

        // EVENTO ENTER -> TEXTBOX NOMBRE ROL DE USUARIOS
        private void txtNombreRol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroNuevosRoles_Click(this, new EventArgs());
            }
        }

        // EVENTO ENTER -> TEXTBOX DESCRIPCION CORTA ROL DE USUARIOS
        private void txtDescripcionCortaRol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroNuevosRoles_Click(this, new EventArgs());
            }
        }
    }
}
