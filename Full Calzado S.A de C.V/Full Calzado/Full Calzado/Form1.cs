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
    public partial class LoginUsuarios : Form
    {
        // CONTROL TIMER -> CUENTA ATRAS PARA BLOQUEO TEXTBOX Y BOTON
        private int InicializandoConteo = 51;
        /*********************************************************************************************
         * HABILITANDO EL ARRASTRE DEL FORMULARIO A X POSICION EN PANTALLA POR PARTE DEL USUARIO
         * --> CODIGO DE INICIALIZACION DEL EVENTO
         *********************************************************************************************/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        // FIN INICIALIZACION DE EVENTO ARRASTRE DE FORMULARIOS
        public LoginUsuarios()
        {
            InitializeComponent();
        }

        // INSTANCIA LLAMADA NOTIFICACIONES PESONALIZADAS
        NotificacionesPersonalizadas Llamada = new NotificacionesPersonalizadas();

        // INSTANCIA CONTROLADOR GENERAL DE CONEXION {TODOS LOS MANTENIMIENTOS DEL SISTEMA}
        ControlConexion Controlador = new ControlConexion();

        // INICIALIZANDO CONTADOR DE INTENTOS
        int ContadorIntentos = 0;

        /*
            --> EFECTO PLACEHOLDER
                CAJA DE TEXTO USUARIO 
        */

        private void txtUsuarioLogin_Enter(object sender, EventArgs e)
        {
            // SI FOCO SE ENCUENTRA ACTIVO, ENTONCES...
            if (txtUsuarioLogin.Text == "Ingrese su usuario...")
            {
                txtUsuarioLogin.Text = "";
                txtUsuarioLogin.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtUsuarioLogin_Leave(object sender, EventArgs e)
        {
            // SI FOCO NO SE ENCUENTRA ACTIVO, ENTONCES...
            if (txtUsuarioLogin.Text == "")
            {
                txtUsuarioLogin.Text = "Ingrese su usuario...";
                txtUsuarioLogin.ForeColor = Color.White;
            }
        }

        /*
            --> EFECTO PLACEHOLDER
                CAJA DE TEXTO CONTRASEÑA {PASSWORD} 
        */

        private void txtPassUsuario_Enter(object sender, EventArgs e)
        {
            // SI FOCO SE ENCUENTRA ACTIVO, ENTONCES...
            if (txtPassUsuario.Text == "password") {
                txtPassUsuario.Text = "";
                txtPassUsuario.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtPassUsuario_Leave(object sender, EventArgs e)
        {
            // SI FOCO NO SE ENCUENTRA ACTIVO, ENTONCES...
            if (txtPassUsuario.Text == "")
            {
                txtPassUsuario.Text = "password";
                txtPassUsuario.ForeColor = Color.White;
            }
        }

        /*
            --> BOTON MINIMIZAR VENTANA 
        */

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*
            --> BOTON CERRAR VENTANA 
        */

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            Application.Exit(); // TERMINA EJECUCION Y CIERRA VENTANA
        }

        /*
            --> ARRASTRE FORMULARIO TODO CONTENEDOR DE INFORMACION IZQUIERDO
                                EXCEPTO LOGO... 
        */

        private void ContenedorInfoIzq_MouseDown(object sender, MouseEventArgs e)
        {
            // HABILITANDO FUNCION DE ARRASTRE DE FORMULARIO
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /*
            --> ARRASTRE FORMULARIO TODO CONTENEDOR DE INFORMACION DERECHO 
        */

        private void ContenedorLoginUsuarios_MouseDown(object sender, MouseEventArgs e)
        {
            // HABILITANDO FUNCION DE ARRASTRE DE FORMULARIO
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /*
            --> METODO INICIO DE SESION 
        */

        public void IngresoUsuarios (String UsuarioFC, String ContraseniaFC) // DONDE FC -> ABREVIATURA FULL CALZADO
        {
            // SI TEXTBOX SE ENCUENTRAN VACIOS, ENTONCES...
            if(this.txtUsuarioLogin.Text == "Ingrese su usuario..." || this.txtPassUsuario.Text == "password" || this.txtUsuarioLogin.Text == "" || this.txtPassUsuario.Text == "")
            {
                Llamada.NotificionAdvertencia();  // NOTIFICACION PERSONALIZADA DE ADVERTENCIA
                // LLAMADA ERROR CAMPOS REQUERIDOS INCOMPLETOS {VACIOS}
                Form LlamadaErrorCampos = new MensajeErrorCamposVacios();
                LlamadaErrorCampos.Show();
            }
            else
            {
                // CASO CONTRARIO, CONEXION EXITOSA Y PROCEDE A VALIDAR INGRESO SEGUN X ROL
                try
                {
                    // SELECCIONANDO NOMBRE DE USUARIO, NOMBRE USUARIO A INGRESAR Y CONTRASEÑA
                    SqlCommand Comunicacion = new SqlCommand("SELECT Nombre, ID_Rol FROM Usuarios WHERE Nombre_Usuario = @nombre_usuario AND Contrasenia = @contrasenia", Controlador.Conexiones());
                    Comunicacion.Parameters.AddWithValue("nombre_usuario", UsuarioFC);  // NOMBRE DE USUARIO
                    // CONTRASEÑA ENCRIPTADA -> IMPORTANTE, SIN EL METODO DE LLAMADO NO ES POSIBLE <<<HACER COMPARACION>>>
                    Comunicacion.Parameters.AddWithValue("contrasenia", Encriptar.ToSha512(ContraseniaFC)); // CONTRASEÑA
                    SqlDataAdapter AdaptadorSQL = new SqlDataAdapter(Comunicacion);
                    DataTable DatosDB = new DataTable();
                    AdaptadorSQL.Fill(DatosDB);
                    // SI EXISTE AL MENOS UN REGISTRO EN LA BUSQUEDA, ENTONCES...
                    if (DatosDB.Rows.Count == 1)
                    {
                        /*
                            --> VALIDACION USUARIOS ADMINISTRADORES
                         */
                        this.Hide(); // OCULTA DATOS DE INGRESO
                        if (DatosDB.Rows[0][1].ToString() == "Administrador") {
                            /*
                                INVOCANDO PANTALLA DE ESPERA ANTES DE INICIAR LA APLICACION
                            */
                            this.Hide(); // SE OCULTA VENTANA LOGIN PARA MOSTRAR VENTANA DE CARGA
                            BienvenidaUsuarios vistabienvenida = new BienvenidaUsuarios(); // INSTANCIA (OBJETO) CREADO PARA INVOCAR VENTANA
                            vistabienvenida.ShowDialog(); // MUESTRA VENTANA TIPO --> VENTANA DE DIALOGO
                            /*
                                --> MOSTRANDO PANTALLA DE ADMINISTRACION 
                                    USUARIOS : ADMINISTRADORES
                             */
                            new Administradores(DatosDB.Rows[0][0].ToString()).Show();
                            /*
                                --> VALIDACION USUARIOS DEPARTEMENTO DE RECURSOS HUMANOS / GERENCIA
                            */
                        }
                        else if(DatosDB.Rows[0][1].ToString() == "RRHH")
                        {
                            /*
                                INVOCANDO PANTALLA DE ESPERA ANTES DE INICIAR LA APLICACION
                            */
                            this.Hide(); // SE OCULTA VENTANA LOGIN PARA MOSTRAR VENTANA DE CARGA
                            BienvenidaUsuarios vistabienvenida = new BienvenidaUsuarios(); // INSTANCIA (OBJETO) CREADO PARA INVOCAR VENTANA
                            vistabienvenida.ShowDialog(); // MUESTRA VENTANA TIPO --> VENTANA DE DIALOGO
                            /*
                                --> MOSTRANDO PANTALLA DE ADMINISTRACION 
                                    USUARIOS : GERENCIA | DEPARTAMENTO RECURSOS HUMANOS
                             */
                            new RecursosHumanosDpto(DatosDB.Rows[0][0].ToString()).Show();
                            /*
                                --> VALIDACION USUARIOS PRESIDENCIA / GERENCIA
                             */
                        }
                        else if (DatosDB.Rows[0][1].ToString() == "Presidencia")
                        {
                            /*
                                INVOCANDO PANTALLA DE ESPERA ANTES DE INICIAR LA APLICACION
                            */
                            this.Hide(); // SE OCULTA VENTANA LOGIN PARA MOSTRAR VENTANA DE CARGA
                            BienvenidaUsuarios vistabienvenida = new BienvenidaUsuarios(); // INSTANCIA (OBJETO) CREADO PARA INVOCAR VENTANA
                            vistabienvenida.ShowDialog(); // MUESTRA VENTANA TIPO --> VENTANA DE DIALOGO
                            /*
                                --> MOSTRANDO PANTALLA DE ADMINISTRACION 
                                    USUARIOS : PRESIDENCIA GERENCIA GENERAL
                             */
                            new PresidenciaAdministracion(DatosDB.Rows[0][0].ToString()).Show();
                            /*
                                --> VALIDACION USUARIOS ATENCION AL CLIENTE / EMPLEADOS FULL CALZADO
                            */
                        }
                        else if (DatosDB.Rows[0][1].ToString() == "AtencionClientes")
                        {
                            /*
                                INVOCANDO PANTALLA DE ESPERA ANTES DE INICIAR LA APLICACION
                            */
                            this.Hide(); // SE OCULTA VENTANA LOGIN PARA MOSTRAR VENTANA DE CARGA
                            BienvenidaUsuarios vistabienvenida = new BienvenidaUsuarios(); // INSTANCIA (OBJETO) CREADO PARA INVOCAR VENTANA
                            vistabienvenida.ShowDialog(); // MUESTRA VENTANA TIPO --> VENTANA DE DIALOGO
                            /*
                                --> MOSTRANDO PANTALLA DE ADMINISTRACION 
                                    USUARIOS : EMPLEADOS GENERALES DE ATENCION AL CLIENTE
                             */
                            new AtencionAlClienteFC(DatosDB.Rows[0][0].ToString()).Show();
                            /*
                                --> VALIDACION USUARIOS VENTAS DIRECTAS {CAJEROS} / EMPLEADOS FULL CALZADO
                            */
                        }
                        else if (DatosDB.Rows[0][1].ToString() == "CajerosFC")
                        {
                            /*
                                INVOCANDO PANTALLA DE ESPERA ANTES DE INICIAR LA APLICACION
                            */
                            this.Hide(); // SE OCULTA VENTANA LOGIN PARA MOSTRAR VENTANA DE CARGA
                            BienvenidaUsuarios vistabienvenida = new BienvenidaUsuarios(); // INSTANCIA (OBJETO) CREADO PARA INVOCAR VENTANA
                            vistabienvenida.ShowDialog(); // MUESTRA VENTANA TIPO --> VENTANA DE DIALOGO
                            /*
                                --> MOSTRANDO PANTALLA DE ADMINISTRACION 
                                    USUARIOS : EMPLEADOS GENERALES DE CAJA -> VENTAS FULL CALZADO {CAJEROS}
                             */
                            new VentasClientesFC(DatosDB.Rows[0][0].ToString()).Show();
                        }

                    }else
                    {
                        // DATOS ERRONEOS, ENTONCES...
                        Llamada.NotificionError();  // NOTIFICACION PERSONALIZADA DE ERROR
                        // LLAMADA ERROR DATOS ERRONEOS -> INGRESO INVALIDO
                        Form LlamadaErrorIngreso = new MensajeErrorLogin();
                        LlamadaErrorIngreso.Show();
                        // AUMENTO EN 1 -> CONTADOR DE INTENTOS
                        ContadorIntentos++;
                    }
                    // SI CONTADOR INTENTOS ACUMULA 3, ENTONCES...
                    if (ContadorIntentos == 3)
                    {
                        CuentaRegresiva.Start();    // INICIO DE CUENTA REGRESIVA | BLOQUEO DE ACCESO
                        // LLAMADA DE CRONOMETRO CONTROLADO -> VENTANA EMERGENTE
                        Form Bloquear = new BloqueoSesion();
                        Bloquear.Show();
                        // BLOQUEO TOTAL DE CONTROLES DE ACCESO
                        txtPassUsuario.Enabled = false;
                        txtUsuarioLogin.Enabled = false;
                        btnIniciarSesion.Enabled = false;
                    }
                    //label7.Text = "Intento: " + ContadorIntentos;     //--> EFECTOS DE PRUEBAS
                }
                // ERROR DE BASE DE DATOS
                catch
                {
                    Llamada.NotificionError(); // NOTIFICACION PERSONALIZADA DE ERROR
                    // LLAMADA MENSAJE ERROR COMUNICACION BASE DE DATOS
                    Form LlamadaErrorDB = new MensajeErrorDB();
                    LlamadaErrorDB.Show();
                }
                // EN TODOS LOS CASOS, CONEXION SERA CERRADA A ESPERA DE NUEVA PETICION
                finally
                {
                    Controlador.CierreConexion(); // CIERRE DE CONEXION
                }
            }
        }

        // BOTON INICIAR SESION
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            IngresoUsuarios(this.txtUsuarioLogin.Text, this.txtPassUsuario.Text);
            //Llamada.IniciarSesion();
        }

        // EVENTO ENTER --> CAJA DE TEXTO USUARIOS
        private void txtUsuarioLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnIniciarSesion_Click(this, new EventArgs());
            }
        }

        // EVENTO ENTER --> CAJA DE TEXTO CONTRASEÑA
        private void txtPassUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIniciarSesion_Click(this, new EventArgs());
            }
        }

        private void CuentaRegresiva_Tick(object sender, EventArgs e)
        {
            // DECREMENTO EN UNO CUENTA REGRESIVA
            InicializandoConteo--;
            //this.label8.Text = InicializandoConteo.ToString();       //--> EFECTOS DE PRUEBAS
            // SI CUENTA REGRESIVA LLEGA A CERO, ENTONCES...
            if (InicializandoConteo == 0)
            {
                ContadorIntentos = 0;           // RESETEANDO CONTADOR DE INTENTOS
                CuentaRegresiva.Stop();         // DETENER CUENTA REGRESIVA
                InicializandoConteo = 51;       // INICIALIZANDO NUEVAMENTE CUENTA REGRESIVA
                // HABILITANDO TODOS LOS CONTROLES DE ACCESO
                txtPassUsuario.Enabled = true;  
                txtUsuarioLogin.Enabled = true;
                btnIniciarSesion.Enabled = true;
                /*
                    Y SE REPITE EL CICLO
                    << IMPORTANTE: INICIALIZACION DE CONTEO EN 51, PARA QUE CONTEO DE VENTANA EMERGENTE
                    SEA EXACTAMENTE IGUAL AL CONTEO DEL FORMULARIO DE ACCESO >>
                    
                    -- CASO CONTRARIO CONTEO ES DISPAREJO -- 
                */
            }
        }
    }
}

