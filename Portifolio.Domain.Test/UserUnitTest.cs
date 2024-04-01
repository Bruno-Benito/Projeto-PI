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
         public void WhenAgeUser_MoreThan0_DomainException()
         {
            Action user=()=> new User("UserName","UserPassworld",0);
            user.Should().Throw<DomainExceptionValidation>()
            .WithMessage("Age invalid");
         }
   }
}