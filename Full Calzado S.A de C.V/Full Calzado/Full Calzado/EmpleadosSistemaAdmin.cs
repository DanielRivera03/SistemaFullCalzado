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
// IMPORTANDO LIBRERIAS CONTROL EXPORTACION A PDF
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Full_Calzado
{
    public partial class EmpleadosSistemaAdmin : Form
    {
        // INSTANCIA CONTROL -> DATAGRIDVIEW
        BaseDeDatos integracion = new BaseDeDatos();

        // INSTANCIA CONTROL GENERAL COMBOBOX
        ControlComboboxGeneral DatosCargo = new ControlComboboxGeneral();   // SEXO DE EMPLEADOS
        ControlComboboxGeneral DatosGenero = new ControlComboboxGeneral();      // GENERO DEL EMPLEADO
        ControlComboboxGeneral DatosEstadoCivil = new ControlComboboxGeneral(); //ESTADO CIVIL DEL EMPLEADO

        // INSTANCIA LLAMADA NOTIFICACIONES PESONALIZADAS
        NotificacionesPersonalizadas Llamada = new NotificacionesPersonalizadas();

        // INSTANCIA CONTROLADOR GENERAL DE CONEXION {TODOS LOS MANTENIMIENTOS DEL SISTEMA}
        ControlConexion Controlador = new ControlConexion();

        public EmpleadosSistemaAdmin()
        {
            InitializeComponent();
            DetallesSimplesEmpleado.DataSource = integracion.SelectDataTable("SELECT * FROM vEmpleadoSistema"); // DATAGRIDVIEW PRODUCTOS
            DatosCargo.SeleccionarDatosCE(cbxCargo);  // COMBOBOX -> CATEGORIA DE PRODUCTOS
            DatosGenero.SeleccionarDatosGE(cbxGenero);             // COMBOBOX -> GENERO DE EMPLEADOS
            DatosEstadoCivil.SeleccionarDatosECE(cbxEstadoCivil); // COMBOBOX -> ESTADO CIVIL DE EMPLEADOS
        }
        /*
          --> BOTON REGISTRAR EMPLEADOS
        */
        private void btnRegistroEmpleadoNuevos_Click(object sender, EventArgs e)
        {
            if (txtIdEmpleado.Text.Length == 0 || txtP1Nombre.Text.Length == 0 || txtA1Apellido.Text.Length == 0 || txtSueldoBase.Text.Length == 0
                || txtFechaNacimiento.Text.Length == 0 || txtDireccion.Text.Length == 0 || txttel.Text.Length == 0 || txtmdui.Text.Length == 0
                || cbxCargo.Text == "- Seleccione Cargo..." || cbxEstadoCivil.Text == "-Seleccione Estado Civil..." || cbxGenero.Text == "- Seleccione Genero...")
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
                    using (SqlCommand comando = new SqlCommand("sp_InsertarEmpleados", Controlador.Conexiones()))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Add(new SqlParameter("@Id_empleado", Convert.ToInt32(txtIdEmpleado.Text)));
                        comando.Parameters.Add(new SqlParameter("@Nombre", txtP1Nombre.Text));
                        comando.Parameters.Add(new SqlParameter("@Apellido", txtA1Apellido.Text));
                        comando.Parameters.Add(new SqlParameter("@Sueldo_Base", txtSueldoBase.Text));
                        comando.Parameters.Add(new SqlParameter("@Fecha_Nacimiento", txtFechaNacimiento.Text));
                        comando.Parameters.Add(new SqlParameter("@Dui", txtmdui.Text));
                        comando.Parameters.Add(new SqlParameter("@Sexo", cbxGenero.Text));
                        comando.Parameters.Add(new SqlParameter("@Estado_Civil", cbxEstadoCivil.Text));
                        comando.Parameters.Add(new SqlParameter("@Telefono", txttel.Text));
                        comando.Parameters.Add(new SqlParameter("@Direccion", txtDireccion.Text));
                        comando.Parameters.Add(new SqlParameter("@Nombre_cargo", cbxCargo.Text));
                        comando.ExecuteNonQuery(); // EJECUTANDO RUTINA
                    }
                    // REFRESCANDO VISTA DATAGRIDVIEW
                    DetallesSimplesEmpleado.DataSource = integracion.SelectDataTable("SELECT * FROM vEmpleadoSistema"); // DATAGRIDVIEW ROLES
                    // LIMPIEZA GENERAL LUEGO DE INSERTAR NUEVO REGISTRO
                    LimpiezaEmpleados(); // LLAMADA METODO LIMPIEZA
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
        /*
          --> BOTON LIMPIEZA FORMULARIO
        */
        private void btnLimpieza_Click(object sender, EventArgs e)
        {
            if (txtIdEmpleado.Text.Length == 0 && txtP1Nombre.Text.Length == 0 && txtA1Apellido.Text.Length == 0 && txtSueldoBase.Text.Length == 0
                && txtFechaNacimiento.Text.Length == 0 && txtDireccion.Text.Length == 0 && txttel.Text.Length == 0 && txtmdui.Text.Length == 0
                && cbxCargo.Text == "- Seleccione Cargo..." && cbxEstadoCivil.Text == "-Seleccione Estado Civil..." && cbxGenero.Text == "- Seleccione Genero...")
            {
                // LLAMADA DE VENTANA EMERGENTE -> ERROR CAMPOS VACIOS A LA HORA DE INVOCAR METODO LIMPIEZA
                Form LlamadaErrorLimpieza = new MensajeLimpieza();
                LlamadaErrorLimpieza.Show();
                // LLAMADA DE NOTIFICACION PERSONALIZADA DE ERROR
                Llamada.NotificionErrorLimpieza();
            }
            else
            {
                LimpiezaEmpleados(); // LLAMADA METODO LIMPIEZA
            }
        }
        // METODO DE LIMPIEZA FORMULARIO {EMPLEADOS}
        public void LimpiezaEmpleados()
        {
            txtIdEmpleado.Clear(); txtP1Nombre.Clear(); txtA1Apellido.Clear(); txtSueldoBase.Clear(); txtFechaNacimiento.Clear();
            txtDireccion.Clear(); txttel.Clear(); txtmdui.Clear(); cbxCargo.Text = "- Selecione Cargo..."; cbxEstadoCivil.Text = "- Seleccione Estado Civil";
            cbxGenero.Text = "- Seleccione Genero...";
        }
        /*
           BOTON PARA MODIFICAR EMPLEADOS
        */
        private void btnModificarEmpleados_Click(object sender, EventArgs e)
        {
            Form ModificarEmpleadosRegistrados = new ModificarEmpleados();
            ModificarEmpleadosRegistrados.Show();
        }
        /*
            BOTON PARA ELIMINAR EMPLEADOS
        */
        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            Form EliminarEmpleadoRegistrados = new EliminarEmpleados();
            EliminarEmpleadoRegistrados.Show();
        }
        /*
            BOTON PARA MODIFICAR CARGO EMPLEADOS
        */
        private void btnModificarCargo_Click(object sender, EventArgs e)
        {
            Form ModificarCargoRegistrado = new ModificarVistaCargo();
            ModificarCargoRegistrado.Show();
        }
        /*
            BOTON PARA AGREGAR CARGO EMPLEADOS
        */
        private void btnAgregarCargo_Click(object sender, EventArgs e)
        {
            Form RegistrarCargosNuevos = new RegistrarCargos();
            RegistrarCargosNuevos.Show();
        }
        /*
            BOTON PARA ELIMINAR CARGO EMPLEADOS
        */
        private void btnEliminarCargo_Click(object sender, EventArgs e)
        {
            Form EliminarCargosRegistrados = new EliminarCargos();
            EliminarCargosRegistrados.Show();
        }
        //---------------------------------------------------------------
        //Evento Boton PARA EXPORTAR ARCHIVO EXCEL
        private void btnExportarEmpleados_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            // MOSTRANDO VENTANA EMERGENTE DE CIERRE DE SESION {Exportar Archivo Excel}
            Form mensaje = new MensajeExportarExcel();
            resultado =  mensaje.ShowDialog();
            // MOSTRANDO VENTANA EMERGENTE DE EXPORTAR ARCHIVO EXCEL {PREGUNTA ACCIONES}
            Form consulta = new MensajeExportarExcel();
            // LLAMADA DE NOTIFICACION PERSONALIZADA DE PREGUNTA
            Llamada.NotificionExportar();
            /*
                --> COMPROBACION PARA GENERAR ARCHIVO EXCEL...
                        DISPONIBILIDAD DE CANCELAR EVENTO 
            */
            if (resultado == DialogResult.OK)
            {
                exportaraexcel(DetallesSimplesEmpleado);
            }
            if (resultado == DialogResult.Cancel)
            {
                this.Close();
            }
            // CREANDO MENSAJE EN VENTANA FLOTANTE PERSONALIZADO
        }
        public void exportaraexcel(DataGridView tabla)
        {
            // CREANDO MENSAJE EN VENTANA FLOTANTE PERSONALIZADO
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int IndiceColumna = 0;
            foreach (DataGridViewColumn col in tabla.Columns) // Columnas
            {
                IndiceColumna++;
                excel.Cells[1, IndiceColumna] = col.Name;
            }
            int IndeceFila = 0;
            foreach (DataGridViewRow row in tabla.Rows) // Filas
            {
                IndeceFila++;
                IndiceColumna = 0;
                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    IndiceColumna++;
                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;
        }
        //---------------------------------------------------------------
        //Evento BOTON PARA EXPORTAR ARCHIVO PDF
        private void btnExportarEmpleadosPDF_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            // MOSTRANDO VENTANA EMERGENTE DE CIERRE DE SESION {Exportar Archivo Excel}
            Form mensaje = new MensajeExportarPDF();
            resultado = mensaje.ShowDialog();
            // MOSTRANDO VENTANA EMERGENTE DE EXPORTAR ARCHIVO EXCEL {PREGUNTA ACCIONES}
            Form consulta = new MensajeExportarPDF();
            // LLAMADA DE NOTIFICACION PERSONALIZADA DE PREGUNTA
            Llamada.NotificionExportar();
            /*
                --> COMPROBACION PARA GENERAR ARCHIVO PDF...
                        DISPONIBILIDAD DE CANCELAR EVENTO 
            */
            if (resultado == DialogResult.OK)
            {
                ExportarPDF(DetallesSimplesEmpleado,"");
            }
            if (resultado == DialogResult.Cancel)
            {
                this.Close();
            }
            // CREANDO MENSAJE EN VENTANA FLOTANTE PERSONALIZADO
        }
        public void ExportarPDF(DataGridView RegistroInformesSistema, string NombreArchivoFinal)
        {
            BaseFont EstilosFuentes = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(RegistroInformesSistema.Columns.Count);
            pdftable.DefaultCell.Padding = 14;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdftable.DefaultCell.BorderWidth = 4;
            iTextSharp.text.Font text = new iTextSharp.text.Font(EstilosFuentes, 19, iTextSharp.text.Font.NORMAL);
            foreach (DataGridViewColumn colum in RegistroInformesSistema.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(colum.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                pdftable.AddCell(cell);
            }

            foreach (DataGridViewRow row in RegistroInformesSistema.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var EstilosFinalesArchivoFinal = new SaveFileDialog();
            EstilosFinalesArchivoFinal.FileName = NombreArchivoFinal;
            EstilosFinalesArchivoFinal.DefaultExt = ".pdf";
            if (EstilosFinalesArchivoFinal.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(EstilosFinalesArchivoFinal.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A1.Rotate(), 40, 40, 40, 40);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }
        // EVENTO ENTER -> TEXTBOX ID EMPLEADOS
        private void txtIdEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroEmpleadoNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX NOMBRE EMPLEADOS
        private void txtP1Nombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroEmpleadoNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX APELIIDOS EMPLEADOS
        private void txtA1Apellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroEmpleadoNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX SUELDO BASE EMPLEADOS
        private void txtSueldoBase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroEmpleadoNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX FECHA DE NACIMIENTO EMPLEADOS
        private void txtFechaNacimiento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroEmpleadoNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX TELEFONO EMPLEADOS
        private void txttel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroEmpleadoNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> COMBOBOX ESTADO CIVIL EMPLEADOS
        private void cbxEstadoCivil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroEmpleadoNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> COMBOBOX GENERO DE EMPLEADOS
        private void cbxGenero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroEmpleadoNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> COMBOBOX CARGOS DE EMPLEADOS
        private void cbxCargo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroEmpleadoNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX DUI EMPLEADOS
        private void txtmdui_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroEmpleadoNuevos_Click(this, new EventArgs());
            }
        }
        // EVENTO ENTER -> TEXTBOX DIRECCION EMPLEADOS
        private void txtDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistroEmpleadoNuevos_Click(this, new EventArgs());
            }
        }
    }
}
