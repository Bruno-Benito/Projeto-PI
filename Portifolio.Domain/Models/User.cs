using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portifolio.Domain.Entities;
using Portifolio.Domain.validations;

namespace Portifolio.Domain.Models
{
    public sealed class User : EntityBase
    {   
        public int Age { get; private set; } 
        public string Name { get; private set; }
        public string Passworld { get; private set; } = "";
        public User(string name, string passworld,int age)
        {
            Age = age;
            Name = name;
            Passworld = passworld;
        }
        public void ValidateDomain(string name)
        {
            DomainExceptionValidation.ExceptionHandler(string.IsNullOrEmpty(name), "Invalid Name. name is required!");
        }
        public User(string name)
        {
            ValidateDomain(name);
        }
    }
}