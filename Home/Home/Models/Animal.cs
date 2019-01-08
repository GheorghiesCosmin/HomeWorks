using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Home.Controllers;
using Home.Models;

namespace Home.Models
{
    public class Animal
    {
        public string Color { get; set; }
        public string Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

}
