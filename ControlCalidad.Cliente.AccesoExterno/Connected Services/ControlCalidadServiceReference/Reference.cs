﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlCalidad.Cliente.AccesoExterno.ControlCalidadServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ControlCalidadServiceReference.IControlCalidadServicio")]
    public interface IControlCalidadServicio {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlCalidadServicio/GetLineas", ReplyAction="http://tempuri.org/IControlCalidadServicio/GetLineasResponse")]
        ControlCalidad.Servidor.Servicio.LineaDto[] GetLineas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlCalidadServicio/GetLineas", ReplyAction="http://tempuri.org/IControlCalidadServicio/GetLineasResponse")]
        System.Threading.Tasks.Task<ControlCalidad.Servidor.Servicio.LineaDto[]> GetLineasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlCalidadServicio/Autenticar", ReplyAction="http://tempuri.org/IControlCalidadServicio/AutenticarResponse")]
        ControlCalidad.Servidor.Servicio.Entidades.UsuarioDto Autenticar(string usuario, string contrasenia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlCalidadServicio/Autenticar", ReplyAction="http://tempuri.org/IControlCalidadServicio/AutenticarResponse")]
        System.Threading.Tasks.Task<ControlCalidad.Servidor.Servicio.Entidades.UsuarioDto> AutenticarAsync(string usuario, string contrasenia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlCalidadServicio/UsuariosDisponibles", ReplyAction="http://tempuri.org/IControlCalidadServicio/UsuariosDisponiblesResponse")]
        ControlCalidad.Servidor.Servicio.Entidades.UsuarioDto[] UsuariosDisponibles();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlCalidadServicio/UsuariosDisponibles", ReplyAction="http://tempuri.org/IControlCalidadServicio/UsuariosDisponiblesResponse")]
        System.Threading.Tasks.Task<ControlCalidad.Servidor.Servicio.Entidades.UsuarioDto[]> UsuariosDisponiblesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlCalidadServicio/GetLineasDisponibles", ReplyAction="http://tempuri.org/IControlCalidadServicio/GetLineasDisponiblesResponse")]
        ControlCalidad.Servidor.Servicio.LineaDto[] GetLineasDisponibles();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlCalidadServicio/GetLineasDisponibles", ReplyAction="http://tempuri.org/IControlCalidadServicio/GetLineasDisponiblesResponse")]
        System.Threading.Tasks.Task<ControlCalidad.Servidor.Servicio.LineaDto[]> GetLineasDisponiblesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlCalidadServicio/GetModelos", ReplyAction="http://tempuri.org/IControlCalidadServicio/GetModelosResponse")]
        ControlCalidad.Servidor.Servicio.Entidades.ModeloDto[] GetModelos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlCalidadServicio/GetModelos", ReplyAction="http://tempuri.org/IControlCalidadServicio/GetModelosResponse")]
        System.Threading.Tasks.Task<ControlCalidad.Servidor.Servicio.Entidades.ModeloDto[]> GetModelosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlCalidadServicio/GetColores", ReplyAction="http://tempuri.org/IControlCalidadServicio/GetColoresResponse")]
        ControlCalidad.Servidor.Servicio.Entidades.ColorDto[] GetColores();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlCalidadServicio/GetColores", ReplyAction="http://tempuri.org/IControlCalidadServicio/GetColoresResponse")]
        System.Threading.Tasks.Task<ControlCalidad.Servidor.Servicio.Entidades.ColorDto[]> GetColoresAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlCalidadServicio/CrearNuevaOP", ReplyAction="http://tempuri.org/IControlCalidadServicio/CrearNuevaOPResponse")]
        void CrearNuevaOP(ControlCalidad.Servidor.Servicio.Entidades.OrdenDeProduccionDto nuevaOP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlCalidadServicio/CrearNuevaOP", ReplyAction="http://tempuri.org/IControlCalidadServicio/CrearNuevaOPResponse")]
        System.Threading.Tasks.Task CrearNuevaOPAsync(ControlCalidad.Servidor.Servicio.Entidades.OrdenDeProduccionDto nuevaOP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlCalidadServicio/ObtenerTurno", ReplyAction="http://tempuri.org/IControlCalidadServicio/ObtenerTurnoResponse")]
        ControlCalidad.Servidor.Servicio.Entidades.TurnoDto ObtenerTurno();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlCalidadServicio/ObtenerTurno", ReplyAction="http://tempuri.org/IControlCalidadServicio/ObtenerTurnoResponse")]
        System.Threading.Tasks.Task<ControlCalidad.Servidor.Servicio.Entidades.TurnoDto> ObtenerTurnoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlCalidadServicio/CambiarEstadoOP", ReplyAction="http://tempuri.org/IControlCalidadServicio/CambiarEstadoOPResponse")]
        bool CambiarEstadoOP(int NumeroOP, string Estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlCalidadServicio/CambiarEstadoOP", ReplyAction="http://tempuri.org/IControlCalidadServicio/CambiarEstadoOPResponse")]
        System.Threading.Tasks.Task<bool> CambiarEstadoOPAsync(int NumeroOP, string Estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlCalidadServicio/GetDefectos", ReplyAction="http://tempuri.org/IControlCalidadServicio/GetDefectosResponse")]
        ControlCalidad.Servidor.Servicio.Entidades.DefectoDto[] GetDefectos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlCalidadServicio/GetDefectos", ReplyAction="http://tempuri.org/IControlCalidadServicio/GetDefectosResponse")]
        System.Threading.Tasks.Task<ControlCalidad.Servidor.Servicio.Entidades.DefectoDto[]> GetDefectosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlCalidadServicio/RegistrarHallazgo", ReplyAction="http://tempuri.org/IControlCalidadServicio/RegistrarHallazgoResponse")]
        void RegistrarHallazgo(int NumeroOP, ControlCalidad.Servidor.Servicio.Entidades.HallazgoDto hallazgo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlCalidadServicio/RegistrarHallazgo", ReplyAction="http://tempuri.org/IControlCalidadServicio/RegistrarHallazgoResponse")]
        System.Threading.Tasks.Task RegistrarHallazgoAsync(int NumeroOP, ControlCalidad.Servidor.Servicio.Entidades.HallazgoDto hallazgo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlCalidadServicio/ContabilizarDefecto", ReplyAction="http://tempuri.org/IControlCalidadServicio/ContabilizarDefectoResponse")]
        int ContabilizarDefecto(string pie, int idDefecto, int NumeroOP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlCalidadServicio/ContabilizarDefecto", ReplyAction="http://tempuri.org/IControlCalidadServicio/ContabilizarDefectoResponse")]
        System.Threading.Tasks.Task<int> ContabilizarDefectoAsync(string pie, int idDefecto, int NumeroOP);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IControlCalidadServicioChannel : ControlCalidad.Cliente.AccesoExterno.ControlCalidadServiceReference.IControlCalidadServicio, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ControlCalidadServicioClient : System.ServiceModel.ClientBase<ControlCalidad.Cliente.AccesoExterno.ControlCalidadServiceReference.IControlCalidadServicio>, ControlCalidad.Cliente.AccesoExterno.ControlCalidadServiceReference.IControlCalidadServicio {
        
        public ControlCalidadServicioClient() {
        }
        
        public ControlCalidadServicioClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ControlCalidadServicioClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ControlCalidadServicioClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ControlCalidadServicioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ControlCalidad.Servidor.Servicio.LineaDto[] GetLineas() {
            return base.Channel.GetLineas();
        }
        
        public System.Threading.Tasks.Task<ControlCalidad.Servidor.Servicio.LineaDto[]> GetLineasAsync() {
            return base.Channel.GetLineasAsync();
        }
        
        public ControlCalidad.Servidor.Servicio.Entidades.UsuarioDto Autenticar(string usuario, string contrasenia) {
            return base.Channel.Autenticar(usuario, contrasenia);
        }
        
        public System.Threading.Tasks.Task<ControlCalidad.Servidor.Servicio.Entidades.UsuarioDto> AutenticarAsync(string usuario, string contrasenia) {
            return base.Channel.AutenticarAsync(usuario, contrasenia);
        }
        
        public ControlCalidad.Servidor.Servicio.Entidades.UsuarioDto[] UsuariosDisponibles() {
            return base.Channel.UsuariosDisponibles();
        }
        
        public System.Threading.Tasks.Task<ControlCalidad.Servidor.Servicio.Entidades.UsuarioDto[]> UsuariosDisponiblesAsync() {
            return base.Channel.UsuariosDisponiblesAsync();
        }
        
        public ControlCalidad.Servidor.Servicio.LineaDto[] GetLineasDisponibles() {
            return base.Channel.GetLineasDisponibles();
        }
        
        public System.Threading.Tasks.Task<ControlCalidad.Servidor.Servicio.LineaDto[]> GetLineasDisponiblesAsync() {
            return base.Channel.GetLineasDisponiblesAsync();
        }
        
        public ControlCalidad.Servidor.Servicio.Entidades.ModeloDto[] GetModelos() {
            return base.Channel.GetModelos();
        }
        
        public System.Threading.Tasks.Task<ControlCalidad.Servidor.Servicio.Entidades.ModeloDto[]> GetModelosAsync() {
            return base.Channel.GetModelosAsync();
        }
        
        public ControlCalidad.Servidor.Servicio.Entidades.ColorDto[] GetColores() {
            return base.Channel.GetColores();
        }
        
        public System.Threading.Tasks.Task<ControlCalidad.Servidor.Servicio.Entidades.ColorDto[]> GetColoresAsync() {
            return base.Channel.GetColoresAsync();
        }
        
        public void CrearNuevaOP(ControlCalidad.Servidor.Servicio.Entidades.OrdenDeProduccionDto nuevaOP) {
            base.Channel.CrearNuevaOP(nuevaOP);
        }
        
        public System.Threading.Tasks.Task CrearNuevaOPAsync(ControlCalidad.Servidor.Servicio.Entidades.OrdenDeProduccionDto nuevaOP) {
            return base.Channel.CrearNuevaOPAsync(nuevaOP);
        }
        
        public ControlCalidad.Servidor.Servicio.Entidades.TurnoDto ObtenerTurno() {
            return base.Channel.ObtenerTurno();
        }
        
        public System.Threading.Tasks.Task<ControlCalidad.Servidor.Servicio.Entidades.TurnoDto> ObtenerTurnoAsync() {
            return base.Channel.ObtenerTurnoAsync();
        }
        
        public bool CambiarEstadoOP(int NumeroOP, string Estado) {
            return base.Channel.CambiarEstadoOP(NumeroOP, Estado);
        }
        
        public System.Threading.Tasks.Task<bool> CambiarEstadoOPAsync(int NumeroOP, string Estado) {
            return base.Channel.CambiarEstadoOPAsync(NumeroOP, Estado);
        }
        
        public ControlCalidad.Servidor.Servicio.Entidades.DefectoDto[] GetDefectos() {
            return base.Channel.GetDefectos();
        }
        
        public System.Threading.Tasks.Task<ControlCalidad.Servidor.Servicio.Entidades.DefectoDto[]> GetDefectosAsync() {
            return base.Channel.GetDefectosAsync();
        }
        
        public void RegistrarHallazgo(int NumeroOP, ControlCalidad.Servidor.Servicio.Entidades.HallazgoDto hallazgo) {
            base.Channel.RegistrarHallazgo(NumeroOP, hallazgo);
        }
        
        public System.Threading.Tasks.Task RegistrarHallazgoAsync(int NumeroOP, ControlCalidad.Servidor.Servicio.Entidades.HallazgoDto hallazgo) {
            return base.Channel.RegistrarHallazgoAsync(NumeroOP, hallazgo);
        }
        
        public int ContabilizarDefecto(string pie, int idDefecto, int NumeroOP) {
            return base.Channel.ContabilizarDefecto(pie, idDefecto, NumeroOP);
        }
        
        public System.Threading.Tasks.Task<int> ContabilizarDefectoAsync(string pie, int idDefecto, int NumeroOP) {
            return base.Channel.ContabilizarDefectoAsync(pie, idDefecto, NumeroOP);
        }
    }
}
