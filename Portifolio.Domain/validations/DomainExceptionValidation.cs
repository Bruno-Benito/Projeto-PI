using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portifolio.Domain.validations
{
    public class DomainExceptionValidation : Exception
    {
       public DomainExceptionValidation(string error) : base(error)
       {
       }
        public static void ExceptionHandler(bool HasError, string error)
            {
                if (HasError)
                {   
                    throw new DomainExceptionValidation(error);
                }
            } 
    }
}