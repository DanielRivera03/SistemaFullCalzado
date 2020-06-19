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
using System.Media;

namespace Full_Calzado
{
    class NotificacionesPersonalizadas
    {
        // CREANDO EVENTO DE SONIDO
        SoundPlayer Notificaciones;

        // INSTANCIA CONTROLADOR DE RUTA
        ControlRutaNotificaciones ControladorRutas = new ControlRutaNotificaciones();

        // NOTIFICACION PERSONALIZADA DE ERRORES
        public void NotificionError()
        {
            // FAVOR CAMBIAR NOMBRE DEL SISTEMA {dany__000} Y RESPETAR RUTA ASIGNADA CON TODAS SUS CARPETAS
            Notificaciones = new SoundPlayer(@"C:\Users\" + ControladorRutas.RutaNotificaciones() + "Error.wav");
            Notificaciones.Play();
        }

        // NOTIFICACION PERSONALIZADA DE ADVERTENCIAS
        public void NotificionAdvertencia()
        {
            // FAVOR CAMBIAR NOMBRE DEL SISTEMA {dany__000} Y RESPETAR RUTA ASIGNADA CON TODAS SUS CARPETAS
            Notificaciones = new SoundPlayer(@"C:\Users\" + ControladorRutas.RutaNotificaciones() + "Advertencia.wav");
            Notificaciones.Play();
        }

        // NOTIFICACION PERSONALIZADA DE CONFIRMACION
        public void NotificionConfirmacion()
        {
            // FAVOR CAMBIAR NOMBRE DEL SISTEMA {dany__000} Y RESPETAR RUTA ASIGNADA CON TODAS SUS CARPETAS
            Notificaciones = new SoundPlayer(@"C:\Users\" + ControladorRutas.RutaNotificaciones() + "Aprobacion.wav");
            Notificaciones.Play();
        }

        // NOTIFICACION PERSONALIZADA DE ERROR DUPLICADOS
        public void NotificionErrorDuplicado()
        {
            // FAVOR CAMBIAR NOMBRE DEL SISTEMA {dany__000} Y RESPETAR RUTA ASIGNADA CON TODAS SUS CARPETAS
            Notificaciones = new SoundPlayer(@"C:\Users\" + ControladorRutas.RutaNotificaciones() + "ErrorDuplicados.wav");
            Notificaciones.Play();
        }

        // NOTIFICACION PERSONALIZADA DE ERROR LIMPIEZA NO COMPLETADA
        public void NotificionErrorLimpieza()
        {
            // FAVOR CAMBIAR NOMBRE DEL SISTEMA {dany__000} Y RESPETAR RUTA ASIGNADA CON TODAS SUS CARPETAS
            Notificaciones = new SoundPlayer(@"C:\Users\" + ControladorRutas.RutaNotificaciones() + "ErrorLimpieza.wav");
            Notificaciones.Play();
        }

        // NOTIFICACION PERSONALIZADA DE ERROR ELIMINAR REGISTROS
        public void NotificionErrorDepurarRegistros()
        {
            // FAVOR CAMBIAR NOMBRE DEL SISTEMA {dany__000} Y RESPETAR RUTA ASIGNADA CON TODAS SUS CARPETAS
            Notificaciones = new SoundPlayer(@"C:\Users\" + ControladorRutas.RutaNotificaciones() + "ErrorEliminar.wav");
            Notificaciones.Play();
        }

        // NOTIFICACION PERSONALIZADA DE INCOGNITA PROCESOS
        public void NotificionIncognita()
        {
            // FAVOR CAMBIAR NOMBRE DEL SISTEMA {dany__000} Y RESPETAR RUTA ASIGNADA CON TODAS SUS CARPETAS
            Notificaciones = new SoundPlayer(@"C:\Users\" + ControladorRutas.RutaNotificaciones() + "ConsultaMensajes.wav");
            Notificaciones.Play();
        }
        // NOTIFICACION PERSONALIZADA DE EXPORTAR ARCHIVOS
        public void NotificionExportar()
        {
            // FAVOR CAMBIAR NOMBRE DEL SISTEMA {dany__000} Y RESPETAR RUTA ASIGNADA CON TODAS SUS CARPETAS
            Notificaciones = new SoundPlayer(@"C:\Users\" + ControladorRutas.RutaNotificaciones() + "ExportarArchivo.wav");
            Notificaciones.Play();
        }
        public void IniciarSesion()
        {
            // FAVOR CAMBIAR NOMBRE DEL SISTEMA {dany__000} Y RESPETAR RUTA ASIGNADA CON TODAS SUS CARPETAS
            Notificaciones = new SoundPlayer(@"C:\Users\" + ControladorRutas.RutaNotificaciones() + "Iniciar-Sesion.wav");
            Notificaciones.Play();
        }
    }
}
