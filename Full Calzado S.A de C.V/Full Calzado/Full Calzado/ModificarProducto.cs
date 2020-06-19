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
    public partial class ModificarProducto : Form
    {
        // INSTANCIA CONTROL -> DATAGRIDVIEW
        BaseDeDatos integracion = new BaseDeDatos();

        // INSTANCIA CONTROL GENERAL COMBOBOX
        ControlComboboxGeneral DatosCategoria = new ControlComboboxGeneral();   // CATEGORIA DE PRODUCTOS

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

        public ModificarProducto()
        {
            InitializeComponent();
            DetallesSimplesProductos.DataSource = integracion.SelectDataTable("SELECT * FROM vProductoSistema"); // DATAGRIDVIEW PRODUCTOS
            DatosCategoria.SeleccionarDatosCP(cbxCategoria);  // COMBOBOX -> CATEGORIA DE PRODUCTOS
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
        --> BOTON REGISTRAR PRODUCTOS VENTANA 
    */
        private void btnRegistroProductoNuevos_Click(object sender, EventArgs e)
        {
            try
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
                    using (SqlCommand comando = new SqlCommand("sp_ModificarProductos", Controlador.Conexiones()))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Add(new SqlParameter("@ID", Convert.ToInt32(txtID.Text)));                      // ID PRODUCTO
                        comando.Parameters.Add(new SqlParameter("@Codigo", txtCodigo.Text));             // CODIGO PRODUCTO
                        comando.Parameters.Add(new SqlParameter("@Nombre", txtNombre.Text));            // NOMBRE PRODUCTO
                        comando.Parameters.Add(new SqlParameter("@Marca", txtMarca.Text));             // MARCA PRODUCTO
                        comando.Parameters.Add(new SqlParameter("@Modelo", txtModelo.Text));          // MODELO PRODUCTO
                        comando.Parameters.Add(new SqlParameter("@Precio", txtPrecio.Text));         // PRECIO PRODUCTO
                        comando.Parameters.Add(new SqlParameter("@Nombre_Categoria", cbxCategoria.Text));     // CATEGORIA PRODUCTO
                        comando.ExecuteNonQuery();  // EJECUTANDO RUTINA
                    }
                    // POR EFECTOS DE SEGURIDAD Y MEJOR CONTROL DEL SISTEMA, ID NO PODRA SER MODIFICADO...
                    if (cbxCategoria.Text == "- Seleccione un Categoria...")
                    {
                        // MOSTRANDO VENTANA EMERGENTE DE ADVERTENCIA
                        Form LlamadaAdvertencia = new MensajeErrorCamposVacios();
                        LlamadaAdvertencia.Show();
                        // LLAMADA DE NOTIFICACION PERSONALIZADA DE ADVERTENCIA
                        Llamada.NotificionAdvertencia();
                    }
                    else
                    {
                        // REFRESCANDO VISTA DATAGRIDVIEW
                        DetallesSimplesProductos.DataSource = integracion.SelectDataTable("SELECT * FROM vProductoSistema"); // DATAGRIDVIEW ROLES
                        // LIMPIEZA GENERAL LUEGO DE INSERTAR NUEVO REGISTRO
                        LimpiezaProducto(); // LLAMADA METODO LIMPIEZA
                        // MOSTRANDO EN PANTALLA PROCESO FINALIZADO CON EXITO
                        Form TareaFinalizada = new MensajeAprobacion();
                        TareaFinalizada.Show();
                        // LLAMADA DE NOTIFICACION PERSONALIZADA DE ADVERTENCIA
                        Llamada.NotificionConfirmacion();
                    }
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
        /*
            --> BOTON MODIFICAR ID PRODUCTOS VENTANA 
        */
        private void btnIDProducto_Click(object sender, EventArgs e)
        {
            Form ModificarIdProductos = new ModificarIdProductos();
            ModificarIdProductos.Show();
        }
        public void LimpiezaProducto()
        {
            txtID.Clear(); txtCodigo.Clear(); txtNombre.Clear(); txtMarca.Clear();
            txtModelo.Clear(); txtPrecio.Clear(); cbxCategoria.Text = "- Seleccione una Categoria...";
        }

        private void DetallesSimplesProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = DetallesSimplesProductos.CurrentRow.Cells["ID"].Value.ToString();
            txtCodigo.Text = DetallesSimplesProductos.CurrentRow.Cells["Codigo"].Value.ToString();
            txtNombre.Text = DetallesSimplesProductos.CurrentRow.Cells["Nombre"].Value.ToString();
            txtMarca.Text = DetallesSimplesProductos.CurrentRow.Cells["Marca"].Value.ToString();
            txtModelo.Text = DetallesSimplesProductos.CurrentRow.Cells["Modelo"].Value.ToString();
            txtPrecio.Text = DetallesSimplesProductos.CurrentRow.Cells["Precio"].Value.ToString();
            cbxCategoria.Text = DetallesSimplesProductos.CurrentRow.Cells["Nombre_Categoria"].Value.ToString();
        }

        private void ContenedorInfoBotones_MouseDown(object sender, MouseEventArgs e)
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
                btnRegistroProductoNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX CODIGO PRODUCTOS
        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroProductoNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX NOMBRE PRODUCTOS
        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroProductoNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX MARCA PRODUCTOS
        private void txtMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroProductoNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX MODELO PRODUCTOS
        private void txtModelo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroProductoNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX PRECIO PRODUCTOS
        private void txtPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroProductoNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> COMBOBOX CATEGORIA PRODUCTOS
        private void cbxCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroProductoNuevos_Click(this, new EventArgs());
            }
        }
    }
}
