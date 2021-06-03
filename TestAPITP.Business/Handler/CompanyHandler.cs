using System;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Text;
using TestAPITP.DataAccess.DataAccess;
using TestAPITP.DataAccess.Model;
using TestAPITP.Model.BaseRequest;
using TestAPITP.Model.BaseResponse;

namespace TestAPITP.Business.Handler
{
    /// <summary>
    /// Clase abstracta para la validacion de las compañias existentes y permitidas en el registro.
    /// </summary>
    public class CompanyHandler : ICompanyHandler
    {
        private readonly IConfiguration _IConfiguration;
        private readonly ICrudCompany _CrudCompany;

        /// <summary>
        /// Constructor
        /// </summary>
        public CompanyHandler(IConfiguration IConfiguration, ICrudCompany ICrudCompany)
        {
            _IConfiguration = IConfiguration;
            _CrudCompany = ICrudCompany;
        }

        /// <summary>
        /// Permite validar la compañia si es existente para continuar con el registro.
        /// </summary>
        /// <returns>true/false</returns>
        public BaseResponse validateCompanyById(string Id)
        {
            BaseResponse result = new BaseResponse()
            {
                Success = _CrudCompany.getCompanyById(Id)
            };

            return result;
        }

        /// <summary>
        /// Permite actualizar la compañia.
        /// </summary>
        /// <returns>true/false</returns>
        public BaseResponse insertCompany(RegisterCompanyRequest request)
        {
            Compañia newDocument = new Compañia()
            {
                NombreCompañia = request.CompanyName ?? string.Empty,
                TipoDocumento = request.IdentificationType ?? string.Empty,
                Documento = request.IdentificationNumber ?? string.Empty,
                Email = request.Email ?? string.Empty,
                PrimerNombre = request.FirstName ?? string.Empty,
                SegundoNombre = request.SecondName ?? string.Empty,
                PrimerApellido = request.FirstLastName ?? string.Empty,
                SegundoApellido = request.SecondLastName ?? string.Empty,
                EnviarMensajesCel = request.AuthorizeMessagesCell ? 0 :1,
                EnviarMensajesEmail = request.AuthorizeMesagesEmail ? 0:1
            };

            BaseResponse result = new BaseResponse()
            {
                Success = _CrudCompany.insertCompany(newDocument)
            };

            return result;          

        }
    }
}
