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
using System.Data.SqlClient;

namespace Full_Calzado
{
    public partial class FacturacionFullCalzado : Form
    {
        BaseDeDatos integracion = new BaseDeDatos();
        //INSTANCIANDO A CLASE QUE ALIMENTA LOS COMBOBOX
        ControlComboboxGeneral DatosEmpleados = new ControlComboboxGeneral();

        //INSTANCIANDO A CONTROLADOR DE BASE DE DATOS
        ControlConexion Controlador = new ControlConexion();

        DataTable dtbdetalle = new DataTable();

        NotificacionesPersonalizadas Llamada = new NotificacionesPersonalizadas();

        public FacturacionFullCalzado()
        {
            InitializeComponent();
            dgvproductos.DataSource = integracion.SelectDataTable("SELECT * FROM VFactura");
            
            DatosEmpleados.SeleccionarDatos2(cmbempleado);
            DatosEmpleados.SeleccionarDatos3(cmbformapago);
           DatosEmpleados.SeleccionarDatos4(cmbtipodoc);
        }

        private void FacturacionFullCalzado_Load(object sender, EventArgs e)
        {
            try
            {
                dtbdetalle.Columns.Add("id_Producto", typeof(string));
                dtbdetalle.Columns.Add("descripcion", typeof(string));
                dtbdetalle.Columns.Add("cantidad", typeof(string));
                dtbdetalle.Columns.Add("precio", typeof(string));
            }
            catch
            {
                // MOSTRANDO VENTANA EMERGENTE DE ADVERTENCIA
                Form LlamadaAdvertencia = new MensajeAlgoSalioMal();
                LlamadaAdvertencia.Show();
                // LLAMADA DE NOTIFICACION PERSONALIZADA DE ADVERTENCIA
                Llamada.NotificionAdvertencia();
            }
        }

        /*
            --> BOTON AGREGAR PRODUCTOS
        */
        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = dtbdetalle.NewRow();
                dr["id_Producto"] = txtcodprod.Text;
                dr["descripcion"] = txtdescripcion.Text;
                dr["cantidad"] = txtcantidad.Text;
                dr["precio"] = txtprecio.Text;

