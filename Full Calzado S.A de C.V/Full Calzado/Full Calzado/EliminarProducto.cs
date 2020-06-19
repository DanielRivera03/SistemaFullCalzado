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
    public partial class EliminarProducto : Form
    {
        // INSTANCIA CONTROL -> DATAGRIDVIEW
        BaseDeDatos integracion = new BaseDeDatos();

        // INSTANCIA CONTROL GENERAL COMBOBOX
        ControlComboboxGeneral DatosCategoria = new ControlComboboxGeneral();   // ROLES DE USUARIOS

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
        public EliminarProducto()
        {
            InitializeComponent();
            DetallesSimplesProducto.DataSource = integracion.SelectDataTable("SELECT * FROM vProductoSistema"); // DATAGRIDVIEW CATEGORIA
            DatosCategoria.SeleccionarDatosCE(cbxCategoria);  // COMBOBOX -> CATEGORIA PRODUCTOS
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

        private void btnRegistroEliminarProductoNuevo_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length == 0 || txtCodigo.Text.Length == 0 || txtNombre.Text.Length == 0 || txtMarca.Text.Length == 0
                || txtModelo.Text.Length == 0 || txtPrecio.Text.Length == 0 || cbxCategoria.Text == "- Seleccione Categoria...")
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
                    using (SqlCommand comando = new SqlCommand("sp_EliminarProductos", Controlador.Conexiones()))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Add(new SqlParameter("@ID", txtID.Text));    // ID DE USUARIO
                        comando.ExecuteNonQuery();  // EJECUTANDO RUTINA
                    }
                    // REFRESCANDO VISTA DATAGRIDVIEW
                    DetallesSimplesProducto.DataSource = integracion.SelectDataTable("SELECT * FROM vProductoSistema"); // DATAGRIDVIEW PRODUCTOS                                                                                                                                                                    // LIMPIEZA GENERAL LUEGO DE INSERTAR NUEVO REGISTRO
                    LimpiezaProducto(); // LLAMADA METODO LIMPIEZA
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
        //--------------------------------------------------------
        // METODO DE LIMPIEZA FORMULARIO {PRODUCTO}
        public void LimpiezaProducto()
        {
            txtID.Clear(); txtCodigo.Clear(); txtNombre.Clear(); txtMarca.Clear();
            txtModelo.Clear(); txtPrecio.Clear(); cbxCategoria.Text = "- Seleccione una Categoria";
        }
        // ENVIO DE DATOS A TEXTBOX Y COMBOBOX DE REGISTRO SELECCIONADO EN DATAGRIDVIEW
        private void DetallesSimplesProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = DetallesSimplesProducto.CurrentRow.Cells["ID"].Value.ToString();
            txtCodigo.Text = DetallesSimplesProducto.CurrentRow.Cells["Codigo"].Value.ToString();
            txtNombre.Text = DetallesSimplesProducto.CurrentRow.Cells["Nombre"].Value.ToString();
            txtMarca.Text = DetallesSimplesProducto.CurrentRow.Cells["Marca"].Value.ToString();
            txtModelo.Text = DetallesSimplesProducto.CurrentRow.Cells["Modelo"].Value.ToString();
            txtPrecio.Text = DetallesSimplesProducto.CurrentRow.Cells["Precio"].Value.ToString();
            cbxCategoria.Text = DetallesSimplesProducto.CurrentRow.Cells["Nombre_Categoria"].Value.ToString();
        }

        private void ContenedorSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            // HABILITANDO FUNCION DE ARRASTRE DE FORMULARIO
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        // EVENTO ENTER -> TEXTBOX ID PRODUCTOS
        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroEliminarProductoNuevo_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX CODIGO PRODUCTOS
        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroEliminarProductoNuevo_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX NOMBRE PRODUCTOS
        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroEliminarProductoNuevo_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX MARCA PRODUCTOS
        private void txtMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroEliminarProductoNuevo_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX MODELO PRODUCTOS
        private void txtModelo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroEliminarProductoNuevo_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX PRECIO PRODUCTOS
        private void txtPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroEliminarProductoNuevo_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> COMBOBOX CATEGORIA PRODUCTOS
        private void cbxCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroEliminarProductoNuevo_Click(this, new EventArgs());
            }
        }
    }
}
