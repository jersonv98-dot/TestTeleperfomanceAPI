using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAPITP.Business.Handler;
using TestAPITP.DataAccess.Model;
using TestAPITP.Model.BaseRequest;
using TestAPITP.Model.BaseResponse;

namespace TestAPITP.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyHandler _ICompanyHandler;
        public CompanyController(ICompanyHandler IcompanyHandler)
        {
            _ICompanyHandler = IcompanyHandler;
        }

        /// <summary>
        /// Permite validar si la compañia existe y se puede continuar con el registro
        /// </summary>
        /// <param name="id">Identificador de la compañia</param>
        /// <returns>true/false</returns>
        [Route("ValidateCompanyById")]
        [HttpGet]        
        public ActionResult<BaseResponse> Get(string id)
        {
            try
            {
                BaseResponse result = _ICompanyHandler.validateCompanyById(id);
                return Ok(result);
            }
            catch(Exception e)
            {
                return BadRequest("Se ha generado un error");
            }
        }

        /// <summary>
        /// Permite insertar los datos de una compañia
        /// </summary>
        /// <param name="value">Request</param>
        [HttpPost]
        [Route("InsertCompany")]
        public  ActionResult<BaseResponse> Post([FromBody] RegisterCompanyRequest request)
         {
            try
            {
                BaseResponse result = _ICompanyHandler.insertCompany(request);
                return Ok(result);
            }
            catch(Exception e)
            {
                return StatusCode(500, e.ToString());
            }
        }
    }
}