                dtbdetalle.Rows.Add(dr);
                datagvdeta.DataSource = dtbdetalle;
                txtsubtotal.Text = (Convert.ToDouble(txtsubtotal.Text) + (Convert.ToDouble(txtcantidad.Text) * Convert.ToDouble(txtprecio.Text))).ToString();
                double iva = 0, descuento = 0, res = 0;
                if (cmbtipodoc.Text == "Credito F")
                {
                    iva = Convert.ToDouble(txtsubtotal.Text) * 0.13;
                    txtiva.Text = iva.ToString();
                }
                else
                {
                    iva = 0;
                    txtiva.Text = iva.ToString();
                }
                if (cmbdescuentos.Text == "5%")
                {
                    descuento = Convert.ToDouble(txtsubtotal.Text) * 0.05;
                    res = Convert.ToDouble(txtsubtotal.Text);
                    txtsubtotal.Text = (res - descuento).ToString();
                }
                else if (cmbdescuentos.Text == "10%")
                {
                    descuento = Convert.ToDouble(txtsubtotal.Text) * 0.10;
                    res = Convert.ToDouble(txtsubtotal.Text);
                    txtsubtotal.Text = (res - descuento).ToString();
                }
                else if (cmbdescuentos.Text == "20%")
                {
                    descuento = Convert.ToDouble(txtsubtotal.Text) * 0.20;
                    res = Convert.ToDouble(txtsubtotal.Text);
                    txtsubtotal.Text = (res - descuento).ToString();
                }
                else if (cmbdescuentos.Text == "30%")
                {
                    descuento = Convert.ToDouble(txtsubtotal.Text) * 0.30;
                    res = Convert.ToDouble(txtsubtotal.Text);
                    txtsubtotal.Text = (res - descuento).ToString();
                }
                else if (cmbdescuentos.Text == "50%")
                {
                    descuento = Convert.ToDouble(txtsubtotal.Text) * 0.50;
                    res = Convert.ToDouble(txtsubtotal.Text);
                    txtsubtotal.Text = (res - descuento).ToString();
                }
                else if (cmbdescuentos.Text == "80%")
                {
                    descuento = Convert.ToDouble(txtsubtotal.Text) * 0.80;
                    res = Convert.ToDouble(txtsubtotal.Text);
                    txtsubtotal.Text = (res - descuento).ToString();
                }
                else if (cmbdescuentos.Text == "")
                {
                    descuento = 0;
                    res = Convert.ToDouble(txtsubtotal.Text);
                    txtsubtotal.Text = (res - descuento).ToString();
                }
                txttotal.Text = (Convert.ToDouble(txtsubtotal.Text) + Convert.ToDouble(txtiva.Text)).ToString();
            }
            catch
            {
                // MOSTRANDO VENTANA EMERGENTE DE ADVERTENCIA
                Form LlamadaAdvertencia = new MensajeNoHayDatosQueCargar();
                LlamadaAdvertencia.Show();
                // LLAMADA DE NOTIFICACION PERSONALIZADA DE ADVERTENCIA
                Llamada.NotificionAdvertencia();
            }
            txtcodprod.Text = "";
            txtdescripcion.Text = "";
            txtcantidad.Text = "";
            txtprecio.Text = "";
        }

        private void cmbformapago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbformapago.Text == "Tarjeta")
            {
                txttarjeta.Enabled = true;
            }
            else
            {
                txttarjeta.Enabled = false;
            }
        }

        private void btnverproductos_Click(object sender, EventArgs e)
        {
            Form Listarproductos = new ListadoPersonalizadoProductos();
            Listarproductos.Show();
        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {
            if (cmbempleado.Text == "- Selccione..." || cmbformapago.Text == "- Selccione..." || cmbtipodoc.Text == "- Selccione..." || datagvdeta.RowCount<0)
            {
                Form msjdatosvacios = new MensajeErrorCamposVacios();
                msjdatosvacios.Show();
                Llamada.NotificionErrorLimpieza();
                //MessageBox.Show("Debe de asegurarse en llenar los campos que correspondan");
            }
            else
            {
                try
                {
                    DateTime dateTime = DateTime.UtcNow.Date;
                    string query = "EXECUTE INSER_FAC @id_Empleado,@id_Formapago,@fecha,@Nit,@No_Registro,@Num_tarjeta,@sub_total,@iva,@total,@id_tipopago";
                    SqlCommand comando = new SqlCommand(query, Controlador.Conexiones());
                    comando.Parameters.AddWithValue("@id_Empleado", cmbempleado.SelectedValue.ToString());
                    comando.Parameters.AddWithValue("@id_Formapago", cmbformapago.SelectedValue.ToString());
                    comando.Parameters.AddWithValue("@fecha", dateTime.ToString("yyyy/MM/dd"));
                    comando.Parameters.AddWithValue("@Nit", txtnit.Text);
                    comando.Parameters.AddWithValue("@No_Registro", txtnregistro.Text);
                    comando.Parameters.AddWithValue("@Num_tarjeta", txttarjeta.Text);
                    comando.Parameters.AddWithValue("@sub_total", txtsubtotal.Text);
                    comando.Parameters.AddWithValue("@iva", txtiva.Text);
                    comando.Parameters.AddWithValue("@total", txttotal.Text);
                    comando.Parameters.AddWithValue("@id_tipopago", cmbtipodoc.SelectedValue.ToString());
                    comando.ExecuteNonQuery();
                }
                catch
                {
                    // MOSTRANDO VENTANA EMERGENTE DE ADVERTENCIA
                    Form LlamadaAdvertencia = new MensajeNoseInsertaFactura();
                    LlamadaAdvertencia.Show();
                    // LLAMADA DE NOTIFICACION PERSONALIZADA DE ADVERTENCIA
                    Llamada.NotificionAdvertencia();
                }
               // MessageBox.Show(cmbempleado.SelectedValue +" "+cmbtipodoc.SelectedValue+" "+ cmbformapago.SelectedValue +" "+ dateTime.ToString("yyyy/MM/dd") +" "+ txtnit.Text +" "+ txtnregistro.Text +" "+ txttarjeta.Text +" "+ txtsubtotal.Text +" "+ txtiva.Text +" "+ txttotal.Text);
                for (int i = 0; i < dtbdetalle.Rows.Count; i++)
                {
                    string strprod = dtbdetalle.Rows[i]["id_Producto"].ToString();
                    string strdescripcion = dtbdetalle.Rows[i]["descripcion"].ToString();
                    int strcantidad = Convert.ToInt32(dtbdetalle.Rows[i]["cantidad"].ToString());
                    double strprecio = Convert.ToDouble(dtbdetalle.Rows[i]["precio"].ToString());

                    string query2 = "EXECUTE INSER_DET_FAC @id_Producto,@descripcion,@cantidad,@precio";
                    SqlCommand comando2 = new SqlCommand(query2, Controlador.Conexiones());
                    comando2.Parameters.AddWithValue("@id_Producto", strprod);
                    comando2.Parameters.AddWithValue("@descripcion", strdescripcion);
                    comando2.Parameters.AddWithValue("@cantidad", strcantidad);
                    comando2.Parameters.AddWithValue("@precio", strprecio);
                    comando2.ExecuteNonQuery();
                }
                //MessageBox.Show(txtcodprod.Text+" "+txtdescripcion.Text+" "+txtcantidad.Text+" "+txtprecio.Text);
               // MessageBox.Show("Datos Insertados correctamente");
                Form msjaprov = new MensajeAprobacion();
                Llamada.NotificionConfirmacion();
                msjaprov.Show();
                dtbdetalle.Rows.Clear();
                datagvdeta.DataSource = dtbdetalle;
                //REFRESCANDO DATOS DE DATAGRID PARA MOSTRAR TODOS LOS DETALLES
                dgvproductos.DataSource = integracion.SelectDataTable("SELECT * FROM VFactura");
                cmbempleado.Text = "";
                cmbformapago.Text = "";
                cmbtipodoc.Text = "";
                cmbdescuentos.Text = "";
                txtnit.Text = "";
                txtnregistro.Text = "";
                txttarjeta.Text = "";
                txtcodprod.Text = "";
                txtdescripcion.Text = "";
                txtcantidad.Text = "";
                txtprecio.Text = "";
                txtsubtotal.Text = "0.00";
                txtiva.Text = "0.00";
                txttotal.Text = "0.00";
            }
        }

        private void cmbtipodoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbtipodoc.Text == "Credito F")
            {
                txtnit.Enabled = true;
                txtnregistro.Enabled = true;
            }
            else
            {
                txtnit.Enabled = false;
                txtnregistro.Enabled = false;
            }
        }
        //METODO PARA PODER MOSTRAR EL PRODUCTO Y PRECIO DEL PANEL DE OPCIONES
        private void txtcodprod_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand consultar = new SqlCommand("SELECT * FROM Productos WHERE ID = @id_producto", Controlador.Conexiones());
            consultar.Parameters.AddWithValue("id_producto", (txtcodprod.Text));
            SqlDataAdapter adaptador = new SqlDataAdapter(consultar);
            DataTable dtbproducto = new DataTable();
            adaptador.Fill(dtbproducto);
            if (dtbproducto.Rows.Count > 0)
            {
                txtdescripcion.Text = dtbproducto.Rows[0]["Nombre"].ToString();
                txtprecio.Text = dtbproducto.Rows[0]["Precio"].ToString();
            }
            if (txtcodprod.Text == "")
            {
                txtdescripcion.Clear(); txtprecio.Clear();
            }
        }
        //METODO PARA LIMPIAR EL PANEL DE OPCIONES
        public void LimpiarPanelOpciones()
        {
            txtcodprod.Clear(); txtdescripcion.Clear(); txtcantidad.Clear(); txtprecio.Clear();
        }

        private void btnLimpieza_Click(object sender, EventArgs e)
        {
            dtbdetalle.Rows.Clear();
            datagvdeta.DataSource = dtbdetalle;
            cmbdescuentos.Text = "";
            cmbempleado.Text = "- Selccione...";
            cmbformapago.Text = "- Selccione...";
            cmbtipodoc.Text = "- Selccione...";
            cmbdescuentos.Text = "";
            txtnit.Text = "";
            txtnregistro.Text = "";
            txttarjeta.Text = "";
            txtcodprod.Text = "";
            txtdescripcion.Text = "";
            txtcantidad.Text = "";
            txtprecio.Text = "";
            txtsubtotal.Text = "0.00";
            txtiva.Text = "0.00";
            txttotal.Text = "0.00";
        }

        private void btnvercompras_Click(object sender, EventArgs e)
        {
            Form listafactura = new ListadoDetalladoFactura();
            listafactura.Show();
        }

        private void btnEliminarFactura_Click(object sender, EventArgs e)
        {
            Form eliminarfactura = new EliminarFactura();
            eliminarfactura.Show();
        }

        private void btnNuevoVerFPago_Click(object sender, EventArgs e)
        {
            Form verformapago = new NuevoVistaFormaPago();
            verformapago.Show();
        }

        private void btnvertipodoc_Click(object sender, EventArgs e)
        {
            Form vistadoc = new NuevoVistaTipoDoc();
            vistadoc.Show();
        }
    }
}
