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
        public User(string name, string passworld, int age)
        {
            ValidateName(name);
            ValidateAge(age);

            Age = age;
            Name = name;
            Passworld = passworld;
        }
        public void ValidateName(string name)
        {
            DomainExceptionValidation.ExceptionHandler(string.IsNullOrEmpty(name), "Invalid Name. name is required!");
            DomainExceptionValidation.ExceptionHandler(name.Length > 30, "is name tool long");
            DomainExceptionValidation.ExceptionHandler(name.Length < 30, "Result Ok, Name is Valid");
            DomainExceptionValidation.ExceptionHandler(name.Length > 0, "Result Ok");

        }
        public void ValidateAge(int age)
        {   
            DomainExceptionValidation.ExceptionHandler(age <= 0, "Age invalid");
            DomainExceptionValidation.ExceptionHandler(age >0, "Age valid");

        }
    }
}