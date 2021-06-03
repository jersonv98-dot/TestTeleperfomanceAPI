using System;
using System.Collections.Generic;
using System.Text;
using TestAPITP.DataAccess.Model;

namespace TestAPITP.DataAccess.DataAccess
{
    /// <summary>
    /// Interfaz de la clase abstracta CrudCompany
    /// </summary>
    public interface ICrudCompany
    {
        /// <summary>
        /// Permite obtener una compañia por su numero de documento
        /// </summary>
        /// <returns></returns>
        public bool getCompanyById(string identificationNumber);

        /// <summary>
        /// Permite crear una nueva compañia
        /// </summary>
        /// <param name="newDocument"></param>
        public bool insertCompany(Compañia newDocument);
    }
}
