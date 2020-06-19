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
    public partial class ModificarUsuarios : Form
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

        public ModificarUsuarios()
        {
            InitializeComponent();
            DetallesSimplesUsuarios.DataSource = integracion.SelectDataTable("SELECT * FROM vUsuariosRegistrados"); // DATAGRIDVIEW USUARIOS
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
            --> BOTON CERRAR VENTANA 
        */
        private void IconCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); // CIERRE DIRECTO DE VENTANA EMERGENTE DE TAREAS
        }

        /*
            --> BOTON MODIFICAR USUARIOS 
        */
        private void btnRegistroUsuariosNuevos_Click(object sender, EventArgs e)
        {
            if (txtIdUsuarios.Text.Length == 0 || txtP1Nombre.Text.Length == 0 || txtA1Apellido.Text.Length == 0
               || txtNombreUsuario.Text.Length == 0 || txtPassword.Text.Length == 0 || cbxRolesUsuarios.Text == "- Seleccione un rol...")
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
                    SqlCommand Comunicacion = new SqlCommand("SELECT Nombre_Usuario FROM Usuarios WHERE Nombre_Usuario = @Nombre_Usuario", Controlador.Conexiones());
                    Comunicacion.Parameters.AddWithValue("Nombre_Usuario", txtNombreUsuario.Text);  // NOMBRE DE USUARIO
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
                            using (SqlCommand comando = new SqlCommand("sp_ModificarUsuarios", Controlador.Conexiones()))
                            {
                                comando.CommandType = CommandType.StoredProcedure;
                                comando.Parameters.Add(new SqlParameter("@ID_Usuario", txtIdUsuarios.Text)); // ID DE USUARIO
                                comando.Parameters.Add(new SqlParameter("@Nombre", txtP1Nombre.Text)); // PRIMER NOMBRE DE USUARIO
                                comando.Parameters.Add(new SqlParameter("@Apellido", txtA1Apellido.Text)); // PRIMER APELLIDO DE USUARIO
                                comando.Parameters.Add(new SqlParameter("@Nombre_Usuario", txtNombreUsuario.Text)); // NOMBRE DE USUARIO
                                comando.Parameters.Add(new SqlParameter("@Contrasenia", Encriptar.ToSha512(txtPassword.Text))); // CONTRASEÑA DE USUARIO
                                comando.Parameters.Add(new SqlParameter("@ID_Rol", cbxRolesUsuarios.Text)); // ROL DE USUARIO
                                comando.ExecuteNonQuery();  // EJECUTANDO RUTINA
                            }
                            // POR EFECTOS DE SEGURIDAD Y MEJOR CONTROL DEL SISTEMA, ID NO PODRA SER MODIFICADO...
                            if (cbxRolesUsuarios.Text == "- Seleccione un rol...")
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
                                DetallesSimplesUsuarios.DataSource = integracion.SelectDataTable("SELECT * FROM vUsuariosRegistrados"); // DATAGRIDVIEW ROLES
                                // LIMPIEZA GENERAL LUEGO DE INSERTAR NUEVO REGISTRO
                                LimpiezaUsuarios(); // LLAMADA METODO LIMPIEZA
                                // MOSTRANDO EN PANTALLA PROCESO FINALIZADO CON EXITO
                                Form TareaFinalizada = new MensajeAprobacion();
                                TareaFinalizada.Show();
                                // LLAMADA DE NOTIFICACION PERSONALIZADA DE ADVERTENCIA
                                Llamada.NotificionConfirmacion();
                            }
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
                    Controlador.CierreConexion(); // CIERRE DE CONEXION
                }
            }
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

        private void ContenedorInfoBotones_MouseDown(object sender, MouseEventArgs e)
        {
            // HABILITANDO FUNCION DE ARRASTRE DE FORMULARIO
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /*
            --> BOTON MODIFICAR ID DE USUARIOS REGISTRADOS PREVIAMENTE.
                -- USO CONTROLADO Y DE SER ESTRICTAMENTE NECESARIO -- 
        */
        private void btnIDUsuarios_Click(object sender, EventArgs e)
        {
            // LLAMADA DE VENTANA EMERGENTE -> CAMBIO ID USUARIOS REGISTRADOS PREVIAMENTE
            Form NuevoIDUsuarios = new ModificarIdUsuarios();
            NuevoIDUsuarios.Show();
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
