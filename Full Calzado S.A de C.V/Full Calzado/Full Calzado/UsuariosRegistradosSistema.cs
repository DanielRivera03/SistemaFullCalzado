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
    public partial class UsuariosRegistradosSistema : Form
    {
        // INSTANCIA CONTROL -> DATAGRIDVIEW
        BaseDeDatos integracion = new BaseDeDatos();

        // INSTANCIA CONTROL GENERAL COMBOBOX
        ControlComboboxGeneral DatosRolesUsuarios = new ControlComboboxGeneral();   // ROLES DE USUARIOS

        // INSTANCIA LLAMADA NOTIFICACIONES PESONALIZADAS
        NotificacionesPersonalizadas Llamada = new NotificacionesPersonalizadas();

        // INSTANCIA CONTROLADOR GENERAL DE CONEXION {TODOS LOS MANTENIMIENTOS DEL SISTEMA}
        ControlConexion Controlador = new ControlConexion();

        public UsuariosRegistradosSistema()
        {
            InitializeComponent();
            DetallesSimplesUsuarios.DataSource = integracion.SelectDataTable("SELECT * FROM vUsuariosRegistrados"); // DATAGRIDVIEW USUARIOS
            DatosRolesUsuarios.SeleccionarDatos(cbxRolesUsuarios);  // COMBOBOX -> ROLES DE USUARIOS
        }

        /*
            --> BOTON REGISTRAR NUEVO USUARIO 
        */

        private void btnRegistroUsuariosNuevos_Click(object sender, EventArgs e)
        {
            if(txtIdUsuarios.Text.Length == 0 || txtP1Nombre.Text.Length == 0 || txtA1Apellido.Text.Length == 0
               || txtNombreUsuario.Text.Length == 0 || txtPassword.Text.Length == 0 || cbxRolesUsuarios.Text == "- Seleccione un rol...")
            {
                // MOSTRANDO VENTANA EMERGENTE DE ADVERTENCIA
                Form LlamadaAdvertencia = new MensajeErrorCamposVacios();
                LlamadaAdvertencia.Show();
                // LLAMADA DE NOTIFICACION PERSONALIZADA DE ADVERTENCIA
                Llamada.NotificionAdvertencia();
            }else
            {
                // SI CUMPLE CONDICION ANTERIOR, E INSERCION ES EXITOSA... ENTONCES
                try
                {   
                    // BUSQUEDA DE REGISTROS DUPLICADOS PREVIO A INSERCION DE NUEVOS REGISTROS
                    SqlCommand Comunicacion = new SqlCommand("SELECT ID_usuario FROM Usuarios WHERE ID_usuario = @ID_usuario", Controlador.Conexiones());
                    Comunicacion.Parameters.AddWithValue("ID_usuario", txtIdUsuarios.Text);  // NOMBRE DE USUARIO
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
                            using (SqlCommand comando = new SqlCommand("sp_InsertarUsuarios", Controlador.Conexiones()))
                            {
                                comando.CommandType = CommandType.StoredProcedure;
                                comando.Parameters.Add(new SqlParameter("@ID_Usuario", txtIdUsuarios.Text));                        // ID DE USUARIO
                                comando.Parameters.Add(new SqlParameter("@Nombre", txtP1Nombre.Text));                              // PRIMER NOMBRE DE USUARIO
                                comando.Parameters.Add(new SqlParameter("@Apellido", txtA1Apellido.Text));                          // PRIMER APELLIDO DE USUARIO
                                comando.Parameters.Add(new SqlParameter("@Nombre_Usuario", txtNombreUsuario.Text));                 // NOMBRE DE USUARIO
                                comando.Parameters.Add(new SqlParameter("@Contrasenia", Encriptar.ToSha512(txtPassword.Text)));    // CONTRASEÑA DE USUARIO
                                comando.Parameters.Add(new SqlParameter("@ID_Rol", cbxRolesUsuarios.Text));                         // ROL DE USUARIO
                                comando.ExecuteNonQuery();  // EJECUTANDO RUTINA
                            }
                            // REFRESCANDO VISTA DATAGRIDVIEW
                            DetallesSimplesUsuarios.DataSource = integracion.SelectDataTable("SELECT * FROM vUsuariosRegistrados"); // DATAGRIDVIEW ROLES
                            // LIMPIEZA GENERAL LUEGO DE INSERTAR NUEVO REGISTRO
                            LimpiezaUsuarios(); // LLAMADA METODO LIMPIEZA
                            // MOSTRANDO EN PANTALLA PROCESO FINALIZADO CON EXITO
                            Form TareaFinalizada = new MensajeAprobacion();
                            TareaFinalizada.Show();
                            // LLAMADA DE NOTIFICACION PERSONALIZADA DE ADVERTENCIA
                            Llamada.NotificionConfirmacion();
                        }catch
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

        private void btnLimpieza_Click(object sender, EventArgs e)
        {
            if (txtIdUsuarios.Text.Length == 0 && txtP1Nombre.Text.Length == 0 && txtA1Apellido.Text.Length == 0
               && txtNombreUsuario.Text.Length == 0 && txtPassword.Text.Length == 0 && cbxRolesUsuarios.Text == "- Seleccione un rol...")
            {
                // LLAMADA DE VENTANA EMERGENTE -> ERROR CAMPOS VACIOS A LA HORA DE INVOCAR METODO LIMPIEZA
                Form LlamadaErrorLimpieza = new MensajeLimpieza();
                LlamadaErrorLimpieza.Show();
                // LLAMADA DE NOTIFICACION PERSONALIZADA DE ERROR
                Llamada.NotificionErrorLimpieza();
            }
            else
            {
                LimpiezaUsuarios(); // LLAMADA METODO LIMPIEZA
            }
        }

        // METODO DE LIMPIEZA FORMULARIO {USUARIOS}

        public void LimpiezaUsuarios()
        {
            txtP1Nombre.Clear(); txtA1Apellido.Clear(); txtIdUsuarios.Clear(); txtNombreUsuario.Clear();
            txtPassword.Clear(); cbxRolesUsuarios.Text = "- Seleccione un rol...";
        }

        // EVENTO ENTER --> CAJA DE TEXTO ID USUARIOS
        private void txtIdUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroUsuariosNuevos_Click(this, new EventArgs());
            }
        }

        // EVENTO ENTER --> CAJA DE TEXTO PRIMER NOMBRE USUARIOS
        private void txtP1Nombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroUsuariosNuevos_Click(this, new EventArgs());
            }
        }

        // EVENTO ENTER --> CAJA DE TEXTO PRIMER APELLIDO USUARIOS
        private void txtA1Apellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroUsuariosNuevos_Click(this, new EventArgs());
            }
        }

        // EVENTO ENTER --> CAJA DE TEXTO NOMBRE DE USUARIO
        private void txtNombreUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroUsuariosNuevos_Click(this, new EventArgs());
            }
        }

        // EVENTO ENTER --> CAJA DE TEXTO CONTRASEÑA DE USUARIOS
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroUsuariosNuevos_Click(this, new EventArgs());
            }
        }

        // EVENTO ENTER --> COMBOBOX ROLES DE USUARIOS
        private void cbxRolesUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroUsuariosNuevos_Click(this, new EventArgs());
            }
        }

        /*
            --> CONSULTA AMPLIADA / AVANZADA DE USUARIOS 
        */
        private void btnConsultarUsuarios_Click(object sender, EventArgs e)
        {
            Form AperturaConsultaAmpliada = new ConsultaUsuariosAmpliada();
            AperturaConsultaAmpliada.Show();
        }

        /*
            --> BOTON MODIFICAR USUARIOS 
        */
        private void btnModificarUsuarios_Click(object sender, EventArgs e)
        {
            Form AperturaModificarUsuarios = new ModificarUsuarios();
            AperturaModificarUsuarios.Show();
        }

        /*
            --> BOTON ELIMINAR USUARIOS 
        */
        private void btnEliminarUsuarios_Click(object sender, EventArgs e)
        {
            Form AperturaEliminarUsuarios = new EliminarUsuarios();
            AperturaEliminarUsuarios.Show();
        }

        /*
            --> BOTON NUEVO / VER ROLES DE USUARIOS 
        */
        private void btnNuevoVerRoles_Click(object sender, EventArgs e)
        {
            Form AperturaNuevoVerRoles = new NuevoVistaRoles();
            AperturaNuevoVerRoles.Show();
        }

        /*
            --> BOTON MODIFICAR ROLES DE USUARIOS 
        */
        private void btnModificarRoles_Click(object sender, EventArgs e)
        {
            Form AperturaModificarRoles = new ModificarRolesUsuarios();
            AperturaModificarRoles.Show();
        }

        /*
            --> BOTON ELIMINAR ROLES DE USUARIOS 
        */
        private void btnEliminarRoles_Click(object sender, EventArgs e)
        {
            Form AperturaEliminarRoles = new EliminarRolesUsuarios();
            AperturaEliminarRoles.Show();
        }
    }
}
