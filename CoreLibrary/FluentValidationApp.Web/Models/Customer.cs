using FluentValidationApp.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Http.HttpResults;
namespace FluentValidationApp.Web.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }
        public int Age { get; set; }
        public DateTime? BirthDay { get; set; }

        
        public IList<Address>? Addresses { get; set; }

        public Gender Gender { get; set; }

        public CreditCard CreditCard { get; set; }


        //public string GetFullName() 
        //{
        //    return $"{Name} - {EMail} - {Age}";
        //}

        public string FullName2()
        {
            return $"{Name} - {EMail} - {Age}";
        }

    }
}
