using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Portifolio.Domain.Models;
using Portifolio.Domain.validations;
using Xunit;

namespace Portifolio.Domain.Test
{

    public class UserUnitTest
 {
    [Fact]
        public void WhenNameUser_LengthToolLong_DomainException()
        {
         Action user=()=> new User("UserNamelongnamelongnamelongname","UserPassworld",18);
       user.Should().Throw<DomainExceptionValidation>()
       .WithMessage("is name tool long");
      }
      [Fact]
         public void WhenNameUser_IsNull_DomainException()
         {
            Action user=()=> new User("","UserPassworld",18);
            user.Should().Throw<DomainExceptionValidation>()
            .WithMessage("Invalid Name. name is required!");
         }
      [Fact]

      public void WhenNameUser_IsNotNull_DomainException()
      {
         Action user=()=> new User("a","UserPassworld",18);
         user.Should().Throw<DomainExceptionValidation>()
         .WithMessage("Result Ok");
      }
      [Fact]

      public void WhenNameUser_LengthNotToolLong_DomainException()
      {
         Action user=()=> new User("namenolong","UserPassworld",18);
         user.Should().Throw<DomainExceptionValidation>()
         .WithMessage("Result Ok, Name is Valid");
      }

      [Fact]
         public void WhenAgeUser_MoreThan0_DomainException()
         {
            Action user=()=> new User("UserName","UserPassworld",0);
            user.Should().Throw<DomainExceptionValidation>()
            .WithMessage("Age invalid");
         }

       [Fact]
         public void WhenAgeUser_MoreNotThan0_DomainException()
         {
            Action user=()=> new User("UserName","UserPassworld",18);
            user.Should().Throw<DomainExceptionValidation>()
            .WithMessage("Age valid");
         }
      

         
   }
}