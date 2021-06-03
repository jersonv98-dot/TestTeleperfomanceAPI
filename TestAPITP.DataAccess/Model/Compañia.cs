using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TestAPITP.DataAccess.Model
{
    public partial class Compañia
    {
        public int Id { get; set; }
        public string TipoDocumento { get; set; }
        public string Documento { get; set; }
        public string NombreCompañia { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Email { get; set; }
        public int EnviarMensajesEmail { get; set; }
        public int EnviarMensajesCel { get; set; }
    }
}
