using System;
using System.Collections.Generic;
using System.Text;

namespace TestAPITP.Model.BaseRequest
{
    public class RegisterCompanyRequest
    {
        public string IdentificationType { get; set; }
        public string IdentificationNumber { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FirstLastName { get; set; }
        public string SecondLastName { get; set; }
        public string Email { get; set; }
        public bool AuthorizeMesagesEmail { get; set; }
        public bool AuthorizeMessagesCell { get; set; }
    }
}
