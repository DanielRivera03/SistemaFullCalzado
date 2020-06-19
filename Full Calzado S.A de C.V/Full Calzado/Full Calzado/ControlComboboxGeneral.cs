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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// IMPORTANDO LIBRERIA SERVICIO CLIENTE C# -> SQL SERVER
using System.Data.SqlClient;

namespace Full_Calzado
{
    class ControlComboboxGeneral
    {

        // INSTANCIA CONTROLADOR GENERAL DE CONEXION {TODOS LOS MANTENIMIENTOS DEL SISTEMA}
        ControlConexion Controlador = new ControlConexion();
        /*
            --> ROLES DE USUARIOS
                CONTROL ESTRICTO PARA SOLO USUARIOS ADMINISTRADORES 
        */
        public void SeleccionarDatos(ComboBox DatosTablasRelacionadas)
        {
            DatosTablasRelacionadas.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Roles", Controlador.Conexiones());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DatosTablasRelacionadas.Items.Add(dr[0].ToString());
            }
            Controlador.CierreConexion();
            DatosTablasRelacionadas.Items.Insert(0, "- Seleccione un rol...");
            DatosTablasRelacionadas.SelectedIndex = 0;
        }
        /*
            --> CARGOS DE EMPLEADOS
                CONTROL ESTRICTO PARA SOLO CARGOS DE EMPLEADOS DE ADMINISTRADORES 
        */
        public void SeleccionarDatosCE(ComboBox DatosTablasRelacionadas)
        {
            DatosTablasRelacionadas.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Cargos", Controlador.Conexiones());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DatosTablasRelacionadas.Items.Add(dr[1].ToString());
            }
            Controlador.CierreConexion();
            DatosTablasRelacionadas.Items.Insert(0, "- Seleccione Cargo...");
            DatosTablasRelacionadas.SelectedIndex = 0;
        }

        public void SeleccionarDatosGE(ComboBox DatosTablasRelacionadas)
        {
            DatosTablasRelacionadas.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Genero", Controlador.Conexiones());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DatosTablasRelacionadas.Items.Add(dr[0].ToString());
            }
            Controlador.CierreConexion();
            DatosTablasRelacionadas.Items.Insert(0, "- Seleccione Genero...");
            DatosTablasRelacionadas.SelectedIndex = 0;
        }

        public void SeleccionarDatosECE(ComboBox DatosTablasRelacionadas)
        {
            DatosTablasRelacionadas.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM EstadoCivil", Controlador.Conexiones());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DatosTablasRelacionadas.Items.Add(dr[0].ToString());
            }
            Controlador.CierreConexion();
            DatosTablasRelacionadas.Items.Insert(0, "- Seleccione EstadoCivil...");
            DatosTablasRelacionadas.SelectedIndex = 0;
        }
        /*
            --> CATEGORIA DE PRODUCTOS 
                CONTROL ESTRICTO PARA SOLO PRODUCTOS DE ADMINISTRADORES 
        */
        public void SeleccionarDatosCP(ComboBox DatosTablasRelacionadas)
        {
            DatosTablasRelacionadas.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Categoria", Controlador.Conexiones());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DatosTablasRelacionadas.Items.Add(dr[1].ToString());
            }
            Controlador.CierreConexion();
            DatosTablasRelacionadas.Items.Insert(0, "- Seleccione un Categoria...");
            DatosTablasRelacionadas.SelectedIndex = 0;
        }

        //METODO PARA ALIMENTAR COMBOBOX DE EMPLEADOS EN LA FACTURA
        public void SeleccionarDatos2(ComboBox DatosTablasRelacionadas)
        {
            DatosTablasRelacionadas.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Empleados", Controlador.Conexiones());
            SqlDataReader dr = cmd.ExecuteReader();
            System.Data.DataTable dtb = new System.Data.DataTable();
            dtb.Columns.Add("Id_empleado");
            dtb.Columns.Add("Nombre");
            dtb.Rows.Add(0, "- Selccione...");
            while (dr.Read())
            {
                dtb.Rows.Add(dr[0].ToString(), dr[1].ToString());
            }
            Controlador.CierreConexion();
            DatosTablasRelacionadas.DataSource = dtb;
            //VALOR A EVALUAR
            DatosTablasRelacionadas.ValueMember = "Id_empleado";
            //VALOR A DESPLEGAR
            DatosTablasRelacionadas.DisplayMember = "Nombre";
        }

        //METODO PARA ALIMENRTAR COMBOBOX DE FORMA DE PAGO EN FACTURA
        public void SeleccionarDatos3(ComboBox DatosTablasRelacionadas)
        {
            DatosTablasRelacionadas.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * from Forma_Pago", Controlador.Conexiones());
            SqlDataReader dr = cmd.ExecuteReader();
            System.Data.DataTable dtb = new System.Data.DataTable();
            dtb.Columns.Add("id_formapago");
            dtb.Columns.Add("nombre");
            dtb.Rows.Add(0, "- Selccione...");
            while (dr.Read())
            {
                dtb.Rows.Add(dr[0].ToString(), dr[1].ToString());
            }
            Controlador.CierreConexion();

            DatosTablasRelacionadas.DataSource = dtb;
            //VALOR A EVALUAR
            DatosTablasRelacionadas.ValueMember = "id_formapago";
            //VALOR A DESPLEGAR
            DatosTablasRelacionadas.DisplayMember = "nombre";

        }

        //METODO PARA ALIMENTAR COMBOBOX DE TIPO DE PAGO EN FACTURA
        public void SeleccionarDatos4(ComboBox DatosTablasRelacionadas)
        {
            DatosTablasRelacionadas.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * from tipo_pago", Controlador.Conexiones());
            SqlDataReader dr = cmd.ExecuteReader();
            System.Data.DataTable dtb = new System.Data.DataTable();
            dtb.Columns.Add("id_tipopago");
            dtb.Columns.Add("nombre");
            dtb.Rows.Add(0, "- Selccione...");
            while (dr.Read())
            {
                dtb.Rows.Add(dr[0].ToString(), dr[1].ToString());
            }
            Controlador.CierreConexion();

            DatosTablasRelacionadas.DataSource = dtb;
            //VALOR A EVALUAR
            DatosTablasRelacionadas.ValueMember = "id_tipopago";
            //VALOR A DESPLEGAR
            DatosTablasRelacionadas.DisplayMember = "nombre";
        }
    }
}
