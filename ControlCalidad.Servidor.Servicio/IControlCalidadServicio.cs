﻿using ControlCalidad.Servidor.Servicio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ControlCalidad.Servidor.Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IControlCalidadServicio
    {
        [OperationContract]
        LineaDto[] GetLineas();

        [OperationContract]
        UsuarioDto Autenticar(string usuario, string contrasenia);

        [OperationContract]
        UsuarioDto[] UsuariosDisponibles();
        [OperationContract]
        LineaDto[] GetLineasDisponibles();
        [OperationContract]
        ModeloDto[] GetModelos();
        [OperationContract]
        ColorDto[] GetColores();

        [OperationContract]
        void CrearNuevaOP(OrdenDeProduccionDto nuevaOP);

        [OperationContract]
        TurnoDto ObtenerTurno();
        [OperationContract]
        bool CambiarEstadoOP(int NumeroOP, string Estado);
        
        [OperationContract]
        DefectoDto[] GetDefectos();
    }
}
