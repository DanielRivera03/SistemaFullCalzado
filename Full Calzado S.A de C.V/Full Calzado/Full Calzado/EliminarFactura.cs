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
// IMPORTANDO LIBRERIA QUE HABILITA EL EVENTO DE ARRASTRES DE FORMULARIOS POR PARTE DE LOS USUARIOS
using System.Runtime.InteropServices;
using System.Windows.Forms;
// IMPORTANDO LIBRERIA SERVICIO CLIENTE C# -> SQL SERVER
using System.Data.SqlClient;

namespace Full_Calzado
{
    public partial class EliminarFactura : Form
    {
        BaseDeDatos integracion = new BaseDeDatos();

        //LLAMADA A CLASE DE NOTIFICACIONES
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
        public EliminarFactura()
        {
            InitializeComponent();
            DetallesSimplesFactura.DataSource = integracion.SelectDataTable("SELECT * FROM VFactura");
        }

        private void IconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void IconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DetallesSimplesFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idfactura.Text=DetallesSimplesFactura.CurrentRow.Cells["cod_examen"].Value.ToString();
            fecha.Text= DetallesSimplesFactura.CurrentRow.Cells["fecha"].Value.ToString();
            empleado.Text = DetallesSimplesFactura.CurrentRow.Cells["Nombre"].Value.ToString();
            formapago.Text = DetallesSimplesFactura.CurrentRow.Cells["FormaPago"].Value.ToString();
            tipodoc.Text = DetallesSimplesFactura.CurrentRow.Cells["TipoDoc"].Value.ToString();
            txtsubtotal.Text = DetallesSimplesFactura.CurrentRow.Cells["sub_total"].Value.ToString();
            tiva.Text = DetallesSimplesFactura.CurrentRow.Cells["iva"].Value.ToString();
            txttotal.Text = DetallesSimplesFactura.CurrentRow.Cells["total"].Value.ToString();
        }

        private void ContenedorSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            // HABILITANDO FUNCION DE ARRASTRE DE FORMULARIO
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtidfactura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btneliminarfactura_Click(this, new EventArgs());
            }
        }

        private void txtfecha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btneliminarfactura_Click(this, new EventArgs());
            }
        }

        private void txtempleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btneliminarfactura_Click(this, new EventArgs());
            }
        }

        private void txttipodoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btneliminarfactura_Click(this, new EventArgs());
            }
        }

        private void txtformapago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btneliminarfactura_Click(this, new EventArgs());
            }
        }

        private void txtsubtotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btneliminarfactura_Click(this, new EventArgs());
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btneliminarfactura_Click(this, new EventArgs());
            }
        }

        private void txttotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btneliminarfactura_Click(this, new EventArgs());
            }
        }

        private void btneliminarfactura_Click(object sender, EventArgs e)
        {
            if (idfactura.Text.Length == 0 || fecha.Text.Length == 0 || empleado.Text.Length == 0 || formapago.Text.Length == 0 || tiva.Text.Length == 0
               || txtsubtotal.Text.Length == 0 || tipodoc.Text.Length == 0 || txttotal.Text.Length == 0)
            {
                // MOSTRANDO VENTANA EMERGENTE DE ADVERTENCIA
                Form LlamadaAdvertenciaNoSeleccion = new MensajeNoSeleccion();
                LlamadaAdvertenciaNoSeleccion.Show();
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
                    using (SqlCommand comando = new SqlCommand("SP_eliminar_factura", Controlador.Conexiones()))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Add(new SqlParameter("@ID_FACTURA", idfactura.Text));    // ID DE USUARIO
                        comando.ExecuteNonQuery();  // EJECUTANDO RUTINA
                    }
                    // REFRESCANDO VISTA DATAGRIDVIEW
                    DetallesSimplesFactura.DataSource = integracion.SelectDataTable("SELECT * FROM [ VFactura]"); // DATAGRIDVIEW PRODUCTOS
                    idfactura.Clear();
                    empleado.Clear();
                    fecha.Clear();
                    formapago.Clear();
                    txtsubtotal.Clear();
                    txttipodoc.Clear();
                    txttotal.Clear();
                    tiva.Clear();
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
    }
}