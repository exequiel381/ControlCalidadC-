using ControlCalidad.Cliente.Vistas;
using ControlCalidad.Cliente.AccesoExterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlCalidad.Servidor.Servicio.Entidades;
using System.Windows.Forms;
using ControlCalidad.Cliente.Presentacion.Vista;

namespace ControlCalidad.Cliente.Presentador
{
    public class AutenticacionPresentador
    {
        IAutenticacion autenticacionVista;
        public AutenticacionPresentador(IAutenticacion vista)
        {
            autenticacionVista = vista;
        } 
        
       

        public bool Autenticar()//poner para recibir parametros y llamarlo asi recargamos el supervisor de linea con op
        {
            UsuarioDto u = Adaptador.Autenticar(autenticacionVista.usuario,autenticacionVista.contrasenia);


            if (u != null)//SE ENCONTRO EL USUARIO
            {
                if(u.opActual != null)//TIENE UNA OP ASIGNADA EN PROCESO
                {
                    switch (u.rol)
                    {
                        case "SupervisorDeLinea":
                            VistaSupLinea SL = new VistaSupLinea(u);
                            SL.OcultarPanelNuevaOP();//Ocultar panel de crear OP, y mostramos la OP.
                            SL.rellenarCampos(u.opActual);
                            SL.Show();
                            break;
                        case "SupervisorDeCalidad":
                            VistaSupCalidad SC = new VistaSupCalidad(u,u.opActual);
                            SC.rellenarCampos();
                            SC.Show();//Mostramos la OP.
                            break;
                    }

                   

                }
                else//NO TIENE UNA OP EN PROCESO
                {
                    switch (u.rol)
                    {
                        case "Administrador":
                            VistaAdministrador VA = new VistaAdministrador();
                            VA.Show();
                            break;
                        case "SupervisorDeLinea":
                            VistaSupLinea SL = new VistaSupLinea(u);
                            SL.OcultarPanelOP();
                            SL.Show();//Mostramos el `panel para crear una OP.
                            break;
                        case "SupervisorDeCalidad":
                            VistaSupCalidad SC = new VistaSupCalidad(u,null);
                            MessageBox.Show("Usted No tiene ninguna orden de produccion asignada para trabajar");
                            return false;
                            //SC.Show();//Mostramos aviso que no tiene orden asignada
                            
                    }
                   
                }

                return true;

            }
            else MessageBox.Show("Usuario o Contraseña INCORRECTA");//NO SE ENCONTRO NINGUN USUARIO
            return false;
        }

    }
}
