using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using TestAPITP.DataAccess.Model;

namespace TestAPITP.DataAccess.DataAccess
{
    /// <summary>
    /// Clase abstracta CRUD para la tabla Compañias en la base de datos
    /// </summary>
    public class CrudCompany : ICrudCompany
    {
        private TestTPContext _Context = new TestTPContext();
        
        /// <summary>
        /// Permite obtener datos de una compañia por su numero de coumento
        /// </summary>
        /// <param name="Documento">Numero de identificacion de la compañia</param>
        /// <returns></returns>
        public bool getCompanyById(string identificationNumber)
        {
            try
            {
                CompañiaPermitida Existe = _Context.CompañiasPermitidas.Where(x => x.Documento.Equals(identificationNumber)).FirstOrDefault();

                if(Existe != null)
                return true;

                return false;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Permite crear una nueva compañia
        /// </summary>
        /// <param name="updatedDocument"></param>
        public bool insertCompany(Compañia newDocument)
        {
            try
            {
                _Context.Add(newDocument);
                _Context.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
       
    }
}
