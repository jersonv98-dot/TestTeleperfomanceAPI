using System;
using System.Collections.Generic;
using System.Text;
using TestAPITP.Model.BaseRequest;
using TestAPITP.DataAccess.Model;
using TestAPITP.Model.BaseResponse;

namespace TestAPITP.Business.Handler
{
    /// <summary>
    /// Interfaz para la clase abstracta CompanyHandler.
    /// </summary>
    public interface ICompanyHandler
    {
        /// <summary>
        /// Permite obtener una compañia existente para la validacion de registro.
        /// </summary>
        /// <returns>true/false</returns>
        public BaseResponse validateCompanyById(string Id);
        /// <summary>
        /// Permite actualizar los datos de una compañia a traves de su documento
        /// </summary>
        /// <param name="Id">Documento de identificacion de la empresa</param>
        /// <returns></returns>
        public BaseResponse insertCompany(RegisterCompanyRequest request);
    }
}
