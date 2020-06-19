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
    public partial class ModificarVistaCargo : Form
    {
        // INSTANCIA CONTROL -> DATAGRIDVIEW
        BaseDeDatos integracion = new BaseDeDatos();

        // INSTANCIA LLAMADA NOTIFICACIONES PESONALIZADAS
        NotificacionesPersonalizadas Llamada = new NotificacionesPersonalizadas();

        // INSTANCIA CONTROLADOR GENERAL DE CONEXION {TODOS LOS MANTENIMIENTOS DEL SISTEMA}
        ControlConexion Controlador = new ControlConexion();
        public ModificarVistaCargo()
        {
            InitializeComponent();
            DetallesSimplesCargos.DataSource = integracion.SelectDataTable("SELECT * FROM vCargoSistema");
        }
        /*
            --> BOTON MINIMIZAR  VENTANA 
        */
        private void IconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /*
            --> BOTON  CERRAR VENTANA 
        */
        private void IconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*
            --> BOTON MODIFICAR NUEVO CARGO VENTANA 
        */
        private void btnModificarNuevosCargo_Click(object sender, EventArgs e)
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
                try
                {
                    // SI CUMPLE CONDICION ANTERIOR, E INSERCION ES EXITOSA... ENTONCES
                    using (SqlCommand comando = new SqlCommand("sp_ModificarCargos", Controlador.Conexiones()))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Add(new SqlParameter("@Id_cargo", txtIdCargo.Text));
                        comando.Parameters.Add(new SqlParameter("@Nombre_cargo", txtNombreCargo.Text));
                        comando.Parameters.Add(new SqlParameter("@Descripcion", txtDescripcionCortaCargo.Text));
                        comando.ExecuteNonQuery();
                    }
                    DetallesSimplesCargos.DataSource = integracion.SelectDataTable("SELECT * FROM vCargoSistema"); // DATAGRIDVIEW CATEGORIA
                    // LIMPIEZA GENERAL LUEGO DE INSERTAR NUEVO REGISTRO
                    LimpiezaCargo(); // LLAMADA METODO LIMPIEZA
                    // MOSTRANDO EN PANTALLA PROCESO FINALIZADO CON EXITO
                    Form TareaFinalizada = new MensajeAprobacion();
                    TareaFinalizada.Show();
                    // LLAMADA DE NOTIFICACION PERSONALIZADA DE ADVERTENCIA
                    Llamada.NotificionConfirmacion();
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
        }
        //EVENTO PARA ELIMINAR CAMPOS AL INGRESARSE LA MODIFICACION DE CARGOS SISTEMA
        public void LimpiezaCargo()
        {
            txtIdCargo.Clear(); txtNombreCargo.Clear(); txtDescripcionCortaCargo.Clear();
        }

        private void DetallesSimplesCargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdCargo.Text = DetallesSimplesCargos.CurrentRow.Cells["Id_cargo"].Value.ToString();
            txtNombreCargo.Text = DetallesSimplesCargos.CurrentRow.Cells["Nombre_cargo"].Value.ToString();
            txtDescripcionCortaCargo.Text = DetallesSimplesCargos.CurrentRow.Cells["Descripcion"].Value.ToString();
        }
        // EVENTO ENTER -> TEXTBOX ID CARGO DE EMPLEADO
        private void txtIdCargo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnModificarNuevosCargo_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX NOMBRE CARGO DE EMPLEADO
        private void txtNombreCargo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnModificarNuevosCargo_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX DESCRIPCION CORTA DE EMPLEADO
        private void txtDescripcionCortaCargo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnModificarNuevosCargo_Click(this, new EventArgs());
            }
        }
    }
}
