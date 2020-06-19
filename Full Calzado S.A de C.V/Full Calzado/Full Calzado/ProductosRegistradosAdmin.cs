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
// IMPORTANDO LIBRERIA SERVICIO CLIENTE C# -> SQL SERVER
using System.Data.SqlClient;

namespace Full_Calzado
{
    public partial class ProductosRegistradosAdmin : Form
    {
        // INSTANCIA CONTROL -> DATAGRIDVIEW
        BaseDeDatos integracion = new BaseDeDatos();

        // INSTANCIA CONTROL GENERAL COMBOBOX
        ControlComboboxGeneral DatosCategoria = new ControlComboboxGeneral();   // CATEGORIA DE PRODUCTOS

        // INSTANCIA LLAMADA NOTIFICACIONES PESONALIZADAS
        NotificacionesPersonalizadas Llamada = new NotificacionesPersonalizadas();

        // INSTANCIA CONTROLADOR GENERAL DE CONEXION {TODOS LOS MANTENIMIENTOS DEL SISTEMA}
        ControlConexion Controlador = new ControlConexion();

        public ProductosRegistradosAdmin()
        {
            InitializeComponent();
            DetallesSimplesProductos.DataSource = integracion.SelectDataTable("SELECT * FROM vProductoSistema"); // DATAGRIDVIEW PRODUCTOS
            DatosCategoria.SeleccionarDatosCP(cbxCategoria);  // COMBOBOX -> CATEGORIA DE PRODUCTOS
        }
        /*
            --> BOTON REGISTRAR PRODUCTOS SISTEMAS
        */
        private void btnRegistroProductosNuevos_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length == 0 || txtCodigo.Text.Length == 0 || txtNombre.Text.Length == 0 || txtMarca.Text.Length == 0
                || txtModelo.Text.Length == 0 || txtPrecio.Text.Length == 0 || cbxCategoria.Text == "- Seleccione Categoria...")
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
                    using (SqlCommand comando = new SqlCommand("sp_InsertarProductos", Controlador.Conexiones()))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Add(new SqlParameter("@ID", txtID.Text));                // ID PRODUCTO
                        comando.Parameters.Add(new SqlParameter("@Codigo", txtCodigo.Text));             // CODIGO PRODUCTO
                        comando.Parameters.Add(new SqlParameter("@Nombre", txtNombre.Text));            // NOMBRE PRODUCTO
                        comando.Parameters.Add(new SqlParameter("@Marca", txtMarca.Text));             // MARCA PRODUCTO
                        comando.Parameters.Add(new SqlParameter("@Modelo", txtModelo.Text));          // MODELO PRODUCTO
                        comando.Parameters.Add(new SqlParameter("@Precio", txtPrecio.Text));         // PRECIO PRODUCTO
                        comando.Parameters.Add(new SqlParameter("@Nombre_Categoria", cbxCategoria.Text));     // CATEGORIA PRODUCTO
                        comando.ExecuteNonQuery();  // EJECUTANDO RUTINA
                    }
                    // REFRESCANDO VISTA DATAGRIDVIEW
                    DetallesSimplesProductos.DataSource = integracion.SelectDataTable("SELECT * FROM vProductoSistema"); // DATAGRIDVIEW ROLES
                    // LIMPIEZA GENERAL LUEGO DE INSERTAR NUEVO REGISTRO
                    LimpiezaProductos(); // LLAMADA METODO LIMPIEZA
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
        /*
            --> BOTON COLSUTAR PRODUCTOS SISTEMS
        */
        private void btnConsultarProductos_Click(object sender, EventArgs e)
        {
            Form AperturaConsultaAmpliada = new ConsultaProductoAmpliada();
            AperturaConsultaAmpliada.Show();
        }
        /*
            --> BOTON MODIFICAR PRODUCTOS SISTEMS
        */
        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            Form ModificarProductoRegistrado = new ModificarProducto();
            ModificarProductoRegistrado.Show();
        }
        /*
            --> BOTON ELIMINAR PRODUCTOS SISTEMAS
        */
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            Form EliminarProductoRegistrado = new EliminarProducto();
            EliminarProductoRegistrado.Show();
        }
        /*
            --> BOTON AGREGAR CATEGPROIA A PRODUCTOS SISTEMAS
        */
        private void btnNuevoVerCategoria_Click(object sender, EventArgs e)
        {
            Form NuevoVerProducto = new NuevaVistaProducto();
            NuevoVerProducto.Show();
        }
        /*
            --> BOTON MODIFICAR CATEGORIA A PRODUCTOS SISTEMAS
        */
        private void btnModificarRoles_Click(object sender, EventArgs e)
        {
            Form ModificarVerCategoria = new ModificarVistaCategoria();
            ModificarVerCategoria.Show();
        }
        /*
            --> BOTON ELIMINAR CATEGORIA A PRODUCTOS SISTEMAS
        */
        private void btnEliminarRoles_Click(object sender, EventArgs e)
        {
            Form EliminarVerCategoria = new EliminarVistaCategoria();
            EliminarVerCategoria.Show();
        }
        
        /*
            --> BOTON LIMPIAR COMBOBOX Y TEXTBOX SISTEMAS
        */
        private void btnLimpieza_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length == 0 || txtCodigo.Text.Length == 0 || txtNombre.Text.Length == 0 || txtMarca.Text.Length == 0
                || txtModelo.Text.Length == 0 || txtPrecio.Text.Length == 0 || cbxCategoria.Text == "- Seleccione Categoria...")
            {
                // LLAMADA DE VENTANA EMERGENTE -> ERROR CAMPOS VACIOS A LA HORA DE INVOCAR METODO LIMPIEZA
                Form LlamadaErrorLimpieza = new MensajeLimpieza();
                LlamadaErrorLimpieza.Show();
                // LLAMADA DE NOTIFICACION PERSONALIZADA DE ERROR
                Llamada.NotificionErrorLimpieza();
            }
            else
            {
                LimpiezaProductos(); // LLAMADA METODO LIMPIEZA
            }
        }
        //METODO PARA LIMPIAR TEXTBOX Y COMBOBOX
        public void LimpiezaProductos()
        {
            txtID.Clear(); txtCodigo.Clear(); txtNombre.Clear(); txtMarca.Clear();
            txtModelo.Clear(); txtPrecio.Clear(); cbxCategoria.Text = "- Seleccione una Categoria...";
        }
        // EVENTO ENTER -> TEXTBOX ID PRODUCTOS
        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroProductosNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX CODIGO PRODUCTOS
        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroProductosNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX NOMBRE PRODUCTOS
        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroProductosNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX MARCA PRODUCTOS
        private void txtMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroProductosNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX MODELO PRODUCTOS
        private void txtModelo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroProductosNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX PRECIO PRODUCTOS
        private void txtPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroProductosNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> COMBOBOX CATEGORIA PRODUCTOS
        private void cbxCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroProductosNuevos_Click(this, new EventArgs());
            }
        }
    }
}
