using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace catering.Models
{
    public class user:IdentityUser
    {
        
        [DataType(DataType.Date),Display(Name="出生日期")]
        public DateTime? Release { get; set; }

        public int Age { get; set; } = 15;
        public DateTime? DateOfBirth { get; set; }

        
    }
}
