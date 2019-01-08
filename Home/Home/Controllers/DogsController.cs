using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Home.Models;

namespace Home.Controllers
{
    public class DogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult List(int? Age)
        {
            var animals = PopulateList();
            if (Age.HasValue)
            {
                // animals = animals.Where(x => x.Color == Age.Value).ToList();
                return View(animals);
            }
            return View(animals);
        }
        private List<Animal> PopulateList()
        {
            List<Animal> Dogs = new List<Animal>
            {
                new Animal()
                {
                    FirstName = "Cat1",
                    Color = "Black",
                    Gender = "Male"
                },
                new Animal()
                {
                    FirstName = "Cat2",
                    Color = "White",
                    Gender = "Female"

                },
                new Animal()
                {
                    FirstName = "Cat3",
                    Color = "Black",
                    Gender = "Female"

                },
                new Animal()
                {
                    FirstName = "Cat4",
                    Color = "Yellow",
                    Gender = "Female"

                },
                new Animal()
                {
                    FirstName = "Cat5",
                    Color = "White",
                    Gender = "Male"

                },
                new Animal()
                {
                    FirstName = "Cat6",
                    Color = "Yellow",
                    Gender = "Male"

                },
                new Animal()
                {
                    FirstName = "Cat7",
                    Color = "Black",
                    Gender = "Female"

                },
                new Animal()
                {
                    FirstName = "Cat8",
                    Color = "White",
                    Gender = "Male"

                },
                new Animal()
                {
                    FirstName = "Cat9",
                    Color = "Yellow",
                    Gender = "Female"

                },
                new Animal()
                {
                    FirstName = "Cat10",
                    Color = "White",
                    Gender = "Female"

                }
            };

            return Dogs;
        }

    }


}