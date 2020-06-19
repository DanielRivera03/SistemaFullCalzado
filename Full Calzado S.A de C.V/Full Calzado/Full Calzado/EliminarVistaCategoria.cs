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
    public partial class EliminarVistaCategoria : Form
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
        public EliminarVistaCategoria()
        {
            InitializeComponent();
            DetallesSimplesCategoria.DataSource = integracion.SelectDataTable("SELECT * FROM vCategoriaSistema"); // DATAGRIDVIEW CATEGORIA
        }
        /*
            --> BOTON  MINIMIZAR VENTANA 
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
            this.Close();
        }
        /*
            --> BOTON ELIMINAR USUARIOS 
        */
        private void btnRegistroCategoriaNuevos_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Length == 0 || txtNombreCategoria.Text.Length == 0 || txtBreveDescripcion.Text.Length == 0)
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
                        using (SqlCommand comando = new SqlCommand("sp_EliminarCategoria", Controlador.Conexiones()))
                        {
                            comando.CommandType = CommandType.StoredProcedure;
                            comando.Parameters.Add(new SqlParameter("@ID_categoria", txtID.Text));    // ID DE USUARIO
                            comando.ExecuteNonQuery();                            
                        }
                        // REFRESCANDO VISTA DATAGRIDVIEW
                        DetallesSimplesCategoria.DataSource = integracion.SelectDataTable("SELECT * FROM vCategoriaSistema"); // DATAGRIDVIEW 
                        // LIMPIEZA GENERAL LUEGO DE INSERTAR NUEVO REGISTRO
                        LimpiezaCategria(); // LLAMADA METODO LIMPIEZA
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
        // METODO DE LIMPIEZA FORMULARIO {CATEGORIA}
        public void LimpiezaCategria()
        {
            txtID.Clear(); txtNombreCategoria.Clear(); txtBreveDescripcion.Clear();
        }
        // ENVIO DE DATOS A TEXTBOX REGISTRO SELECCIONADO EN DATAGRIDVIEW
        private void DetallesSimplesCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = DetallesSimplesCategoria.CurrentRow.Cells["ID_categoria"].Value.ToString();
            txtNombreCategoria.Text = DetallesSimplesCategoria.CurrentRow.Cells["Nombre_Categoria"].Value.ToString();
            txtBreveDescripcion.Text = DetallesSimplesCategoria.CurrentRow.Cells["Descripcion_Categoria"].Value.ToString();
        }

        private void ContenedorSuperiorEUs_MouseDown(object sender, MouseEventArgs e)
        {
            // HABILITANDO FUNCION DE ARRASTRE DE FORMULARIO
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        // EVENTO ENTER -> TEXTBOX ID PROVEEDOR
        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroCategoriaNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX CATEGORIA PROVEEDOR
        private void txtNombreCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroCategoriaNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX BREVE DESCRIPCION
        private void txtBreveDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroCategoriaNuevos_Click(this, new EventArgs());
            }
        }
    }
}
