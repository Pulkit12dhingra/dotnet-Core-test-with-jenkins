using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class Calculator : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Display(int val1, int val2, String Operator)
        {
            Calci values = new Calci();
            int a = val1;
            int b = val2;
            String s = Operator;
            if (s.ToLower()=="add")
            {
                values.answer = Add(a, b);
            }
            else if (s.ToLower() == "substract")
            {
                values.answer = Substract(a, b);
            }

            else if (s.ToLower() == "multiply")
            {
                values.answer = Multiply(a, b);
            }
            else if (s.ToLower() == "divide")
            {
                values.answer = Divide(a, b);
            }
            else {
                values.answer = 0;
            }
            
            return View(values);
        }



        public IActionResult Index()
        {
            Calci s = new Calci();      
            return View();
        }

        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        public int Substract(int value1, int value2)
        {
            return value1 - value2;
        }

        public int Multiply(int value1, int value2)
        {
            return value1 * value2;
        }

        public int Divide(int value1, int value2)
        {
            return value1 / value2;
        }

        public ActionResult Display(Calci values)
        {

            return View();
        }
    }
}
