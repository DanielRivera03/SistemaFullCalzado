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
    public partial class RegistrarCargos : Form
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
        public RegistrarCargos()
        {
            InitializeComponent();
            DetallesCargo.DataSource = integracion.SelectDataTable("SELECT * FROM vCargoSistema"); // DATAGRIDVIEW CARGO
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
            this.Close();
        }
        /*
            --> BOTON REGISTRAR NUEVOS ROLES DE USUARIOS 
        */
        private void btnRegistroNuevosCargo_Click(object sender, EventArgs e)
        {
            if (txtIdCargo.Text.Length == 0 || txtNombreCargo.Text.Length == 0 || txtDescripcionCortaCargo.Text.Length == 0)
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
                    using (SqlCommand comando = new SqlCommand("sp_InsertarCargos", Controlador.Conexiones()))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Add(new SqlParameter("@Id_cargo", txtIdCargo.Text));                                  // ID CARGO
                        comando.Parameters.Add(new SqlParameter("@Nombre_cargo", txtNombreCargo.Text));                         // NOMBRE CARGO
                        comando.Parameters.Add(new SqlParameter("@Descripcion", txtDescripcionCortaCargo.Text));         // DESCRIPCION DE CARGO
                        comando.ExecuteNonQuery();
                    }
                    // REFRESCANDO VISTA DATAGRIDVIEW
                    DetallesCargo.DataSource = integracion.SelectDataTable("SELECT * FROM vCargoSistema"); // DATAGRIDVIEW ROLES
                    // LIMPIEZA GENERAL LUEGO DE INSERTAR NUEVO REGISTRO
                    LimpiezaCargo(); // LLAMADA METODO LIMPIEZA
                    // MOSTRANDO EN PANTALLA PROCESO FINALIZADO CON EXITO
                    Form TareaFinalizada = new MensajeAprobacion();
                    TareaFinalizada.Show();
                    // LLAMADA DE NOTIFICACION PERSONALIZADA DE ADVERTENCIA
                    Llamada.NotificionConfirmacion();
                }
                // SI INSERCION ES DUPLICADA, ENTONCES...
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
        }
        // METODO DE LIMPIEZA FORMULARIO {CARGOS}
        public void LimpiezaCargo()
        {
            txtIdCargo.Clear(); txtNombreCargo.Clear(); txtDescripcionCortaCargo.Clear();
        }
        //PARA PODER MOVER EL FORMULARIOS
        private void ContenedorSuperiorBotones_MouseDown(object sender, MouseEventArgs e)
        {
            // HABILITANDO FUNCION DE ARRASTRE DE FORMULARIO
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        // EVENTO ENTER -> TEXTBOX ID CARGO
        private void txtIdCargo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroNuevosCargo_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX NOMBRE CARGO
        private void txtNombreCargo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroNuevosCargo_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX DESCRIPCION DE CARGO
        private void txtDescripcionCortaCargo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroNuevosCargo_Click(this, new EventArgs());
            }
        }
    }
}
