using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Home.Models;

namespace Home.Controllers
{
    public class CatsController : Controller
    {
        public IActionResult Index()
        {
            return View("Classe");
        }



        public IActionResult List(int? Age)
        {
            var animals = PopulateList();
            if (Age.HasValue)
            {
               //animals = animals.Where(x => x.Color == Age.Value).ToList();
               return View(animals);
            }
            
            return View (animals);
        }
        private List<Animal> PopulateList()
        {
            List<Animal> Cats = new List<Animal>();
            Cats.Add(new Animal()
            {
                FirstName="Cat1",        
                Color = "Black",
                gender = "Male"

            });
            Cats.Add(new Animal()
            {
                FirstName = "Cat2",
                Color = "White",
                gender = "Female"

            });
            Cats.Add(new Animal()
            {
                FirstName = "Cat3",
                Color = "Black",
                gender = "Female"

            });
            Cats.Add(new Animal()
            {
                FirstName = "Cat4",
                Color = "Yellow",
                gender = "Female"

            });
            Cats.Add(new Animal()
            {
                FirstName = "Cat5",
                Color = "White",
                gender = "Male"

            });
            Cats.Add(new Animal()
            {
                FirstName = "Cat6",
                Color = "Yellow",
                gender = "Male"

            });
             Cats.Add(new Animal()
            {
                FirstName="Cat7",        
                Color = "Black",
                gender = "Female"

            });
            Cats.Add(new Animal()
            {
                FirstName = "Cat8",
                Color = "White",
                gender = "Male"

            });
            Cats.Add(new Animal()
            {
                FirstName = "Cat9",
                Color = "Yellow",
                gender = "Female"

            });
            Cats.Add(new Animal()
            {
                FirstName = "Cat10",
                Color = "White",
                gender = ""

            });

            return Cats;
        }

       
    }

}